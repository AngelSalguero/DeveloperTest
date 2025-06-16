using System;

namespace ProgrammingLogic.Models
{
	public class InputExercise1 // This class is used to validate the input for the exercise. This will be used by ProcessInput1 to finilize the exercise.
    {

        private int n;

        public InputExercise1(int n)
        {
            if (n > 0)
            {
                this.n = n;
            }
            else
            {
                this.n = 0;
                Console.WriteLine("Value of n must be positive.");
            }
        }

        public int GetN()
        {
            return n;
        }

        
	}
}