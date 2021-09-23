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
using System.Threading;

namespace Serial_Arduino
{
    public partial class Form1 : Form
    {
        string Entrada;
        private delegate void SetTextDelege(string data);
        string R;
        string G;
        string B;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            button4.Visible = false;
            button3.Visible = false;

            RS232();
            try
            {
                // abre conecao com as portas e muda cor da label.
                serialPort1.Open();
                lblCOM1.ForeColor = Color.Green;

            }

            catch
            {
                // se nao conseguir conexao com a porta muda cor da label e exibe mensagem.
                if (!serialPort1.IsOpen)
                {
                    lblCOM1.ForeColor = Color.Red;
                    MessageBox.Show("Porta Serial já em Uso");
                    hScrollBar1.Enabled = false;
                    hScrollBar2.Enabled = false;
                    hScrollBar3.Enabled = false;
                    return;
                }
            }

            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        private void RS232() // configura as portas seriais
        {
            serialPort1.PortName = "COM5";   //scanner
            serialPort1.BaudRate = Convert.ToInt32(115200);
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;
            serialPort1.DataBits = 8;
        }




        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e) // recebe sinal da serial
        {
            SerialPort sp = (SerialPort)sender;
            System.Threading.Thread.Sleep(100);
            string indata = sp.ReadExisting();

            this.BeginInvoke(new SetTextDelege(DisplayToUI), new object[] { indata });

        }

        private void DisplayToUI(string displayData)  // recebe dados da serial e envia para as seriais 
        {

            Entrada = "";

            Entrada += displayData.Trim();
            listBox1.ForeColor = Color.Red;
            listBox1.Items.Add(Entrada);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("900000");
            hScrollBar1.Value = 90;
            //pictureBox_cinza.Visible = true;
            //pictureBox_cinza.Visible = false;
            button1.Visible = false;
            button2.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("000000");
           
            hScrollBar1.Value = 0;
            hScrollBar2.Value = 0;
            hScrollBar3.Value = 0;

            //pictureBox_cinza.Visible = false;
            //pictureBox_cinza.Visible = true;
            button2.Visible = false;
            button1.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("009000");

            hScrollBar1.Value = 0;
            hScrollBar2.Value = 90;
            hScrollBar3.Value = 0;

            //pictureBox_verde.Visible = true;
            //pictureBox_cinza2.Visible = false;
            button4.Visible = true;
            button5.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("000000");

            hScrollBar1.Value = 0;
            hScrollBar2.Value = 0;
            hScrollBar3.Value = 0;

            //pictureBox_verde.Visible = false;
            //pictureBox_cinza2.Visible = true;
            button4.Visible = false;
            button5.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("000090");
            hScrollBar1.Value = 0;
            hScrollBar2.Value = 0;
            hScrollBar3.Value = 90;
            //pictureBox_azul.Visible = true;
            //pictureBox_cinza3.Visible = false;
            button6.Visible = false;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("000000");
            hScrollBar1.Value = 0;
            hScrollBar2.Value = 0;
            hScrollBar3.Value = 0;
            //pictureBox_azul.Visible = false;
            //pictureBox_cinza3.Visible = true;
            button6.Visible = true;
            button3.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(textBox1.Text);
            textBox1.Focus();
        }
        public void calculo()
        {

            if (hScrollBar1.Value <= 9)
            {
                R = "0" + Convert.ToString(hScrollBar1.Value);

            }
            else
            {
                R = Convert.ToString(hScrollBar1.Value);
            }

            if (hScrollBar2.Value <= 9)
            {
                G = "0" + Convert.ToString(hScrollBar2.Value);
            }
            else
            {
                G = Convert.ToString(hScrollBar2.Value);
            }
            if (hScrollBar3.Value <= 9)
            {
                B = "0" + Convert.ToString(hScrollBar3.Value);
            }
            else
            {
                B = Convert.ToString(hScrollBar3.Value);
            }

            textBox1.Text = R + G + B;

            lblVermelho.Text = R;
            lblVerde.Text = G;
            lblAzul.Text = B;

            Thread.Sleep(500);
            serialPort1.WriteLine(R + G + B);

        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            calculo();
            aGauge1.Value = hScrollBar1.Value;
            aGauge1.Refresh();
        }

        private void hScrollBar2_ValueChanged(object sender, EventArgs e)
        {
            calculo();
            aGauge2.Value = hScrollBar2.Value;
            aGauge2.Refresh();
        }

        private void hScrollBar3_ValueChanged(object sender, EventArgs e)
        {
            calculo();
            aGauge3.Value = hScrollBar3.Value;
            aGauge3.Refresh();
        }

    }

}
