using System;
using System.Security.Cryptography;
using System.Text;

public class HashHelper
{
    public static string ComputeMD5Hash(string input)
    {
        using (MD5 md5 = MD5.Create())
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input); // String -> byte[]
            byte[] hashBytes = md5.ComputeHash(inputBytes);    // MD5 hesaplama

            // byte[] -> hex string
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hashBytes)
            {
                sb.Append(b.ToString("x2")); // Hex formatında ekleme
            }

            return sb.ToString();
        }
    }
}
