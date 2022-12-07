using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElGamal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sipher = SMsg.Text.Split(' ');
            foreach (var ch in sipher)
            {
                bool smena = true;
                string a = null, b = null;
                for (int i=0;i<ch.Length;i++)
                {
                    if (ch[i] == ',')
                    {
                        smena = false;
                    }
                    else if (smena == false)
                    {
                        b += ch[i];
                    }
                    else a+=ch[i];
                }

                int A = Convert.ToInt32(a);
                int B = Convert.ToInt32(b);
                int P = Convert.ToInt32(PtextBox.Text);
                int X = Convert.ToInt32(XtextBox.Text);

                int test = (int)BigInteger.ModPow(B * BigInteger.Pow(A, P - 1 - X), 1, P);

                Msg.Text += (char)BigInteger.ModPow(B * BigInteger.Pow(A, P - 1 - X), 1, P);
            }
        }
    }
}
