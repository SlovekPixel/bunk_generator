namespace bunk_generator.interfaces
{
    public interface IParameters
    {
        int PersonsCount { get; }
        bool IsSpecialConditions { get; }
        void IncPersonsCount();
        void DecPersonsCount();
        void UpdatePersonsCount(string newValue);
        void SaveSettings(string directoryPath, string fileName);
        bool LoadSettings(string filePath);
    }
}