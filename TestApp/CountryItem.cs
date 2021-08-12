using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class CountryItem : UserControl
    {
        private string name, id;
        public CountryItem()
        {
            InitializeComponent();
        }
        public CountryItem(string name)
        {
            this.name = name;
            InitializeComponent();
            buttonCountry.Text = name;
        }

    }
}
