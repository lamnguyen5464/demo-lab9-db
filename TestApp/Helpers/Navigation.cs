using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp.Helpers
{
    class Navigation
    {
        public Form form;
        private static Navigation instance = null;
        private Navigation()
        {

        }
        public static Navigation getInstance()
        {
            if(instance == null)
            {
                instance = new Navigation();
            }
            return instance;
        }
        public void Init(Form form)
        {
            form.Size = new Size( 1000, 500);
            form.Font = new Font("Arial", 10);
            this.form = form;
        }


        Stack<UserControl> screenStack = new Stack<UserControl>();

        public void push(UserControl screen)
        {
            if(screen == null)
            {
                return;
            }
            screenStack.Push(screen);
            form.Controls.Clear();
            form.Controls.Add(screen);
        }
        public void pop()
        {
            if(screenStack.Count == 0)
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
