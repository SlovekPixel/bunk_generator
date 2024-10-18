using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bunk_generator.Services;

namespace bunk_generator
{
    public partial class Form1 : Form
    {
        private Setting _setting;
        private string _DATA_PATH = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");
        private string _SETTINGS_PATH = "settings.json";
        private bool isGameStarted = false;

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
                checkBox_2.Checked = _setting.IsCheckBox_2;
                checkBox_3.Checked = _setting.IsCheckBox_3;
                MessageBox.Show("Settings loaded!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Settings file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = checkBox_2.Checked;
            _setting.SetCheckBox_2(isChecked);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = checkBox_3.Checked;
            _setting.SetCheckBox_3(isChecked);
        }

        private void button_start_settings_Click(object sender, EventArgs e)
        {
            if (isGameStarted) return;

            _setting.SavePersonsToFile();
            _panels = GamesData.GenerateFrames();
            foreach (var panel in _panels)
            {
                persons_panel.Controls.Add(panel);
            }
            isGameStarted = true;
        }

        private void button_stop_settings_Click(object sender, EventArgs e)
        {
            if (!isGameStarted) return;

            foreach (var panel in _panels) persons_panel.Controls.Remove(panel);
            isGameStarted = false;
        }
    }
}