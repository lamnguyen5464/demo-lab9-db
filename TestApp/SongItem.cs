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
    public partial class SongItem : UserControl
    {
        string idString, nameString, singerString, composerString, qualityString, viewString;

        private void singer_Click(object sender, EventArgs e)
        {

        }

        int officalInt;
        public SongItem(string id, string name, string singer, string composer,
                    int official, string quality, string view)
        {
            InitializeComponent();
            this.idString = id;
            this.nameString = name;
            this.singerString = singer;
            this.composerString = composer;
            this.officalInt = official;
            this.qualityString = quality;
            this.viewString = view;

            songName.Text = name;
            composerName.Text = composer;
            this.singer.Text = singer;
            //this.sq.Text = quality;
            this.view.Text = view;

        }
    }
}
