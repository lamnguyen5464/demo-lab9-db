using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp.Helpers;

namespace TestApp
{
    public partial class LoginScreen : UserControl
    {
        public LoginScreen()
        {


            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Navigation.getInstance().push(new HomeScreen());
        }
    }
}
