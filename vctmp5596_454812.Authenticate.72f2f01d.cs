using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Epsilon
{
    class Authenticate
    {
        private static int OFFSET = 25;

        public string Encrypt (string input)
        {
            byte[] asciivalues = Encoding.ASCII.GetBytes(input);
            for (int i = 0; i < asciivalues.Length; i++)
            {
                asciivalues[i] += (byte)OFFSET;
                while (asciivalues[i] > 122)
                {
                    asciivalues[i] -= 90;
                }
            }
            return Encoding.ASCII.GetString(asciivalues);
        }
    }
}
