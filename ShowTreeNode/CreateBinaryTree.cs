using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowTreeNode
{
    internal static class CreateBinaryTree
    {
        public record TwoPoint
        {
            public int X1,Y1;
            public int X2,Y2;
            public TwoPoint(int X1,int Y1,int X2,int Y2)
            {
                this.X1 = X1; 
                this.Y1 = Y1; 
                this.X2 = X2;
                this.Y2 = Y2;
            }
        }
        public record EllipseNode
        {
            public int x;
            public int y;
            public int val;
            public EllipseNode()
            {
                x = -1;
                y = -1;
                val = -1;
            }
            public EllipseNode(int x, int y, int val)
            {
                this.x = x;
                this.y = y;
                this.val = val;
            }
        }
        public class SpaceTreeNode
        {
            public int index;
            public int val;
            public SpaceTreeNode left;
            public SpaceTreeNode right;
            public SpaceTreeNode(int val = 0, SpaceTreeNode left = null, int index = 0, SpaceTreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
                this.index = index;
            }
        }
        private static void CreateSpaceTreeIndex(SpaceTreeNode tree, ref int index)
        {
            if (tree == null)
                return;

            CreateSpaceTreeIndex(tree.left, ref index);

            tree.index = index;
            index += tree.val.ToString().Length;

            CreateSpaceTreeIndex(tree.right, ref index);
        }
        public static string GetStringRoot(SpaceTreeNode tree)
        {
            if (tree == null)
                return "";

            int index = 0;

            StringBuilder str = new StringBuilder();
            Queue<SpaceTreeNode> q = new Queue<SpaceTreeNode>();

            q.Enqueue(tree);

            while (q.Any())
            {
                int count = q.Count();
                int prev = 0;

                StringBuilder strVe = new StringBuilder();

                for (int i = 0; i < count; i++)
                {
                    var temp = q.Dequeue();

                    for (int j = prev; j < temp.index; j++)
                    {
                        strVe.Append(" ");
                        str.Append(" ");
                    }

                    str.Append(temp.val);

                    prev = temp.index + temp.val.ToString().Length;

                    if (temp.left != null)
                    {
                        q.Enqueue(temp.left);
                        strVe.Append("/");
                    }


                    if (temp.right != null)
                    {
                        q.Enqueue(temp.right);
                        strVe.Append("\\");
                    }
                }

                str.Append('\n');
                strVe.Append('\n');
                str.Append(strVe);
            }

            return str.ToString();
        }
        public static SpaceTreeNode CreateTreeNode(int?[] vals)
        {
            if (vals.Length == 0 || vals[0] == null) return null;

            Queue<SpaceTreeNode> q = new Queue<SpaceTreeNode>();
            SpaceTreeNode treeNode = new SpaceTreeNode((int)vals[0]);
            q.Enqueue(treeNode);

            int i = 1;
            while (i < vals.Length && q.Count + i < vals.Length)
            {
                int count = q.Count;
                int j = 0;

                while (j < count && i < vals.Length)
                {
                    var temp = q.Dequeue();

                    if (vals[i] != null)
                    {
                        temp.left = new SpaceTreeNode((int)vals[i]);
                        q.Enqueue(temp.left);
                    }
                    i++;

                    if (i == vals.Length) break;

                    if (vals[i] != null)
                    {
                        temp.right = new SpaceTreeNode((int)vals[i]);
                        q.Enqueue(temp.right);
                    }

                    i++;
                    j++;
                }
            }

            while (i < vals.Length)
            {
                var temp = q.Dequeue();

                if (vals[i] != null)
                {
                    temp.left = new SpaceTreeNode((int)vals[i]);
                    q.Enqueue(temp.left);
                }
                i++;

                if (i == vals.Length) break;

                if (vals[i] != null)
                {
                    temp.right = new SpaceTreeNode((int)vals[i]);
                    q.Enqueue(temp.right);
                }
                i++;
            }

            int unused = 0;
            CreateSpaceTreeIndex(treeNode, ref unused);

            return treeNode;
        }
        public static EllipseNode[] GetNodes(SpaceTreeNode tree)
        {
            if (tree == null)
                return [];

            List<EllipseNode> listResult = new List<EllipseNode>();

            int index = 0;

            Queue<SpaceTreeNode> q = new Queue<SpaceTreeNode>();
            q.Enqueue(tree);

            int deep = 0;

            while (q.Any())
            {
                int count = q.Count();

                for (int i = 0; i < count; i++)
                {
                    var temp = q.Dequeue();

                    listResult.Add(new EllipseNode(
                        x: temp.index,
                        y: deep,
                        val: temp.val
                        ));

                    if (temp.left != null)
                    {
                        q.Enqueue(temp.left);
                    }


                    if (temp.right != null)
                    {
                        q.Enqueue(temp.right);
                    }
                }

                deep++;
            }


            return listResult.ToArray();
        }
        public static TwoPoint[] GetLines(SpaceTreeNode tree)
        {
            if (tree == null)
                return [];

            List<TwoPoint> listResult = new List<TwoPoint> ();

            int index = 0;

            Queue<SpaceTreeNode> q = new Queue<SpaceTreeNode>();

            q.Enqueue(tree);

            int deep = 0;

            while (q.Any())
            {
                int count = q.Count();

                for (int i = 0; i < count; i++)
                {
                    var temp = q.Dequeue();

                    if (temp.left != null)
                    {
                        q.Enqueue(temp.left);
                        listResult.Add(
                            new TwoPoint(
                                X1: temp.index,
                                Y1: deep,
                                X2: temp.left.index,
                                Y2: deep + 1));
                    }


                    if (temp.right != null)
                    {
                        q.Enqueue(temp.right);
                        listResult.Add(
                            new TwoPoint(
                                X1: temp.index,
                                Y1: deep,
                                X2: temp.right.index,
                                Y2: deep + 1));
                    }
                }

                deep++;
            }

            return listResult.ToArray ();
        }
    }
}
