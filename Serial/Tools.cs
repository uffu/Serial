using System;
using System.Collections.Generic;
using System.Text;

namespace Serial
{
    class Tools
    {
        public static string toAscii(string hex)
        {
            try
            {
                string ascii = string.Empty;
                for (int i = 0; i < hex.Length; i += 2)
                {
                    string hs = string.Empty;

                    hs = hex.Substring(i, 2);
                    uint decval = Convert.ToUInt32(hs, 16);
                    char character = Convert.ToChar(decval);
                    ascii += character;
                }
                return ascii;
            }
            catch { }

            return string.Empty;
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
