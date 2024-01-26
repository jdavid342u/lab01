using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    public class Relation
    {
        private string RelationshipType { get; set; }

        public Relation(string RelationshipType) {
            this.RelationshipType = RelationshipType;
        }

        public void ShowRelationship(Person p1, Person p2) {
            Console.WriteLine($"Relationship between {p1.firstName} and {p2.firstName} is {this.RelationshipType}");
        }
    }
}
