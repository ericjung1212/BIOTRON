/*
 * Project: Pressure Sensor
 * Date: Fall 2019
 * Rev 1
 * 
 * GUI Code for visualizing the pressure sensor mat.
 * 
 * Authors: Lixin Chu
 *          Eric Jung
 *          Jonah Leinwand
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string arduinoinfo;
        string[] splitter = new string[9];
        float[] pressures = new float[9];

        int counter = 0; //for test with the clicker
        public Form1()
        {
            InitializeComponent();                     //Initialize 
            serialPort1.Open();                        //Open Serial Port
            Thread Loop_Thread = new Thread(Loop);   //Begin Loop
            Loop_Thread.Start();
        }

        public void Loop()                             //Loop to constantly update info
        {
            while (true)
            {
                Display();                             //Display Function for pressure mat
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(Read_String); //Read Arduino info
            }
        }

        public void Read_String(object sender, SerialDataReceivedEventArgs e)
        {
            arduinoinfo = serialPort1.ReadExisting();
            splitter = arduinoinfo.Split("@"); //split incoming arduino string

            //assign read pressures to pressures array
            for (int i = 0; i < splitter.Length; i++)
            {
                float.TryParse(splitter[i], out float pressure[i]);
            }
        }

        Thread.Delay(500);
    }


        public void Display()
        {
            
        }
    }
        
        private void PictureBox1(object sender, EventArgs e)
        {
            if (sensor1.BackColor == Color.Yellow)
            {
                sensor1.BackColor = Color.Red;
                counter++;
                textBox1.Text = $"# of clicks: { counter }";
            }
            else if (sensor1.BackColor == Color.Red)
            {
                sensor1.BackColor = Color.Yellow;
                counter++;
                textBox1.Text = $"# of clicks: { counter }";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sensor2.BackColor = Color.Red;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            sensor3.BackColor = Color.Red;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            sensor4.BackColor = Color.Red;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            sensor5.BackColor = Color.Red;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            sensor6.BackColor = Color.Red;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            sensor7.BackColor = Color.Red;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            sensor8.BackColor = Color.Red;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            sensor9.BackColor = Color.Red;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
}
