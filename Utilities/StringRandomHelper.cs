﻿using System;
using System.Text;

namespace M11_Dzianis_Dukhnou.Utilities
{
    public class StringRandomHelper
    {
        public string GetRandomString(int length)
        {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder(length - 1);
            string alphabet = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
            int position;

            for (int i = 0; i < length; i++)
            {
                position = rnd.Next(0, alphabet.Length - 1);
                sb.Append(alphabet[position]);
            }

            return sb.ToString();
        }
    }
}