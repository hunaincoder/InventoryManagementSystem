using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 4; 
            progBar.Value = startpoint;

            if (progBar.Value >= progBar.Maximum)
            {
                progBar.Value = progBar.Maximum; 
                timer1.Stop();

                Form1 login = new Form1();
                this.Hide();
                login.Show();
            }
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void progBar_Click(object sender, EventArgs e)
        {

        }
    }
}
