using System;

namespace ProgrammingLogic.Models
{
	public class CreateListOfNumbers // This class is used to create a list of numbers from 1 to n.
    {

        private int n;
        private List<int> numbers = new List<int>();

        public CreateListOfNumbers(int n)
        {
            this.n = n;
        }

        public List<int> GetNumbers()
        {
            numbers.Clear();
            for (int i = 1; i <= n; i++)
            {
                numbers.Add(i);
            }
            return numbers;
        }


    }
}