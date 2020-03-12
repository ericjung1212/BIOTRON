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
        string str;
        string[] splitter = new string[9];
        char[] separator = new char[] { '@' };
        float[] pressures = new float[9];
        Color backcolor;

        System.Threading.Thread Loop_Thread; //Declaring thread for infinite loop

        public Form1()
        {
            InitializeComponent();                     //Initialize 
            serialPort1.Open();                        //Open Serial Port
            Loop_Thread = new System.Threading.Thread(Loop);   //Begin Loop
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
            str = serialPort1.ReadExisting();
            splitter = str.Split(separator, StringSplitOptions.None); //split incoming arduino string

            //assign read pressures to pressures array
            for (int i = 0; i < splitter.Length; i++)
            {
                float.TryParse(splitter[0], NumberStyles.Any, CultureInfo.InvariantCulture, out pressures[i]);
            }

            Thread.Sleep(500);

        }


        public void Display()
        {
            
            for (int i = 0; i < pressures.Length; i++)
            {
                if (pressures[i] >= 0 && pressures[i] < 341)
                    backcolor = Color.Yellow;
                else if (pressures[i] >= 341 && pressures[i] < 682)
                    backcolor = Color.Orange;
                else if (pressures[i] >= 682 && pressures[i] <= 1023)
                    backcolor = Color.Red;

                switch(i)
                {
                    case 0:
                        sensor1.BackColor = backcolor;
                        break;
                    case 1:
                        sensor2.BackColor = backcolor;
                        break;
                    case 2:
                        sensor3.BackColor = backcolor;
                        break;
                    case 3:
                        sensor4.BackColor = backcolor;
                        break;
                    case 4:
                        sensor5.BackColor = backcolor;
                        break;
                    case 5:
                        sensor6.BackColor = backcolor;
                        break;
                    case 6:
                        sensor7.BackColor = backcolor;
                        break;
                    case 7:
                        sensor8.BackColor = backcolor;
                        break;
                    case 8:
                        sensor9.BackColor = backcolor;
                        break;
                }
            }
        }

    }
}
