using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoginDemo
{
    public partial class Form1 : Form
    {
        string username;

        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //variables and inputs
            username = usernameInput.Text;

            //outputs
            outputLabel.Text = $"Welcome back {username}";
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = $"Welcome back ADMIN {username}";
        }

    }
}
