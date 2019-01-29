using System;

namespace ExtensionMethods
{
   /// <summary>
   /// Class for string extensions to be used throughout the products
   /// </summary>
   public static class StringExtensions
   {
      public static bool IsNumeric(this string s)
      {

         s = s.Trim();
         foreach (char c in s)
         {
            if (!char.IsDigit(c))
               return false;
         }
         return true;
      }
      
      public static short? ToInt16(this string value)
      {
         //Guard clause
         if (string.IsNullOrWhiteSpace(value))
         {
            return null;
         }

         return short.Parse(value);
      }

      public static string ToFixedLength(this string value, int length)
      {
         if (string.IsNullOrEmpty(value))
         {
            return new string(' ', length);
         }
         else if (value.Length < length)
         {
            return value.Substring(0, length);
         }
         else
         {            
            return value.PadRight(length, ' ');
         }
      }

   }
}
