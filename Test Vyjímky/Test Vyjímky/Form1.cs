using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Vyjímky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int[] cisla = new int[textBox1.Lines.Count()];
                double soucet = 0, pocitadlo = 0; ;
                double prumer = 0;
                for (int i = 0; i < textBox1.Lines.Count(); i++)
                {
                    cisla[i] = Convert.ToInt32(textBox1.Lines[i]);
                }
                
                try
                {
                    foreach (int cislo in cisla)
                    {
                        if (cislo < 0)
                        {
                            soucet += cislo;
                            pocitadlo++;
                        }
                    }
                    if (pocitadlo == 0)
                    {
                        MessageBox.Show("Nebyly zadány žádné záporné hodnoty!\n");
                    }
                    else
                    {
                        prumer = soucet / pocitadlo;
                        MessageBox.Show("Aritmetický průměr záporných čísel je: " + prumer);
                    }
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("Nebyly zadány žádné hodnoty!\n" + ex.Message);
                }
                catch (OverflowException ex)
                {
                    MessageBox.Show("Došlo k přetečení při počítání průměru!\n" + ex.Message);
                }
                catch (DivideByZeroException ex)
                {
                    MessageBox.Show("V počítání průměru se dělí nulou!\n" + ex.Message);
                }
                catch (ArithmeticException ex)
                {
                    MessageBox.Show("Chybná aritmetická operace!\n" + ex.Message);
                }

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Nebyly zadány žádné hodnoty!\n" + ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Došlo k přetečení v komponentě textbox!\n" + ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Byl zadán chybný formát v komponentě textbox!\n" + ex.Message);
            }  
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tento program spočítá aritmetický průměr, pouze ze záporných hodnot zadaných uživatelem do textboxu.", "info" , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Gold;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.LawnGreen;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.MidnightBlue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.RoyalBlue;
        }
    }
}
