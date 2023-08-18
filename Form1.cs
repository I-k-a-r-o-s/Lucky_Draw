using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucky_Draw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Random rand = new Random();           
            if(txtinput.Text.Length == 0 ) 
            {
                MessageBox.Show("Input lucky number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                rchtxtoutput.Clear();
                for (int i = 0; i < 5; i++)
                {
                    int nmbr = rand.Next(0, 20);
                    rchtxtoutput.Text += nmbr.ToString() + Environment.NewLine;
                    if (int.Parse(txtinput.Text) == nmbr)
                    {
                        MessageBox.Show("Congratulations!You have won", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    }                  
                }
            }         
        }
    }
}
