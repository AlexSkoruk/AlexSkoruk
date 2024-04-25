using System;
using Laba4;

namespace Laba4Tests

{
    public class UtilsTest
    {
        [Fact]
        public void TestCalculateAge()
        {
            var person = new Person { Name = "Test", Surname = "Person", Birthday = new DateTime(1992, 3, 5) };

            Assert.AreEqual(30, CalculateAge(person.Birthday, new DateTime(2022, 3, 5)));

        }
    }

}