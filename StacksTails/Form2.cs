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
    public partial class FormTail : Form
    {
        private int[] tail;
        private int front;
        private int end;
        private int max;

        public FormTail()
        {
            InitializeComponent();
            max = 5; 
            tail = new int[max];
            front = -1;
            end = -1;
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            if ((end + 1) % max == front)
            {
                MessageBox.Show("Queue full. No more elements can be added.");
            }
            else
            {
                if (int.TryParse(txtNumber.Text, out int element))
                {
                    if (front == -1) front = 0;
                    end = (end + 1) % max;
                    tail[end] = element;
                    MessageBox.Show("Element" + element + "add.");
                    txtNumber.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter a valid number.");
                }
            }
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            if (front == -1)
            {
                MessageBox.Show("Empty queue. No items to remove.");
            }
            else
            {
                int element = tail[front];
                if (front == end)
                {
                    front = -1;
                    end = -1;
                }
                else
                {
                    front = (front + 1) % max;
                }
                MessageBox.Show("Element " + element + " retirado.");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lstTail.Items.Clear();
            if (front == -1)
            {
                lstTail.Items.Add("Empty tail.");
            }
            else
            {
                int i = front;
                while (true)
                {
                    lstTail.Items.Add(tail[i]);
                    if (i == end) break;
                    i = (i + 1) % max;
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
