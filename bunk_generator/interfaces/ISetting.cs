using System.Collections.Generic;
using bunk_generator.Services;


namespace bunk_generator.Interfaces
{
    public interface ISetting
    {
        int PersonsCount { get; }
        bool IsSpecialConditions { get; }
        bool IsGenerateFiles { get; }
        bool IsHideParameters { get; }
        void IncPersonsCounter();
        void DecPersonsCounter();
        void UpdatePersonsCounter(string newValue);
        void SaveSettings(string directoryPath, string fileName);
        bool LoadSettings(string filePath);
        void SetSpecialConditions(bool value);
        void SetGenerateFiles(bool value);
        void SetHideParameters(bool value);
        List<Person> SavePersonsToFile();
        List<Person> LoadPersonsFromFile();
    }
}