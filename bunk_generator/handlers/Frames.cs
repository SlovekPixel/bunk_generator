using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using bunk_generator.interfaces;
using DotNetEnv;

namespace bunk_generator.handlers
{
    public class Frames
    {
        public int PanelsCount { get; private set; }
        private Panel[] _panels;
        private Person[] _personsArray;

        public Frames()
        {
            PanelsCount = 0;
            _panels = Array.Empty<Panel>();
            _personsArray = Array.Empty<Person>();
        }

        public Person[] GetPersonById(string personNumber)
        {
            if (int.TryParse(personNumber, out int index))
            {
                if (index >= 0 && index < _personsArray.Count()) return new Person[] { _personsArray[index] };
            }
            return _personsArray;
        }
        
        public void UpdatePerson(Person person)
        {
            _personsArray[person.Id] = person;
            this.ClearFrames();
            this.GenerateFrames(_personsArray);
        }
        
        public Panel[] GenerateFrames(Person[] persons)
        {
            int _PADDINGS = 5;
            
            _personsArray = persons;
            _panels = new Panel[persons.Length];
            
            int currentX = _PADDINGS;
            int currentY = _PADDINGS;

            foreach (var person in persons)
            {
                int i = person.Id;

                (Panel squarePanel, var newcurrentX, var newcurrentY) = InfoLabel.GetInfoLabel(person,  currentX, currentY);

                currentX = newcurrentX;
                currentY = newcurrentY;

                _panels[i] = squarePanel;
            }
            
            PanelsCount += _panels.Length;
            
            return _panels;
        }

        public Panel[] ClearFrames()
        {
            Panel[] pans = _panels;
            
            _panels = Array.Empty<Panel>();
            PanelsCount = _panels.Length;

            return pans;
        }
    }
}