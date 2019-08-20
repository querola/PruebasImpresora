namespace Prueba
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
            this.BtnBuscarPuertos = new System.Windows.Forms.Button();
            this.BtnEnviarDatos = new System.Windows.Forms.Button();
            this.BtnConectar = new System.Windows.Forms.Button();
            this.CboPuertos = new System.Windows.Forms.ComboBox();
            this.CboBaudRate = new System.Windows.Forms.ComboBox();
            this.TxtEnviar = new System.Windows.Forms.TextBox();
            this.TxtRecibidos = new System.Windows.Forms.TextBox();
            this.LblBaudRate = new System.Windows.Forms.Label();
            this.LblDatosIngreso = new System.Windows.Forms.Label();
            this.SpPuertos = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // BtnBuscarPuertos
            // 
            this.BtnBuscarPuertos.Location = new System.Drawing.Point(44, 32);
            this.BtnBuscarPuertos.Name = "BtnBuscarPuertos";
            this.BtnBuscarPuertos.Size = new System.Drawing.Size(157, 39);
            this.BtnBuscarPuertos.TabIndex = 0;
            this.BtnBuscarPuertos.Text = "Buscar";
            this.BtnBuscarPuertos.UseVisualStyleBackColor = true;
            this.BtnBuscarPuertos.Click += new System.EventHandler(this.BtnBuscarPuertos_Click);
            // 
            // BtnEnviarDatos
            // 
            this.BtnEnviarDatos.Location = new System.Drawing.Point(44, 176);
            this.BtnEnviarDatos.Name = "BtnEnviarDatos";
            this.BtnEnviarDatos.Size = new System.Drawing.Size(157, 33);
            this.BtnEnviarDatos.TabIndex = 1;
            this.BtnEnviarDatos.Text = "Enviar Datos";
            this.BtnEnviarDatos.UseVisualStyleBackColor = true;
            this.BtnEnviarDatos.Click += new System.EventHandler(this.BtnEnviarDatos_Click);
            // 
            // BtnConectar
            // 
            this.BtnConectar.Location = new System.Drawing.Point(543, 43);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(148, 39);
            this.BtnConectar.TabIndex = 2;
            this.BtnConectar.Text = "Conectar";
            this.BtnConectar.UseVisualStyleBackColor = true;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // CboPuertos
            // 
            this.CboPuertos.FormattingEnabled = true;
            this.CboPuertos.Location = new System.Drawing.Point(292, 43);
            this.CboPuertos.Name = "CboPuertos";
            this.CboPuertos.Size = new System.Drawing.Size(213, 28);
            this.CboPuertos.TabIndex = 3;
            // 
            // CboBaudRate
            // 
            this.CboBaudRate.FormattingEnabled = true;
            this.CboBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "115200"});
            this.CboBaudRate.Location = new System.Drawing.Point(292, 106);
            this.CboBaudRate.Name = "CboBaudRate";
            this.CboBaudRate.Size = new System.Drawing.Size(213, 28);
            this.CboBaudRate.TabIndex = 4;
            this.CboBaudRate.Text = "115200";
            // 
            // TxtEnviar
            // 
            this.TxtEnviar.Location = new System.Drawing.Point(292, 183);
            this.TxtEnviar.Name = "TxtEnviar";
            this.TxtEnviar.Size = new System.Drawing.Size(213, 26);
            this.TxtEnviar.TabIndex = 5;
            // 
            // TxtRecibidos
            // 
            this.TxtRecibidos.Location = new System.Drawing.Point(292, 250);
            this.TxtRecibidos.Name = "TxtRecibidos";
            this.TxtRecibidos.Size = new System.Drawing.Size(213, 26);
            this.TxtRecibidos.TabIndex = 6;
            // 
            // LblBaudRate
            // 
            this.LblBaudRate.AutoSize = true;
            this.LblBaudRate.Location = new System.Drawing.Point(49, 114);
            this.LblBaudRate.Name = "LblBaudRate";
            this.LblBaudRate.Size = new System.Drawing.Size(86, 20);
            this.LblBaudRate.TabIndex = 7;
            this.LblBaudRate.Text = "Baud Rate";
            // 
            // LblDatosIngreso
            // 
            this.LblDatosIngreso.AutoSize = true;
            this.LblDatosIngreso.Location = new System.Drawing.Point(49, 256);
            this.LblDatosIngreso.Name = "LblDatosIngreso";
            this.LblDatosIngreso.Size = new System.Drawing.Size(126, 20);
            this.LblDatosIngreso.TabIndex = 8;
            this.LblDatosIngreso.Text = "Datos Recibidos";
            // 
            // SpPuertos
            // 
            this.SpPuertos.BaudRate = 115200;
            this.SpPuertos.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.ErrorDedatos);
            this.SpPuertos.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DatoRecibido);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 353);
            this.Controls.Add(this.LblDatosIngreso);
            this.Controls.Add(this.LblBaudRate);
            this.Controls.Add(this.TxtRecibidos);
            this.Controls.Add(this.TxtEnviar);
            this.Controls.Add(this.CboBaudRate);
            this.Controls.Add(this.CboPuertos);
            this.Controls.Add(this.BtnConectar);
            this.Controls.Add(this.BtnEnviarDatos);
            this.Controls.Add(this.BtnBuscarPuertos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBuscarPuertos;
        private System.Windows.Forms.Button BtnEnviarDatos;
        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.ComboBox CboPuertos;
        private System.Windows.Forms.ComboBox CboBaudRate;
        private System.Windows.Forms.TextBox TxtEnviar;
        private System.Windows.Forms.TextBox TxtRecibidos;
        private System.Windows.Forms.Label LblBaudRate;
        private System.Windows.Forms.Label LblDatosIngreso;
        private System.IO.Ports.SerialPort SpPuertos;
    }
}

