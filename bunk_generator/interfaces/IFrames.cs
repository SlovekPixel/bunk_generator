using System.Collections.Generic;
using System.Windows.Forms;
using bunk_generator.handlers;

namespace bunk_generator.interfaces
{
    public interface IFrames
    {
        int PanelsCount { get; }
        Panel[] GenerateFrames(Person[] persons, int maxWidthSize, int maxHeightSize);
        Panel[] ClearFrames();
    }
}