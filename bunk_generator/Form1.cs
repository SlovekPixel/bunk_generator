using System;
using System.IO;
using System.Windows.Forms;
using bunk_generator.enums;
using bunk_generator.handlers;
using DotNetEnv;

namespace bunk_generator
{
    public partial class Form1 : Form
    {
        private Parameters _parameters;
        private Frames _frames;
        private string _DATA_PATH = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");
        private string _SETTINGS_PATH = "settings.json";
        public Form1()
        {
            InitializeComponent();
            _parameters = new Parameters();
            _frames = new Frames();
        }

        private void dec_count_persons_Click(object sender, EventArgs e)
        {
            _parameters.DecPersonsCount();
            txt_person_counter.Text = _parameters.PersonsCount.ToString();
        }

        private void inc_count_persons_Click(object sender, EventArgs e)
        {
            _parameters.IncPersonsCount();
            txt_person_counter.Text = _parameters.PersonsCount.ToString();
        }

        private void txt_person_counter_TextChanged(object sender, EventArgs e)
        {
            _parameters.UpdatePersonsCount(txt_person_counter.Text);
        }

        private void btn_save_settings_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(_DATA_PATH, "game");
            _parameters.SaveSettings(path, _SETTINGS_PATH);
            MessageBox.Show("The settings have been saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_load_settings_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(_DATA_PATH, "game", _SETTINGS_PATH);
            if (_parameters.LoadSettings(filePath))
            {
                txt_person_counter.Text = _parameters.PersonsCount.ToString();
                checkBox_specialConditions.Checked = _parameters.IsSpecialConditions;
            }
            else
            {
                MessageBox.Show("Settings file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (_frames.PanelsCount != 0) return;
            
            _parameters.LockSettings(blockPanel);
            // add characteristic types in comboBox
            foreach (var characteristic in Enum.GetValues(typeof(CharacteristicType))) changeOne_combobox_charact.Items.Add(characteristic);

            // Generate persons
            int personsCount = _parameters.PersonsCount;
            Person[] _persons = new Person[personsCount];
            for (var i = 0; i < personsCount; i++)
            {
                _persons[i] = new Person(i);
            }
            
            // Generate Frames
            Panel[] panels = _frames.GenerateFrames(_persons);
            foreach (var panel in panels)
            {
                personsBox.Controls.Add(panel);
                if (panel.Tag is Person person) changeOne_combobox_person_number.Items.Add(person.Id);
            }
            changeOne_combobox_person_number.Items.Add("All");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Panel[] panels = _frames.ClearFrames();
            if (panels.Length == 0) return;
            
            _parameters.UnlockSettings(blockPanel);
            changeOne_combobox_charact.Items.Clear();
            changeOne_combobox_person_number.Items.Clear();
            foreach (var panel in panels) personsBox.Controls.Remove(panel);
        }

        private void changeOne_combobox_button_Click(object sender, EventArgs e)
        {
            if (changeOne_combobox_charact.SelectedItem != null && changeOne_combobox_person_number.SelectedItem != null)
            {
                string personId = changeOne_combobox_person_number.SelectedItem.ToString();
                string charact = changeOne_combobox_charact.SelectedItem.ToString();

                if (Enum.TryParse(charact, out CharacteristicType selectedType))
                {
                    
                    Person[] selectedPerson = _frames.GetPersonById(personId);
                    foreach (var person in selectedPerson)
                    {
                        Person newPerson = person.ChangeCharacteristic(selectedType, person);
                        _frames.UpdatePerson(newPerson);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select both person number and attribute.");
            }
        }

        private void checkBox_specialConditions_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = checkBox_specialConditions.Checked;
            _parameters.SetSpecialConditions(isChecked);
        }
    }
}