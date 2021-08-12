using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp.Repos;
using TestApp.Models;

namespace TestApp
{
    public partial class Form1 : Form
    {
        List<Country> countries;
        public Form1()
        {
            InitializeComponent();
            InitCountry();
            SetCountry();
        }

        private void SetCountry()
        {
            if(countries != null)
            {
                for (int i = countries.Count - 1; i >= 0; i--)
                {
                    CountryItem addItem = new CountryItem(
                        countries[i].getName(),
                        countries[i].getId()
                        );
                    addItem.GetButton().Click += new EventHandler(this.country_click);
                    addItem.Dock = DockStyle.Top;
                    panelCat.Controls.Add(addItem);

                }
            }

        }

        private void InitCountry()
        {
            countries = AppRepository.getIntance().getListCountries();
        }
        private void country_click(object sender, System.EventArgs e)
        {
            Button btn = sender as Button;
            string countryId = btn.Name;
            MessageBox.Show(countryId);
            //List<Category> cat = AppRepository.getIntance().getCatOnId();
        }
    }
}
