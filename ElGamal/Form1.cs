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
    public partial class Form1 : Form
    {
        int p, g, y, x, k, a, b;

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newfrm = new Form2();
            newfrm.Show();
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            LabelEr.Text = null;
            byte[] ZnchChar = new byte[Msg.Text.Length];
            int.TryParse(PtextBox.Text,out p);
            if (!Algorithms.ProverkaNaProstoe(p))
            {
                LabelEr.Text = "Число P непростое";
                return;
            }


            int.TryParse(GtextBox.Text, out g);
            int.TryParse(XtextBox.Text, out x);
            y = Algorithms.BigPow(g,x,p);
            YtextBox.Text = Convert.ToString(y);
            int.TryParse(KtextBox.Text, out k);

            /*if (!Algorithms.StandartAlgoritmEvklida(x,p-1))
            {
                LabelEr.Text = "Число X невзаимнопростое числу P-1";
                return;
            }*/

            a = (int)BigInteger.ModPow(g,k,p);

            BigInteger YVStepK = BigInteger.ModPow(y,k,p);

            for (int i = 0; i<Msg.Text.Length;i++)
            {
                ZnchChar[i] = Convert.ToByte(Msg.Text[i]);
                b = (int)BigInteger.ModPow(YVStepK * ZnchChar[i], 1,p);
                textBox2.Text += a + "," + b + " ";
            }
        }
    }
}
