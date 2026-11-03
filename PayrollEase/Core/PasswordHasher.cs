using System;
using System.Security.Cryptography;

namespace PayrollEase
{
    /// <summary>PBKDF2 password hashing. Stored format: iterations:salt:hash (Base64).</summary>
    public static class PasswordHasher
    {
        private const int Iterations = 10000;

        public static string Hash(string password)
        {
            byte[] salt = new byte[16];
            using (var rng = new RNGCryptoServiceProvider()) rng.GetBytes(salt);
            byte[] hash;
            using (var kdf = new Rfc2898DeriveBytes(password ?? "", salt, Iterations)) hash = kdf.GetBytes(32);
            return Iterations + ":" + Convert.ToBase64String(salt) + ":" + Convert.ToBase64String(hash);
        }

        public static bool Verify(string password, string stored)
        {
            try
            {
                if (string.IsNullOrEmpty(stored)) return false;
                string[] parts = stored.Split(':');
                if (parts.Length != 3) return false;
                int iterations;
                if (!int.TryParse(parts[0], out iterations)) return false;
                byte[] salt = Convert.FromBase64String(parts[1]);
                byte[] expected = Convert.FromBase64String(parts[2]);
                byte[] actual;
                using (var kdf = new Rfc2898DeriveBytes(password ?? "", salt, iterations)) actual = kdf.GetBytes(expected.Length);
                int diff = 0;
                for (int i = 0; i < expected.Length; i++) diff |= expected[i] ^ actual[i];
                return diff == 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
