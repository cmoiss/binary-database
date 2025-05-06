using System.Security.Cryptography;

namespace binary_database.service
{
    internal static class RandomHexGeneratorHelpers
    {
        public static int GenerateRandomHex(int length)
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

            return Convert.ToInt32(hexString.ToLower());
        }
    }
}