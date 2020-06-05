namespace PantallaMain
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.pictureBoxImagenUsuario = new System.Windows.Forms.PictureBox();
            this.buttonMiPlaylist = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonMejorarCuenta = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBoxBuscador = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonAñadirPlaylist = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.macTrackBarTiempo = new XComponent.SliderBar.MACTrackBar();
            this.macTrackBarVolumen = new XComponent.SliderBar.MACTrackBar();
            this.ImagenPlay = new System.Windows.Forms.PictureBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelArtista = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.bunifuSliderVolumen = new Bunifu.Framework.UI.BunifuSlider();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.labelInvisibleArtista = new System.Windows.Forms.Label();
            this.labelInvisibleNombre = new System.Windows.Forms.Label();
            this.tablaCanciones = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenUsuario)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPlay)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reproductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCanciones)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Black;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.panel1);
            this.panel.Controls.Add(this.textBox5);
            this.panel.Controls.Add(this.buttonInsertar);
            this.panel.Controls.Add(this.pictureBoxImagenUsuario);
            this.panel.Controls.Add(this.buttonMiPlaylist);
            this.panel.Controls.Add(this.panel10);
            this.panel.Controls.Add(this.comboBox1);
            this.panel.Controls.Add(this.labelUsuario);
            this.panel.Controls.Add(this.buttonBuscar);
            this.panel.Controls.Add(this.buttonMejorarCuenta);
            this.panel.Controls.Add(this.panel2);
            this.panel.Controls.Add(this.textBox1);
            this.panel.Controls.Add(this.panel7);
            this.panel.Controls.Add(this.textBoxBuscador);
            this.panel.Controls.Add(this.panel6);
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(266, 831);
            this.panel.TabIndex = 1;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(29, 539);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 26;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Black;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(28, 512);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(147, 28);
            this.textBox5.TabIndex = 27;
            this.textBox5.Text = "Profile";
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertar.ForeColor = System.Drawing.Color.White;
            this.buttonInsertar.Location = new System.Drawing.Point(144, 723);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(92, 37);
            this.buttonInsertar.TabIndex = 36;
            this.buttonInsertar.Text = "Insert";
            this.buttonInsertar.UseVisualStyleBackColor = true;
            this.buttonInsertar.Visible = false;
            this.buttonInsertar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxImagenUsuario
            // 
            this.pictureBoxImagenUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImagenUsuario.Location = new System.Drawing.Point(11, 546);
            this.pictureBoxImagenUsuario.Name = "pictureBoxImagenUsuario";
            this.pictureBoxImagenUsuario.Size = new System.Drawing.Size(237, 157);
            this.pictureBoxImagenUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagenUsuario.TabIndex = 35;
            this.pictureBoxImagenUsuario.TabStop = false;
            this.pictureBoxImagenUsuario.Click += new System.EventHandler(this.pictureBoxImagenUsuario_Click);
            this.pictureBoxImagenUsuario.DoubleClick += new System.EventHandler(this.pictureBoxImagenUsuario_DoubleClick);
            // 
            // buttonMiPlaylist
            // 
            this.buttonMiPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMiPlaylist.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMiPlaylist.ForeColor = System.Drawing.Color.White;
            this.buttonMiPlaylist.Location = new System.Drawing.Point(28, 446);
            this.buttonMiPlaylist.Name = "buttonMiPlaylist";
            this.buttonMiPlaylist.Size = new System.Drawing.Size(202, 43);
            this.buttonMiPlaylist.TabIndex = 34;
            this.buttonMiPlaylist.Text = "PLAYLIST";
            this.buttonMiPlaylist.UseVisualStyleBackColor = true;
            this.buttonMiPlaylist.Click += new System.EventHandler(this.button_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel10.Location = new System.Drawing.Point(12, 759);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(224, 1);
            this.panel10.TabIndex = 29;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(32, 276);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 32);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.Color.White;
            this.labelUsuario.Location = new System.Drawing.Point(11, 727);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(77, 27);
            this.labelUsuario.TabIndex = 32;
            this.labelUsuario.Text = "label2";
            this.labelUsuario.Click += new System.EventHandler(this.labelUsuario_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.Black;
            this.buttonBuscar.BackgroundImage = global::PantallaMain.Properties.Resources.BottonBuscarBlanco;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Location = new System.Drawing.Point(31, 230);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(39, 37);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonMejorarCuenta
            // 
            this.buttonMejorarCuenta.BackColor = System.Drawing.Color.Black;
            this.buttonMejorarCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonMejorarCuenta.CausesValidation = false;
            this.buttonMejorarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMejorarCuenta.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMejorarCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonMejorarCuenta.Location = new System.Drawing.Point(12, 775);
            this.buttonMejorarCuenta.Name = "buttonMejorarCuenta";
            this.buttonMejorarCuenta.Size = new System.Drawing.Size(237, 47);
            this.buttonMejorarCuenta.TabIndex = 30;
            this.buttonMejorarCuenta.Text = "Modify Account";
            this.buttonMejorarCuenta.UseVisualStyleBackColor = false;
            this.buttonMejorarCuenta.Click += new System.EventHandler(this.buttonMejorarCuenta_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(31, 438);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 25;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(30, 411);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 28);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "PlayList";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel7.Location = new System.Drawing.Point(32, 269);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(201, 1);
            this.panel7.TabIndex = 24;
            // 
            // textBoxBuscador
            // 
            this.textBoxBuscador.BackColor = System.Drawing.Color.Black;
            this.textBoxBuscador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBuscador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscador.ForeColor = System.Drawing.Color.White;
            this.textBoxBuscador.Location = new System.Drawing.Point(70, 244);
            this.textBoxBuscador.Name = "textBoxBuscador";
            this.textBoxBuscador.Size = new System.Drawing.Size(179, 19);
            this.textBoxBuscador.TabIndex = 23;
            this.textBoxBuscador.Text = "Search";
            this.textBoxBuscador.TextChanged += new System.EventHandler(this.textBoxBuscador_TextChanged);
            this.textBoxBuscador.Enter += new System.EventHandler(this.textBoxBuscador_Enter);
            this.textBoxBuscador.Leave += new System.EventHandler(this.textBoxBuscador_Leave);
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::PantallaMain.Properties.Resources.LogoFinal;
            this.panel6.Location = new System.Drawing.Point(31, 45);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 163);
            this.panel6.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonAñadirPlaylist);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.macTrackBarTiempo);
            this.panel3.Controls.Add(this.macTrackBarVolumen);
            this.panel3.Controls.Add(this.ImagenPlay);
            this.panel3.Controls.Add(this.buttonStop);
            this.panel3.Controls.Add(this.labelArtista);
            this.panel3.Controls.Add(this.labelNombre);
            this.panel3.Controls.Add(this.panel13);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.ForeColor = System.Drawing.Color.Purple;
            this.panel3.Location = new System.Drawing.Point(266, 705);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1178, 126);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // buttonAñadirPlaylist
            // 
            this.buttonAñadirPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAñadirPlaylist.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAñadirPlaylist.Location = new System.Drawing.Point(1009, 31);
            this.buttonAñadirPlaylist.Name = "buttonAñadirPlaylist";
            this.buttonAñadirPlaylist.Size = new System.Drawing.Size(150, 74);
            this.buttonAñadirPlaylist.TabIndex = 11;
            this.buttonAñadirPlaylist.Text = "ADD TO  PLAYLIST";
            this.buttonAñadirPlaylist.UseVisualStyleBackColor = true;
            this.buttonAñadirPlaylist.Visible = false;
            this.buttonAñadirPlaylist.Click += new System.EventHandler(this.buttonAñadirPlaylist_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // macTrackBarTiempo
            // 
            this.macTrackBarTiempo.BackColor = System.Drawing.Color.Transparent;
            this.macTrackBarTiempo.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.macTrackBarTiempo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macTrackBarTiempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.macTrackBarTiempo.IndentHeight = 6;
            this.macTrackBarTiempo.Location = new System.Drawing.Point(375, 16);
            this.macTrackBarTiempo.Maximum = 100;
            this.macTrackBarTiempo.Minimum = 0;
            this.macTrackBarTiempo.Name = "macTrackBarTiempo";
            this.macTrackBarTiempo.Size = new System.Drawing.Size(628, 28);
            this.macTrackBarTiempo.TabIndex = 9;
            this.macTrackBarTiempo.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBarTiempo.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.macTrackBarTiempo.TickHeight = 4;
            this.macTrackBarTiempo.TickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBarTiempo.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.macTrackBarTiempo.TrackerSize = new System.Drawing.Size(16, 16);
            this.macTrackBarTiempo.TrackLineColor = System.Drawing.Color.White;
            this.macTrackBarTiempo.TrackLineHeight = 3;
            this.macTrackBarTiempo.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.macTrackBarTiempo.Value = 0;
            // 
            // macTrackBarVolumen
            // 
            this.macTrackBarVolumen.BackColor = System.Drawing.Color.Transparent;
            this.macTrackBarVolumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.macTrackBarVolumen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.macTrackBarVolumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macTrackBarVolumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.macTrackBarVolumen.IndentHeight = 6;
            this.macTrackBarVolumen.Location = new System.Drawing.Point(874, 64);
            this.macTrackBarVolumen.Maximum = 100;
            this.macTrackBarVolumen.Minimum = 0;
            this.macTrackBarVolumen.Name = "macTrackBarVolumen";
            this.macTrackBarVolumen.Size = new System.Drawing.Size(113, 28);
            this.macTrackBarVolumen.TabIndex = 10;
            this.macTrackBarVolumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBarVolumen.TickColor = System.Drawing.Color.White;
            this.macTrackBarVolumen.TickHeight = 4;
            this.macTrackBarVolumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBarVolumen.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.macTrackBarVolumen.TrackerSize = new System.Drawing.Size(8, 16);
            this.macTrackBarVolumen.TrackLineColor = System.Drawing.Color.White;
            this.macTrackBarVolumen.TrackLineHeight = 3;
            this.macTrackBarVolumen.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.macTrackBarVolumen.Value = 0;
            this.macTrackBarVolumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.macTrackBar2_ValueChanged);
            // 
            // ImagenPlay
            // 
            this.ImagenPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImagenPlay.Image = global::PantallaMain.Properties.Resources.ButtonPlayBlanco;
            this.ImagenPlay.Location = new System.Drawing.Point(424, 48);
            this.ImagenPlay.Name = "ImagenPlay";
            this.ImagenPlay.Size = new System.Drawing.Size(65, 68);
            this.ImagenPlay.TabIndex = 9;
            this.ImagenPlay.TabStop = false;
            this.ImagenPlay.Click += new System.EventHandler(this.ImagenPlay_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackgroundImage = global::PantallaMain.Properties.Resources.buttonSTOPBlanco1;
            this.buttonStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.ForeColor = System.Drawing.Color.Black;
            this.buttonStop.Location = new System.Drawing.Point(507, 48);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(63, 63);
            this.buttonStop.TabIndex = 8;
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelArtista
            // 
            this.labelArtista.AutoSize = true;
            this.labelArtista.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtista.ForeColor = System.Drawing.Color.White;
            this.labelArtista.Location = new System.Drawing.Point(172, 81);
            this.labelArtista.Name = "labelArtista";
            this.labelArtista.Size = new System.Drawing.Size(0, 24);
            this.labelArtista.TabIndex = 7;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(172, 20);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(0, 24);
            this.labelNombre.TabIndex = 6;
            // 
            // panel13
            // 
            this.panel13.BackgroundImage = global::PantallaMain.Properties.Resources.VOLUMENBLANCO;
            this.panel13.Location = new System.Drawing.Point(816, 53);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(52, 50);
            this.panel13.TabIndex = 5;
            // 
            // bunifuSliderVolumen
            // 
            this.bunifuSliderVolumen.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSliderVolumen.BackgroudColor = System.Drawing.Color.White;
            this.bunifuSliderVolumen.BorderRadius = 0;
            this.bunifuSliderVolumen.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuSliderVolumen.Location = new System.Drawing.Point(1300, 594);
            this.bunifuSliderVolumen.MaximumValue = 100;
            this.bunifuSliderVolumen.Name = "bunifuSliderVolumen";
            this.bunifuSliderVolumen.Size = new System.Drawing.Size(113, 30);
            this.bunifuSliderVolumen.TabIndex = 4;
            this.bunifuSliderVolumen.Value = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.reproductor);
            this.panel4.Controls.Add(this.labelInvisibleArtista);
            this.panel4.Controls.Add(this.labelInvisibleNombre);
            this.panel4.Controls.Add(this.tablaCanciones);
            this.panel4.Controls.Add(this.buttonActualizar);
            this.panel4.Controls.Add(this.bunifuSliderVolumen);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.panel11);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(266, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1178, 705);
            this.panel4.TabIndex = 4;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Black;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(719, 362);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(201, 47);
            this.textBox4.TabIndex = 13;
            this.textBox4.Text = "Genre";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Black;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(367, 362);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(362, 47);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "Artist";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(19, 362);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(351, 47);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "Title";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // reproductor
            // 
            this.reproductor.Enabled = true;
            this.reproductor.Location = new System.Drawing.Point(476, 311);
            this.reproductor.Name = "reproductor";
            this.reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("reproductor.OcxState")));
            this.reproductor.Size = new System.Drawing.Size(42, 20);
            this.reproductor.TabIndex = 8;
            this.reproductor.Visible = false;
            this.reproductor.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.reproductor_PlayStateChange);
            // 
            // labelInvisibleArtista
            // 
            this.labelInvisibleArtista.AutoSize = true;
            this.labelInvisibleArtista.ForeColor = System.Drawing.Color.White;
            this.labelInvisibleArtista.Location = new System.Drawing.Point(422, 315);
            this.labelInvisibleArtista.Name = "labelInvisibleArtista";
            this.labelInvisibleArtista.Size = new System.Drawing.Size(35, 13);
            this.labelInvisibleArtista.TabIndex = 7;
            this.labelInvisibleArtista.Text = "label2";
            this.labelInvisibleArtista.Visible = false;
            // 
            // labelInvisibleNombre
            // 
            this.labelInvisibleNombre.AutoSize = true;
            this.labelInvisibleNombre.ForeColor = System.Drawing.Color.White;
            this.labelInvisibleNombre.Location = new System.Drawing.Point(352, 315);
            this.labelInvisibleNombre.Name = "labelInvisibleNombre";
            this.labelInvisibleNombre.Size = new System.Drawing.Size(35, 13);
            this.labelInvisibleNombre.TabIndex = 6;
            this.labelInvisibleNombre.Text = "label2";
            this.labelInvisibleNombre.Visible = false;
            // 
            // tablaCanciones
            // 
            this.tablaCanciones.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tablaCanciones.AllowUserToAddRows = false;
            this.tablaCanciones.AllowUserToDeleteRows = false;
            this.tablaCanciones.AllowUserToResizeColumns = false;
            this.tablaCanciones.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.tablaCanciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.tablaCanciones.BackgroundColor = System.Drawing.Color.Black;
            this.tablaCanciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaCanciones.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.tablaCanciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaCanciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.tablaCanciones.ColumnHeadersHeight = 42;
            this.tablaCanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaCanciones.ColumnHeadersVisible = false;
            this.tablaCanciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Artista,
            this.Genero});
            this.tablaCanciones.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaCanciones.DefaultCellStyle = dataGridViewCellStyle8;
            this.tablaCanciones.EnableHeadersVisualStyles = false;
            this.tablaCanciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tablaCanciones.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tablaCanciones.Location = new System.Drawing.Point(19, 403);
            this.tablaCanciones.MultiSelect = false;
            this.tablaCanciones.Name = "tablaCanciones";
            this.tablaCanciones.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaCanciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.tablaCanciones.RowHeadersVisible = false;
            this.tablaCanciones.RowHeadersWidth = 70;
            this.tablaCanciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            this.tablaCanciones.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.tablaCanciones.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.tablaCanciones.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaCanciones.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.tablaCanciones.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tablaCanciones.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.tablaCanciones.RowTemplate.Height = 47;
            this.tablaCanciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaCanciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaCanciones.ShowRowErrors = false;
            this.tablaCanciones.Size = new System.Drawing.Size(1230, 296);
            this.tablaCanciones.TabIndex = 5;
            this.tablaCanciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCanciones_CellClick);
            this.tablaCanciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 200F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Nombre.Width = 350;
            // 
            // Artista
            // 
            this.Artista.HeaderText = "Artista";
            this.Artista.Name = "Artista";
            this.Artista.ReadOnly = true;
            this.Artista.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Artista.Width = 350;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            this.Genero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Genero.Width = 200;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.BackgroundImage = global::PantallaMain.Properties.Resources.buttonActualizarBlanco;
            this.buttonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizar.Location = new System.Drawing.Point(241, 307);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(48, 49);
            this.buttonActualizar.TabIndex = 4;
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(25, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "List of songs";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Location = new System.Drawing.Point(0, 917);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(150, 121);
            this.panel11.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1178, 292);
            this.panel5.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1444, 831);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThunderMusic";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenUsuario)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPlay)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reproductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCanciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBoxBuscador;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button buttonMejorarCuenta;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button buttonBuscar;
        private Bunifu.Framework.UI.BunifuSlider bunifuSliderVolumen;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelInvisibleNombre;
        private System.Windows.Forms.Label labelArtista;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelInvisibleArtista;
        private System.Windows.Forms.Button buttonStop;
        private AxWMPLib.AxWindowsMediaPlayer reproductor;
        private System.Windows.Forms.PictureBox ImagenPlay;
        private System.Windows.Forms.Timer timer1;
        private XComponent.SliderBar.MACTrackBar macTrackBarVolumen;
        private XComponent.SliderBar.MACTrackBar macTrackBarTiempo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        protected System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonMiPlaylist;
        private System.Windows.Forms.Button buttonAñadirPlaylist;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.DataGridView tablaCanciones;
        private System.Windows.Forms.PictureBox pictureBoxImagenUsuario;
        private System.Windows.Forms.Button buttonInsertar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
    }
}