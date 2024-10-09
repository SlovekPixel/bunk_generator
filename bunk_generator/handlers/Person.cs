using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using bunk_generator.enums;
using bunk_generator.interfaces;

namespace bunk_generator.handlers
{
    public class Person: IPerson
    {
        private readonly string _PERSONS_DIRECTORY = "persons";
        private readonly Random _random;
        public int Id { get; private set; }
        public string Gender { get; private set; }
        public string Age { get; private set; }
        public string Job { get; private set; }
        public bool Fertility { get; private set; }
        public string Health { get; private set; }
        public string Phobia { get; private set; }
        public string Hobby { get; private set; }
        public string Baggage { get; private set; }
        public string Fact1 { get; private set; }
        public string Fact2 { get; private set; }
        
        private static readonly Dictionary<CharacteristicType, string> CharacteristicMap = new Dictionary<CharacteristicType, string>
        {
            { CharacteristicType.Gender, "gender.json" },
            { CharacteristicType.Job, "profession.json" },
            { CharacteristicType.Age, "age.json" },
            { CharacteristicType.Fertility, "fertility.json" },
            { CharacteristicType.Health, "health.json" },
            { CharacteristicType.Phobia, "phobia.json" },
            { CharacteristicType.Hobby, "hobby.json" },
            { CharacteristicType.Baggage, "baggage.json" },
            { CharacteristicType.Fact1, "fact.json" },
            { CharacteristicType.Fact2, "fact.json" },
        };

        public Person(int i)
        {
            _random = new Random();
            Id = i;
            Gender = this.GenerateCharacteristic(CharacteristicType.Gender);
            Job = this.GenerateCharacteristic(CharacteristicType.Job);
            Age = this.GenerateCharacteristic(CharacteristicType.Age);
            Health = this.GenerateCharacteristic(CharacteristicType.Health);
            Phobia = this.GenerateCharacteristic(CharacteristicType.Phobia);
            Hobby = this.GenerateCharacteristic(CharacteristicType.Hobby);
            Baggage = this.GenerateCharacteristic(CharacteristicType.Baggage);
            Fact1 = this.GenerateCharacteristic(CharacteristicType.Fact1);
            Fact2 = this.GenerateCharacteristic(CharacteristicType.Fact2);
        }

        public override string ToString()
        {
            return $"№ {this.Id}\n" +
                   $"Job: {this.Job}\n" +
                   $"Gender: {this.Gender} {this.Fertility}\n" +
                   $"Age: {this.Age}\n" +
                   $"Health: {this.Health}\n" +
                   $"Phobia: {this.Phobia}\n" +
                   $"Hobby: {this.Hobby}\n" +
                   $"Baggage: {this.Baggage}\n" +
                   $"Fact1: {this.Fact1}\n" +
                   $"Fact2: {this.Fact2}\n";
        }

        private string GenerateCharacteristic(CharacteristicType type)
        {
            CharacteristicMap.TryGetValue(type, out string fileName);
            if (fileName == null) throw new FileNotFoundException();
            
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", _PERSONS_DIRECTORY, fileName);
            if (!File.Exists(path)) throw new FileNotFoundException();

            if (type == CharacteristicType.Age)
            {
                var ages = JsonSerializer.Deserialize<List<int>>(File.ReadAllText(path));
                int minAge = ages[0];
                int maxAge = ages[1];

                return _random.Next(minAge, maxAge).ToString();
            }
            
            var characters = JsonSerializer.Deserialize<List<string>>(File.ReadAllText(path));
            return characters[_random.Next(characters.Count)];
        }

        public Person ChangeCharacteristic(CharacteristicType type, Person person)
        {
            string newChar = this.GenerateCharacteristic(type);

            switch (type)
            {
                case CharacteristicType.Job:
                    person.Job = newChar;
                    break;
                case CharacteristicType.Gender:
                    person.Gender = newChar;
                    break;
                case CharacteristicType.Age:
                    person.Age = newChar;
                    break;
                case CharacteristicType.Health:
                    person.Health = newChar;
                    break;
                case CharacteristicType.Phobia:
                    person.Gender = newChar;
                    break;
                case CharacteristicType.Hobby:
                    person.Hobby = newChar;
                    break;
                case CharacteristicType.Baggage:
                    person.Baggage = newChar;
                    break;
                case CharacteristicType.Fact1:
                    person.Fact1 = newChar;
                    break;
                case CharacteristicType.Fact2:
                    person.Fact2 = newChar;
                    break;
            }

            return person;
        }
    }
}