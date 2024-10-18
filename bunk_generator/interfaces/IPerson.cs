namespace bunk_generator.Interfaces
{
    public interface IPerson
    {
        string Gender { get; }
        string Age { get; }
        string Job { get; }
        bool Fertility { get; }
        string Health { get; }
        string Phobia { get; }
        string Hobby { get; }
        string Baggage { get; }
        string Fact1 { get; }
        string Fact2 { get; }

        // string GenerateProfession();
        //
        // string GenerateGender();
        //
        // int GenerateAge();

    }
}