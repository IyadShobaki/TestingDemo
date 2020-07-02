using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;
using DemoLibrary.Models;
using Xunit;

namespace DemoLibrary.Tests
{
    public class DataAccessTests
    {
        [Fact]
        public void AddPersonToPeopleList_ShouldWork()
        {
            PersonModel newPerson = new PersonModel { FirstName = "Iyad",LastName = "Shobaki" };
            List<PersonModel> people = new List<PersonModel>();

            DataAccess.AddPersonToPeopleList(people, newPerson);

            Assert.True(people.Count == 1);
            Assert.Contains<PersonModel>(newPerson, people);
        }
        [Theory]
        [InlineData("Iyad", "", "LastName")]
        [InlineData("", "Shobaki", "FirstName")]
        public void AddPersonToPeopleList_ShouldFail(string firstName, string lastName, string param)
        {
            PersonModel newPerson = new PersonModel { FirstName = firstName, LastName = lastName };
            List<PersonModel> people = new List<PersonModel>();

            Assert.Throws<ArgumentException>(param, () => DataAccess.AddPersonToPeopleList(people, newPerson));
        }

        [Theory]
        [InlineData("Iyad","Shobaki", "Iyad,Shobaki")]
        [InlineData("Tim", "Corey", "Tim,Corey")]
        public void ConvertModelToCSV_ShouldWork(string firstName, string lastName, string param)
        {
            PersonModel newPerson = new PersonModel { FirstName = firstName, LastName = lastName };
            List<PersonModel> people = new List<PersonModel>();
            people.Add(newPerson);

            List<string> actual = DataAccess.ConvertModelToCSV(people);

            Assert.Equal(param, actual[0].ToString());
        }
        [Theory]
        [InlineData("Iyad,Shobaki", "Iyad", "Shobaki")]
        [InlineData("Tim,Corey", "Tim", "Corey")]
        public void ConvertCSVToModel_ShouldWork(string line, string firstName, string lastName)
        {
            string[] content = new string[]{ line };
            List<PersonModel> people = new List<PersonModel>();

            DataAccess.ConvertCSVToModel(content, people);

            PersonModel expected = new PersonModel { FirstName = firstName, LastName = lastName };

            Assert.Equal(expected.ToString(), (people[0]).ToString());
     
        }
    }
}
