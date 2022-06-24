using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Cop4931Project
{
    // Citation of where most of my code came from.
    /*********************************************************
     * Title: Aes Class
     * Author: Microsoft
     * Date: 2021
     * Code Version: .NET Core 3.1
     * Availability: https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.aes?view=net-6.0
     * ******************************************************/
    /*********************************************************
   * Title: Use Visual C# to compute and compare hash values
   * Author: Microsoft
   * Date: 2021
   * Code Version: .NET Core 3.1
   * Availability: https://docs.microsoft.com/en-us/troubleshoot/dotnet/csharp/compute-hash-values
   * ******************************************************/
    /*********************************************************
    * Title: RSACryptoServiceProvider Class
    * Author: Microsoft
    * Date: 2021
    * Code Version: .NET Core 3.1
    * Availability: https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.rsacryptoserviceprovider?view=net-6.0
    * ******************************************************/
    /*********************************************************
    * Title: Cryptographic Signatures
    * Author: Microsoft
    * Date: 2021
    * Code Version: .NET Core 3.1
    * Availability: https://docs.microsoft.com/en-us/dotnet/standard/security/cryptographic-signatures
    * ******************************************************/
    public partial class Form1 : Form
    {
        byte[] encrypted;
        public Form1()
        {
            InitializeComponent();
            
        }

        static string ByteArrayToString(byte[] arrInput)
        {
            int i;
            StringBuilder sOutput = new StringBuilder(arrInput.Length);
            for (i = 0; i < arrInput.Length; i++)
            {
                sOutput.Append(arrInput[i].ToString("X2"));
            }
            return sOutput.ToString();
        }
        static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }

        static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Aes myAes = Aes.Create())
            {


                // Encrypt the string to an array of bytes.
                encrypted = EncryptStringToBytes_Aes(aesTextEncrpyt.Text, myAes.Key, myAes.IV);
                string roundtrip = DecryptStringFromBytes_Aes(encrypted, myAes.Key, myAes.IV);



                //Display the original data and the decrypted data.
                //       Console.WriteLine("Original:   {0}", original);
                //       Console.WriteLine("Round Trip: {0}", roundtrip);
           //     string s = System.Text.Encoding.UTF8.GetString(encrypted, 0, encrypted.Length);
                encryptedText.Text = ByteArrayToString(encrypted);
                decryptedTextAes.Text = roundtrip;


            }
        }
        public static byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                //Create a new instance of RSACryptoServiceProvider.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    //Import the RSA Key information. This needs
                    //to include the private key information.
                    RSA.ImportParameters(RSAKeyInfo);

                    //Decrypt the passed byte array and specify OAEP padding.  
                    //OAEP padding is only available on Microsoft Windows XP or
                    //later.  
                    decryptedData = RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
                }
                return decryptedData;
            }
            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());

                return null;
            }
        }
        public static byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                //Create a new instance of RSACryptoServiceProvider.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {

                    //Import the RSA Key information. This only needs
                    //toinclude the public key information.
                    RSA.ImportParameters(RSAKeyInfo);

                    //Encrypt the passed byte array and specify OAEP padding.  
                    //OAEP padding is only available on Microsoft Windows XP or
                    //later.  
                    encryptedData = RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
                }
                return encryptedData;
            }
            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return null;
            }
        }

        private void rsaEncrptyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Create a UnicodeEncoder to convert between byte array and string.
                UnicodeEncoding ByteConverter = new UnicodeEncoding();

                //Create byte arrays to hold original, encrypted, and decrypted data.
                byte[] dataToEncrypt = ByteConverter.GetBytes(rsaEncrpytBox.Text);
                byte[] encryptedData;
                byte[] decryptedData;

                //Create a new instance of RSACryptoServiceProvider to generate
                //public and private key data.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {

                    //Pass the data to ENCRYPT, the public key information 
                    //(using RSACryptoServiceProvider.ExportParameters(false),
                    //and a boolean flag specifying no OAEP padding.
                    encryptedData = RSAEncrypt(dataToEncrypt, RSA.ExportParameters(false), false);

                    //Pass the data to DECRYPT, the private key information 
                    //(using RSACryptoServiceProvider.ExportParameters(true),
                    //and a boolean flag specifying no OAEP padding.
                    decryptedData = RSADecrypt(encryptedData, RSA.ExportParameters(true), false);

                    //Display the decrypted plaintext to the console. 
               //     rsaEncryptedText.Text = System.Text.Encoding.UTF8.GetString(encryptedData, 0, encryptedData.Length);
                    rsaDecryptBox.Text = ByteConverter.GetString(decryptedData);
                    rsaEncryptedText.Text = ByteArrayToString(encryptedData);
                }
            }
            catch (ArgumentNullException)
            {
                //Catch this exception in case the encryption did
                //not succeed.
                Console.WriteLine("Encryption failed.");
            }
        }
        

        private void digitalSignatureBtn_Click(object sender, EventArgs e)
        {
            //The hash value to sign.
            byte[] hashValue = { 59, 4, 248, 102, 77, 97, 142, 201, 210, 12, 224, 93, 25, 41, 100, 197, 213, 134, 130, 135 };

            //The value to hold the signed value.
            byte[] signedHashValue;

            //Generate a public/private key pair.
            RSA rsa = RSA.Create();

            //Create an RSAPKCS1SignatureFormatter object and pass it the
            //RSA instance to transfer the private key.
            RSAPKCS1SignatureFormatter rsaFormatter = new RSAPKCS1SignatureFormatter(rsa);

            //Set the hash algorithm to SHA1.
            rsaFormatter.SetHashAlgorithm("SHA1");

            //Create a signature for hashValue and assign it to
            //signedHashValue.
            signedHashValue = rsaFormatter.CreateSignature(hashValue);
            //    signatureTextBox.Text = System.Text.Encoding.UTF8.GetString(signedHashValue, 0, signedHashValue.Length);
            signatureTextBox.Text = ByteArrayToString(signedHashValue);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            byte[] tmpSource;
            byte[] tmpHash;
            tmpSource = ASCIIEncoding.ASCII.GetBytes(hashValueToConvert.Text);
            tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            hashValueOutput.Text = ByteArrayToString(tmpHash);
        }
    }
}
