using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using bunk_generator.Enums;
using bunk_generator.Interfaces;


namespace bunk_generator.Services
{
    public class Person: IPerson
    {
        private readonly string _PERSONS_DIRECTORY = "characteristics";
        private Random _random;
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
            _random = new Random(i*100 + i * 2 + i % 3);
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

        [JsonConstructor]
        public Person(int id, string gender, string age, string job, bool fertility, string health, string phobia, string hobby, string baggage, string fact1, string fact2)
        {
            Id = id;
            Gender = gender;
            Age = age;
            Job = job;
            Fertility = fertility;
            Health = health;
            Phobia = phobia;
            Hobby = hobby;
            Baggage = baggage;
            Fact1 = fact1;
            Fact2 = fact2;
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
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

        public static List<Person> GeneratePersons(int count)
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < count; i++)
            {
                persons.Add(new Person(i + 1));
            }
            return persons;
        }
    }
}