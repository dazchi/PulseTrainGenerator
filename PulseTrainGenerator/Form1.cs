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
using System.Reflection;

namespace PulseTrainGenerator
{
    public partial class Form1 : Form
    {
        SerialPort SP = new SerialPort();
        Thread t_sendpulse;
        bool Running = false;

        private delegate void SetObjectPropertyThreadSafeDelegate(object item, string propertyName, object propertyValue);
        public void SetObjectPropertyThreadSafe(object item, string propertyName, object propertyValue)
        {
            if (InvokeRequired)
            {
                SetObjectPropertyThreadSafeDelegate d = new SetObjectPropertyThreadSafeDelegate(SetObjectPropertyThreadSafe);
                this.Invoke(d, new object[] { item, propertyName, propertyValue });
            }
            else
            {
                PropertyInfo propertyInfo = item.GetType().GetProperty(propertyName);
                propertyInfo.SetValue(item, propertyValue, null);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        void GetSerialPortsNames()
        {
            comboBox_port.Sorted = true;

            string[] ports = SerialPort.GetPortNames();
            comboBox_port.Items.Clear();
            comboBox_port.Items.AddRange(ports);
            if (comboBox_port.Items.Count != 0)        //AutoSelect First COM Port
                comboBox_port.SelectedItem = comboBox_port.Items[0];
        }
   

        private void Form1_Load(object sender, EventArgs e)
        {
            GetSerialPortsNames();
            label_steps.Text = $"{numericUpDown_steps.Value * 5 } Steps";
            groupBox1.Enabled = false;
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            SP.PortName = comboBox_port.Text;
            SP.DataBits = 8;
            SP.WriteTimeout = -1;
            SP.BaudRate = 51200;
            SP.StopBits = StopBits.One;
            SP.Handshake = Handshake.None;
            SP.Parity = Parity.None;       
            try
            {
                SP.Open();
                button_connect.Enabled = false;
                groupBox1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            
        }

        private void SendPulse()
        {
            Running = true;
            try
            {
                SP.BaudRate = (int)(numericUpDown_pps.Value * 9) / 5;
                
            }
            catch (Exception ex)
            {
                Running = false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetObjectPropertyThreadSafe(button_send, "Enabled", true);
                return;                
            }
            
            byte[] data = new byte[(int)numericUpDown_steps.Value];
            for (int i = 0; i < data.Length; i++)
            {            
                data[i] = 0x55;                                       
            }
            try
            {
                SP.Write(data, 0, (int)numericUpDown_steps.Value);               
            }
            catch (Exception)
            {
               
            }
            finally
            {
                SetObjectPropertyThreadSafe(button_send, "Enabled", true);
                Running = false;
            }       
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button_send.Enabled = false;            
            t_sendpulse = new Thread(SendPulse);
            t_sendpulse.Start();
        }

        private void numericUpDown_steps_ValueChanged(object sender, EventArgs e)
        {
            label_steps.Text = $"{numericUpDown_steps.Value * 5 } Steps";
        }

        private void button_abort_Click(object sender, EventArgs e)
        {
            try
            {              
                SP.Close();
                groupBox1.Enabled = false;
                button_send.Enabled = true;
                button_connect.Enabled = true;
            }
            catch (Exception)
            {
               
            }       
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Running)
            {
                e.Cancel = true;
                MessageBox.Show("Busy!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

     
    }
}
