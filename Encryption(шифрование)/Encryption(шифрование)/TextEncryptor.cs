using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace Encryption_шифрование_
{
    public class TextEncryptor
    {
        /// <summary>
        /// приватные поля класса
        /// </summary>
        private AesManaged algorithm = new AesManaged();
        private byte[] rgbKey;
        private byte[] rgbSalt;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public TextEncryptor()
        {
            string str = "qwertyuiop";
            string salt = "asdfghjkl";
            var rgb = new Rfc2898DeriveBytes(str, Encoding.Unicode.GetBytes(salt));
            rgbKey = rgb.GetBytes(algorithm.KeySize / 8);
            rgbSalt = rgb.GetBytes(algorithm.BlockSize / 8);
        }

        /// <summary>
        /// Конструктр с параметрами
        /// </summary>
        /// <param name=str></param>
        /// <param name=salt></param>
        public TextEncryptor(string str, string salt)
        {
            var rgb = new Rfc2898DeriveBytes(str, Encoding.Unicode.GetBytes(salt));
            rgbKey = rgb.GetBytes(algorithm.KeySize / 8);
            rgbSalt = rgb.GetBytes(algorithm.BlockSize / 8);
        }

        /// <summary>
        /// Метод шифрования строки
        /// </summary>
        /// <param name=bytesToEncrypt></param>
        /// <returns></returns>
        public byte[] TextEncryption(byte[] bytesToEncrypt)
        {
            byte[] encryptedBytes;
            using (MemoryStream buffer = new MemoryStream())
            {
                var algorithmEncryptor = algorithm.CreateEncryptor(rgbKey, rgbSalt);
                var cryptoStream = new CryptoStream(buffer, algorithmEncryptor, CryptoStreamMode.Write);
                cryptoStream.Write(bytesToEncrypt, 0, bytesToEncrypt.Length);
                cryptoStream.FlushFinalBlock();
                encryptedBytes = buffer.ToArray();
                cryptoStream.Close();
                buffer.Close();
            }
            return encryptedBytes;
        }

        /// <summary>
        /// Метод дешифрвания строки
        /// </summary>
        /// <param name=bytesToDecrypt></param>
        /// <returns></returns>
        public byte[] TextDecryption(byte[] bytesToDecrypt)
        {
            byte[] decryptedBytes;
            using (MemoryStream buffer = new MemoryStream())
            {
                var algorithmDecryptor = algorithm.CreateDecryptor(rgbKey, rgbSalt);
                var cryptoStream = new CryptoStream(buffer, algorithmDecryptor, CryptoStreamMode.Write);
                cryptoStream.Write(bytesToDecrypt, 0, bytesToDecrypt.Length);
                cryptoStream.FlushFinalBlock();
                decryptedBytes = buffer.ToArray();
                cryptoStream.Close();
                buffer.Close();
            }
            return decryptedBytes;
        }
    }
}
