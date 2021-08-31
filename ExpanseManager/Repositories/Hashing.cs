using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExpanseManager.Repositories
{
    public class Hashing : IHashing
    {
        public string GetHash(string password)
        {
            var bytes = Encoding.UTF8.GetBytes(password);
            using (var hash = SHA512.Create())
            {
                var hashedBytes = hash.ComputeHash(bytes);

                var hashedStringBuilder = new StringBuilder(128);
                foreach (var b in hashedBytes)
                    hashedStringBuilder.Append(b.ToString("X2"));

                return hashedStringBuilder.ToString();
            }
        }
    }
}
