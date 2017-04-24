using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LINQquestions
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1
            //var words = new List<string>() { "hello", "apple", "turtle", "turtle", "pear" };
            //IEnumerable<string> Words = words.Distinct();
            //var alphabeticallyOrderedWords = Words.OrderBy(w => w).ToList();
            //foreach(var word in alphabeticallyOrderedWords)
            //{
            //    Console.WriteLine(word);
            //}

            ////2
            //var grades = new List<string>()
            //{
            //    { "90, 60, 45, 85, 85, 90" },
            //    { "72, 49, 55, 84, 86, 99" },
            //    { "80, 69, 40, 76, 75, 90" },
            //};
            //var averages = new List<double>();
            //for(int i = 0; i < grades.Count; i++)
            //{
            //    var individualStudent = new List<int>();
            //    Regex regex = new Regex(", ");
            //    string[] subGrades = regex.Split(grades[i]);
            //    foreach (var grade in subGrades)
            //    {
            //        int intGrade = int.Parse(grade);
            //        individualStudent.Add(intGrade);
            //    }
            //    int min = individualStudent.Min();
            //    individualStudent.Remove(min);
            //    double average = individualStudent.Average();
            //    Console.WriteLine("Student's Average: " + average);
            //    averages.Add(average);
            //}
            //double classAverage = averages.Average();
            //Console.WriteLine("Class Average: " + Math.Round(classAverage, 2));

            //3
            var word = new List<string>() { "Llewellyn" };
            Regex rgx = new Regex("");
            var subString = rgx.Split(word[0].ToLower());
            var newWord = subString.OrderBy(l => l).ToList();
            var query = newWord.AsQueryable().GroupBy(l => l);
            foreach (var letter in query)
            {
                if (!letter.Key.Equals(""))
                {
                    Console.WriteLine($"{letter.Key} {letter.Count()}");
                }
            }

            //4
        }
    }
}
