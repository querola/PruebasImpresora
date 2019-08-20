using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Prueba
{
    public partial class Form1 : Form
    {
        private string strBufferIn;
        private string strBufferout;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            strBufferIn = "";
            strBufferout = "";
            BtnConectar.Enabled = false;
            BtnEnviarDatos.Enabled = false;

        }

        private void BtnBuscarPuertos_Click(object sender, EventArgs e)
        {
            string[] PuertosDisponibles = SerialPort.GetPortNames();

            CboPuertos.Items.Clear();

            foreach (string puerto_simple in PuertosDisponibles)
            {
                CboPuertos.Items.Add(puerto_simple);
            }
            if (CboPuertos.Items.Count > 0)
            {
                CboPuertos.SelectedIndex = 0;
                MessageBox.Show("Seleccionar puerto");
                BtnConectar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se detectaron Puertos");
                CboPuertos.Items.Clear();
                CboPuertos.Text = "";
                strBufferIn = "";
                strBufferout = "";
                BtnConectar.Enabled = false;
                BtnEnviarDatos.Enabled = false;
            }
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (BtnConectar.Text =="Conectar")
                {
                    SpPuertos.BaudRate = 115200;
                    SpPuertos.DataBits = 8;
                    SpPuertos.Parity = Parity.None;
                    SpPuertos.StopBits = StopBits.One;
                    SpPuertos.Handshake = Handshake.None;
                    SpPuertos.PortName = CboPuertos.Text;

                    try
                    {
                        SpPuertos.Open();
                        BtnConectar.Text = "Desconectar";
                        BtnEnviarDatos.Enabled = true;
                   
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                
                    }


                }
                else if (BtnConectar.Text == "Desconectar")
                {
                    SpPuertos.Close();
                    BtnConectar.Text = "Desconectar";
                    BtnEnviarDatos.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnEnviarDatos_Click(object sender, EventArgs e)
        {
            try
            {


                SpPuertos.DiscardOutBuffer();
                //byte[] buffer_out = new byte[30];
                var pruebas = strinToByte(TxtEnviar.Text);
                //var prueba2 = Convert.ToDecimal(TxtEnviar.Text);
               // byte[] arreglo = { 0x1D, 0x49 , 0x40};
               // byte[] arreglo2 = { 0x1F, 0x74 };
                byte[] arreglo2 = { 0x1B, 0x6D };
                //buffer_out[1] = 0xbb;
                // int offset = 0;
                if (SpPuertos.IsOpen == true) {
                    //MessageBox.Show("Esta Abierto");
                    SpPuertos.WriteLine("");
                    SpPuertos.WriteLine("");
                    SpPuertos.WriteLine("meper d0nas¿ si te e fayado t pido perdon d la única forma q c dandote mi corason para kuando decidas volver, yo solo quiero tu amistad");
                    //SpPuertos.WriteLine("compañeros de oficina porfavor :) de antemano gracias");
                    SpPuertos.WriteLine("");
                    SpPuertos.WriteLine("");
                    SpPuertos.WriteLine("");
                    SpPuertos.WriteLine("");
                    SpPuertos.WriteLine("");
                    SpPuertos.WriteLine("");
                    SpPuertos.Write(arreglo2, 0, arreglo2.Length);
                   // SpPuertos.Read(arreglo, offset, arreglo.Length);
                }
                else 
                    MessageBox.Show("Esta Cerrado");
                           

                SpPuertos.Close();
                MessageBox.Show("Funciono?");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
        public byte[] strinToByte(string cadena)
        {
            return Enumerable.Range(0, cadena.Length).Where(x => x % 2 == 0).Select(x => Convert.ToByte(cadena.Substring(x, 2), 16)).ToArray();
        }
        private void DatoRecibido(object sender, SerialDataReceivedEventArgs e)
        {
            string Data_in = SpPuertos.ReadExisting();
            MessageBox.Show(Data_in);
            TxtRecibidos.Text = Data_in;
        }

        private void ErrorDedatos(object sender, SerialErrorReceivedEventArgs e)
        {
            MessageBox.Show("Error");
        }
    }
}
