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
    public partial class Form1 : Form
    {
        string[] country;
        public Form1()
        {
            InitializeComponent();
            InitCountry();
            SetCountry();
        }

        private void SetCountry()
        {
            for (int i = country.Length - 1; i >= 0 ; i--)
            {
                CountryItem addItem = new CountryItem(
                    country[i], "id"
                    );
                addItem.Dock = DockStyle.Top;
                panelCat.Controls.Add(addItem);
            }
        }

        private void InitCountry()
        {
            country = new string[] { "Viet Nam", "Au My", "Chau A", "Khac"};
        }
    }
}
