using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    public class Person
    {
        private int personId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string favoriteColor { get; set; }
        public int age { get; set; }
        private bool isWorking { get; set; }

        public Person(int personId, string firstName, string lastName, string favoriteColor, int age, bool isWorking) {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favoriteColor = favoriteColor;
            this.age = age;
            this.isWorking = isWorking;
        }

        public string DisplayPersonInfo() {
            return $"""
                Name = {this.firstName} {this.lastName}
                Person ID = {this.personId}
                Their favorite color is {this.favoriteColor}
                """;
        }
        public void ChangeFavoriteColor(string color) {
            this.favoriteColor = color;
        }
        public int GetAgeInTenYears() {
            return this.age + 10;
        }
        public override string ToString()
        {
            return $"""
                1. firstName = {this.firstName}
                2. lastName = {this.lastName}
                3. personId = {this.personId}
                4. favoriteColor = {this.favoriteColor}
                5. age = {this.age}
                6. isWorking = {this.isWorking}
                """;
        }
    }
}
