using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrionWinForms
{
    public partial class SplashScreen : Form
    {
       
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            if(progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                lblProgressBarPercent.Text = progressBar1.Value.ToString() + "%";
                
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Welcome Orion System!","Welcome",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Hide();
                frmPrincipal frm = new frmPrincipal();
                frm.Show();
                
            }
        }
    }      
}
