using System;
using System.Threading;

namespace SortingLibrary
{
    public class AnimateText
    {
        public static void Animate(string text, int delay = 100)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay); // ایجاد تأخیر بین نمایش هر حرف
            }
            Console.WriteLine();
        }
    }
}
