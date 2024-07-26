using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowTreeNode
{
    internal static class Parse
    {
        public static int? StringToInt(string str)
        {
            if (str.ToLower() == "null")
            {
                return null;
            }
            else
            {
                return int.Parse(str);
            }
        }
        public static bool StringToArrInt(string data,out int?[] result)
        {
            List<int?> resultList = new List<int?>();
            result = null;
          
            int len = data.Length;
            if (len < 2) return false;

            int indexStart = 0;
            while (indexStart < len && data[indexStart] != '[')
            {
                if (data[indexStart] != ' ')
                    return false;

                indexStart++;
            }

            int indexEnd = data.Length - 1;
            while (indexEnd > 0 && data[indexEnd] != ']')
            {
                if (data[indexEnd] != ' ')
                    return false;

                indexEnd--;
            }

            for (int i = indexStart + 1; i < indexEnd; i++)
            {
                int starVal = i;
                while (data[i] != ',' && data[i] != ']')
                    i++;

                var temp = data.Substring(starVal, i - starVal);
                int indexStartTemp = 0;

                while (indexStartTemp < temp.Length && temp[indexStartTemp] == ' ')
                    indexStartTemp++;

                int indexEndTemp = temp.Length - 1;

                while (indexEndTemp >= 0 && temp[indexEndTemp] == ' ')
                    indexEndTemp--;

                if (indexStartTemp > indexEndTemp)
                    return false;

                temp = temp.Substring(indexStartTemp,indexEndTemp - indexStartTemp + 1);
                if (temp.ToLower() == "null")
                {
                    resultList.Add(null);
                }
                else
                {
                    if (temp.Length == 0 || !int.TryParse(temp, out int digit))
                        return false;

                    resultList.Add(digit);
                }
            }

            result = resultList.ToArray();
            return true;
        }
    }
}
