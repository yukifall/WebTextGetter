using System;
using System.Collections.Generic;
using System.Text;

namespace WebTextGetter
{
    public class GetUrlFormatter
    {
        public const string RootUrl = @"https://ncode.syosetu.com"; //n0757ey/1/";
        public static string GetBody(string ncode, int page)
        {
            return $"{RootUrl}/{ncode}/{page}";
        }
    }
}
