using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TeknoBideTPV.Data;
using TeknoBideTPV.Domain;

namespace TeknoBideTPV.Services
{
    public class LoginController
    {
        public bool loginEgin(string erabiltzaile_izena, string pasahitza)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                var Langilea = session.Query<Langilea>()
                    .FirstOrDefault(u => u.Erabiltzaile_izena == erabiltzaile_izena);

                if (Langilea == null)
                return false;

                
                string pasahitzaHash = pasahitzaHasheatu(pasahitza);

                return Langilea.Pasahitza == pasahitzaHash;
            }
        }

        private string pasahitzaHasheatu(string input)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }

    }
}
