using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using bunk_generator.dto;
using bunk_generator.interfaces;
using DotNetEnv;

namespace bunk_generator.handlers
{
    public class Parameters: IParameters
    {
        public int PersonsCount { get; private set; }
        public bool IsSpecialConditions { get; private set; }
        private int _MAX_PERSONS = Env.GetInt("MAX_PLAYERS");
        private int _MIN_PERSONS = Env.GetInt("MIN_PLAYERS");

        public Parameters()
        {
            PersonsCount = _MIN_PERSONS;
            IsSpecialConditions = false;
        }

        public void IncPersonsCount()
        {
            PersonsCount++;
            if (PersonsCount > _MAX_PERSONS) PersonsCount = _MAX_PERSONS;
        }
        
        public void DecPersonsCount()
        {
            PersonsCount--;
            if (PersonsCount < _MIN_PERSONS) PersonsCount = _MIN_PERSONS;
        }

        public void UpdatePersonsCount(string newValue)
        {
            if (int.TryParse(newValue, out int value) && value >= _MIN_PERSONS && value <= _MAX_PERSONS)
            {
                PersonsCount = value;
            }
        }
        
        public void SaveSettings(string directoryPath, string fileName)
        {
            ParametersDTO jsonParameters = new ParametersDTO
            {
                PersonsCount = this.PersonsCount,
                IsSpecialConditions = this.IsSpecialConditions,
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
                var settings = JsonSerializer.Deserialize<ParametersDTO>(json);
                this.UpdatePersonsCount(settings.PersonsCount.ToString());
                this.IsSpecialConditions = settings.IsSpecialConditions;
                return true;
            }
            return false;
        }

        public void LockSettings(Panel blockPanel)
        {
            blockPanel.Visible = true;
            blockPanel.Enabled = true;
        }
        
        public void UnlockSettings(Panel blockPanel)
        {
            blockPanel.Visible = false;
            blockPanel.Enabled = false;
        }

        public void SetSpecialConditions(bool value)
        {
            IsSpecialConditions = value;
        }
    }
}