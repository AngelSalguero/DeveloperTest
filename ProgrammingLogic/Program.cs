using Newtonsoft.Json;
using ProgrammingLogic;
using ProgrammingLogic.Util;
using System.Text.Json.Serialization;

#region exercise_01
Console.WriteLine("This are the scenarios for the FizzBuzz function on the class 1\n\n");
Console.WriteLine($"With input 3 function return: [{string.Join(" , ", _01.fizzBuzz(3))}]");
//should output: ["1" , "2" , "Fizz"]


Console.WriteLine($"With input 10 function return: [{string.Join(" , ", _01.fizzBuzz(10))}]");
//should output: ["1" , "2" , "Fizz" , "4" , "Buzz" , "Fizz" , "7" , "8" , "Fizz" , "Buzz"]


Console.WriteLine($"With input 20 function return: [{string.Join(" , ", _01.fizzBuzz(20))}]");
//should output: ["1" , "2" , "Fizz" , "4" , "Buzz" , "Fizz" , "7" , "8" , "Fizz" , "Buzz" , "11" , "Fizz" , "13" , "14" , "FizzBuzz" , "16" , "17" , "Fizz" , "19" , "Buzz"]


Console.WriteLine($"With input -2 function return: [{string.Join(" , ", _01.fizzBuzz(-2))}]");
//should output: []

#endregion
#region exercise_02
Console.WriteLine("\n\n*************************************************************************");
Console.WriteLine("This are the scenarios for the getUserByGuid function on the class 2\n\n");
_02 exercise = new _02();

Console.WriteLine(JsonConvert.SerializeObject(exercise.getUserByGuid(default)));
//Should output: [{"name":"John Doe","email":"John@doe.com","birthDate":"1997-02-15T00:00:00","id":"00000000-0000-0000-0000-000000000000"}]

Console.WriteLine(JsonConvert.SerializeObject(exercise.getUserByGuid( new Guid())));
//Should output: []

#endregion

#region MiguelNotes
/*
    - I created the folder Models to use a POO structure and SOLID principles for the first exercise.
    - Since the exercises said that the logic should be in the method, that's what I did for the second one.
    - On the second exercise, I added a debugging line to see which ID was being searched since the outcome was not as expected.
    - The output of the second exercise is not the same as the one in the example, because the first parameter that it is receiving is empty and the second one is the default.
    - The default Guid is "0000...", so it will match all users in the list, since the id for all of them is that one. The way to fix it is to use "Guid.NewGuid()" instead of "new Guid()"
*/
#endregion
