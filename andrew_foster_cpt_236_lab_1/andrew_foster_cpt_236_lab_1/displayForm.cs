using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace andrew_foster_cpt_236_lab_1
{
    public partial class displayForm : Form
    {
        public displayForm()
        {
            InitializeComponent();
            displayBox.Text = displayResults;
        }

        public string displayResults = "";

        public string DisplayResults
        {
            set
            {
                displayResults = Form1.resultsBuilder;
            }
            get
            {
                return displayResults;
            }
        }

        private void closeButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
