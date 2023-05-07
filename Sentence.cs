using System.Linq;

namespace Homework_10
{
    internal static class Sentence
    {
        public static string[] ToWords(string text)
        {
            text = SpaceCollapse(text.Trim());
            return text.Split(' ');
        }

        public static string Reverse(string text)
        {
            text = string.Join(" ", ToWords(text).Reverse());
            return UnpperFirst(text);
        }

        private static string UnpperFirst(string text)
        {
            if (text.Length == 0) return text;

            string lowText = text.ToLower();
            return char.ToUpper(lowText[0]) + lowText.Substring(1);
        }

        private static string SpaceCollapse(string text)
        {
            string result = string.Empty;
            bool lastSpace = false;

            for(int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    if (lastSpace) continue;
                    lastSpace = true;
                }
                else
                {
                    lastSpace = false;
                }

                result += text[i];
            }

            return result;
        }
    }
}
