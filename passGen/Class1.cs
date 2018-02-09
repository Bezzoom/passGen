using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace passGen
{
    public class Passwords
    {
        bool cap, sym, dig, small;
        int len;

        public Passwords(bool cap, bool sym, bool dig, bool small, decimal len)
        {
            this.cap = cap;
            this.sym = sym;
            this.dig = dig;
            this.small = small;
            this.len = Convert.ToInt16(len);
        }

        public string FastGenerate()
        {
            string dic = "";
            string tmp = "";

            Random mran = new Random();

            string pass = "";
            
            if (this.sym) dic += "!@#$%^&*()";
            if (this.dig) dic += "0123456789";
            if (this.cap)
            {
                char nchar;
                    for (int i = 65; i < 91; i++)
                    {
                        nchar = (char)i;
                        tmp += Convert.ToString(nchar);
                    }
                    dic += tmp;
                }

                if (this.small)
                {
                    tmp = "";
                    char nchar;
                    for (int i = 97; i < 123; i++)
                    {
                        nchar = (char)i;
                        tmp += Convert.ToString(nchar);
                    }
                    dic += tmp;
                }

                for (int i = 0; i < len; i++)
                {
                    int index = Convert.ToUInt16(mran.NextDouble() * dic.Length) % dic.Length;
                    char ScharS = dic[index];
                    pass += Convert.ToString(ScharS);
                }
            return pass;
        }
    }
}
