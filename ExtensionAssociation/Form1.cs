using System;
using System.IO;
using System.Windows.Forms;

namespace ExtensionAssociation
{
    public partial class Form1 : Form
    {

        public Form1() 
        {
            InitializeComponent();
        }

        public Form1(string args)
        {
            InitializeComponent();
            var reader = new StreamReader(args);
            var text = reader.ReadToEnd();
            reader.Close();
            mytext.Text = text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
