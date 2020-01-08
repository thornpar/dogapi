using System;

namespace DogAPI.Data
{
    public class Dog
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string BestSkill { get; set; }
        public Guid Id { get; set; }
    }
}