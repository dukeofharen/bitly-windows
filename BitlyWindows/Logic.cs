using BitlyDotNET.Implementations;
using BitlyDotNET.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitlyWindows
{
    public class Logic
    {
        public static string ShortenURL(string longURL)
        {
            IBitlyService s = new BitlyService(Properties.Settings.Default.bitlyUsername, Properties.Settings.Default.bitlyKey);
            return s.Shorten(longURL);
        }
    }
}
