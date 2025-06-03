using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ugyfel
{
    internal class hash
    {
        public static string KeszitHash(string jelszo)
        {
            string kodolt="";
            byte[] salt=new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
                byte[] jelszoByte = Encoding.UTF8.GetBytes(jelszo);
                byte[] Combined = new byte[salt.Length+jelszoByte.Length];
                Buffer.BlockCopy(salt,0,Combined,0, salt.Length);
                Buffer.BlockCopy(jelszoByte,0,Combined,salt.Length,jelszoByte.Length);
            }
            return  kodolt;
        }
    }
}
