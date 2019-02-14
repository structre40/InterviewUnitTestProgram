using System;

namespace HelperClass
{
   /// <summary>
   /// Class for string extensions to be used throughout the products
   /// </summary>
   public static class StringHelper
   {
      /// <summary>
      /// Determines if the specified string contains only numeric characters
      /// </summary>
      /// <param name="s"></param>
      /// <returns></returns>
      public static bool IsNumeric(string s)
      {

         s = s.Trim();
         foreach (char c in s)
         {
            if (!char.IsDigit(c))
               return false;
         }
         return true;
      }
      
      /// <summary>
      /// Given a valid string value, attempts to parse to a short
      /// </summary>
      /// <param name="value">string value to convert to short/Int16</param>
      /// <returns></returns>
      public static short? ToInt16(string value)
      {
         //Guard clause
         if (string.IsNullOrWhiteSpace(value))
         {
            return null;
         }

         return short.Parse(value);
      }

      /// <summary>
      /// Sets fixed length on the string based on the length parameter
      /// If the string is null or empty a blank string of the length parameter is returned
      /// If the string length is larger than the length parameter, the shortened string will be returned based on the length parameter
      /// In all other scenarios(string length is smaller than the length parameter), space will be added to the end of the string until it is the length of the length parameter
      /// </summary>
      /// <param name="value">Original string that needs to be fixed length</param>
      /// <param name="length">The total length the original string should be when returned</param>
      /// <returns>string of fixed length</returns>
      public static string ToFixedLength(string value, int length)
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
