using System.Collections.Generic;

namespace bunk_generator.Interfaces
{
    public interface IPerson
    {
        string Gender { get; }
        string Age { get; }
        List<string> Job { get; }
        bool Fertility { get; }
        string Health { get; }
        string Phobia { get; }
        List<string> Hobby { get; }
        List<string> Baggage { get; }
        string Fact1 { get; }
        string Fact2 { get; }
    }
}