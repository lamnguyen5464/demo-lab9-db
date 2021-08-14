using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPV102_CS486_Team13.Components
{
    public partial class ContestantItem : UserControl
    {
        string nameString, bdString, universityString, moreinfoString;
        public ContestantItem(string name, string bd, string university, string moreInfo)
        {
            InitializeComponent();
            this.nameString = name;

            buttonName.Text = name;
            buttonBD.Text = bd;
            buttonUni.Text = university;
            buttonInfo.Text = moreInfo;
        }
    }
}
