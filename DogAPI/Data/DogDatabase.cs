using System.Collections.Generic;

namespace DogAPI.Data
{
    public class DogDatabase
    {
        public IEnumerable<Dog> Dogs => new List<Dog>
        {
            new Dog{Name = "Lasse", Race = "German Sheperd", BestSkill = "Policing"},
            new Dog{Name = "Ronny", Race = "Golden Retriever", BestSkill = "Allways ready to eat the food you dont want"},
            new Dog{Name = "Pelle", Race = "Weimaraner", BestSkill = "Highly developed hunting instincts"}
        };
    }
}