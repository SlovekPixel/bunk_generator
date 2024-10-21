namespace bunk_generator.dto
{
    public class SettingsDto
    {
        public int PersonsCount { get; set; }
        public bool IsSpecialConditions { get; set; }
        public bool IsGenerateFiles { get; set; }
        public bool IsHideParameters { get; set; }
        public int _MAX_PERSONS { get; set; }
        public int _MIN_PERSONS { get; set; }
    }
}