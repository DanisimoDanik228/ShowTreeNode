using System;
using System.Drawing;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using static ShowTreeNode.CreateBinaryTree;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.LinkLabel;

namespace ShowTreeNode
{
    //public static class ExplicitExpancionMethod
    //{
    //    public static void UploadImage(this PictureBox pictureBox, string filepath, ref Graphics graphics)
    //    {
    //        pictureBox.Image = Image.FromFile(filepath);
    //        graphics = Graphics.FromImage(pictureBox.Image);
    //        pictureBox.Invalidate();
    //    }
    //}
    public partial class Form1 : Form
    {
        private readonly int _sizePictureX;
        private readonly int _sizePictureY;
        private const int _radius = 20;
        private  Pen _penNode = new Pen(Brushes.Red,1);
        private  Pen _penLine = new Pen(Brushes.Green,1);
        private Graphics _graphics;
        private const string _filePathMassive = "D:\\ñ#\\ShowTreeNode\\ShowTreeNode\\bin\\Debug\\net8.0-windows\\Binary Tree.bst";
        private const string _filePathImage = @"D:\ñ#\ShowTreeNode\ShowTreeNode\bin\Debug\net8.0-windows\Cute Cat.png";
        public Form1()
        {
            InitializeComponent();

            richTextBox1.Lines = File.ReadAllLines(_filePathMassive);
            //pictureBox1.UploadImage(_filePathImage,ref _graphics);


            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitmap;
            _graphics = Graphics.FromImage(pictureBox1.Image);
            _graphics.Clear(Color.White);
            pictureBox1.Invalidate();

            _sizePictureX = pictureBox1.Image.Width;
            _sizePictureY = pictureBox1.Image.Height;
        }
        
        private void buttonShow_Click(object sender, EventArgs e)
        {
            _graphics.Clear(Color.White);
            pictureBox1.Invalidate();
            //pictureBox1.UploadImage(_filePathImage, ref _graphics);

            string data = richTextBox1.Text;
            int?[] vals;
            if (Parse.StringToArrInt(data, out vals))
            {
                if (vals.Length > 0)
                {
                    string info = "";

                    foreach (var item in vals)
                    {
                        if (item == null)
                        {
                            info += "null, ";
                        }
                        else
                        {
                            info += item + ", ";
                        }
                    }

                    SpaceTreeNode root = CreateTreeNode(vals);
                    //MessageBox.Show(GetStringRoot(root));

                    var nodes = GetNodes(root);

                    int maxDeep = nodes.Last().y;
                    int centerX = _sizePictureX / 2;
                    int centerY = _sizePictureY / 2;

                    centerX = _radius / 2;// pictureBox1.Width / 2;
                    centerY = _radius / 2;// pictureBox1.Height / 2;

                    int kX = 10;
                    int kY = kX * 3;

                    foreach (var item in nodes)
                        _graphics.DrawEllipse(_penNode, item.x * kX + centerX - _radius / 2, item.y * kY + centerY - _radius / 2, _radius, _radius);

                    var lines = GetLines(root);

                    foreach (var item in lines)
                        _graphics.DrawLine(_penLine, new Point(item.X1 * kX + centerX, item.Y1 * kY + centerY), new Point(item.X2 * kX + centerX, item.Y2 * kY + centerY));

                    pictureBox1.Invalidate();
                }
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            _graphics.Clear(Color.White);
            pictureBox1.Invalidate();
            //pictureBox1.UploadImage(_filePathImage, ref _graphics);

            richTextBox1.Clear();
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, trackBar1.Value);
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(_filePathMassive, richTextBox1.Lines);
        }
    }
}
