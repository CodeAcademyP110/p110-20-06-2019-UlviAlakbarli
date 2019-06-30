using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_F_Disconnected
{
    public partial class NewPosition : Form
    {
        Login login;
        public NewPosition()
        {
            InitializeComponent();
        }
        public NewPosition(Login Ilogin)
        {
            InitializeComponent();
            login = Ilogin;
        }

        private void NewPosition_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Show();
        }
    }
}
