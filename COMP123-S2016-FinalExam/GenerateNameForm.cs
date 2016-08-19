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
 * Program Description: Generates Name to the Form
 */
namespace COMP123_S2016_FinalExam
{
    public partial class GenerateNameForm : Form
    {
        public GenerateNameForm()
        {
            InitializeComponent();
        }
        //Generate Names Method, Returns Void
        private void GenerateNames(object sender, EventArgs e)
        {
           // Random random = new Random();
            FirstNameListBox.SelectedIndex = 0;

            LastNameListBox.SelectedIndex = 0;


        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //Instantiating a	new	abilityGeneratorForm object	of	the	AbilityGeneratorForm class
            AbilityGeneratorForm ABF = new AbilityGeneratorForm();
            //Hiding This Form
            this.Hide();
            //Displaying AbilityGenerator Form
            ABF.Show();
        }
    }

}
