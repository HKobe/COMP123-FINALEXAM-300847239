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
    public partial class GenerateNameForm : Form
    {
        public GenerateNameForm()
        {
            InitializeComponent();
        }

        private void GenerateNameForm_Load(object sender, EventArgs e)
        {

        }
        //Generate Names Method, Returns Void
        private void GenerateNames(object sender, EventArgs e)
        {
            Random random = new Random();
            FirstNameListBox.SelectedIndex = Convert.ToInt32(random);
            
            LastNameListBox.SelectedIndex = Convert.ToInt32(random);


        }
    }

}
