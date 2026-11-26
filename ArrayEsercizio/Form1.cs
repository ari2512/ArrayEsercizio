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
        string[] conto = new string[] { "11264\r\n\r\n99780\r\n\r\n00342\r\n\r\n03419\r\n\r\n34562\r\n\r\n09887\r\n\r\n02341" };
        string[] saldo = new string[] { "11534\r\n\r\n-2345\r\n\r\n3451\r\n\r\n127\r\n\r\n45673\r\n\r\n-13\r\n\r\n3452" };

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
       
    

