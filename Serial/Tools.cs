using System;
using System.Collections.Generic;
using System.Text;

namespace Serial
{
    class Tools
    {
        public static char toChar(uint dec)
        {
            const uint TAB = 9, LF = 10, CR = 13;
            if ( (dec >= 32 && dec < 127) || dec == TAB || dec == LF || dec == CR) 
                return Convert.ToChar(dec);
            else
                return '?';
        }
        public static string toAscii(string hex)
        {
            string ascii = string.Empty;
            for (int i = 0; i < hex.Length; i += 2)
            {
                string hs = string.Empty;
                try
                {
                    hs = hex.Substring(i, 2);
                    uint dec = Convert.ToUInt32(hs, 16);
                    ascii += toChar(dec);
                    // TODO fix chars
                }
                catch { }
            }
            return ascii;            
        }

        public static string toHex(string ascii)
        {
            string hexOutput = "";
            foreach (char c in ascii.ToCharArray())
                hexOutput += String.Format("{0:X}", Convert.ToInt32(c));
            return hexOutput;
        }
    }
}
