namespace StacksTails
{
    public partial class FormStack : Form
    {
        private int[] stack;
        private int tope;
        private int max;
        public FormStack()
        {
            InitializeComponent();
            max = 5; // Tamaño máximo de la pila
            stack = new int[max];
            tope = -1;
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            if (tope == max - 1)
            {
                MessageBox.Show("Full stack. No more items can be added.");
            }
            else
            {
                if (int.TryParse(txtNumber.Text, out int element))
                {
                    stack[++tope] = element;
                    MessageBox.Show("Element " + element + " add.");
                    txtNumber.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter a valid number.");
                }
            }
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (tope == -1)
            {
                MessageBox.Show("Pila vacía. No hay elementos para retirar.");
            }
            else
            {
                int elemento = stack[tope--];
                MessageBox.Show("Element" + elemento + " removed.");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lstStack.Items.Clear();
            if (tope == -1)
            {
                lstStack.Items.Add("Empty stack.");
            }
            else
            {
                for (int i = tope; i >= 0; i--)
                {
                    lstStack.Items.Add(stack[i]);
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
