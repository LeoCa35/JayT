namespace PantallaMain.VISTA
{
    partial class FormCambioDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCambioDatos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxPasswordActual = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxPasswordNueva = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.labelRestricciones = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxUsuarioActual = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::PantallaMain.Properties.Resources.LogoFinal;
            this.pictureBox1.Location = new System.Drawing.Point(117, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 159);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(540, 265);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 38);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel3.Location = new System.Drawing.Point(540, 305);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(353, 1);
            this.panel3.TabIndex = 19;
            // 
            // textBoxPasswordActual
            // 
            this.textBoxPasswordActual.BackColor = System.Drawing.Color.Black;
            this.textBoxPasswordActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPasswordActual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordActual.ForeColor = System.Drawing.Color.White;
            this.textBoxPasswordActual.Location = new System.Drawing.Point(585, 280);
            this.textBoxPasswordActual.Name = "textBoxPasswordActual";
            this.textBoxPasswordActual.Size = new System.Drawing.Size(308, 19);
            this.textBoxPasswordActual.TabIndex = 18;
            this.textBoxPasswordActual.Text = "Password";
            this.textBoxPasswordActual.Enter += new System.EventHandler(this.textBoxPasswordActual_Enter);
            this.textBoxPasswordActual.Leave += new System.EventHandler(this.textBoxPasswordActual_Leave);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Black;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(540, 230);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(353, 29);
            this.textBox4.TabIndex = 27;
            this.textBox4.Text = "Current Password";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Black;
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(540, 340);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(353, 29);
            this.textBox5.TabIndex = 31;
            this.textBox5.Text = "New Password";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Location = new System.Drawing.Point(540, 375);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(39, 38);
            this.pictureBox5.TabIndex = 30;
            this.pictureBox5.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel4.Location = new System.Drawing.Point(540, 415);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(353, 1);
            this.panel4.TabIndex = 29;
            // 
            // textBoxPasswordNueva
            // 
            this.textBoxPasswordNueva.BackColor = System.Drawing.Color.Black;
            this.textBoxPasswordNueva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPasswordNueva.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordNueva.ForeColor = System.Drawing.Color.White;
            this.textBoxPasswordNueva.Location = new System.Drawing.Point(585, 390);
            this.textBoxPasswordNueva.Name = "textBoxPasswordNueva";
            this.textBoxPasswordNueva.Size = new System.Drawing.Size(308, 19);
            this.textBoxPasswordNueva.TabIndex = 28;
            this.textBoxPasswordNueva.Text = "Password";
            this.textBoxPasswordNueva.Enter += new System.EventHandler(this.textBoxPasswordNueva_Enter);
            this.textBoxPasswordNueva.Leave += new System.EventHandler(this.textBoxPasswordNueva_Leave);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Black;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBox7.Location = new System.Drawing.Point(493, 45);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(442, 37);
            this.textBox7.TabIndex = 32;
            this.textBox7.Text = "ALTERATION DATA CLIENT";
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonActualizar.Location = new System.Drawing.Point(540, 457);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(353, 58);
            this.buttonActualizar.TabIndex = 33;
            this.buttonActualizar.Text = "UPDATE";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // labelRestricciones
            // 
            this.labelRestricciones.AutoSize = true;
            this.labelRestricciones.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRestricciones.ForeColor = System.Drawing.Color.White;
            this.labelRestricciones.Location = new System.Drawing.Point(26, 457);
            this.labelRestricciones.Name = "labelRestricciones";
            this.labelRestricciones.Size = new System.Drawing.Size(0, 24);
            this.labelRestricciones.TabIndex = 34;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(30, 230);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(353, 29);
            this.textBox1.TabIndex = 38;
            this.textBox1.Text = "Current Username";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(30, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 1);
            this.panel1.TabIndex = 37;
            // 
            // textBoxUsuarioActual
            // 
            this.textBoxUsuarioActual.BackColor = System.Drawing.Color.Black;
            this.textBoxUsuarioActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsuarioActual.Enabled = false;
            this.textBoxUsuarioActual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuarioActual.ForeColor = System.Drawing.Color.White;
            this.textBoxUsuarioActual.Location = new System.Drawing.Point(75, 275);
            this.textBoxUsuarioActual.Name = "textBoxUsuarioActual";
            this.textBoxUsuarioActual.Size = new System.Drawing.Size(154, 19);
            this.textBoxUsuarioActual.TabIndex = 36;
            this.textBoxUsuarioActual.Text = "User";
            this.textBoxUsuarioActual.TextChanged += new System.EventHandler(this.textBoxUsuarioActual_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(30, 261);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 40);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // FormCambioDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1009, 558);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxUsuarioActual);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelRestricciones);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.textBoxPasswordNueva);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBoxPasswordActual);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCambioDatos";
            this.Text = "ThunderMusic";
            this.Load += new System.EventHandler(this.FormCambioDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxPasswordActual;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxPasswordNueva;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Label labelRestricciones;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxUsuarioActual;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}