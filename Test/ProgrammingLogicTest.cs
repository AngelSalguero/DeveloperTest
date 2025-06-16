using Newtonsoft.Json;
using ProgrammingLogic;
using ProgrammingLogic.Util;

namespace Test
{
    [TestClass]
    public sealed class ProgrammingLogicTest
    {

        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [TestMethod]
        public void _01TestCases(int test)
        {
            //Arrange
            IDictionary<int, string[]> cases = new Dictionary<int, string[]>(){
                { 3, new string[]{ "1","2","Fizz"} },
                { 10, new string[]{ "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz"} },
                { 20, new string[]{ "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz",  "11", "Fizz", "13", "14", "FizzBuzz", "16", "17", "Fizz", "19", "Buzz"} },
                { -2, new string[0]},
            };
            //Act
            string[] result = _01.fizzBuzz(cases.ElementAt(test).Key);

            //Assert
            Assert.IsTrue(cases.ElementAt(test).Value.SequenceEqual(result), $"The expected value is [{string.Join(" , ", cases.ElementAt(test).Value)}] but the function returned [{string.Join(" , ", result)}]");
        }
        [DataRow(0)]
        [DataRow(1)]
        [TestMethod]
        public void _02TestCases(int test)
        {
            //Arrange
            IDictionary<Guid, List<User>> cases = new Dictionary<Guid, List<User>>() {
                {default, new List<User>() {new User() { name = "John Doe", email = "John@doe.com", birthDate = new DateTime(1997, 2, 15), id = default } } },
                { Guid.NewGuid(), new List<User>()}
            };
            _02 exercise = new _02();

            //Act
            List<User> result = exercise.getUserByGuid(cases.ElementAt(test).Key);


            //Assert
            Assert.IsTrue((JsonConvert.SerializeObject(result) == JsonConvert.SerializeObject(cases.ElementAt(test).Value)), $"The expected result is {JsonConvert.SerializeObject(cases.ElementAt(test).Value)} but function returned {JsonConvert.SerializeObject(result)}");
        }

    }
}
