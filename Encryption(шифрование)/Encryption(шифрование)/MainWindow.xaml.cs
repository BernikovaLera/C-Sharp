using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Security.Cryptography;

namespace Encryption_шифрование_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void encryption1(object sender, RoutedEventArgs e)
        {
            string originalString = TextBox1.Text;
            byte[] originalBytes = Encoding.Unicode.GetBytes(originalString);

            TextEncryptor textEncryptor = new TextEncryptor();
            byte[] encryptedBytes = textEncryptor.TextEncryption(originalBytes);
            byte[] decryptedBytes = textEncryptor.TextDecryption(encryptedBytes);

            String encryptedString = Encoding.Unicode.GetString(encryptedBytes);
            //Encoding.GetEncoding(1251);
            TextBox2.Text = encryptedString;
        }

        private void decryption1(object sender, RoutedEventArgs e)
        {
            string originalString = TextBox1.Text;
            byte[] originalBytes = Encoding.Unicode.GetBytes(originalString);

            TextEncryptor textEncryptor = new TextEncryptor();
            byte[] encryptedBytes = textEncryptor.TextEncryption(originalBytes);
            byte[] decryptedBytes = textEncryptor.TextDecryption(encryptedBytes);

            String decryptedString = Encoding.Unicode.GetString(decryptedBytes);

            TextBox2_Copy.Text = decryptedString;
        }
    }
}

//        private void Button_Click(object sender, RoutedEventArgs e)
//        {

//            string original;
//            original = TextBox1.Text;
//            // Create a new instance of the Rijndael
//            // class.  This generates a new key and initialization
//            // vector (IV).
//            using (Rijndael myRijndael = Rijndael.Create())
//            {
//                // Encrypt the string to an array of bytes.
//                byte[] encrypted = EncryptStringToBytes(original, myRijndael.Key, myRijndael.IV);

//                // Decrypt the bytes to a string.
//                string roundtrip = DecryptStringFromBytes(encrypted, myRijndael.Key, myRijndael.IV);

//                //Display the original data and the decrypted data.
//                //Display the original data and the decrypted data.
//                TextBox2.Text = original;
//                //TextBox2.Text= roundtrip;
//            }
//        }
//        static byte[] EncryptStringToBytes(string plainText, byte[] Key, byte[] IV)
//        {
//            // Check arguments.
//            if (plainText == null || plainText.Length <= 0)
//                throw new ArgumentNullException("plainText");
//            if (Key == null || Key.Length <= 0)
//                throw new ArgumentNullException("Key");
//            if (IV == null || IV.Length <= 0)
//                throw new ArgumentNullException("IV");
//            byte[] encrypted;
//            // Create an Rijndael object
//            // with the specified key and IV.
//            using (Rijndael rijAlg = Rijndael.Create())
//            {
//                rijAlg.Key = Key;
//                rijAlg.IV = IV;

//                // Create an encryptor to perform the stream transform.
//                ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);

//                // Create the streams used for encryption.
//                using (MemoryStream msEncrypt = new MemoryStream())
//                {
//                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
//                    {
//                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
//                        {

//                            //Write all data to the stream.
//                            swEncrypt.Write(plainText);
//                        }
//                        encrypted = msEncrypt.ToArray();
//                    }
//                }
//            }

//            // Return the encrypted bytes from the memory stream.
//            return encrypted;
//        }
//        static string DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV)
//        {
//            // Check arguments.
//            if (cipherText == null || cipherText.Length <= 0)
//                throw new ArgumentNullException("cipherText");
//            if (Key == null || Key.Length <= 0)
//                throw new ArgumentNullException("Key");
//            if (IV == null || IV.Length <= 0)
//                throw new ArgumentNullException("IV");

//            // Declare the string used to hold
//            // the decrypted text.
//            string plaintext = null;

//            // Create an Rijndael object
//            // with the specified key and IV.
//            using (Rijndael rijAlg = Rijndael.Create())
//            {
//                rijAlg.Key = Key;
//                rijAlg.IV = IV;

//                // Create a decryptor to perform the stream transform.
//                ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);

//                // Create the streams used for decryption.
//                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
//                {
//                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
//                    {
//                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
//                        {

//                            // Read the decrypted bytes from the decrypting stream
//                            // and place them in a string.
//                            plaintext = srDecrypt.ReadToEnd();
//                        }
//                    }
//                }
//            }
//            return plaintext;
//        }
     
//        private void Button_Click_1(object sender, RoutedEventArgs e)
//        {
//            string original;
//            original = TextBox1.Text;
//            // Create a new instance of the Rijndael
//            // class.  This generates a new key and initialization
//            // vector (IV).
//            using (Rijndael myRijndael = Rijndael.Create())
//            {
//                // Encrypt the string to an array of bytes.
//                byte[] encrypted = EncryptStringToBytes(original, myRijndael.Key, myRijndael.IV);

//                // Decrypt the bytes to a string.
//                string roundtrip = DecryptStringFromBytes(encrypted, myRijndael.Key, myRijndael.IV);

//                //Display the original data and the decrypted data.
//                //Display the original data and the decrypted data.
//                //TextBox2.Text = original;
//                TextBox2_Copy.Text = roundtrip;
//            }
//        }


//    }
//}
