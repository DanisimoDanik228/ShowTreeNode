using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel.Com2Interop;
using System.Xml.Serialization;
using static ShowTreeNode.CreateBinaryTree;

namespace ShowTreeNode
{
    public partial class Form1 : Form
    {
        private const int _deepLineX = 20;
        private const int _deepLineY = 30;
        private const int _radius = 20;

        private int _sizePictureX;
        private int _sizePictureY;
        private Pen _penNode = new Pen(Brushes.Red, 1);
        private Pen _penLine = new Pen(Brushes.Green, 1);
        private Pen _penDigit = new Pen(Brushes.Black, 1);
        private Graphics _graphics;
        private const string _filePathMassive = "D:\\ñ#\\ShowTreeNode\\ShowTreeNode\\bin\\Debug\\net8.0-windows\\Binary Tree.bst";
        private const string _filePathImage = @"D:\ñ#\ShowTreeNode\ShowTreeNode\bin\BinaryTree.png";
        public Form1()
        {
            InitializeComponent();

            richTextBox1.Lines = File.ReadAllLines(_filePathMassive);
        }
        private void buttonShow_Click(object sender, EventArgs e)
        {
            _graphics.Clear(Color.White);
            pictureBox1.Invalidate();

            string data = richTextBox1.Text;
            int?[] vals;
            if (Parse.StringToArrInt(data, out vals))
            {
                if (vals.Length > 0)
                {
                    SpaceTreeNode root = CreateTreeNode(vals);

                    var nodes = GetNodes(root);
                    int maxRight = nodes.Length;
                    int maxDeep = nodes.Last().y;

                    int centerY = _radius / 2 + (_sizePictureY - maxDeep * _deepLineY) / 2;
                    int centerX = _radius / 2 + (_sizePictureX - maxRight * _deepLineX) / 2;


                    var lines = GetLines(root);
                    foreach (var item in lines)
                        _graphics.DrawLine(_penLine, new Point(item.X1 * _deepLineX + centerX, item.Y1 * _deepLineY + centerY), new Point(item.X2 * _deepLineX + centerX, item.Y2 * _deepLineY + centerY));
                    
                    foreach (var item in nodes)
                    {
                        int x = item.x * _deepLineX + centerX - _radius / 2;
                        int y = item.y * _deepLineY + centerY - _radius / 2;

                        string strVal = item.val.ToString();

                        int size = 2;
                        int l = 2;

                        _graphics.FillRectangle(Brushes.White, x, y, _radius + (l + size * 5) * (strVal.Length - 1), _radius);

                        for (int i1 = 0; i1 < strVal.Length; i1++)
                        {
                            var digit = NumberCoord.GetDigit(strVal[i1] - '0', x + i1 * (5 * size + l) + _radius / 3, y +  _radius / 3, size);

                            for (int i = 0; i < digit.Length - 1; i++)
                            {
                                _graphics.DrawLine(_penDigit, digit[i], digit[i + 1]);
                            }
                        }

                        _graphics.DrawRectangle(_penNode, x, y, _radius + (l + size * 5) * (strVal.Length - 1), _radius);
                    }

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

            richTextBox1.Clear();
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, trackBar1.Value);
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(_filePathMassive, richTextBox1.Lines);

            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Save(_filePathImage, ImageFormat.Png);
                
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitmap;
            _graphics = Graphics.FromImage(pictureBox1.Image);
            _graphics.Clear(Color.White);

            _sizePictureX = pictureBox1.Image.Width;
            _sizePictureY = pictureBox1.Image.Height;

            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, trackBar1.Value);

            pictureBox1.Invalidate();
        }
    }
}
