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
using SPV102_CS486_Team13.Repos;
using SPV102_CS486_Team13.Models;
using SPV102_CS486_Team13.Components;

namespace SPV102_CS486_Team13.Screen
{
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();
            InitCategory();
           
        }

        private void InitCategory()
        {
            panelRound.Visible = false;
            List<Round> rounds = AppRepo.getInstnace().getAllRounds();
            for(int i = rounds.Count - 1; i >=0; i--)
            {

                IconButton btn_add = new IconButton();
                btn_add.Text = rounds[i].id;
                btn_add.Dock = System.Windows.Forms.DockStyle.Top;
                btn_add.FlatAppearance.BorderSize = 0;
                btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn_add.IconChar = FontAwesome.Sharp.IconChar.React;
                btn_add.IconColor = System.Drawing.Color.Black;
                btn_add.IconFont = FontAwesome.Sharp.IconFont.Auto;
                btn_add.IconSize = 20;
                btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btn_add.Location = new System.Drawing.Point(0, 228);
                btn_add.Size = new System.Drawing.Size(179, 40);
                btn_add.TabIndex = 7;
                
                btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                btn_add.UseVisualStyleBackColor = true;
                panelRound.Controls.Add(btn_add);
            }
            panelRound.Size = new Size(panelRound.Width, 40 * rounds.Count);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NavigationHelper.getInstance().push(new AboutScreen());
        }


        private void buttonRounds_Click_1(object sender, EventArgs e)
        {
            panelRound.Visible = !panelRound.Visible;
        }

        private void buttonContestant_Click(object sender, EventArgs e)
        {
            List<Contestant> contestants = AppRepo.getInstnace().getAllContestant();
            for (int i = contestants.Count -1; i>=0; i--)
            {
                ContestantItem add = new ContestantItem(
                    contestants[i].name, "","",""
                    );
                panelMain.Controls.Add(add);
            }
        }
    }
}
