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
    public partial class LcdFuntion : Form
    {
        private SerialPort SpPorts;
        public LcdFuntion(SerialPort spPorts)
        {
            InitializeComponent();
            SpPorts = spPorts;

        }

        bool On_StaticText = false;
        bool On_TextScrolling = false;
        bool On_FlashingText = false;
        bool On_StaticImage = false;

        
    private void LcdFuntion_Load(object sender, EventArgs e)
        {

        }

        private void BtnStaticText_Click(object sender, EventArgs e)
        {
            try
            {
                if (On_StaticText == false)
                {
                    SpPorts.Write("7");
                    pictureBox1.BackColor = Color.Red;
                    On_StaticText = true;
                    BtnStaticText.Text = "Texto estatico";

                    BtnTextScrolling.Enabled = false;
                    BtnFlashingText.Enabled = false;
                    BtnStaticImage.Enabled = false;

                }
                else
                {

                    SpPorts.Write("8");
                    pictureBox1.BackColor = Color.Black;
                    On_StaticText = false;
                    BtnStaticText.Text = "Texto estatico";

                    BtnTextScrolling.Enabled = true;
                    BtnFlashingText.Enabled = true;
                    BtnStaticImage.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private void BtnTextScrolling_Click(object sender, EventArgs e)
        {

            try
            {
                if (On_TextScrolling == false)
                {
                    SpPorts.Write("9");
                    pictureBox2.BackColor = Color.Red;
                    On_TextScrolling = true;
                    BtnTextScrolling.Text = "Texto con desplazamiento";

                    BtnStaticText.Enabled = false;
                    BtnFlashingText.Enabled = false;
                    BtnStaticImage.Enabled = false;

                }
                else
                {

                    SpPorts.Write("10");
                    pictureBox2.BackColor = Color.Black;
                    On_TextScrolling = false;
                    BtnTextScrolling.Text = "Texto con desplazamiento";

                    BtnStaticText.Enabled = true;
                    BtnFlashingText.Enabled = true;
                    BtnStaticImage.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }

        }

        private void BtnFlashingText_Click(object sender, EventArgs e)
        {

            try
            {
                if (On_FlashingText == false)
                {
                    SpPorts.Write("11");
                    pictureBox3.BackColor = Color.Red;
                    On_FlashingText = true;
                    BtnFlashingText.Text = "Texto parpadeando";

                    BtnStaticText.Enabled = false;
                    BtnTextScrolling.Enabled = false;
                    BtnStaticImage.Enabled = false;

                }
                else
                {

                    SpPorts.Write("12");
                    pictureBox3.BackColor = Color.Black;
                    On_FlashingText = false;
                    BtnFlashingText.Text = "Texto parpadeante";

                    BtnStaticText.Enabled = true;
                    BtnTextScrolling.Enabled = true;
                    BtnStaticImage.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }

        }

        private void BtnStaticImage_Click(object sender, EventArgs e)
        {

            try
            {
                if (On_StaticImage == false)
                {
                    SpPorts.Write("1");
                    pictureBox4.BackColor = Color.Red;
                    On_StaticImage = true;
                    BtnStaticImage.Text = "Imagen estatico";

                    BtnStaticText.Enabled = false;
                    BtnTextScrolling.Enabled = false;
                    BtnFlashingText.Enabled = false;

                }
                else
                {

                    SpPorts.Write("2");
                    pictureBox4.BackColor = Color.Black;
                    On_StaticImage = false;
                    BtnStaticImage.Text = "Texto parpadeante";

                    BtnStaticText.Enabled = true;
                    BtnTextScrolling.Enabled = true;
                    BtnFlashingText.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }

        }
    }
}
