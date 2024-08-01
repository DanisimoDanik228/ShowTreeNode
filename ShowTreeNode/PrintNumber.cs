using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowTreeNode
{
    internal static class NumberCoord
    {
        private static Point[] Minus(int x, int y, int size)
        {
            return [
                GetPoint(x,y,size,1,2.5),
                GetPoint(x,y,size,4,2.5)
                ];
        }
        public static Point[] GetDigit(int digit, int x, int y, int size)
        {
            if (digit == '-' - '0')
            {
                return Minus(x,y,size);
            }

            if (digit < 0 || digit > 9)
            {
                throw new InvalidDataException($"digits must be between 0 <--> 9 (negative or positive). You = '{(char)(digit + '0')}'");
            }

            switch (digit)
            {
                case (0):
                    return Zero(x,y,size);

                case (1):
                    return One(x, y, size);

                case (2):
                    return Two(x, y, size);

                case (3):
                    return Three(x, y, size);

                case (4):
                    return Four(x, y, size);

                case (5):
                    return Five(x, y, size);

                case (6):
                    return Six(x, y, size);

                case (7):
                    return Seven(x, y, size);

                case (8):
                    return Eight(x, y, size);

                default:
                    return Nine(x, y, size);
            }
        }
        private static Point GetPoint(int x,int y,int size, double X, double Y)
        {
            return new Point((int)(x + X * size),(int)(y + Y * size));
        }
        private static Point[] Zero(int x, int y, int size) 
        {
            return
                    [
                GetPoint(x, y,size,2,0),
                GetPoint(x, y,size,3,0),
                GetPoint(x, y,size,4,1),
                GetPoint(x, y,size,4,4),
                GetPoint(x, y,size,3,5),
                GetPoint(x, y,size,2,5),
                GetPoint(x, y,size,1,4),
                GetPoint(x, y,size,1,1),
                GetPoint(x, y,size,2,0)
                ];
        }
        private static Point[] One(int x,int y ,int size)
        {
            return
                [
                GetPoint(x, y,size,1,2),
                GetPoint(x, y,size,3,0),
                GetPoint(x, y,size,3,5)
                ];
        }
        private static Point[] Two(int x, int y, int size)
        {
            return [
                 GetPoint(x, y,size,1,2),
                 GetPoint(x, y,size,1,1),
                 GetPoint(x, y,size,2,0),
                 GetPoint(x, y,size,3,0),
                 GetPoint(x, y,size,4,1),
                 GetPoint(x, y,size,4,2),
                 GetPoint(x, y,size,1,5),
                 GetPoint(x, y,size,4,5)
                ];
        }
        private static Point[] Three(int x, int y, int size)
        {
            return [
                GetPoint(x, y, size, 1, 1),
                GetPoint(x, y, size, 2, 0),
                GetPoint(x, y, size, 4, 1),
                GetPoint(x, y, size, 2, 2.5),
                GetPoint(x, y, size, 4, 4),
                GetPoint(x, y, size, 2, 5),
                GetPoint(x, y, size, 1, 4)
            ];
        }
        private static Point[] Four(int x, int y, int size)
        {
            return [
                GetPoint(x, y, size, 1, 0),
                GetPoint(x, y, size, 1, 2),
                GetPoint(x, y, size, 4, 2),
                GetPoint(x, y, size, 4, 0),
                GetPoint(x, y, size, 4, 5)
                ];
        }
        private static Point[] Five(int x, int y, int size)
        {
            return [
                GetPoint(x, y, size, 4, 0),
                GetPoint(x, y, size, 1, 0),
                GetPoint(x, y, size, 1, 2),
                GetPoint(x, y, size, 3, 2),
                GetPoint(x, y, size, 4, 3),
                GetPoint(x, y, size, 4, 4),
                GetPoint(x, y, size, 3, 5),
                GetPoint(x, y, size, 1, 5)
                ];
        }
        private static Point[] Six(int x, int y, int size)
        {
            return [
                GetPoint(x, y, size, 4, 1),
                GetPoint(x, y, size, 3, 0),
                GetPoint(x, y, size, 2, 0),
                GetPoint(x, y, size, 1, 1),
                GetPoint(x, y, size, 1, 4),
                GetPoint(x, y, size, 2, 5),
                GetPoint(x, y, size, 3, 5),
                GetPoint(x, y, size, 4, 4),
                GetPoint(x, y, size, 4, 3),
                GetPoint(x, y, size, 3, 2),
                GetPoint(x, y, size, 2, 2),
                GetPoint(x, y, size, 1, 3)
                ];
        }
        private static Point[] Seven(int x, int y, int size)
        {
            return [
                GetPoint(x, y, size, 1, 0),
                GetPoint(x, y, size, 4, 0),
                GetPoint(x, y, size, 2.5, 2),
                GetPoint(x, y, size, 1.5, 2),
                GetPoint(x, y, size, 3.5, 2),
                GetPoint(x, y, size, 2.5, 2),
                GetPoint(x, y, size, 1, 5)
                ];
        }
        private static Point[] Eight(int x, int y, int size)
        {
            return [
                GetPoint(x, y, size, 2, 0),
                GetPoint(x, y, size, 3, 0),
                GetPoint(x, y, size, 4, 1),
                GetPoint(x, y, size, 4, 2),
                GetPoint(x, y, size, 1, 3),
                GetPoint(x, y, size, 1, 4),
                GetPoint(x, y, size, 2, 5),
                GetPoint(x, y, size, 3, 5),
                GetPoint(x, y, size, 4, 4),
                GetPoint(x, y, size, 4, 3),
                GetPoint(x, y, size, 1, 2),
                GetPoint(x, y, size, 1, 1),
                GetPoint(x, y, size, 2, 0)
                ];
        }
        private static Point[] Nine(int x, int y, int size)
        {
            return [
                GetPoint(x, y, size, 4, 2),
                GetPoint(x, y, size, 3, 3),
                GetPoint(x, y, size, 2, 3),
                GetPoint(x, y, size, 1, 2),
                GetPoint(x, y, size, 1, 1),
                GetPoint(x, y, size, 2, 0),
                GetPoint(x, y, size, 3, 0),
                GetPoint(x, y, size, 4, 1),
                GetPoint(x, y, size, 4, 4),
                GetPoint(x, y, size, 3, 5),
                GetPoint(x, y, size, 2, 5),
                GetPoint(x, y, size, 1, 4),
                GetPoint(x, y, size, 1, 3.5)
            ];
        }
    }
}
