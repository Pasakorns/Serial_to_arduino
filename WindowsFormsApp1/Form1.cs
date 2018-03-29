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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private SerialPort myport;

        public Form1()
        {
            InitializeComponent();
            //Init();
        }

        private void btnON_Click(object sender, EventArgs e)
        {           
            myport = new SerialPort();
            myport.BaudRate = 9600;
            myport.PortName = "COM5";
            myport.Open();
            myport.WriteLine("ON");
            //myport.Close();

            btnON.Enabled = false;
            btnOFF.Enabled = true;
        }

        private void btnOFF_Click(object sender, EventArgs e)
        {
            myport = new SerialPort();
            myport.BaudRate = 9600;
            myport.PortName = "COM5";
            myport.Open();
            myport.WriteLine("OFF");
            //myport.Close();

            btnON.Enabled = true;
            btnOFF.Enabled = false;
        }

        private void Init()
        {
            try
            {
                myport = new SerialPort("COM5", 9600, Parity.None, 8, StopBits.One);
                myport.Open();

            }
            catch(Exception)
            {
                MessageBox.Show("Can't connect to Arduino!!!");
            }

            //
            btnON.Enabled = true;
            btnOFF.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            textBox1.AppendText(serialPort1.ReadLine());
        }
    }
}
