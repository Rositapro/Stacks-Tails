using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StacksTails
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            FormStack formStack = new FormStack();
            formStack.Show();
        }

        private void btnTail_Click(object sender, EventArgs e)
        {
            FormTail formTail = new FormTail();
            formTail.Show();
        }
    }
}
