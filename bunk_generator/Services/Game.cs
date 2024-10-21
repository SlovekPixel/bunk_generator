using System.Collections.Generic;
using System.Windows.Forms;


namespace bunk_generator.Services
{
    public class Game
    {
        public static Panel[] GenerateFrames()
        {
            int _PADDINGS = 5;
            List<Person> persons = Setting.LoadPersonsFromFile();
            Panel[] panels = new Panel[persons.Count];
        
            int currentX = _PADDINGS + 5;
            int currentY = _PADDINGS + 5;

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