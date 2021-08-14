using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPV102_CS486_Team13.Navigation
{
    class NavigationHelper
    {
        public Form form;
        private static NavigationHelper instance = null;
        private NavigationHelper()
        {

        }
        public static NavigationHelper getInstance()
        {
            if (instance == null)
            {
                instance = new NavigationHelper();
            }
            return instance;
        }
        public void Init(Form form)
        {
            form.Size = new Size(885, 502);
            this.form = form;
        }


        Stack<UserControl> screenStack = new Stack<UserControl>();

        public void push(UserControl screen)
        {
            if (screen == null)
            {
                return;
            }
            screenStack.Push(screen);
            form.Controls.Clear();
            form.Controls.Add(screen);
        }
        public void pop()
        {
            if (screenStack.Count == 0)
            {
                MessageBox.Show("Can not back");
                return;
            }
            screenStack.Pop();
            form.Controls.Clear();
            form.Controls.Add(screenStack.Peek());
        }
    }
}
