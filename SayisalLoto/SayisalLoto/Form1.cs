using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayisalLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOyna_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            lbl1.Text = random.Next(0,47).ToString();
            lbl2.Text = random.Next(0, 47).ToString();
            lbl3.Text = random.Next(0, 47).ToString();
            lbl4.Text = random.Next(0, 47).ToString();
            lbl5.Text = random.Next(0, 47).ToString();
            lbl6.Text = random.Next(0, 47).ToString();
        }
    }
}
