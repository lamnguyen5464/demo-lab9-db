using FontAwesome.Sharp;
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
using TestApp.Repos;

namespace TestApp
{
    public partial class CountryItem : UserControl
    {
        private string name, id;
        private bool open;
        public int num;
        mainLayoutAdapter adapter;
        public List<Button> buttonsExtend;
        public CountryItem()
        {
            InitializeComponent();
            
        }
        public CountryItem(string name, string id)
        {
            this.name = name;
            this.id = id;
            InitializeComponent();
            adapter = mainLayoutAdapter.getInstance();
            buttonCountry.Text = name;
            buttonCountry.Name = id;
            panelCountry.Visible = false;
            this.Height = buttonCountry.Height;
            open = false;
            num = 0;
            buttonsExtend = new List<Button>();
        }

        public void AddCategories(string name, string id)
        {
            IconButton btn_add = new IconButton();
            btn_add.Text = name;
            btn_add.Name = id;
            btn_add.Dock = System.Windows.Forms.DockStyle.Top;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btn_add.IconChar = FontAwesome.Sharp.IconChar.Music;
            btn_add.IconColor = System.Drawing.Color.LightCoral;
            btn_add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_add.IconSize = 30;
            btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_add.Location = new System.Drawing.Point(0, 0);
            btn_add.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            btn_add.Size = new System.Drawing.Size(265, 45);
            btn_add.TabIndex = 0;
            btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += new EventHandler(this.button_Click);
            panelCountry.Controls.Add(btn_add);
        }

        internal void AddMoreButton()
        {
            Button btn_add = new Button();
            btn_add.Text = "Xem Them";
            btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(170)))));
            btn_add.Dock = System.Windows.Forms.DockStyle.Top;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_add.ForeColor = System.Drawing.Color.White;
            btn_add.Location = new System.Drawing.Point(0, 135);
            btn_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btn_add.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            btn_add.Size = new System.Drawing.Size(194, 45);
            btn_add.TabIndex = 3;
            btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += new EventHandler(this.button_Click_More);
            panelCountry.Controls.Add(btn_add);
        }

        internal void AddCategoriesToExtend(string name, string id)
        {
            Button btn_add = new Button();
            btn_add.Text = name;
            btn_add.Name = id;
            btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(170)))));
            btn_add.Dock = System.Windows.Forms.DockStyle.Top;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_add.ForeColor = System.Drawing.Color.White;
            btn_add.Location = new System.Drawing.Point(0, 135);
            btn_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btn_add.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            btn_add.Size = new System.Drawing.Size(194, 45);
            btn_add.TabIndex = 3;
            btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += new EventHandler(this.button_Click_inExtend);
            buttonsExtend.Add(btn_add);
        }

        private void button_Click(object sender, EventArgs e)
        {
            IconButton btn = sender as IconButton;
            string id = btn.Name;
            List<Song> songs = AppRepository.getIntance().getSongsByCatId(id);
            foreach (Control item in adapter.mainLayout.Controls.OfType<Control>().ToList())
            {
                if(item.Name != "panelTop")
                    adapter.mainLayout.Controls.Remove(item);
            }


            for (int i = songs.Count - 1; i >= 0; i--)
            {
                SongItem addItem = new SongItem(
                    songs[i].id, songs[i].name, songs[i].singer, songs[i].composer,
                    songs[i].official, songs[i].quality, songs[i].view.ToString()
                    );

                addItem.Dock = DockStyle.Top;                
                adapter.mainLayout.Controls.Add(addItem);
            }
            adapter.NameCat.Text = btn.Text;
        }

        private void button_Click_More(object sender, EventArgs e)
        {
            adapter.extendPanel.Visible = true;
            foreach (Control item in adapter.PanelCatExtend.Controls.OfType<Control>().ToList())
            {
                adapter.PanelCatExtend.Controls.Remove(item);
            }
            foreach (Button btn_add in buttonsExtend)
            {
                adapter.PanelCatExtend.Controls.Add(btn_add);
            }
        }

        private void button_Click_inExtend(object sender, EventArgs e)
        {
            adapter.extendPanel.Visible = false;
            Button btn = sender as Button;
            string id = btn.Name;
            List<Song> songs = AppRepository.getIntance().getSongsByCatId(id);
            foreach (Control item in adapter.mainLayout.Controls.OfType<Control>().ToList())
            {
                if (item.Name != "panelTop")
                    adapter.mainLayout.Controls.Remove(item);
            }


            for (int i = songs.Count - 1; i >= 0; i--)
            {
                SongItem addItem = new SongItem(
                    songs[i].id, songs[i].name, songs[i].singer, songs[i].composer,
                    songs[i].official, songs[i].quality, songs[i].view.ToString()
                    );

                addItem.Dock = DockStyle.Top;
                adapter.mainLayout.Controls.Add(addItem);
            }

            adapter.NameCat.Text = btn.Text;
        }


        public void setHeight(int height)
        {
            panelCountry.Size = new Size(
                panelCountry.Width, height
                );
        }

        private void buttonCountry_Click_1(object sender, EventArgs e)
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
