namespace bunk_generator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.settings_panel = new System.Windows.Forms.GroupBox();
            this.checkBox_hide_parameters = new System.Windows.Forms.CheckBox();
            this.checkBox_generate_files = new System.Windows.Forms.CheckBox();
            this.checkBox_special_conditions = new System.Windows.Forms.CheckBox();
            this.button_start_settings = new System.Windows.Forms.Button();
            this.button_stop_settings = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_load_settings = new System.Windows.Forms.Button();
            this.button_save_settings = new System.Windows.Forms.Button();
            this.textBox_persons_counter = new System.Windows.Forms.TextBox();
            this.button_inc_persons_counter = new System.Windows.Forms.Button();
            this.button_dec_persons_counter = new System.Windows.Forms.Button();
            this.label_person_counter = new System.Windows.Forms.Label();
            this.changes_panel = new System.Windows.Forms.GroupBox();
            this.comboBox_change_all_charact = new System.Windows.Forms.ComboBox();
            this.button_change_all_characteristic = new System.Windows.Forms.Button();
            this.label_change_all_characteristic_charact = new System.Windows.Forms.Label();
            this.label_change_all_characteristic = new System.Windows.Forms.Label();
            this.comboBox_change_one_charact = new System.Windows.Forms.ComboBox();
            this.comboBox_change_one_person = new System.Windows.Forms.ComboBox();
            this.button_change_one_characteristic = new System.Windows.Forms.Button();
            this.label_change_one_characteristic_charact = new System.Windows.Forms.Label();
            this.label_change_one_characteristic_person = new System.Windows.Forms.Label();
            this.label_change_one_characteristic = new System.Windows.Forms.Label();
            this.persons_panel = new System.Windows.Forms.GroupBox();
            this.settings_panel.SuspendLayout();
            this.changes_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // settings_panel
            // 
            this.settings_panel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.settings_panel.Controls.Add(this.checkBox_hide_parameters);
            this.settings_panel.Controls.Add(this.checkBox_generate_files);
            this.settings_panel.Controls.Add(this.checkBox_special_conditions);
            this.settings_panel.Controls.Add(this.button_start_settings);
            this.settings_panel.Controls.Add(this.button_stop_settings);
            this.settings_panel.Controls.Add(this.button4);
            this.settings_panel.Controls.Add(this.button3);
            this.settings_panel.Controls.Add(this.button_load_settings);
            this.settings_panel.Controls.Add(this.button_save_settings);
            this.settings_panel.Controls.Add(this.textBox_persons_counter);
            this.settings_panel.Controls.Add(this.button_inc_persons_counter);
            this.settings_panel.Controls.Add(this.button_dec_persons_counter);
            this.settings_panel.Controls.Add(this.label_person_counter);
            this.settings_panel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settings_panel.ForeColor = System.Drawing.Color.Black;
            this.settings_panel.Location = new System.Drawing.Point(12, 12);
            this.settings_panel.Name = "settings_panel";
            this.settings_panel.Size = new System.Drawing.Size(300, 300);
            this.settings_panel.TabIndex = 1;
            this.settings_panel.TabStop = false;
            this.settings_panel.Text = "Settings";
            // 
            // checkBox_hide_parameters
            // 
            this.checkBox_hide_parameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_hide_parameters.Location = new System.Drawing.Point(6, 113);
            this.checkBox_hide_parameters.Name = "checkBox_hide_parameters";
            this.checkBox_hide_parameters.Size = new System.Drawing.Size(288, 24);
            this.checkBox_hide_parameters.TabIndex = 13;
            this.checkBox_hide_parameters.Text = "Hide the parameters?";
            this.checkBox_hide_parameters.UseVisualStyleBackColor = true;
            this.checkBox_hide_parameters.CheckedChanged += new System.EventHandler(this.checkBox_hide_parameters_CheckedChanged);
            // 
            // checkBox_generate_files
            // 
            this.checkBox_generate_files.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_generate_files.Location = new System.Drawing.Point(6, 83);
            this.checkBox_generate_files.Name = "checkBox_generate_files";
            this.checkBox_generate_files.Size = new System.Drawing.Size(288, 24);
            this.checkBox_generate_files.TabIndex = 12;
            this.checkBox_generate_files.Text = "Generate files?";
            this.checkBox_generate_files.UseVisualStyleBackColor = true;
            this.checkBox_generate_files.CheckedChanged += new System.EventHandler(this.checkBox_generate_files_CheckedChanged);
            // 
            // checkBox_special_conditions
            // 
            this.checkBox_special_conditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_special_conditions.Location = new System.Drawing.Point(6, 53);
            this.checkBox_special_conditions.Name = "checkBox_special_conditions";
            this.checkBox_special_conditions.Size = new System.Drawing.Size(288, 24);
            this.checkBox_special_conditions.TabIndex = 11;
            this.checkBox_special_conditions.Text = "Specific conditions?";
            this.checkBox_special_conditions.UseVisualStyleBackColor = true;
            this.checkBox_special_conditions.CheckedChanged += new System.EventHandler(this.checkBox_special_conditions_CheckedChanged);
            // 
            // button_start_settings
            // 
            this.button_start_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_start_settings.Location = new System.Drawing.Point(209, 264);
            this.button_start_settings.Name = "button_start_settings";
            this.button_start_settings.Size = new System.Drawing.Size(85, 30);
            this.button_start_settings.TabIndex = 10;
            this.button_start_settings.Text = "Start";
            this.button_start_settings.UseVisualStyleBackColor = true;
            this.button_start_settings.Click += new System.EventHandler(this.button_start_settings_Click);
            // 
            // button_stop_settings
            // 
            this.button_stop_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_stop_settings.Location = new System.Drawing.Point(209, 228);
            this.button_stop_settings.Name = "button_stop_settings";
            this.button_stop_settings.Size = new System.Drawing.Size(85, 30);
            this.button_stop_settings.TabIndex = 9;
            this.button_stop_settings.Text = "Stop";
            this.button_stop_settings.UseVisualStyleBackColor = true;
            this.button_stop_settings.Click += new System.EventHandler(this.button_stop_settings_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(108, 264);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 30);
            this.button4.TabIndex = 8;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(108, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 30);
            this.button3.TabIndex = 7;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button_load_settings
            // 
            this.button_load_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_load_settings.Location = new System.Drawing.Point(6, 264);
            this.button_load_settings.Name = "button_load_settings";
            this.button_load_settings.Size = new System.Drawing.Size(85, 30);
            this.button_load_settings.TabIndex = 6;
            this.button_load_settings.Text = "Load";
            this.button_load_settings.UseVisualStyleBackColor = true;
            this.button_load_settings.Click += new System.EventHandler(this.button_load_settings_Click);
            // 
            // button_save_settings
            // 
            this.button_save_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save_settings.Location = new System.Drawing.Point(6, 228);
            this.button_save_settings.Name = "button_save_settings";
            this.button_save_settings.Size = new System.Drawing.Size(85, 30);
            this.button_save_settings.TabIndex = 5;
            this.button_save_settings.Text = "Save";
            this.button_save_settings.UseVisualStyleBackColor = true;
            this.button_save_settings.Click += new System.EventHandler(this.button_save_settings_Click);
            // 
            // textBox_persons_counter
            // 
            this.textBox_persons_counter.Location = new System.Drawing.Point(91, 25);
            this.textBox_persons_counter.Name = "textBox_persons_counter";
            this.textBox_persons_counter.Size = new System.Drawing.Size(84, 26);
            this.textBox_persons_counter.TabIndex = 4;
            this.textBox_persons_counter.Text = "4";
            this.textBox_persons_counter.TextChanged += new System.EventHandler(this.textBox_persons_counter_TextChanged);
            // 
            // button_inc_persons_counter
            // 
            this.button_inc_persons_counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_inc_persons_counter.Location = new System.Drawing.Point(227, 21);
            this.button_inc_persons_counter.Name = "button_inc_persons_counter";
            this.button_inc_persons_counter.Size = new System.Drawing.Size(40, 25);
            this.button_inc_persons_counter.TabIndex = 3;
            this.button_inc_persons_counter.Text = ">";
            this.button_inc_persons_counter.UseVisualStyleBackColor = true;
            this.button_inc_persons_counter.Click += new System.EventHandler(this.button_inc_persons_counter_Click);
            // 
            // button_dec_persons_counter
            // 
            this.button_dec_persons_counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_dec_persons_counter.Location = new System.Drawing.Point(181, 21);
            this.button_dec_persons_counter.Name = "button_dec_persons_counter";
            this.button_dec_persons_counter.Size = new System.Drawing.Size(40, 25);
            this.button_dec_persons_counter.TabIndex = 2;
            this.button_dec_persons_counter.Text = "<";
            this.button_dec_persons_counter.UseVisualStyleBackColor = true;
            this.button_dec_persons_counter.Click += new System.EventHandler(this.button_dec_persons_counter_Click);
            // 
            // label_person_counter
            // 
            this.label_person_counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_person_counter.Location = new System.Drawing.Point(6, 25);
            this.label_person_counter.Name = "label_person_counter";
            this.label_person_counter.Size = new System.Drawing.Size(79, 22);
            this.label_person_counter.TabIndex = 1;
            this.label_person_counter.Text = "Persons:";
            // 
            // changes_panel
            // 
            this.changes_panel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.changes_panel.Controls.Add(this.comboBox_change_all_charact);
            this.changes_panel.Controls.Add(this.button_change_all_characteristic);
            this.changes_panel.Controls.Add(this.label_change_all_characteristic_charact);
            this.changes_panel.Controls.Add(this.label_change_all_characteristic);
            this.changes_panel.Controls.Add(this.comboBox_change_one_charact);
            this.changes_panel.Controls.Add(this.comboBox_change_one_person);
            this.changes_panel.Controls.Add(this.button_change_one_characteristic);
            this.changes_panel.Controls.Add(this.label_change_one_characteristic_charact);
            this.changes_panel.Controls.Add(this.label_change_one_characteristic_person);
            this.changes_panel.Controls.Add(this.label_change_one_characteristic);
            this.changes_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changes_panel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.changes_panel.Location = new System.Drawing.Point(12, 318);
            this.changes_panel.Name = "changes_panel";
            this.changes_panel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.changes_panel.Size = new System.Drawing.Size(300, 351);
            this.changes_panel.TabIndex = 2;
            this.changes_panel.TabStop = false;
            this.changes_panel.Text = "Characterization changes";
            // 
            // comboBox_change_all_charact
            // 
            this.comboBox_change_all_charact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_change_all_charact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_change_all_charact.FormattingEnabled = true;
            this.comboBox_change_all_charact.Location = new System.Drawing.Point(138, 169);
            this.comboBox_change_all_charact.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_change_all_charact.Name = "comboBox_change_all_charact";
            this.comboBox_change_all_charact.Size = new System.Drawing.Size(97, 24);
            this.comboBox_change_all_charact.TabIndex = 9;
            // 
            // button_change_all_characteristic
            // 
            this.button_change_all_characteristic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_change_all_characteristic.Location = new System.Drawing.Point(6, 196);
            this.button_change_all_characteristic.Name = "button_change_all_characteristic";
            this.button_change_all_characteristic.Size = new System.Drawing.Size(127, 30);
            this.button_change_all_characteristic.TabIndex = 8;
            this.button_change_all_characteristic.Text = "Change all";
            this.button_change_all_characteristic.UseVisualStyleBackColor = true;
            this.button_change_all_characteristic.Click += new System.EventHandler(this.button_change_all_characteristic_Click);
            // 
            // label_change_all_characteristic_charact
            // 
            this.label_change_all_characteristic_charact.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_change_all_characteristic_charact.Location = new System.Drawing.Point(6, 169);
            this.label_change_all_characteristic_charact.Name = "label_change_all_characteristic_charact";
            this.label_change_all_characteristic_charact.Size = new System.Drawing.Size(127, 24);
            this.label_change_all_characteristic_charact.TabIndex = 7;
            this.label_change_all_characteristic_charact.Text = "Characteristic:";
            // 
            // label_change_all_characteristic
            // 
            this.label_change_all_characteristic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_change_all_characteristic.Location = new System.Drawing.Point(6, 149);
            this.label_change_all_characteristic.Name = "label_change_all_characteristic";
            this.label_change_all_characteristic.Size = new System.Drawing.Size(288, 23);
            this.label_change_all_characteristic.TabIndex = 6;
            this.label_change_all_characteristic.Text = "Change all characteristics for everyone:";
            // 
            // comboBox_change_one_charact
            // 
            this.comboBox_change_one_charact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_change_one_charact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_change_one_charact.FormattingEnabled = true;
            this.comboBox_change_one_charact.Location = new System.Drawing.Point(138, 76);
            this.comboBox_change_one_charact.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_change_one_charact.Name = "comboBox_change_one_charact";
            this.comboBox_change_one_charact.Size = new System.Drawing.Size(97, 24);
            this.comboBox_change_one_charact.TabIndex = 5;
            // 
            // comboBox_change_one_person
            // 
            this.comboBox_change_one_person.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_change_one_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_change_one_person.FormattingEnabled = true;
            this.comboBox_change_one_person.Location = new System.Drawing.Point(138, 50);
            this.comboBox_change_one_person.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_change_one_person.Name = "comboBox_change_one_person";
            this.comboBox_change_one_person.Size = new System.Drawing.Size(97, 24);
            this.comboBox_change_one_person.TabIndex = 4;
            // 
            // button_change_one_characteristic
            // 
            this.button_change_one_characteristic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_change_one_characteristic.Location = new System.Drawing.Point(6, 103);
            this.button_change_one_characteristic.Name = "button_change_one_characteristic";
            this.button_change_one_characteristic.Size = new System.Drawing.Size(127, 30);
            this.button_change_one_characteristic.TabIndex = 3;
            this.button_change_one_characteristic.Text = " Change one";
            this.button_change_one_characteristic.UseVisualStyleBackColor = true;
            this.button_change_one_characteristic.Click += new System.EventHandler(this.button_change_one_characteristic_Click);
            // 
            // label_change_one_characteristic_charact
            // 
            this.label_change_one_characteristic_charact.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_change_one_characteristic_charact.Location = new System.Drawing.Point(6, 76);
            this.label_change_one_characteristic_charact.Name = "label_change_one_characteristic_charact";
            this.label_change_one_characteristic_charact.Size = new System.Drawing.Size(127, 24);
            this.label_change_one_characteristic_charact.TabIndex = 2;
            this.label_change_one_characteristic_charact.Text = "Characteristic:";
            // 
            // label_change_one_characteristic_person
            // 
            this.label_change_one_characteristic_person.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_change_one_characteristic_person.Location = new System.Drawing.Point(6, 52);
            this.label_change_one_characteristic_person.Name = "label_change_one_characteristic_person";
            this.label_change_one_characteristic_person.Size = new System.Drawing.Size(127, 24);
            this.label_change_one_characteristic_person.TabIndex = 1;
            this.label_change_one_characteristic_person.Text = "Person\'s number:";
            // 
            // label_change_one_characteristic
            // 
            this.label_change_one_characteristic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_change_one_characteristic.Location = new System.Drawing.Point(6, 29);
            this.label_change_one_characteristic.Name = "label_change_one_characteristic";
            this.label_change_one_characteristic.Size = new System.Drawing.Size(288, 23);
            this.label_change_one_characteristic.TabIndex = 0;
            this.label_change_one_characteristic.Text = "Change in one characteristic:";
            // 
            // persons_panel
            // 
            this.persons_panel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.persons_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.persons_panel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.persons_panel.Location = new System.Drawing.Point(318, 12);
            this.persons_panel.Name = "persons_panel";
            this.persons_panel.Size = new System.Drawing.Size(934, 657);
            this.persons_panel.TabIndex = 3;
            this.persons_panel.TabStop = false;
            this.persons_panel.Text = "Persons";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 691);
            this.Controls.Add(this.persons_panel);
            this.Controls.Add(this.changes_panel);
            this.Controls.Add(this.settings_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bunk_generator";
            this.settings_panel.ResumeLayout(false);
            this.settings_panel.PerformLayout();
            this.changes_panel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox comboBox_change_all_charact;

        private System.Windows.Forms.Button button_change_all_characteristic;

        private System.Windows.Forms.Label label_change_all_characteristic_charact;

        private System.Windows.Forms.Label label_change_all_characteristic;

        private System.Windows.Forms.ComboBox comboBox_change_one_person;
        private System.Windows.Forms.ComboBox comboBox_change_one_charact;

        private System.Windows.Forms.Button button_change_one_characteristic;

        private System.Windows.Forms.Label label_change_one_characteristic_person;
        private System.Windows.Forms.Label label_change_one_characteristic_charact;

        private System.Windows.Forms.Label label_change_one_characteristic;

        private System.Windows.Forms.CheckBox checkBox_special_conditions;
        private System.Windows.Forms.CheckBox checkBox_generate_files;
        private System.Windows.Forms.CheckBox checkBox_hide_parameters;

        private System.Windows.Forms.Button button_save_settings;
        private System.Windows.Forms.Button button_load_settings;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button_stop_settings;
        private System.Windows.Forms.Button button_start_settings;

        private System.Windows.Forms.TextBox textBox_persons_counter;

        private System.Windows.Forms.Button button_dec_persons_counter;
        private System.Windows.Forms.Button button_inc_persons_counter;

        private System.Windows.Forms.Label label_person_counter;

        private System.Windows.Forms.GroupBox persons_panel;

        private System.Windows.Forms.GroupBox settings_panel;
        private System.Windows.Forms.GroupBox changes_panel;

        #endregion
    }
}