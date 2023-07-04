using System;

namespace netFramework
{
    internal class Exercise_68
    {
        public static bool Assignment()
        {
            Console.WriteLine("Enter the numbers:");
            string input = Console.ReadLine();
            var splitInput = input.Trim().Split('-');

            for (int i = 1; i < splitInput.Length; i++)
            {
                var currentNum = int.Parse(splitInput[i]);
                var previousNum = int.Parse(splitInput[i - 1]);

                if (currentNum != previousNum + 1 && currentNum != previousNum - 1)
                {
                    return false;
                }
            }

            return true;
        }

        public static void Assignment2()
        { 
            Console.WriteLine("Enter Text for PascalCase");
            string input = Console.ReadLine();
            var splitInput = input.Trim().ToLower().Split(' ');
            var joinedop = "";
            for(int i = 0;i < splitInput.Length;i++)
            {
                var temp = splitInput[i];
                var Capitalized = char.ToUpper(temp[0])+temp.Substring(1);
                joinedop += Capitalized;
            }
            Console.WriteLine(joinedop);
        }
    }
}
