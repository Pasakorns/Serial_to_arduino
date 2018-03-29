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

namespace SerialTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getAvailablePort();
            serialPort1.ReadTimeout = 3000;
        }

        private void cmbBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void getAvailablePort()
        {
            String[] ports = SerialPort.GetPortNames();
            cmbPortName.Items.AddRange(ports);
        }

        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmbPortName.Text == "" || cmbBaudRate.Text == "")
                {
                    MessageBox.Show("Please select port name or baud rate!");
                }
                else
                {
                    serialPort1.PortName = cmbPortName.Text;
                    serialPort1.BaudRate = Convert.ToInt32(cmbBaudRate.Text);
                    serialPort1.Open();
                    progressBar1.Value = 100;
                    btnSend.Enabled = true;
                    btnRead.Enabled = true;
                    txtSend.Enabled = true;
                    btnOpenPort.Enabled = false;
                    btnClosePort.Enabled = true;                    
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Connection error");
            }
        }

        private void btnClosePort_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            progressBar1.Value = 0;
            btnSend.Enabled = false;
            btnRead.Enabled = false;
            txtSend.Enabled = false;
            txtReceive.Enabled = false;
            btnClosePort.Enabled = false;
            btnOpenPort.Enabled = true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(txtSend.Text);
            txtSend.Text = "";
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                txtReceive.Text = serialPort1.ReadLine();
            }
            catch(TimeoutException)
            {
                MessageBox.Show("Connection time out!!!");
            }
        }
    }
}
