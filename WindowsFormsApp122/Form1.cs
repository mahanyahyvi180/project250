using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp122
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Next r = new Next();
            TextBoxcolor(r);
            this.Controls.Add(r);
        }

        private void TextBoxcolor(TextBox t)
        {
            t.BackColor = Color.DarkBlue;
        }

        private void next1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void fButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
