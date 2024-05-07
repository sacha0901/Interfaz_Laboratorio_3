using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class FrmHome : Form
    {
        private String strBufferIn;
        private String strBufferOut;

        public FrmHome()
        {
            InitializeComponent();
        }

        bool On_LedMatrix = false;
        bool On_LcdDisplay = false;
        bool On_Sensors = false;
        bool Conected = false;
        private void FrmHome_Load(object sender, EventArgs e)
        {
            strBufferIn = "";
            strBufferOut = "";
            BtnConect.Enabled= false;
            TmrTimer.Start();
        
        }

        private void BtnConect_Click(object sender, EventArgs e)
        {
            try
            {
              

                if (Conected == false)
                {
                    SpPorts.BaudRate = Int32.Parse(CboBaudRate.Text);
                    SpPorts.DataBits = 8;
                    SpPorts.Parity = Parity.None;
                    SpPorts.StopBits = StopBits.One;
                    SpPorts.Handshake = Handshake.None;
                    SpPorts.PortName = CboPorts.Text;

                    try
                    {
                        TmrTimerConect.Stop();
                        LblTimer.Text = Convert.ToString(TimerConect);
                        SpPorts.Open();
                        BtnLedMatrix.Enabled = true;
                        BtnLcdDisplay.Enabled = true;
                        BtnSensors.Enabled = true;
                        TmrTimerConect.Start();
                        //pictureBox1.BackColor = Color.GreenYellow;
                        Conected = true;
                        BtnConect.Text = "Disconnect";
                        pictureBox8.Image = Properties.Resources.conect;
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }

                }
                else
                {
                    TmrTimerConect.Start();
                    SpPorts.Close();
                    //pictureBox1.BackColor = Color.Black;
                    Conected = false;
                    BtnConect.Text = "Conect";
                    BtnLedMatrix.Enabled = false;
                    BtnLcdDisplay.Enabled = false;
                    BtnSensors.Enabled = false;
                   
                    pictureBox2.BackColor = Color.Black;
                    pictureBox3.BackColor = Color.Black;
                    pictureBox4.BackColor = Color.Black;
                    pictureBox8.Image = Properties.Resources.disconnected;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }

        }

        private void BtnSearchPorts_Click(object sender, EventArgs e)
        {
            string[] AvailablePorts = SerialPort.GetPortNames();

            CboPorts.Items.Clear();

            foreach (string simple_port in AvailablePorts)
            {
                CboPorts.Items.Add(simple_port);
            }

            if (CboPorts.Items.Count > 0)
            {
                CboPorts.SelectedIndex = 0;
                MessageBox.Show("Select the working port");
                BtnConect.Enabled = true;
            }
            else
            {
                MessageBox.Show("no port detected");
                CboPorts.Items.Clear();
                CboPorts.Text = "                     ";
                strBufferIn = "";
                strBufferOut = "";
                BtnConect.Enabled = false;
            }
        }

        private void BtnLedMatrix_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (On_LedMatrix == false)
                {
                    SpPorts.Write("1");
                    pictureBox2.BackColor = Color.Red;
                    On_LedMatrix = true;
                    BtnLedMatrix.Text = "    Matriz de Leds 8x8";

                    BtnLcdDisplay.Enabled = false;
                    BtnSensors.Enabled = false;

                }
                else
                {

                    SpPorts.Write("2");
                    pictureBox2.BackColor = Color.Black;
                    On_LedMatrix = false;
                    BtnLedMatrix.Text = "    Matriz de Leds 8x8";

                    BtnLcdDisplay.Enabled = true;
                    BtnSensors.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private void BtnLcdDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia del formulario LcdFuntion y pasar el puerto serial al constructor
                LcdFuntion lcdFuntionForm = new LcdFuntion(SpPorts);
                lcdFuntionForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            /*
            try
            {
                if (On_LcdDisplay == false)
                {
                    SpPorts.Write("3");
                    pictureBox3.BackColor = Color.Red;
                    On_LcdDisplay = true;
                    BtnLcdDisplay.Text = "Pantalla LCD";

                    BtnLedMatrix.Enabled = false;
                    BtnSensors.Enabled = false;

                }
                else
                {

                    SpPorts.Write("4");
                    pictureBox3.BackColor = Color.Black;
                    On_LcdDisplay = false;
                    BtnLcdDisplay.Text = "Pantalla LCD";

                    BtnLedMatrix.Enabled = true;
                    BtnSensors.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
            */
        }


        private void BtnSensors_Click(object sender, EventArgs e)
        {
            try
            {
                if (On_Sensors == false)
                {
                    SpPorts.Write("5");
                    pictureBox4.BackColor = Color.Red;
                    On_Sensors = true;
                    BtnSensors.Text = "Sensores";

                    BtnLedMatrix.Enabled = false;
                    BtnLcdDisplay.Enabled = false;

                }
                else
                {

                    SpPorts.Write("6");
                    pictureBox4.BackColor = Color.Black;
                    On_Sensors = false;
                    BtnSensors.Text = "Sensores";

                    BtnLedMatrix.Enabled = true;
                    BtnLcdDisplay.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void TmrTimer_Tick(object sender, EventArgs e)
        {
            int Timer = int.Parse(LblTimer.Text);
            Timer += 1;
            LblTimer.Text = Convert.ToString(Timer);
            if (Timer == 20)
            {
                pictureBox5.Image = Properties.Resources.LedMatrix;
            }

            if (Timer == 40)
            {
                pictureBox5.Image = Properties.Resources.LcdDisplay;
            }

            if (Timer == 60)
            {
                TmrTimer.Stop();
                pictureBox5.Image = Properties.Resources.Sensors;
                Timer = 0;
                LblTimer.Text = Convert.ToString(Timer);
                TmrTimer.Start();
            }
        }
        int TimerConect;
        private void TmrTimerConect_Tick(object sender, EventArgs e)
        {
            if (Conected == true)
            {
       
                TimerConect = int.Parse(LblTimerConect.Text);
                TimerConect += 1;
                LblTimerConect.Text = Convert.ToString(TimerConect);

                if (TimerConect == 1)
                {
                    pictureBox1.BackColor = Color.GreenYellow;
                }


                if (TimerConect == 2)
                {
                    TmrTimerConect.Stop();
                    pictureBox1.BackColor = Color.Black;
                    TimerConect = 0;
                    LblTimerConect.Text = Convert.ToString(TimerConect);
                    TmrTimerConect.Start();
                }
            }
            else
            {
                pictureBox1.BackColor = Color.Black;
            }

            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CboPorts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
