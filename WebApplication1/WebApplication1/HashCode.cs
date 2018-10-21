using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace WebApplication1
{
    public class HashCode
    {
        public static string MD5hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            if (input != null)
            {
                MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
                byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

                for (int i = 0; i < bytes.Length; i++)
                {
                    hash.Append(bytes[i].ToString("x2"));
                }
            }
            return hash.ToString();
        }

        public static string MD5hash(Stream stream)
        {
            StringBuilder hash = new StringBuilder();
            if (stream != null)
            {
                MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
                byte[] bytes = md5provider.ComputeHash(stream);

                for (int i = 0; i < bytes.Length; i++)
                {
                    hash.Append(bytes[i].ToString("x2"));
                }
                stream.Seek(0, SeekOrigin.Begin);
            }
            return hash.ToString();
        }
    }
}
