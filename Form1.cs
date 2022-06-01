using System;
using System.Windows.Forms;

namespace _7.Binary_tree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BinaryTree<int> bt = new BinaryTree<int>();

        private void Add(object sender, EventArgs e)
        {
            pictureBox.BackgroundImage = bt.Add(int.Parse(valT.Text));
            deepL.Text = deepL.Text.Remove(7);
            deepL.Text += " " + bt.DeepCount();
            listL.Text = listL.Text.Remove(18);
            listL.Text += " " + bt.ListCount();
        }
        private void delB_Click(object sender, EventArgs e)
        {
            pictureBox.BackgroundImage = bt.Del(int.Parse(valT.Text));
            deepL.Text = deepL.Text.Remove(7);
            deepL.Text += " " + bt.DeepCount();
            listL.Text = listL.Text.Remove(18);
            listL.Text += " " + bt.ListCount();
        }

        private void CLR_Click(object sender, EventArgs e)
        {
            textBox1.Text += "CLR: " + bt.CLR() + Environment.NewLine;
        }
        private void LCR_Click(object sender, EventArgs e)
        {
            textBox1.Text += "LCR: " + bt.LCR() + Environment.NewLine;
        }
        private void RCL_Click(object sender, EventArgs e)
        {
            textBox1.Text += "RCL: " + bt.RCL() + Environment.NewLine;
        }
        private void conc_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            fileText = fileText.ToLower();
            string[] sep = { ",", ":", ".", "!", "?", ";", " -", "\""};
            foreach(string elem in sep)
                fileText = fileText.Replace(elem, "");
            fileText = fileText.Replace("  "," ");
            string[] text = fileText.Split(' ');
            Form2 f2 = new Form2(text);
            f2.Show();
        }
    }
}
