using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp.Models;

namespace TestApp
{
    public partial class CountryItem : UserControl
    {
        private string name, id;
        private bool open;
        public int num;
        public CountryItem()
        {
            InitializeComponent();
        }
        public CountryItem(string name, string id)
        {
            this.name = name;
            this.id = id;
            InitializeComponent();
            buttonCountry.Text = name;
            buttonCountry.Name = id;
            panelCountry.Visible = false;
            this.Height = buttonCountry.Height;
            open = false;
            num = 0;
        }

        public Button GetButton()
        {
            return buttonCountry;
        }

        public void AddCategories(string name, string id)
        {
            Button btn_add = new Button();
            btn_add.Text = name;
            btn_add.Name = id;
            btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            btn_add.Dock = System.Windows.Forms.DockStyle.Top;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_add.ForeColor = System.Drawing.Color.LightGray;
            btn_add.Location = new System.Drawing.Point(0, 135);
            btn_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btn_add.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            btn_add.Size = new System.Drawing.Size(194, 45);
            btn_add.TabIndex = 3;
            btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += new EventHandler(this.button_Click);
            panelCountry.Controls.Add(btn_add);
            
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            //List<Song> songs = AppRepository.getIntance().getSong;
            //SongItem.
        }


        public void setHeight(int height)
        {
            panelCountry.Size = new Size(
                panelCountry.Width, height
                );
        }

        private void buttonCountry_Click(object sender, EventArgs e)
        {
            if (open == false)
            {
                this.Height += num * 45;
                open = true;
                panelCountry.Visible = true;
                setHeight(num * 45);
            }
            else
            {
                this.Height -= num * 45;
                open = false;
                panelCountry.Visible = false;
                setHeight(0);
            }
            
        }

    }
}
