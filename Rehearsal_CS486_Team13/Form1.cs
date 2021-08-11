using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rehearsal_CS486_Team13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView_Vietnam.Items.Add("Nhạc trẻ");
            listView_Vietnam.Items.Add("Trữ tình");
            listView_Vietnam.Items.Add("Remix Việt");
            listView_Vietnam.Items.Add("Rap Việt");
            listView_Vietnam.Items.Add("Tiền Chiến");
            listView_Vietnam.Items.Add("Nhạc Trịnh");
            listView_Vietnam.Items.Add("Thiếu Nhi");
            listView_Vietnam.Items.Add("Rock Việt");
            listView_Vietnam.Items.Add("Cách mạng");

            listView_Eu.Items.Add("Pop");
            listView_Eu.Items.Add("Rock");
            listView_Eu.Items.Add("Electroniaca/Dance");
            listView_Eu.Items.Add("Hip Hop/Rap");
            listView_Eu.Items.Add("Blues/Jazz");
            listView_Eu.Items.Add("Country");
            listView_Eu.Items.Add("Latin");

            listView_As.Items.Add("Nhạc Hàn");
            listView_As.Items.Add("Nhạc Hoa");
            listView_As.Items.Add("Nhạc Nhật");
            listView_As.Items.Add("Nhạc Thái");

            listView_khac.Items.Add("Beat");
            listView_khac.Items.Add("Không lời");
            listView_khac.Items.Add("Thể loại khác");
            listView_khac.Items.Add("Tui hát");

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 formAboutUs = new Form2();
            formAboutUs.ShowDialog();
        }
    }
}
