using System;
using System.Windows.Forms;

namespace _7.Binary_tree
{
    public partial class Form2 : Form
    {
        public Form2(string[] text)
        {
            InitializeComponent();
            BinaryTree<string> bt = new BinaryTree<string>();
            foreach (string elem in text)
                bt.Add(elem);
            foreach (string elem in bt.Concordance())
                textBox1.Text += elem + Environment.NewLine;
        }
    }
}
