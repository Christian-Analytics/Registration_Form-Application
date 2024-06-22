using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Castillo_4
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        // Handles the close button event handler
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the about form and returns to registration form
        }
    }
}
