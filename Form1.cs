using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        bool daLiImaPocetneNule = true, daLiImaTacke = false, daLiImaX = false, brisiBroj = false;
        double x=0, prosliBroj=0;
        char prosliZnak;
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!brisiBroj)
            {
                if (!daLiImaPocetneNule)
                {
                    textBox1.Text = textBox1.Text + "1";
                    daLiImaPocetneNule = false;
                }
                else
                {
                    textBox1.Text = "1";
                    daLiImaPocetneNule = false;
                }
            }
            else
            {
                textBox1.Text = "1";
                brisiBroj = false;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (!brisiBroj)
            {
                if (!daLiImaPocetneNule)
                {
                    textBox1.Text = textBox1.Text + "2";
                    daLiImaPocetneNule = false;
                }
                else
                {
                    textBox1.Text = "2";
                    daLiImaPocetneNule = false;
                }
            }
            else
            {
                textBox1.Text = "2";
                brisiBroj = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!brisiBroj)
            {
                if (!daLiImaPocetneNule)
                {
                    textBox1.Text = textBox1.Text + "3";
                    daLiImaPocetneNule = false;
                }
                else
                {
                    textBox1.Text = "3";
                    daLiImaPocetneNule = false;
                }
            }
            else
            {
                textBox1.Text = "3";
                brisiBroj = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!brisiBroj)
            {
                if (!daLiImaPocetneNule)
                {
                    textBox1.Text = textBox1.Text + "4";
                    daLiImaPocetneNule = false;
                }
                else
                {
                    textBox1.Text = "4";
                    daLiImaPocetneNule = false;
                }
            }
            else
            {
                textBox1.Text = "4";
                brisiBroj = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!brisiBroj)
            {
                if (!daLiImaPocetneNule)
                {
                    textBox1.Text = textBox1.Text + "5";
                    daLiImaPocetneNule = false;
                }
                else
                {
                    textBox1.Text = "5";
                    daLiImaPocetneNule = false;
                }
            }
            else
            {
                textBox1.Text = "5";
                brisiBroj = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!brisiBroj)
            {
                if (!daLiImaPocetneNule)
                {
                    textBox1.Text = textBox1.Text + "6";
                    daLiImaPocetneNule = false;
                }
                else
                {
                    textBox1.Text = "6";
                    daLiImaPocetneNule = false;
                }
            }
            else
            {
                textBox1.Text = "6";
                brisiBroj = false;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (!brisiBroj)
            {
                if (!daLiImaPocetneNule)
                {
                    textBox1.Text = textBox1.Text + "7";
                    daLiImaPocetneNule = false;
                }
                else
                {
                    textBox1.Text = "7";
                    daLiImaPocetneNule = false;
                }
            }
            else
            {
                textBox1.Text = "7";
                brisiBroj = false;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!brisiBroj)
            {
                if (!daLiImaPocetneNule)
                {
                    textBox1.Text = textBox1.Text + "8";
                    daLiImaPocetneNule = false;
                }
                else
                {
                    textBox1.Text = "8";
                    daLiImaPocetneNule = false;
                }
            }
            else
            {
                textBox1.Text = "8";
                brisiBroj = false;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!brisiBroj)
            {
                if (!daLiImaPocetneNule)
                {
                    textBox1.Text = textBox1.Text + "9";
                    daLiImaPocetneNule = false;
                }
                else
                {
                    textBox1.Text = "9";
                    daLiImaPocetneNule = false;
                }
            }
            else
            {
                textBox1.Text = "9";
                brisiBroj = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!brisiBroj)
            {
                if (!daLiImaPocetneNule)
                {
                    textBox1.Text = textBox1.Text + "0";
                    daLiImaPocetneNule = false;
                }
            }
            else
            {
                textBox1.Text = "0";
                daLiImaPocetneNule = false;
            }
        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            if (!daLiImaTacke)
            {
                textBox1.Text = textBox1.Text + ".";
                daLiImaTacke = true;
                daLiImaPocetneNule = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            daLiImaTacke = false;
            daLiImaPocetneNule = true;
            daLiImaX = false;
            brisiBroj = false;
            prosliBroj = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (!daLiImaX)
            {
                x = Convert.ToDouble(textBox1.Text);
                daLiImaX = true;
                brisiBroj = true;
                prosliZnak = '*';
            }
            else
            {
                prosliBroj = Convert.ToDouble(textBox1.Text);
                if (prosliZnak == '+')
                    x += Convert.ToDouble(textBox1.Text);
                if (prosliZnak == '-')
                    x -= Convert.ToDouble(textBox1.Text);
                if (prosliZnak == '*')
                    x *= Convert.ToDouble(textBox1.Text);
                if (prosliZnak == '/')
                {
                    if (Convert.ToDouble(textBox1.Text) == 0)
                    {
                        MessageBox.Show("Math.devide je crko", "Error");
                        textBox1.Text = "0";
                        daLiImaTacke = false;
                        daLiImaPocetneNule = true;
                        daLiImaX = false;
                        brisiBroj = false;
                        prosliBroj = 0;
                    }
                    else
                        x /= Convert.ToDouble(textBox1.Text);
                }
                daLiImaTacke = false;
                brisiBroj = true;
                textBox1.Text = Convert.ToString(x);
                prosliZnak = '*';
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (!daLiImaX)
            {
                x = Convert.ToDouble(textBox1.Text);
                daLiImaX = true;
                brisiBroj = true;
                prosliZnak = '+';
            }
            else
            {
                prosliBroj = Convert.ToDouble(textBox1.Text);
                if(prosliZnak == '+')
                    x += Convert.ToDouble(textBox1.Text);
                if(prosliZnak == '-')
                    x -= Convert.ToDouble(textBox1.Text);
                if (prosliZnak == '*')
                    x *= Convert.ToDouble(textBox1.Text);
                if (prosliZnak == '/')
                {
                    if (Convert.ToDouble(textBox1.Text) == 0)
                    {
                        MessageBox.Show("Math.devide je crko", "Error");
                        textBox1.Text = "0";
                        daLiImaTacke = false;
                        daLiImaPocetneNule = true;
                        daLiImaX = false;
                        brisiBroj = false;
                        prosliBroj = 0;
                    }
                    else
                        x /= Convert.ToDouble(textBox1.Text);
                }
                daLiImaTacke = false;
                brisiBroj = true;
                textBox1.Text = Convert.ToString(x);
                prosliZnak = '+';
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (daLiImaPocetneNule)
            {
                textBox1.Text = "-";
                daLiImaPocetneNule = false;
            }
            else
            {
                if (!daLiImaX)
                {
                    x = Convert.ToDouble(textBox1.Text);
                    daLiImaX = true;
                    brisiBroj = true;
                    prosliZnak = '-';
                }
                else
                {
                    prosliBroj = Convert.ToDouble(textBox1.Text);
                    if (prosliZnak == '+')
                        x += Convert.ToDouble(textBox1.Text);
                    if (prosliZnak == '-')
                        x -= Convert.ToDouble(textBox1.Text);
                    if (prosliZnak == '*')
                        x *= Convert.ToDouble(textBox1.Text);
                    if (prosliZnak == '/')
                    {
                        if (Convert.ToDouble(textBox1.Text) == 0)
                        {
                            MessageBox.Show("Math.devide je crko", "Error");
                            textBox1.Text = "0";
                            daLiImaTacke = false;
                            daLiImaPocetneNule = true;
                            daLiImaX = false;
                            brisiBroj = false;
                            prosliBroj = 0;
                        }
                        else
                            x /= Convert.ToDouble(textBox1.Text);
                    }
                    daLiImaTacke = false;
                    brisiBroj = true;
                    textBox1.Text = Convert.ToString(x);
                    prosliZnak = '-';
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (!daLiImaX)
            {
                x = Convert.ToDouble(textBox1.Text);
                daLiImaX = true;
                brisiBroj = true;
                prosliZnak = '/';
            }
            else
            {
                prosliBroj = Convert.ToDouble(textBox1.Text);
                if (prosliZnak == '+')
                    x += Convert.ToDouble(textBox1.Text);
                if (prosliZnak == '-')
                    x -= Convert.ToDouble(textBox1.Text);
                if (prosliZnak == '*')
                    x *= Convert.ToDouble(textBox1.Text);
                if (prosliZnak == '/')
                {
                    if (Convert.ToDouble(textBox1.Text) == 0)
                    {
                        MessageBox.Show("Math.devide je crko", "Error");
                        textBox1.Text = "0";
                        daLiImaTacke = false;
                        daLiImaPocetneNule = true;
                        daLiImaX = false;
                        brisiBroj = false;
                        prosliBroj = 0;
                    }
                    else
                        x /= Convert.ToDouble(textBox1.Text);
                }
                brisiBroj = true;
                textBox1.Text = Convert.ToString(x);
                prosliZnak = '/';
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (daLiImaX)
            {
                if (brisiBroj)
                {
                    double temp = Convert.ToDouble(textBox1.Text);
                    if (prosliZnak == '+')
                        if (temp == 0)
                            temp = prosliBroj;
                        else
                            temp += prosliBroj;
                    if (prosliZnak == '-')
                        if (temp == 0)
                            temp = prosliBroj;
                        else
                            temp -= prosliBroj;
                    if (prosliZnak == '*')
                        if (temp == 0)
                            temp = prosliBroj;
                        else
                            temp *= prosliBroj;
                    if (prosliZnak == '/')
                    {
                        if (prosliBroj == 0)
                        {
                            MessageBox.Show("Math.devide je crko", "Error");
                        }
                        else
                            x /= Convert.ToDouble(textBox1.Text);
                    }
                    textBox1.Text = Convert.ToString(temp);
                    brisiBroj = true;
                    daLiImaTacke = false;
                    daLiImaX = false;
                    prosliBroj = 0;
                }
                else
                {
                    if (prosliZnak == '+')
                        x += Convert.ToDouble(textBox1.Text);
                    if (prosliZnak == '-')
                        x -= Convert.ToDouble(textBox1.Text);
                    if (prosliZnak == '*')
                        x *= Convert.ToDouble(textBox1.Text);
                    if (prosliZnak == '/')
                    {
                        if (Convert.ToDouble(textBox1.Text) == 0)
                        {
                            MessageBox.Show("Math.devide je crko", "Error");
                        }
                        else
                            x /= Convert.ToDouble(textBox1.Text);
                    }
                    textBox1.Text = Convert.ToString(x);
                    brisiBroj = true;
                    daLiImaTacke = false;
                    daLiImaX = false;
                    prosliBroj = 0;
                    
                }
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (!daLiImaX)
            {
                textBox1.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(textBox1.Text)));
                brisiBroj = true;
            }
            else
            {
                MessageBox.Show("Koren moze dizvadi samo od jednog broja, ne od izraza", "Error");
                textBox1.Text = "0";
                daLiImaTacke = false;
                daLiImaPocetneNule = true;
                daLiImaX = false;
                brisiBroj = false;
                prosliBroj = 0;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (!daLiImaX)
            {
                textBox1.Text = Convert.ToString(Math.Abs(Convert.ToDouble(textBox1.Text)));
                brisiBroj = true;
            }
            else
            {
                MessageBox.Show("Moze apsolutno samo od jednog broja, ne od izraza", "Error");
                textBox1.Text = "0";
                daLiImaTacke = false;
                daLiImaPocetneNule = true;
                daLiImaX = false;
                brisiBroj = false;
                prosliBroj = 0;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (!daLiImaX)
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text)*Convert.ToDouble(textBox1.Text));
                brisiBroj = true;
            }
            else
            {
                MessageBox.Show("Moze kvadrat samo od jednog broja, ne od izraza", "Error");
                textBox1.Text = "0";
                daLiImaTacke = false;
                daLiImaPocetneNule = true;
                daLiImaX = false;
                brisiBroj = false;
                prosliBroj = 0;
            } 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!daLiImaX)
            {
                textBox1.Text = Convert.ToString(Math.Log10(Convert.ToDouble(textBox1.Text)));
                brisiBroj = true;
            }
            else
            {
                MessageBox.Show("Moze Log10 samo od jednog broja, ne od izraza", "Error");
                textBox1.Text = "0";
                daLiImaTacke = false;
                daLiImaPocetneNule = true;
                daLiImaX = false;
                brisiBroj = false;
                prosliBroj = 0;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (!daLiImaX)
            {
                textBox1.Text = Convert.ToString(Math.Sin(Convert.ToDouble(textBox1.Text)));
                brisiBroj = true;
            }
            else
            {
                MessageBox.Show("Moze Sin samo od jednog broja, ne od izraza", "Error");
                textBox1.Text = "0";
                daLiImaTacke = false;
                daLiImaPocetneNule = true;
                daLiImaX = false;
                brisiBroj = false;
                prosliBroj = 0;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (!daLiImaX)
            {
                textBox1.Text = Convert.ToString(Math.Cos(Convert.ToDouble(textBox1.Text)));
                brisiBroj = true;
            }
            else
            {
                MessageBox.Show("Moze Sin samo od jednog broja, ne od izraza", "Error");
                textBox1.Text = "0";
                daLiImaTacke = false;
                daLiImaPocetneNule = true;
                daLiImaX = false;
                brisiBroj = false;
                prosliBroj = 0;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (!daLiImaX)
            {
                textBox1.Text = Convert.ToString(Math.Tan(Convert.ToDouble(textBox1.Text)));
                brisiBroj = true;
            }
            else
            {
                MessageBox.Show("Moze Sin samo od jednog broja, ne od izraza", "Error");
                textBox1.Text = "0";
                daLiImaTacke = false;
                daLiImaPocetneNule = true;
                daLiImaX = false;
                brisiBroj = false;
                prosliBroj = 0;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (!daLiImaX)
            {
                textBox1.Text = Convert.ToString(1/Math.Tan(Convert.ToDouble(textBox1.Text)));
                brisiBroj = true;
            }
            else
            {
                MessageBox.Show("Moze Sin samo od jednog broja, ne od izraza", "Error");
                textBox1.Text = "0";
                daLiImaTacke = false;
                daLiImaPocetneNule = true;
                daLiImaX = false;
                brisiBroj = false;
                prosliBroj = 0;
            }
        }
    }
}
