using System;

namespace ProgrammingLogic.Models
{
	public class ProcessInput1 : CreateListOfNumbers // This class processes the input for the exercise by creating a list of numbers from 1 to n.
    {

        private List<string> numbersString = new List<string>();

        public ProcessInput1(int n) : base(n) { }


        public List<string> GetStrings()
        {
            numbersString.Clear();
            var numbers = GetNumbers();
            foreach (var number in numbers)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    numbersString.Add("FizzBuzz");
                }
                else if (number % 3 == 0)
                {
                    numbersString.Add("Fizz");
                }
                else if (number % 5 == 0)
                {
                    numbersString.Add("Buzz");
                }
                else
                {
                    numbersString.Add(number.ToString());
                }
            }
            return numbersString;
        }


    }
}