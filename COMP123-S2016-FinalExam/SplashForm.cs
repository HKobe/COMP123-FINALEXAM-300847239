using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 *Author: Hassan Kobeissi
 * Co-Author: Tom T
 * Date Created: 2016-08-19
 * Date Modified: 2016-08-19
 * Program Description: To create a splash screen form that loads before other forms
 */
namespace COMP123_S2016_FinalExam
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        //Public Instance Variables
        public int TimeLeft { get; set; }
        //SplashScreen On Load
        private void SplashForm_Load(object sender, EventArgs e)
        {
            TimeLeft = 7;
            SplashScreenTimer.Start();
        }
        //++Incrementation++
        public int counter;
        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            counter += 100;
            //If counter reaches 1000 , Hide this form and display show AbilityGeneratorForm
            if (counter == 1000)
            {
                //Creating a new instance of the AbilityGeneratorForm
                AbilityGeneratorForm AGF = new AbilityGeneratorForm();
                //Show the Form
                AGF.Show();
                //Hide this form
                this.Hide();
                SplashScreenTimer.Enabled = false;
                //-1 from 7 Until times out
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
