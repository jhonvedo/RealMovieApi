using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RealMovieApi.Utils
{
    public static class EncryptService
    {
        public static string Encrypt(string encryptString)
        {
            SHA1 sha1 = SHA1CryptoServiceProvider.Create();
            Byte[] textOriginal = ASCIIEncoding.Default.GetBytes(encryptString);
            Byte[] hash = sha1.ComputeHash(textOriginal);
            StringBuilder cadena = new StringBuilder();
            foreach (byte i in hash)
            {
                _= cadena.AppendFormat("{0:x2}", i);
            }
            return cadena.ToString();
        }
    }
}
