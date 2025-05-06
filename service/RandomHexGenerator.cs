using System.Security.Cryptography;

namespace binary_database.service
{
    public class RandomHexGenerator
    {
        public static string GenerateRandomHex(int length)
        {
            // Cada byte representa 2 caracteres hexadecimais
            byte[] randomBytes = new byte[length / 2];

            // Usando RandomNumberGenerator para maior segurança/aleatoriedade
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomBytes);
            }

            // Convertendo para string hexadecimal
            string hexString = BitConverter.ToString(randomBytes).Replace("-", "");

            // Se o comprimento for ímpar, ajustamos
            if (length % 2 != 0)
            {
                hexString = hexString.Substring(0, length);
            }

            return hexString.ToLower();
        }
    }
}