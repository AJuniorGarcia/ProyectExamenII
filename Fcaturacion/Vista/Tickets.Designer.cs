namespace Vista
{
    partial class Tickets
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
            this.Gurdar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtRespuesta1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtUsuario1 = new System.Windows.Forms.TextBox();
            this.txtCliente1 = new System.Windows.Forms.TextBox();
            this.cmbTipoSoporte1 = new System.Windows.Forms.ComboBox();
            this.txtSolicitud1 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.txtPrecio1 = new System.Windows.Forms.TextBox();
            this.txtImpuesto1 = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.DateTime1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox4.SuspendLayout();
            this.txtRespuesta1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gurdar
            // 
            this.Gurdar.Location = new System.Drawing.Point(35, 646);
            this.Gurdar.Name = "Gurdar";
            this.Gurdar.Size = new System.Drawing.Size(528, 58);
            this.Gurdar.TabIndex = 0;
            this.Gurdar.Text = "Guardar";
            this.Gurdar.UseVisualStyleBackColor = true;
            this.Gurdar.Click += new System.EventHandler(this.Gurdar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Usuario";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(692, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Cliente";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(684, 550);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Precio";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(661, 595);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "Impuesto";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(650, 638);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 20);
            this.label14.TabIndex = 6;
            this.label14.Text = "Descuento";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(693, 684);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 20);
            this.label15.TabIndex = 7;
            this.label15.Text = "Total";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtSolicitud1);
            this.groupBox4.Location = new System.Drawing.Point(25, 235);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(986, 100);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Descripcion Solicitud";
            // 
            // txtRespuesta1
            // 
            this.txtRespuesta1.Controls.Add(this.textBox9);
            this.txtRespuesta1.Location = new System.Drawing.Point(25, 354);
            this.txtRespuesta1.Name = "txtRespuesta1";
            this.txtRespuesta1.Size = new System.Drawing.Size(986, 100);
            this.txtRespuesta1.TabIndex = 9;
            this.txtRespuesta1.TabStop = false;
            this.txtRespuesta1.Text = "Respuesta Solicitud";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 147);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 20);
            this.label16.TabIndex = 10;
            this.label16.Text = "Tipo de soporte";
            // 
            // txtUsuario1
            // 
            this.txtUsuario1.Location = new System.Drawing.Point(414, 40);
            this.txtUsuario1.Multiline = true;
            this.txtUsuario1.Name = "txtUsuario1";
            this.txtUsuario1.Size = new System.Drawing.Size(242, 38);
            this.txtUsuario1.TabIndex = 12;
            // 
            // txtCliente1
            // 
            this.txtCliente1.Location = new System.Drawing.Point(756, 40);
            this.txtCliente1.Multiline = true;
            this.txtCliente1.Name = "txtCliente1";
            this.txtCliente1.Size = new System.Drawing.Size(242, 38);
            this.txtCliente1.TabIndex = 13;
            // 
            // cmbTipoSoporte1
            // 
            this.cmbTipoSoporte1.FormattingEnabled = true;
            this.cmbTipoSoporte1.Location = new System.Drawing.Point(177, 144);
            this.cmbTipoSoporte1.Name = "cmbTipoSoporte1";
            this.cmbTipoSoporte1.Size = new System.Drawing.Size(188, 28);
            this.cmbTipoSoporte1.TabIndex = 14;
            // 
            // txtSolicitud1
            // 
            this.txtSolicitud1.Location = new System.Drawing.Point(6, 25);
            this.txtSolicitud1.Multiline = true;
            this.txtSolicitud1.Name = "txtSolicitud1";
            this.txtSolicitud1.Size = new System.Drawing.Size(967, 69);
            this.txtSolicitud1.TabIndex = 15;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(6, 25);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(967, 69);
            this.textBox9.TabIndex = 16;
            // 
            // txtPrecio1
            // 
            this.txtPrecio1.Location = new System.Drawing.Point(756, 543);
            this.txtPrecio1.Multiline = true;
            this.txtPrecio1.Name = "txtPrecio1";
            this.txtPrecio1.Size = new System.Drawing.Size(242, 38);
            this.txtPrecio1.TabIndex = 15;
            // 
            // txtImpuesto1
            // 
            this.txtImpuesto1.Location = new System.Drawing.Point(756, 587);
            this.txtImpuesto1.Multiline = true;
            this.txtImpuesto1.Name = "txtImpuesto1";
            this.txtImpuesto1.Size = new System.Drawing.Size(242, 38);
            this.txtImpuesto1.TabIndex = 16;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(756, 631);
            this.txtDescuento.Multiline = true;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(242, 38);
            this.txtDescuento.TabIndex = 17;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(756, 675);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(242, 38);
            this.txtTotal.TabIndex = 18;
            // 
            // DateTime1
            // 
            this.DateTime1.Location = new System.Drawing.Point(105, 45);
            this.DateTime1.Name = "DateTime1";
            this.DateTime1.Size = new System.Drawing.Size(200, 26);
            this.DateTime1.TabIndex = 19;
            // 
            // Tickets
            // 
            this.ClientSize = new System.Drawing.Size(1045, 727);
            this.Controls.Add(this.DateTime1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtImpuesto1);
            this.Controls.Add(this.txtPrecio1);
            this.Controls.Add(this.cmbTipoSoporte1);
            this.Controls.Add(this.txtCliente1);
            this.Controls.Add(this.txtUsuario1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtRespuesta1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Gurdar);
            this.Name = "Tickets";
            this.Load += new System.EventHandler(this.Tickets_Load_1);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.txtRespuesta1.ResumeLayout(false);
            this.txtRespuesta1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker DateTime;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.ComboBox cmbTipoSoporte;
        private System.Windows.Forms.TextBox txtSolicitud;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Gurdar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtSolicitud1;
        private System.Windows.Forms.GroupBox txtRespuesta1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtUsuario1;
        private System.Windows.Forms.TextBox txtCliente1;
        private System.Windows.Forms.ComboBox cmbTipoSoporte1;
        private System.Windows.Forms.TextBox txtPrecio1;
        private System.Windows.Forms.TextBox txtImpuesto1;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DateTimePicker DateTime1;
    }
}