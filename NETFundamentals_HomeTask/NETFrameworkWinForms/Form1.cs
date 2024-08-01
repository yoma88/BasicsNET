using NETLibrary;
using System;
using System.Windows.Forms;

namespace NETFrameworkWinForms
{
    public partial class Form1 : Form
    {
        private string _username;
        public Form1(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = HelloWorldLibrary.Concatenation(_username);
        }
        
    }
}
