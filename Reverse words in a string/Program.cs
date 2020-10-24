using System;

namespace Reverse_words_in_a_string
{
    class Program
    {
        static void Main(string[] args)
        {
            //   hello world  
            // 
            // 
            // 
            //
            string s = "  hello world  "; 
            string reversedstring = ReverseWords(s);
            Console.WriteLine(reversedstring);
        }

        static string ReverseWords(string s)
        {
            char[] arr = s.ToCharArray();
            int length = s.Length;
            int wordCount = 0;
            int i = 0, j = 0, l = 0;
            while (true)
            {
                while (i< length &&  s[i] == ' ') i++; // skip spaces from front
                if (i == length) break;
                if (wordCount > 0) arr[j++] = ' ';
                l = j;
                while (i< length  && s[i] != ' ')
                {
                    arr[j++] = arr[i++];
                }
                ReverseWord(arr, l, j - 1);
                wordCount++;
            }

            ReverseWord(arr, 0, j - 1);
            return string.Join("", arr);
        }

        static void ReverseWord(char[] arr, int left, int right)
        {
            while (left < right)
            {
                char temp = arr[left];
                arr[left++] = arr[right];
                arr[right--] = temp;
            }
        }
    }
}
