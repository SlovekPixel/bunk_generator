using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using bunk_generator.Enums;
using bunk_generator.Services;

namespace bunk_generator
{
    public partial class Form1 : Form
    {
        private Setting _setting;
        private string _DATA_PATH = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");
        private string _SETTINGS_PATH = "settings.json";
        private bool _isGameStarted = false;

        private Panel[] _panels;
        public Form1()
        {
            InitializeComponent();
            _setting = new Setting();
        }

        private void button_inc_persons_counter_Click(object sender, EventArgs e)
        {
            _setting.IncPersonsCounter();
            textBox_persons_counter.Text = _setting.PersonsCount.ToString();
        }

        private void button_dec_persons_counter_Click(object sender, EventArgs e)
        {
            _setting.DecPersonsCounter();
            textBox_persons_counter.Text = _setting.PersonsCount.ToString();
        }

        private void textBox_persons_counter_TextChanged(object sender, EventArgs e)
        {
            _setting.UpdatePersonsCounter(textBox_persons_counter.Text);
        }

        private void checkBox_special_conditions_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = checkBox_special_conditions.Checked;
            _setting.SetSpecialConditions(isChecked);
        }

        private void button_save_settings_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(_DATA_PATH, "game");
            _setting.SaveSettings(path, _SETTINGS_PATH);
            MessageBox.Show("The settings have been saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_load_settings_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(_DATA_PATH, "game", _SETTINGS_PATH);
            if (_setting.LoadSettings(filePath))
            {
                textBox_persons_counter.Text = _setting.PersonsCount.ToString();
                checkBox_special_conditions.Checked = _setting.IsSpecialConditions;
                checkBox_generate_files.Checked = _setting.IsGenerateFiles;
                checkBox_hide_parameters.Checked = _setting.IsHideParameters;
                MessageBox.Show("Settings loaded!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Settings file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox_generate_files_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = checkBox_generate_files.Checked;
            _setting.SetGenerateFiles(isChecked);
        }

        private void checkBox_hide_parameters_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = checkBox_hide_parameters.Checked;
            _setting.SetHideParameters(isChecked);
        }

        private void button_start_settings_Click(object sender, EventArgs e)
        {
            if (_isGameStarted) return;

            List<Person> persons = _setting.SavePersonsToFile();
            _panels = Game.GenerateFrames(persons);
            foreach (var panel in _panels)
            {
                persons_panel.Controls.Add(panel);
                if (panel.Tag is Person person) comboBox_change_one_person.Items.Add(person.Id);
            }

            foreach (var characteristic in Enum.GetValues(typeof(CharacteristicType)))
            {
                comboBox_change_one_charact.Items.Add(characteristic);
                comboBox_change_all_charact.Items.Add(characteristic);
            }
            _isGameStarted = true;
        }

        private void button_stop_settings_Click(object sender, EventArgs e)
        {
            if (!_isGameStarted) return;

            foreach (var panel in _panels) persons_panel.Controls.Remove(panel);
            comboBox_change_one_person.Items.Clear();
            comboBox_change_one_charact.Items.Clear();
            comboBox_change_all_charact.Items.Clear();
            _isGameStarted = false;
        }

        private void button_change_one_characteristic_Click(object sender, EventArgs e)
        {
            if ((comboBox_change_one_person.SelectedItem != null) && (comboBox_change_one_charact.SelectedItem != null))
            {
                foreach (var panel in _panels) persons_panel.Controls.Remove(panel);
                int selectedPersonId = (int)comboBox_change_one_person.SelectedItem;
                CharacteristicType selectedCharacteristic = (CharacteristicType)comboBox_change_one_charact.SelectedItem;

                List<Person> persons = _setting.LoadPersonsFromFile();
                var selectedPerson = persons.FirstOrDefault(p => p.Id == selectedPersonId);
                if (selectedPerson != null)
                {
                    selectedPerson.ChangeCharacteristic(selectedCharacteristic);
                }
                _setting.SavePersonsToFile();
                _panels = Game.GenerateFrames(persons);
                foreach (var panel in _panels)
                {
                    persons_panel.Controls.Add(panel);
                }
            }
            else
            {
                MessageBox.Show("Please select both person number and attribute.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_change_all_characteristic_Click(object sender, EventArgs e)
        {
            if (comboBox_change_all_charact.SelectedItem != null)
            {
                //TODO
            }
            else
            {
                MessageBox.Show("Please select both person attribute.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}