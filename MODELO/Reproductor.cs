using NAudio.Utils;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PantallaMain.MODELO
{
    class Reproductor
    {
        /********ATRIBUTOS***************/
        double volumen = 1;
        int i=0;
        int idCancion;
        int tiempoCancion;
        int totalCancion;
        /***Getters y Setters***/
        public int IdCancion { get => idCancion; set => idCancion = value; }
        public int I { get => i; set => i = value; }
        public double Volumen { get => volumen; set => volumen = value; }
        public int TiempoCancion { get => tiempoCancion; set => tiempoCancion = value; }
        public int TotalCancion { get => totalCancion; set => totalCancion = value; }
        /// <summary>
        /// Reproductor musica streaming, le pasamos la url del servidor
        /// </summary>
        /// <param name="url"></param>
        public void PlayMp3FromUrl(int url)
        {

            using (Stream ms = new MemoryStream())
            {
                //Le pasamos la URL del nuestro servidor para coger las canciones
                using (Stream stream = WebRequest.Create("ftp://jayt.zapto.org/" + url + ".mp3")
                    .GetResponse().GetResponseStream())
                {
                    byte[] buffer = new byte[32768];
                    int read;
                    //Coge el stream y lo pasa a Bytes
                    while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        ms.Write(buffer, 0, read);
                    }
                }

                ms.Position = 0;
                //
                using (WaveStream blockAlignedStream =
                    new BlockAlignReductionStream(
                        WaveFormatConversionStream.CreatePcmStream(
                            new Mp3FileReader(ms))))
                {
                    using (WaveOut prova = new WaveOut(WaveCallbackInfo.FunctionCallback()))
                    {
                        //Declara la cancion que coge
                        prova.Init(blockAlignedStream);
                        prova.Play();
                        //Cogemos la duracion total de la cancion en segundos
                        totalCancion = (int)blockAlignedStream.TotalTime.TotalSeconds;
                        i = 1;
                        //Bucle si la cancion se esta reproducciendo
                        while (prova.PlaybackState == PlaybackState.Playing)
                        {
                        //Declaramos Volumen
                        prova.Volume = (float)volumen;
                            //blockAlignedStream.CurrentTime = 32;
                            Console.WriteLine(blockAlignedStream.CurrentTime);
                            //Para coger el tiempo mientras esta transcurriendo la cancion en segundos
                            tiempoCancion = blockAlignedStream.CurrentTime.Seconds;
                            //Si se pausa la cancion(Se utiliza bucle para no reproducir mas de una cancion al mismo tiempo)
                            while (i == 2)
                            {
                                prova.Pause();
                            }
                            //Si se reanuda la cancion
                            if (i == 3)
                            {
                                prova.Resume();
                                //Reanudamos el tiempo de la cancion mientras estaba transcurriendo
                                tiempoCancion = blockAlignedStream.CurrentTime.Seconds;
                            }
                            //Si se Detiene la cancion
                            if (i == 4)
                            {
                                prova.Stop();
                                i = 0;

                            }

                        }
                        i = 0;
                    }
                }
            }
        }
        /// <summary>
        /// Comprueba si hay alguna cancion sonando
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            //Si i es 0 significa que no hay ninguna cancion corriendo
            if (i == 0)
            {
                //Ejecuta la cancion por el id
                PlayMp3FromUrl(idCancion);

            }
        }

        public void iniciarCancion()
        {
            Debug.WriteLine("Ehjecutando: {0}", Thread.CurrentThread.ManagedThreadId);
            BackgroundWorker bgw = new BackgroundWorker();
            //Cogemos la cancion que tenemos y lo ponemos la ejecucion del proceso en segundo plano
            bgw.DoWork += bgw_DoWork;
            bgw.RunWorkerAsync();
        }

      
    }
}
