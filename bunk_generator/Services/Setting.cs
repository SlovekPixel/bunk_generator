using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using bunk_generator.dto;
using bunk_generator.Interfaces;
using DotNetEnv;

namespace bunk_generator.Services
{
    public class Setting: ISetting
    {
        public int PersonsCount { get; private set; }
        public bool IsSpecialConditions { get; private set; }
        public bool IsGenerateFiles { get; private set; }
        public bool IsHideParameters { get; private set; }
        private int _MAX_PERSONS = Env.GetInt("MAX_PLAYERS");
        private int _MIN_PERSONS = Env.GetInt("MIN_PLAYERS");

        private Person _person;
        public Setting() 
        {
            PersonsCount = _MIN_PERSONS;
            IsSpecialConditions = false;
            IsGenerateFiles = false;
            IsHideParameters = false;

            // _person = new Person();
        }
        
        public void IncPersonsCounter()
        {
            PersonsCount++;
            if (PersonsCount > _MAX_PERSONS) PersonsCount = _MAX_PERSONS;
        }
        
        public void DecPersonsCounter()
        {
            PersonsCount--;
            if (PersonsCount < _MIN_PERSONS) PersonsCount = _MIN_PERSONS;
        }

        public void UpdatePersonsCounter(string newValue)
        {
            if (int.TryParse(newValue, out int value) && value >= _MIN_PERSONS && value <= _MAX_PERSONS)
            {
                PersonsCount = value;
            }
        }

        public void SaveSettings(string directoryPath, string fileName)
        {
            SettingsDto jsonParameters = new SettingsDto
            {
                PersonsCount = this.PersonsCount,
                IsSpecialConditions = this.IsSpecialConditions,
                IsGenerateFiles = this.IsGenerateFiles,
                IsHideParameters = this.IsHideParameters,
                _MAX_PERSONS = this._MAX_PERSONS,
                _MIN_PERSONS = this._MIN_PERSONS
            };
            var jsonResult = JsonSerializer.Serialize(jsonParameters);
            Directory.CreateDirectory(directoryPath);
            File.WriteAllText(Path.Combine(directoryPath, fileName), jsonResult);
        }
        
        public bool LoadSettings(string filePath)
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                var settings = JsonSerializer.Deserialize<SettingsDto>(json);
                this.UpdatePersonsCounter(settings.PersonsCount.ToString());
                this.IsSpecialConditions = settings.IsSpecialConditions;
                this.IsGenerateFiles = settings.IsGenerateFiles;
                this.IsHideParameters = settings.IsHideParameters;
                return true;
            }
            return false;
        }
        
        public void SetSpecialConditions(bool value)
        {
            IsSpecialConditions = value;
        }

        public void SetGenerateFiles(bool value)
        {
            IsGenerateFiles = value;
        }
        
        public void SetHideParameters(bool value)
        {
            IsHideParameters = value;
        }
        
        public void SavePersonsToFile()
        {
            List<Person> persons = Person.GeneratePersons(PersonsCount);
            var jsonPersons = JsonSerializer.Serialize(persons, new JsonSerializerOptions { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping });
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data/game");
            Directory.CreateDirectory(directoryPath);
            
            const string fileName = "new_game.json";
            File.WriteAllText(Path.Combine(directoryPath, fileName), jsonPersons);
        }
        
        public static List<Person> LoadPersonsFromFile()
        {
            const string fileName = "new_game.json";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "game", fileName);
            return JsonSerializer.Deserialize<List<Person>>(File.ReadAllText(filePath));
        }
    }
}