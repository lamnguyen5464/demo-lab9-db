using SPV102_CS486_Team13.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace SPV102_CS486_Team13.Screen
{
    public partial class MainScreen : UserControl
    {

        string[] cat = { "Contestants", "Examiners", "Rounds" };
        public MainScreen()
        {
            InitializeComponent();
            InitCategory();
        }

        private void InitCategory()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NavigationHelper.getInstance().push(new AboutScreen());
        }
    }
}
