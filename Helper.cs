using System.Text;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;
public class Helper : GenericSingleton<Helper>
{
    
    public string GenerateID(int length)
    {
        if (length <= 0)
        {
            return "error: length < 0";
        }
        else
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder strb = new StringBuilder(length);
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                strb.Append(chars[random.Next(chars.Length)]);
            }
            string result = strb.ToString();
            return result;
        }
    }
    
}