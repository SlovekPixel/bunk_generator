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
        public List<string> Job { get; private set; }
        public bool Fertility { get; private set; }
        public string Health { get; private set; }
        public string Phobia { get; private set; }
        public List<string> Hobby { get; private set; }
        public List<string> Baggage { get; private set; }
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
            int gameSeed = new Random((int)(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() % int.MaxValue)).Next();
            _random = new Random(gameSeed + i * 15);
            Id = i;
            Gender = this.GenerateSingleCharacteristic(CharacteristicType.Gender);
            Job = this.GenerateListCharacteristic(CharacteristicType.Job);
            Age = this.GenerateSingleCharacteristic(CharacteristicType.Age);
            Health = this.GenerateSingleCharacteristic(CharacteristicType.Health);
            Phobia = this.GenerateSingleCharacteristic(CharacteristicType.Phobia);
            Hobby = this.GenerateListCharacteristic(CharacteristicType.Hobby);
            Baggage = this.GenerateListCharacteristic(CharacteristicType.Baggage);
            Fact1 = this.GenerateSingleCharacteristic(CharacteristicType.Fact1);
            Fact2 = this.GenerateSingleCharacteristic(CharacteristicType.Fact2);
        }

        [JsonConstructor]
        public Person(int id, string gender, string age, List<string> job, bool fertility, string health, string phobia, List<string> hobby, List<string> baggage, string fact1, string fact2)
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
        
        public void ChangeCharacteristic(CharacteristicType characteristicType)
        {
            switch (characteristicType)
            {
                case CharacteristicType.Gender:
                    Gender = this.GenerateSingleCharacteristic(CharacteristicType.Gender);
                    break;
                case CharacteristicType.Job:
                    Job = this.GenerateListCharacteristic(CharacteristicType.Job);
                    break;
                case CharacteristicType.Age:
                    Age = this.GenerateSingleCharacteristic(CharacteristicType.Age);
                    break;
                case CharacteristicType.Health:
                    Health = this.GenerateSingleCharacteristic(CharacteristicType.Health);
                    break;
                case CharacteristicType.Phobia:
                    Phobia = this.GenerateSingleCharacteristic(CharacteristicType.Phobia);
                    break;
                case CharacteristicType.Hobby:
                    Hobby = this.GenerateListCharacteristic(CharacteristicType.Hobby);
                    break;
                case CharacteristicType.Baggage:
                    Baggage = this.GenerateListCharacteristic(CharacteristicType.Baggage);
                    break;
                case CharacteristicType.Fact1:
                    Fact1 = this.GenerateSingleCharacteristic(CharacteristicType.Fact1);
                    break;
                case CharacteristicType.Fact2:
                    Fact2 = this.GenerateSingleCharacteristic(CharacteristicType.Fact2);
                    break;
                default:
                    throw new ArgumentException("Unknown characteristic type");
            }
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        }

        public override string ToString()
        {
            return $"№ {this.Id}\n" +
                   $"Job: {string.Join(", ", this.Job)}\n" +
                   $"Gender: {this.Gender} {this.Fertility}\n" +
                   $"Age: {this.Age}\n" +
                   $"Health: {this.Health}\n" +
                   $"Phobia: {this.Phobia}\n" +
                   $"Hobby: {string.Join(", ", this.Hobby)}\n" +
                   $"Baggage: {string.Join(", ", this.Baggage)}\n" +
                   $"Fact1: {this.Fact1}\n" +
                   $"Fact2: {this.Fact2}\n";
        }
        
        private string GenerateSingleCharacteristic(CharacteristicType type)
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

        private List<string> GenerateListCharacteristic(CharacteristicType type)
        {
            CharacteristicMap.TryGetValue(type, out string fileName);
            if (fileName == null) throw new FileNotFoundException();

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", _PERSONS_DIRECTORY, fileName);
            if (!File.Exists(path)) throw new FileNotFoundException();

            var characters = JsonSerializer.Deserialize<List<string>>(File.ReadAllText(path));
            return new List<string> { characters[_random.Next(characters.Count)] };
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