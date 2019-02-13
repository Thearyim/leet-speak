namespace LeetSpeak
{
    public class LeetSpeak
    {
        public string GetLeetSpeak(string word)
        {
            //uses an alternative alphabet of numbers 
            //and symbols to replace various letters in 
            //words using the following rules:
            //"e" should be replaced with "3
            //"o" should be replaced with "0"
            //Capital (not the lowercase "I"
            //should be replaced with "1"
            //"t" should be replaced with "7"
            //"s" should be replaced with "z",
            //unless it is the first letter of a word
            
            //reference: https://docs.microsoft.com/en-us/dotnet/api/system.string?view=netframework-4.7.2
            

            // public string Replace (char oldChar, char newChar);

            string[] input = new string[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];

                if (letter == 's' && i != 0)
                {
                    input[i] = "z";
                }
                else if (letter == 'e')
                {
                    input[i] = "3";
                }
                else if (letter == 'o')
                {
                    input[i] = "0";
                }
                else if (letter == 'I')
                {
                    input[i] = "1";
                }
                else if (letter == 't')
                {
                    input[i] = "7";
                }
               
                else 
                {
                    input[i] = letter.ToString();
                }
            }

            return string.Join("", input);
        }
    }
}