using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab5
{
    public class Tree
    {
        public class TreeNode
        {
            public int Value; // Значение ключа
            public int Count = 0; // Количество одинаковых ключей
            public TreeNode Left; // Левое поддерево
            public TreeNode Right; // Правое поддерево
            public TreeNode Parent;
        }

        public TreeNode Node;

        public enum BypassOptions // перечисление - объявленные константы для выбора
        {
            LNR,
            NLR,
            LRN,
            RNL,
            BFS
        }

        public void Add(int value) // добавление элемента - интерфейсный метод
        {
            AddChildren(ref Node, value);
        }

        private void AddChildren(ref TreeNode node, int val)
        {
            if (node == null)
            {
                node = new TreeNode();
                node.Value = val;
                node.Count = 1;
                node.Parent = null;
            }
            else
            {
                if (node.Value == val) node.Count++;
                else
                {
                    if (node.Value > val)
                    {
                        AddChildren(ref node.Left, val);
                        node.Left.Parent = node;
                    }
                    else
                    {
                        AddChildren(ref node.Right, val);
                        node.Right.Parent = node;
                    }
                }
            }
        }

        public void Output(ref string s)
        {
            s = "";
            OutputTree(Node, 0, ref s);
        }

        private void OutputTree(TreeNode root, int spaces, ref string s)
        {
            if (root != null)
            {
                for (int i = 0; i < root.Count; i++)
                {
                    for (int j = 0; j <= spaces; j++)
                    {
                        if (j == 0) s += "|";
                        else s += " -";
                    }

                    s += " ";
                    s += root.Value.ToString();
                    s += Environment.NewLine;
                }

                OutputTree(root.Left, spaces + 1, ref s);
                OutputTree(root.Right, spaces + 1, ref s);
            }
        }

        public void KeySearch(ref string s, int key, ref int depth) // поиск ключа в дереве - интерфейсный метод
        {
            s = "";
            Find(Node, ref depth, ref key, ref s);
        }

        private void Find(TreeNode node, ref int depth, ref int key, ref string s)
        {
            if (node != null)
            {
                if (node.Value < key)
                {
                    depth++;
                    Find(node.Right, ref depth, ref key, ref s);
                }
                else if (node.Value > key)
                {
                    depth++;
                    Find(node.Left, ref depth, ref key, ref s);
                }
                else
                {
                    depth++;
                    s += node.Value.ToString() + " ";
                }
            }
        }

        public void Bypass(BypassOptions option, ref string s) // обход дерева - интерфейсный метод
        {
            s = "";
            if (option == BypassOptions.LNR) LNR_bypass(Node, ref s);
            if (option == BypassOptions.NLR) NLR_bypass(Node, ref s);
            if (option == BypassOptions.LRN) LRN_bypass(Node, ref s);
            if (option == BypassOptions.RNL) RNL_bypass(Node, ref s);
            if (option == BypassOptions.BFS) BFS_bypass(Node, ref s);
            s += Environment.NewLine;
        }

        private void LNR_bypass(TreeNode node, ref string s)
        {
            if (node != null)
            {
                LNR_bypass(node.Left, ref s); // обойти левое поддерево
                s += node.Value.ToString() + " "; // записать данные
                LNR_bypass(node.Right, ref s); // обойти правое поддерево
            }
        }

        private void NLR_bypass(TreeNode node, ref string s)
        {
            if (node != null)
            {
                s += node.Value.ToString() + " ";
                NLR_bypass(node.Left, ref s);
                NLR_bypass(node.Right, ref s);
            }
        }

        private void LRN_bypass(TreeNode node, ref string s)
        {
            if (node != null)
            {
                LRN_bypass(node.Left, ref s);
                LRN_bypass(node.Right, ref s);
                s += node.Value.ToString() + " ";
            }
        }

        private void RNL_bypass(TreeNode node, ref string s)
        {
            if (node != null)
            {
                RNL_bypass(node.Right, ref s); // обойти правое поддерево
                s += node.Value.ToString() + " "; // запомнить текущее значение
                RNL_bypass(node.Left, ref s); // обойти левое поддерево
            }
        }

        private void BFS_bypass(TreeNode node, ref string s)
        {
            var tail = new Queue<TreeNode>(); // создание очереди, принцип FIFO
            tail.Enqueue(node);
            while (tail.Count != 0)
            {
                if (tail.Peek().Left != null)
                {
                    tail.Enqueue(tail.Peek().Left);
                }

                if (tail.Peek().Right != null)
                {
                    tail.Enqueue(tail.Peek().Right);
                }

                s += tail.Peek().Value.ToString() + " ";
                tail.Dequeue();
            }
        }

        public void DellNode(int key)
        {
            Dell(Node, ref key);
        }

        private void Dell(TreeNode node, ref int key)
        {
            if (node == null)
            {
                return;
            }

            if (node.Value < key)
            {
                Dell(node.Right, ref key);
            }
            else if (node.Value > key)
            {
                Dell(node.Left, ref key);
            }
            else
            {
                if (node.Count > 1) node.Count--;
                else if (node.Left == null && node.Right == null)
                {
                    if (node.Parent.Left != null && node.Parent.Left.Value == node.Value) node.Parent.Left = null;
                    else node.Parent.Right = null;
                } // Удаление листа
                else if (node.Left != null && node.Right != null)
                {
                    int key_left = RightN(node.Left);
                    int key_right = LeftN(node.Right);
                    if (node.Left.Value <= key_left && node.Right.Value >= key_left)
                    {
                        Dell(node, ref key_left);
                        node.Value = key_left;
                    }
                    else if (node.Left.Value <= key_right && node.Right.Value >= key_right)
                    {
                        Dell(node, ref key_right);
                        node.Value = key_right;
                    }
                    if (node.Left != null) node.Left.Parent = node;
                    if (node.Right != null) node.Right.Parent = node;
                }
                else
                {
                    if (node.Parent.Right.Value == node.Value)
                    {
                        if (node.Left != null)
                        {
                            node.Parent.Right = node.Left;
                            node.Parent.Right.Parent = node.Parent;
                        }
                        else
                        {
                            node.Parent.Right = node.Right;
                            node.Parent.Right.Parent = node.Parent;
                        }
                    }
                    else
                    {
                        if (node.Left != null)
                        {
                            node.Parent.Left = node.Left;
                            node.Parent.Left.Parent = node.Parent;
                        }
                        else
                        {
                            node.Parent.Left = node.Right;
                            node.Parent.Left.Parent = node.Parent;
                        }
                    }
                } // Удаление с одной веткой
            }
        }

        private int RightN(TreeNode node)
        {
            if (node.Right == null) return node.Value;
            else return RightN(node.Right);
        }

        private int LeftN(TreeNode node)
        {
            if (node.Left == null) return node.Value;
            else return LeftN(node.Left);
        }
    }
}