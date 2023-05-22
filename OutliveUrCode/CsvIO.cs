using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutliveUrCode
{
    public class ReadCsv
    {
        public List<string[]> MyCSV; //你想要的csv转换后的数据

        /// <summary>
        /// Separator 为表格中的单元分隔符
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Separator"></param>
        /// <returns></returns>
	    public static List<string[]> ReadCSV(string Text, char Separator = ',')
        {
            int i = 0;
            List<string[]> list = new List<string[]>();
            while (i < Text.Length)
            {
                string[] array = ParseCSVline(Text, ref i, Separator);
                if (array == null)
                {
                    break;
                }
                list.Add(array);
            }
            return list;
        }

        private static string[] ParseCSVline(string Line, ref int iStart, char Separator)
        {
            List<string> list = new List<string>();
            int length = Line.Length;
            int num = iStart;
            bool flag = false;
            while (iStart < length)
            {
                char c = Line[iStart];
                if (flag)
                {
                    if (c == '"')
                    {
                        if (iStart + 1 >= length || Line[iStart + 1] != '"')
                        {
                            flag = false;
                        }
                        else if (iStart + 2 < length && Line[iStart + 2] == '"')
                        {
                            flag = false;
                            iStart += 2;
                        }
                        else
                        {
                            iStart++;
                        }
                    }
                }
                else if (c == '\n' || c == Separator)
                {
                    AddCSVtoken(ref list, ref Line, iStart, ref num);
                    if (c == '\n')
                    {
                        iStart++;
                        break;
                    }
                }
                else if (c == '"')
                {
                    flag = true;
                }
                iStart++;
            }
            if (iStart > num)
            {
                AddCSVtoken(ref list, ref Line, iStart, ref num);
            }
            return list.ToArray();
        }

        private static void AddCSVtoken(ref List<string> list, ref string Line, int iEnd, ref int iWordStart)
        {
            string text = Line.Substring(iWordStart, iEnd - iWordStart);
            iWordStart = iEnd + 1;
            text = text.Replace("\"\"", "\"");
            if (text.Length > 1 && text[0] == '"' && text[text.Length - 1] == '"')
            {
                text = text.Substring(1, text.Length - 2);
            }
            list.Add(text);
        }
    }
}
