namespace Laba4Tests
{
    public class UnitTest1
    {
        [Fact]
        public void InitPeopleFromStream_InitsRight()
        {
            //arrange
            List<Person> expected = new List<Person>()
            {
                new Person()
                {
                    Id = Guid.Parse("e1ed8d1a-9a22-4d56-b3a0-b9eb87c33a58"),
                    Name = "Karina",
                    SurName = "Kolodov",
                    Age = 42,
                    Birthday = DateTime.Parse("1981-08-12"),
                    IsAdmin = false
                },
                new Person()
                {
                    Id = Guid.Parse("e1ed8d1a-9a22-4d56-b3a0-b9eb87c33a58"),
                    Name = "Karina",
                    SurName = "Kolodov",
                    Age = 42,
                    Birthday = DateTime.Parse("1981-08-12"),
                    IsAdmin = false
                },
                new Person()
                {
                    Id = Guid.Parse("e1ed8d1a-9a22-4d56-b3a0-b9eb87c33a58"),
                    Name = "Karina",
                    SurName = "Kolodov",
                    Age = 42,
                    Birthday = DateTime.Parse("1981-08-12"),
                    IsAdmin = false
                },
            };

            List<Person> actual = new List<Person>();

            MemoryStream stream = new MemoryStream();

            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine("e1ed8d1a-9a22-4d56-b3a0-b9eb87c33a58\r\nKarina\r\nKolodov\r\n42\r\n1981-08-12\r\nfalse");
            writer.WriteLine("e1ed8d1a-9a22-4d56-b3a0-b9eb87c33a58\r\nKarina\r\nKolodov\r\n42\r\n1981-08-12\r\nfalse");
            writer.WriteLine("e1ed8d1a-9a22-4d56-b3a0-b9eb87c33a58\r\nKarina\r\nKolodov\r\n42\r\n1981-08-12\r\nfalse");
            writer.Flush();


            stream.Seek(0, SeekOrigin.Begin);

            //act
            lab4.Program.InitPeopleFromStream(actual, stream);

            //assert

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AsD()
        {
            //arrange
            List<Person> list = new List<Person>()
            {
                new Person()
                {
                    Id = Guid.Parse("e1ed8d1a-9a22-4d56-b3a0-b9eb87c33a58"),
                    Name = "Karina",
                    SurName = "Kolodov",
                    Age = 42,
                    Birthday = DateTime.Parse("1981-08-12"),
                    IsAdmin = false
                }
            };
            string expected = "12 августа: Karina Kolodov - исполнится 42";

            //act

            string actual = lab4.Program.FormBirthdayString(list[0]);

            //assert
            Assert.Equal(expected, actual);

        }
    }
}