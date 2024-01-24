using System;
using System.Text;
using System.Security.Cryptography;

namespace EVEOnline.Esi.Communication.Utilities.Hashing
{
    internal class Sha256Hashing : IHashing
    {
        public string GenerateHash(string value)
        {
            using (var hash = SHA256.Create())
            {
                return Convert.ToHexString(hash.ComputeHash(Encoding.UTF8.GetBytes(value)));
            }
        }
    }
}
