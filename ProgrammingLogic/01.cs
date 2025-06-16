using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgrammingLogic.Models;

namespace ProgrammingLogic
{
    public class _01
    {
    /*
     The task is to build the logic within the fizzBuzz method that returns an array of strings
     that contains the following info:
     
     for a given an integer n, for every positive integer i <= n, add to the array

        * “FizzBuzz” if i is divisible by 3 and 5,
        * “Fizz” if i is divisible by 3,
        * “Buzz” if i is divisible by 5
        * “i” as a string, if none of the conditions are true.
        
        For example:
            Input: n = 3
            Output: [“1”, “2”, “Fizz”]

            Input: n = 10
            Output: [“1”, “2”, “Fizz”, “4”, “Buzz”, “Fizz”, “7”, “8”, “Fizz”, “Buzz”]
        
     */

        public static string[] fizzBuzz(int n)
        {
            InputExercise1 input = new InputExercise1(n);
            ProcessInput1 process = new ProcessInput1(input.GetN());
            return process.GetStrings().ToArray();
        }
    }
}
