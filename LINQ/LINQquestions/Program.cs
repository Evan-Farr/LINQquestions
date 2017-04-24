using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQquestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            var words = new List<string>() { "hello", "apple", "turtle", "turtle", "pear" };
            IEnumerable<string> Words = words.Distinct();
            var alphabeticallyOrderedWords = Words.OrderBy(w => w).ToList();
            foreach(var word in alphabeticallyOrderedWords)
            {
                Console.WriteLine(word);
            }

            //2

        }
    }
}
