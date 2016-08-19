using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_FinalExam
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        public int TimeLeft { get; set; }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            TimeLeft = 10;
            SplashScreenTimer.Start();
        }
        public int counter;
        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            counter += 100;
            if (counter == 1000)
            {
                AbilityGeneratorForm AGF = new AbilityGeneratorForm();
                AGF.Show();
                this.Hide();
                SplashScreenTimer.Enabled = false;

                if (TimeLeft > 0)
                {
                    TimeLeft = TimeLeft - 1;

                }
                else
                {

                    SplashScreenTimer.Stop();
                    new AbilityGeneratorForm().Show();
                    this.Hide();
                }
            }
        }

        private void SplashProgressBar_Click(object sender, EventArgs e)
        {
            AbilityGeneratorForm AGFF = new AbilityGeneratorForm();
            AGFF.Show();
        }
    }
}
