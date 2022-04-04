using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms4april
{
    public partial class FormPraktikum : Form
    {
        public FormPraktikum()
        {
            InitializeComponent();
            char[] huruf = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        }

        private void FormPraktikum_Load(object sender, EventArgs e)
        {

        }

        private void buttonNoConvert_Click(object sender, EventArgs e)
        {
            labelOutput.Text = textBoxInput.Text;
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {

        }
    }
}
