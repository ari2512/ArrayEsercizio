using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ArrayEsercizio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] nome = new string[] { "ROSSI MARIO\r\nBIANCHI LUIGI\r\nBELLI GIULIA\r\nDOTTI FABIO\r\nMERLI GIANNA\r\nZERI GIULIO\r\nBOTTI MARIA" };
        int [] conto = new int[] {11264,99780,00342,03419,34562,09887,02341 };
       int [] saldo = new int[] { 11534,-2345,3451,127,45673,-13,3452 };

        private void button4_Click (object sender, EventArgs e)
        {
            string val=Convert.ToString(textBox2.Text);
            for(int i = 0;i<7;i++)
            {
                if(val==nome[i])
                {
                    label3.Text=Convert.ToString(conto[i]);
                    label1.Text = Convert.ToString(saldo[i]);

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox3.Text);
            for(int i=0;i<7;i++)
            {
                if (n == conto[i])
                {
                    label6.Text = nome[i];
                    label7.Text = Convert.ToString(saldo[i]);
                }
            }
        }
    }
    
}
       
    

