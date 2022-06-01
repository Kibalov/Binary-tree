using System;
using System.Collections.Generic;
using System.Drawing;

namespace _7.Binary_tree
{
    class BinaryTree<T> where T:IComparable<T>
    {
        BinaryTreeNode<T> root;
        Bitmap img;
        Graphics gr;
        List<string> res = new List<string>();

        public Bitmap Add(T item)
        {
            root = AddR(item, root);
            return Draw();
        }
        public Bitmap Del(T item)
        {
            root = DelR(item, ref root);
            return Draw();
        }
        public string CLR()
        {
            string res = "";
            res = PreOrder(ref root, ref res);
            return res;
        }
        public string LCR()
        {
            string res = "";
            res = InOrder(ref root, ref res);
            return res;
        }
        public string RCL()
        {
            string res = "";
            res = PostOrder(ref root, ref res);
            return res;
        }
        public int DeepCount()
        {
            return DeepCountR(root)-1;
        }
        public int ListCount()
        {
            return ListCountR(ref root); ;
        }
        private Bitmap Draw()
        {
            img = new Bitmap(600, 400);
            gr = Graphics.FromImage(img);
            
            DrawR(ref root, new RectangleF(0,0,600,100));
            return img;
            
        }

        private BinaryTreeNode<T> AddR(T item, BinaryTreeNode<T> r)
        {
            if (r == null)
                return new BinaryTreeNode<T>(item);
            else if (item.CompareTo(r.value) == -1)
            {
                r.left = AddR(item, r.left);
                r = balance_tree(r);
            }
            else if (item.CompareTo(r.value) == 1)
            {
                r.right = AddR(item, r.right);
                r = balance_tree(r);
            }
            else r.count++;
            return r;
        }
        private BinaryTreeNode<T> DelR(T item, ref BinaryTreeNode<T> r)
        {
            BinaryTreeNode<T> parent;
            if (r == null) return null;
            else
            {
                if (item.CompareTo(r.value) == -1)
                {
                    r.left = DelR(item, ref r.left);
                    if (balance_factor(r) == -2)
                    {
                        if (balance_factor(r.right) <= 0)
                            r = RotateRR(r);
                        else
                            r = RotateRL(r);
                    }
                }
                else if (item.CompareTo(r.value) == 1)
                {
                    r.right = DelR(item, ref r.right);
                    if (balance_factor(r) == 2)
                    {
                        if (balance_factor(r.left) >= 0)
                            r = RotateLL(r);
                        else
                            r = RotateLR(r);
                    }
                }
                else
                {
                    if (r.right != null && r.count==1)
                    {
                        parent = r.right;
                        while (parent.left != null)
                            parent = parent.left;
                        r.left.parent = parent;
                        parent.left = r.left;
                        r = parent;
                        if (balance_factor(r) == 2)
                        {
                            if (balance_factor(r.left) >= 0)
                            {
                                r = RotateLL(r);
                            }
                            else { r = RotateLR(r); }
                        }
                    }
                    else if (r.left != null && r.count == 1)
                    {
                        return r.left;
                    }
                    else if (r.count > 1)
                        r.count--;
                }
            }
            return r;
        }
        private int ListCountR(ref BinaryTreeNode<T> r)
        {
            int result;
            if ((r.left == null) && (r.right == null))
                result = 1;
            else result = 0;
            if (r.left != null)
                result += ListCountR(ref r.left);
            if (r.right != null)
                result += ListCountR(ref r.right);
            return result;
        }
        private int DeepCountR(BinaryTreeNode<T> current)
        {
            int height = 0;
            if (current != null)
            {
                int l = DeepCountR(current.left);
                int r = DeepCountR(current.right);
                int m = l > r ? l : r;
                height = m + 1;
            }
            return height;
        }
        private string PreOrder(ref BinaryTreeNode<T> r, ref string res)
        {
            res += r.value + " ";
            if (r.left != null) PreOrder(ref r.left, ref res);
            if (r.right != null) PreOrder(ref r.right, ref res);
            return res;
        }
        private string InOrder(ref BinaryTreeNode<T> r, ref string res)
        {
            if (r.left != null) InOrder(ref r.left, ref res);
            res += r.value + " ";
            if (r.right != null) InOrder(ref r.right, ref res);
            return res;
        }
        private string PostOrder(ref BinaryTreeNode<T> r, ref string res)
        {
            if (r.right != null) PostOrder(ref r.right, ref res);
            res += r.value + " ";
            if (r.left != null) PostOrder(ref r.left, ref res);
            return res;
        }

        private void DrawR(ref BinaryTreeNode<T> r, RectangleF box)
        {
            if (r.left != null)
            {
                gr.DrawLine(new Pen(Color.Black), box.Left + box.Width / 2, box.Top + 30, box.Left + box.Width / 4, box.Bottom + 10);
                DrawR(ref r.left, new RectangleF((int)box.X, box.Bottom, box.Width / 2f, 2 * box.Height / 3f));
            }
            if (r.right != null)
            {
                gr.DrawLine(new Pen(Color.Black), box.Left + box.Width / 2, box.Top + 30, box.Left + box.Width / 2 + box.Width / 4, box.Bottom + 10);
                DrawR(ref r.right, new RectangleF((int)box.X + box.Width / 2f, box.Bottom, box.Width / 2f, 2 * box.Height / 3f));
            }

            gr.DrawEllipse(new Pen(Color.Red), new Rectangle((int)box.X + (int)box.Width / 2 - 12, (int)box.Top + 7, 20, 20));
            gr.DrawString($"{r.value}", new Font("Arial", 10), new SolidBrush(Color.Black), (int)box.X + (int)box.Width / 2 - 10, (int)box.Top + 10);
        }
        private BinaryTreeNode<T> balance_tree(BinaryTreeNode<T> current)
        {
            int b_factor = balance_factor(current);
            if (b_factor > 1)
            {
                if (balance_factor(current.left) > 0)
                    current = RotateLL(current);
                else
                    current = RotateLR(current);
            }
            else if (b_factor < -1)
            {
                if (balance_factor(current.right) > 0)
                    current = RotateRL(current);
                else
                    current = RotateRR(current);
            }
            return current;
        }
        private int balance_factor(BinaryTreeNode<T> current)
        {
            int l = DeepCountR(current.left);
            int r = DeepCountR(current.right);
            int b_factor = l - r;
            return b_factor;
        }
        private BinaryTreeNode<T> RotateRR(BinaryTreeNode<T> parent)
        {
            BinaryTreeNode<T> pivot = parent.right;
            parent.right = pivot.left;
            pivot.left = parent;
            return pivot;
        }
        private BinaryTreeNode<T> RotateLL(BinaryTreeNode<T> parent)
        {
            BinaryTreeNode<T> pivot = parent.left;
            parent.left = pivot.right;
            pivot.right = parent;
            return pivot;
        }
        private BinaryTreeNode<T> RotateLR(BinaryTreeNode<T> parent)
        {
            BinaryTreeNode<T> pivot = parent.left;
            parent.left = RotateRR(pivot);
            return RotateLL(parent);
        }
        private BinaryTreeNode<T> RotateRL(BinaryTreeNode<T> parent)
        {
            BinaryTreeNode<T> pivot = parent.right;
            parent.right = RotateLL(pivot);
            return RotateRR(parent);
        }

        public List<string> Concordance()
        {
            ConcordanceR(ref root);
            return res;
        }
        private void ConcordanceR(ref BinaryTreeNode<T> r)
        {
            if (r.left != null) ConcordanceR(ref r.left);
            res.Add(r.value.ToString().PadRight(30, '.') + r.count.ToString());
            if (r.right != null) ConcordanceR(ref r.right);
        }
    }
}
