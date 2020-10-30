using System;
using System.Collections.Generic;
namespace Open_Lab_04._08
{
    public class StringTools
    {
        public string[] IsFourLetters(string[] strings)
        {
            List<string> lists = new List<string>();
            foreach (string str in strings)
            {
                if (str.Length == 4)
                {
                    lists.Add(str);
                }
            }
            return lists.ToArray();
        }
    }
}
