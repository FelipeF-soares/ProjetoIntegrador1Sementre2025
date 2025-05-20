using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Infrastructure.EmailService;

public static class CryptoService
{
   
    public static string Encrypt(string password)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(GenerateKey.RecoveryKeysByName("key"));
            aes.IV = Encoding.UTF8.GetBytes(GenerateKey.RecoveryKeysByName("iv"));

            ICryptoTransform crypto = aes.CreateEncryptor(aes.Key, aes.IV);

            using MemoryStream memoryStream = new MemoryStream();
            using CryptoStream cryptoStream = new CryptoStream(memoryStream, crypto, CryptoStreamMode.Write);
            using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
            {
                streamWriter.Write(password);
            }

            return Convert.ToBase64String(memoryStream.ToArray());
        }
    }

    public static string Decrypt(string passwordEncrypt)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(GenerateKey.RecoveryKeysByName("key"));
            aes.IV = Encoding.UTF8.GetBytes(GenerateKey.RecoveryKeysByName("iv"));

            ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

            using MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(passwordEncrypt));
            using CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            using StreamReader streamReader = new StreamReader(cryptoStream);

            return streamReader.ReadToEnd();
        }
    }
}
