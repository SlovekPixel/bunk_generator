using System.Collections.Generic;
using bunk_generator.Services;


namespace bunk_generator.Interfaces
{
    public interface ISetting
    {
        int PersonsCount { get; }
        bool IsSpecialConditions { get; }
        bool IsCheckBox_2 { get; }
        bool IsCheckBox_3 { get; }
        void IncPersonsCounter();
        void DecPersonsCounter();
        void UpdatePersonsCounter(string newValue);
        void SaveSettings(string directoryPath, string fileName);
        bool LoadSettings(string filePath);
        void SetSpecialConditions(bool value);
        void SetCheckBox_2(bool value);
        void SetCheckBox_3(bool value);
        void SavePersonsToFile();
    }
}