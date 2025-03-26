using System;
using System.Windows.Forms;

namespace Modile2BaiSo11_NguyenNgocTuTrinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTimesNewRoman.Checked)
            {
                textBoxInput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular);
            }
            else if (radioButtonArial.Checked)
            {
                textBoxInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            }
            else if (radioButtonTahoma.Checked)
            {
                textBoxInput.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            }
            else if (radioButtonCourierNew.Checked)
            {
                textBoxInput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular);
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
