using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 65, -34 };
            int[] newArr = new int[7];

           
            Array.Resize(ref numbers, numbers.Length+1);
            numbers[5] = 45;


            //numbers.CopyTo(newArr, 2);

            Array.Copy(numbers, 1, newArr, 2, 3);


            Array.Sort(numbers);
            Array.Reverse(numbers);


            int[] newNumbers = { 3, 5, 14, 3, 60 };

            var index = Array.IndexOf(newNumbers, 3);
            index = Array.LastIndexOf(newNumbers, 33);

            Console.WriteLine("index:"+index);

            string word = "Hello, World";
            var charIndex =  word.LastIndexOf('o');
            Console.WriteLine("charIndex:"+charIndex);

            var newWord = word.Substring(0,word.IndexOf(','));
            newWord = word.Substring(word.IndexOf(',')+1);


            Console.WriteLine("word: "+word);
            Console.WriteLine(word.Contains("lo"));
            Console.WriteLine(word.EndsWith("Hello"));


            word = "   Hello, World   ";
            word = word.Trim();
            word = word.TrimStart();

            word = word.ToUpper();
            Console.WriteLine(word);
            word = word.ToLower();
            Console.WriteLine(word);

            string sentence = "alma,armud,sefteli,kivi";
            var wordArr = sentence.Split(',');

            Console.WriteLine("Meyveler:");
            foreach (var item in wordArr)
            {
                Console.WriteLine(item);
            }

            var newSentence = String.Join("-", wordArr);
            Console.WriteLine("new sentence: "+newSentence);

            var letter = 'a';

            Console.WriteLine(Char.IsDigit(letter));
            letter = Char.ToUpper(letter);
            Console.WriteLine("letter: "+letter);

            string numStr = "1a23";
            int newNum;
            int.TryParse(numStr, out newNum);
            
            Console.WriteLine("new num:"+newNum);


            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }


          
            int num;
            bool check;
            do
            {
                Console.WriteLine("Eded daxil edin:");
                string str = Console.ReadLine();
                check = TryParse(out num, str);

            } while (check == false);

            Console.WriteLine($"eded: {num}");

        }

        static bool TryParse(out int num,string str)
        {
            try
            {
                num = Convert.ToInt32(str);
                return true;
            }
            catch (Exception)
            {
                num = 0;
                return false;
            }
        }
    }
}
