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
                    
                    addItem.Dock = DockStyle.Top;
                    List<Category> categories = AppRepository.getIntance().getCatOnId(countries[i].getId());
                    if(categories != null)
                    {
                        addItem.num = categories.Count;
                        for (int j = categories.Count - 1; j >= 0; j--)
                        {
                            addItem.AddCategories(categories[j].getName());
                        }
                    }
                    panelCat.Controls.Add(addItem);
                }
            }

        }

        private void InitCountry()
        {
            countries = AppRepository.getIntance().getListCountries();

            //List<Category> list = AppRepository.getIntance().getCatOnId("1");
            //MessageBox.Show(list[0].getName());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void country_click(object sender, System.EventArgs e)
        {
            Button btn = sender as Button;
            string countryId = btn.Name;

        }
    }
}
