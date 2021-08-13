using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp.Models
{
    class mainLayoutAdapter
    {
        public FlowLayoutPanel mainLayout;
        public Panel extendPanel;
        public Panel PanelCatExtend;
        public Label NameCat;
        private mainLayoutAdapter(FlowLayoutPanel panel, Panel panel1, Panel panelCatExtend,Label nameCat)
        {
            mainLayout = panel;
            extendPanel = panel1;
            PanelCatExtend = panelCatExtend;
            NameCat = nameCat;
        }
        static private mainLayoutAdapter instance = null;
        static public mainLayoutAdapter getInstance()
        {
            return instance;
        }
        static public void setInstance(FlowLayoutPanel panel, Panel panel1, Panel panelCatExtend, Label nameCat)
        {
            instance = new mainLayoutAdapter(panel, panel1, panelCatExtend, nameCat);
        }

    }
}
