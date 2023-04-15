namespace Vista
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CodigoUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.ContraseñaTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.MostrarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AceptarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONTRASEÑA:";
            // 
            // CodigoUsuarioTextBox
            // 
            this.CodigoUsuarioTextBox.Location = new System.Drawing.Point(243, 63);
            this.CodigoUsuarioTextBox.Name = "CodigoUsuarioTextBox";
            this.CodigoUsuarioTextBox.Size = new System.Drawing.Size(222, 26);
            this.CodigoUsuarioTextBox.TabIndex = 2;
            // 
            // ContraseñaTextBox
            // 
            this.ContraseñaTextBox.Location = new System.Drawing.Point(243, 105);
            this.ContraseñaTextBox.Name = "ContraseñaTextBox";
            this.ContraseñaTextBox.PasswordChar = '*';
            this.ContraseñaTextBox.Size = new System.Drawing.Size(192, 26);
            this.ContraseñaTextBox.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MostrarButton
            // 
            this.MostrarButton.Image = global::Vista.Properties.Resources.ver;
            this.MostrarButton.Location = new System.Drawing.Point(444, 107);
            this.MostrarButton.Name = "MostrarButton";
            this.MostrarButton.Size = new System.Drawing.Size(35, 26);
            this.MostrarButton.TabIndex = 7;
            this.MostrarButton.UseVisualStyleBackColor = true;
            this.MostrarButton.Click += new System.EventHandler(this.MostrarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Image = global::Vista.Properties.Resources.cancelar;
            this.CancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarButton.Location = new System.Drawing.Point(287, 175);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(139, 58);
            this.CancelarButton.TabIndex = 6;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vista.Properties.Resources.programador;
            this.pictureBox1.Location = new System.Drawing.Point(489, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AceptarButton
            // 
            this.AceptarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AceptarButton.Image = global::Vista.Properties.Resources.aceptar;
            this.AceptarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AceptarButton.Location = new System.Drawing.Point(142, 175);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(139, 58);
            this.AceptarButton.TabIndex = 4;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 296);
            this.ControlBox = false;
            this.Controls.Add(this.MostrarButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(this.ContraseñaTextBox);
            this.Controls.Add(this.CodigoUsuarioTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CodigoUsuarioTextBox;
        private System.Windows.Forms.TextBox ContraseñaTextBox;
        private System.Windows.Forms.Button AceptarButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button MostrarButton;
    }
}

