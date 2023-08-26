using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Azure;
           this.Controls.Add(labelName);
            labelName.Show();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("i love u so muchhhh ,my beloved sama <3");
            Close();
        }

        private void button1_Move(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
  

        }
       Label labelName = new Label();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
