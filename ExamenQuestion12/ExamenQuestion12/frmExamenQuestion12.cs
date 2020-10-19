using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenQuestion12
{
    public partial class frmExamenQuestion12 : Form
    {
        Thread Thread1;
        //System.Timers.Timer Timer1 = new System.Timers.Timer();
        public frmExamenQuestion12()
        {
            InitializeComponent();

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Thread1 = new Thread(new ThreadStart(ThreadLoop1));
            Thread1.Start();
        }
        public void ThreadLoop1()
        {
            Random R = new Random();
            int random;
            int compteur = 0;
            while (Thread1.IsAlive)
            {
                random = R.Next(1, 5);
                compteur++;
                this.Invoke((MethodInvoker)delegate ()
                {
                    if (random == 1)
                    {
                        pbImage.Load(@"..\..\..\images\1.jpeg");
                    }
                    else if (random == 2)
                    {
                        pbImage.Load(@"..\..\..\images\2.jpeg");
                    }
                    else if (random == 3)
                    {
                        pbImage.Load(@"..\..\..\images\3.jpeg");
                    }
                    else
                    {
                        pbImage.Load(@"..\..\..\images\4.jpeg");
                    }
                    txtRandom.Text = random.ToString() + "      (" + compteur.ToString() + ")";
                    Application.DoEvents();
                });
                Thread.Sleep(1000);
            }
        }

            
    }
}
