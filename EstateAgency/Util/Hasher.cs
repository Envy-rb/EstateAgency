using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgency.Util
{
    class Hasher
    {
        public String hash(String data)
        {
            string result = "";
            MD5 hasher = MD5.Create();
            byte[] hash = hasher.ComputeHash(Encoding.UTF8.GetBytes(data));

            foreach (var b in hash)
            {
                result += b.ToString("x2");
            }

            return result;
        }
    }
}
