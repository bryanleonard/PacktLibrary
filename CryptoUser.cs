using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.Crypto
{
    public class CryptoUser
    {
        public string Name { get; set; }
        public string Salt { get; set; }
        public string SaltedHashedPassword { get; set; }
    }
}
