using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2_michealWalls
{
    public partial class Form_About : Form
    {
        public Form_About()
        {
            InitializeComponent();
        }

        private void buttons_exitAbout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox_aboutParagraph_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
