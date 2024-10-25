using System.Collections.Generic;
using System.Windows.Forms;


namespace bunk_generator.Services
{
    public class Game
    {
        public static Panel[] GenerateFrames(List<Person> persons)
        {
            int paddings = 5;
            Panel[] panels = new Panel[persons.Count];

            int currentX = paddings + 5;
            int currentY = paddings + 5;

            foreach (var person in persons)
            {
                int i = person.Id;
                (Panel squarePanel, var newcurrentX, var newcurrentY) = InfoLabelPerson.GetLabel(person, currentX, currentY);
                currentX = newcurrentX;
                currentY = newcurrentY;
                panels[i-1] = squarePanel;
            }
            return panels;
        }
    }
}