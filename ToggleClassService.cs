using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToggleCharacter
{
    public class ToggleClassService
    {
        /// <summary>
        /// This method is Used to Toggle character
        /// </summary>
        /// <param name="input">Input string from User Console</param>
        /// <returns>Converted Toggle string from input string </returns>
        public string ToggleCase(string input)         
        {
            if (!string.IsNullOrEmpty(input))
            {
                // Initialize variable
                string result = string.Empty;
                // Array to store all charcater
                char[] inputArray = input.ToCharArray();

                // Loop each character from the input string
                foreach (char c in inputArray)
                {
                    // Check if the character is lower then convert to Upper
                    if (char.IsLower(c))
                    {
                        result += char.ToUpper(c);

                    }
                    // Check if the character is Upper then convert to lower
                    else
                    {
                        result += char.ToLower(c);
                    }

                }

                return result;
            }
            else
            {
                return "String is Empty. Kindly enter some text";
            }

        }
    }
}
