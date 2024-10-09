using System.Drawing;
using System.Windows.Forms;
using DotNetEnv;

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
            System.Windows.Forms.Panel settings_panel;
            System.Windows.Forms.Label lbl_persons_count;
            System.Windows.Forms.Label settings;
            System.Windows.Forms.Label Charact_chages;
            System.Windows.Forms.Label changeOne_label;
            System.Windows.Forms.Label changeOne_person_label;
            System.Windows.Forms.Label changeOne_charact_label;
            this.blockPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox_specialConditions = new System.Windows.Forms.CheckBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_load_settings = new System.Windows.Forms.Button();
            this.dec_count_persons = new System.Windows.Forms.Button();
            this.btn_save_settings = new System.Windows.Forms.Button();
            this.txt_person_counter = new System.Windows.Forms.TextBox();
            this.inc_count_persons = new System.Windows.Forms.Button();
            this.personsBox = new System.Windows.Forms.GroupBox();
            this.changes = new System.Windows.Forms.Panel();
            this.changeOne_combobox_button = new System.Windows.Forms.Button();
            this.changeOne_combobox_person_number = new System.Windows.Forms.ComboBox();
            this.changeOne_combobox_charact = new System.Windows.Forms.ComboBox();
            this.btnShowData = new System.Windows.Forms.Button();
            settings_panel = new System.Windows.Forms.Panel();
            lbl_persons_count = new System.Windows.Forms.Label();
            settings = new System.Windows.Forms.Label();
            Charact_chages = new System.Windows.Forms.Label();
            changeOne_label = new System.Windows.Forms.Label();
            changeOne_person_label = new System.Windows.Forms.Label();
            changeOne_charact_label = new System.Windows.Forms.Label();
            settings_panel.SuspendLayout();
            this.changes.SuspendLayout();
            this.SuspendLayout();
            // 
            // settings_panel
            // 
            settings_panel.BackColor = System.Drawing.SystemColors.MenuBar;
            settings_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            settings_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            settings_panel.CausesValidation = false;
            settings_panel.Controls.Add(this.blockPanel);
            settings_panel.Controls.Add(this.button2);
            settings_panel.Controls.Add(this.button1);
            settings_panel.Controls.Add(this.btn_clear);
            settings_panel.Controls.Add(this.checkBox3);
            settings_panel.Controls.Add(this.checkBox2);
            settings_panel.Controls.Add(this.checkBox_specialConditions);
            settings_panel.Controls.Add(this.btn_start);
            settings_panel.Controls.Add(this.btn_load_settings);
            settings_panel.Controls.Add(lbl_persons_count);
            settings_panel.Controls.Add(this.dec_count_persons);
            settings_panel.Controls.Add(this.btn_save_settings);
            settings_panel.Controls.Add(settings);
            settings_panel.Controls.Add(this.txt_person_counter);
            settings_panel.Controls.Add(this.inc_count_persons);
            settings_panel.Location = new System.Drawing.Point(12, 12);
            settings_panel.Name = "settings_panel";
            settings_panel.Size = new System.Drawing.Size(300, 347);
            settings_panel.TabIndex = 5;
            // 
            // blockPanel
            // 
            this.blockPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.blockPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.blockPanel.Enabled = false;
            this.blockPanel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.blockPanel.Location = new System.Drawing.Point(7, 44);
            this.blockPanel.Name = "blockPanel";
            this.blockPanel.Size = new System.Drawing.Size(282, 59);
            this.blockPanel.TabIndex = 0;
            this.blockPanel.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 45);
            this.button2.TabIndex = 16;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 45);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(199, 241);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(90, 45);
            this.btn_clear.TabIndex = 14;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.Location = new System.Drawing.Point(14, 195);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(275, 40);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(14, 149);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(275, 40);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox_specialConditions
            // 
            this.checkBox_specialConditions.Location = new System.Drawing.Point(14, 103);
            this.checkBox_specialConditions.Name = "checkBox_specialConditions";
            this.checkBox_specialConditions.Size = new System.Drawing.Size(275, 40);
            this.checkBox_specialConditions.TabIndex = 11;
            this.checkBox_specialConditions.Text = "Specific conditions?";
            this.checkBox_specialConditions.UseVisualStyleBackColor = true;
            this.checkBox_specialConditions.CheckedChanged += new System.EventHandler(this.checkBox_specialConditions_CheckedChanged);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(199, 292);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(90, 45);
            this.btn_start.TabIndex = 10;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_load_settings
            // 
            this.btn_load_settings.Location = new System.Drawing.Point(7, 292);
            this.btn_load_settings.Name = "btn_load_settings";
            this.btn_load_settings.Size = new System.Drawing.Size(90, 45);
            this.btn_load_settings.TabIndex = 9;
            this.btn_load_settings.Text = "Load";
            this.btn_load_settings.UseVisualStyleBackColor = true;
            this.btn_load_settings.Click += new System.EventHandler(this.btn_load_settings_Click);
            // 
            // lbl_persons_count
            // 
            lbl_persons_count.FlatStyle = System.Windows.Forms.FlatStyle.System;
            lbl_persons_count.Location = new System.Drawing.Point(14, 50);
            lbl_persons_count.Name = "lbl_persons_count";
            lbl_persons_count.Size = new System.Drawing.Size(70, 26);
            lbl_persons_count.TabIndex = 8;
            lbl_persons_count.Text = "Persons";
            // 
            // dec_count_persons
            // 
            this.dec_count_persons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dec_count_persons.Location = new System.Drawing.Point(170, 44);
            this.dec_count_persons.Margin = new System.Windows.Forms.Padding(0);
            this.dec_count_persons.Name = "dec_count_persons";
            this.dec_count_persons.Size = new System.Drawing.Size(39, 38);
            this.dec_count_persons.TabIndex = 1;
            this.dec_count_persons.Text = "<";
            this.dec_count_persons.UseVisualStyleBackColor = true;
            this.dec_count_persons.Click += new System.EventHandler(this.dec_count_persons_Click);
            // 
            // btn_save_settings
            // 
            this.btn_save_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_settings.Location = new System.Drawing.Point(7, 241);
            this.btn_save_settings.Name = "btn_save_settings";
            this.btn_save_settings.Size = new System.Drawing.Size(90, 45);
            this.btn_save_settings.TabIndex = 3;
            this.btn_save_settings.Text = "Save";
            this.btn_save_settings.UseVisualStyleBackColor = true;
            this.btn_save_settings.Click += new System.EventHandler(this.btn_save_settings_Click);
            // 
            // settings
            // 
            settings.FlatStyle = System.Windows.Forms.FlatStyle.System;
            settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            settings.Location = new System.Drawing.Point(7, 12);
            settings.Name = "settings";
            settings.Size = new System.Drawing.Size(282, 23);
            settings.TabIndex = 7;
            settings.Text = "Generation settings:";
            // 
            // txt_person_counter
            // 
            this.txt_person_counter.Location = new System.Drawing.Point(90, 50);
            this.txt_person_counter.Name = "txt_person_counter";
            this.txt_person_counter.Size = new System.Drawing.Size(77, 26);
            this.txt_person_counter.TabIndex = 0;
            this.txt_person_counter.Tag = "txt_person_counter";
            this.txt_person_counter.Text = "4";
            this.txt_person_counter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_person_counter.TextChanged += new System.EventHandler(this.txt_person_counter_TextChanged);
            // 
            // inc_count_persons
            // 
            this.inc_count_persons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inc_count_persons.Location = new System.Drawing.Point(209, 44);
            this.inc_count_persons.Margin = new System.Windows.Forms.Padding(0);
            this.inc_count_persons.Name = "inc_count_persons";
            this.inc_count_persons.Size = new System.Drawing.Size(39, 38);
            this.inc_count_persons.TabIndex = 2;
            this.inc_count_persons.Text = ">";
            this.inc_count_persons.UseVisualStyleBackColor = true;
            this.inc_count_persons.Click += new System.EventHandler(this.inc_count_persons_Click);
            // 
            // Charact_chages
            // 
            Charact_chages.FlatStyle = System.Windows.Forms.FlatStyle.System;
            Charact_chages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Charact_chages.Location = new System.Drawing.Point(7, 14);
            Charact_chages.Name = "Charact_chages";
            Charact_chages.Size = new System.Drawing.Size(282, 23);
            Charact_chages.TabIndex = 17;
            Charact_chages.Text = "Characterization changes:";
            // 
            // changeOne_label
            // 
            changeOne_label.FlatStyle = System.Windows.Forms.FlatStyle.System;
            changeOne_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            changeOne_label.Location = new System.Drawing.Point(7, 54);
            changeOne_label.Name = "changeOne_label";
            changeOne_label.Size = new System.Drawing.Size(282, 23);
            changeOne_label.TabIndex = 18;
            changeOne_label.Text = "Change in one characteristic:";
            // 
            // changeOne_person_label
            // 
            changeOne_person_label.FlatStyle = System.Windows.Forms.FlatStyle.System;
            changeOne_person_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            changeOne_person_label.Location = new System.Drawing.Point(7, 89);
            changeOne_person_label.Name = "changeOne_person_label";
            changeOne_person_label.Size = new System.Drawing.Size(133, 23);
            changeOne_person_label.TabIndex = 19;
            changeOne_person_label.Text = "Person\'s number:";
            // 
            // changeOne_charact_label
            // 
            changeOne_charact_label.FlatStyle = System.Windows.Forms.FlatStyle.System;
            changeOne_charact_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            changeOne_charact_label.Location = new System.Drawing.Point(7, 123);
            changeOne_charact_label.Name = "changeOne_charact_label";
            changeOne_charact_label.Size = new System.Drawing.Size(133, 23);
            changeOne_charact_label.TabIndex = 20;
            changeOne_charact_label.Text = "Characteristic:";
            // 
            // personsBox
            // 
            this.personsBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.personsBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.personsBox.Location = new System.Drawing.Point(318, 12);
            this.personsBox.Name = "personsBox";
            this.personsBox.Size = new System.Drawing.Size(1584, 1016);
            this.personsBox.TabIndex = 6;
            this.personsBox.TabStop = false;
            // 
            // changes
            // 
            this.changes.BackColor = System.Drawing.SystemColors.MenuBar;
            this.changes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.changes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.changes.Controls.Add(this.changeOne_combobox_button);
            this.changes.Controls.Add(changeOne_charact_label);
            this.changes.Controls.Add(changeOne_person_label);
            this.changes.Controls.Add(changeOne_label);
            this.changes.Controls.Add(Charact_chages);
            this.changes.Controls.Add(this.changeOne_combobox_person_number);
            this.changes.Controls.Add(this.changeOne_combobox_charact);
            this.changes.Location = new System.Drawing.Point(12, 365);
            this.changes.Name = "changes";
            this.changes.Size = new System.Drawing.Size(300, 663);
            this.changes.TabIndex = 7;
            // 
            // changeOne_combobox_button
            // 
            this.changeOne_combobox_button.Location = new System.Drawing.Point(7, 154);
            this.changeOne_combobox_button.Name = "changeOne_combobox_button";
            this.changeOne_combobox_button.Size = new System.Drawing.Size(282, 45);
            this.changeOne_combobox_button.TabIndex = 21;
            this.changeOne_combobox_button.Text = "Change";
            this.changeOne_combobox_button.UseVisualStyleBackColor = true;
            this.changeOne_combobox_button.Click += new System.EventHandler(this.changeOne_combobox_button_Click);
            // 
            // changeOne_combobox_person_number
            // 
            this.changeOne_combobox_person_number.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.changeOne_combobox_person_number.FormattingEnabled = true;
            this.changeOne_combobox_person_number.Location = new System.Drawing.Point(146, 86);
            this.changeOne_combobox_person_number.Name = "changeOne_combobox_person_number";
            this.changeOne_combobox_person_number.Size = new System.Drawing.Size(143, 28);
            this.changeOne_combobox_person_number.TabIndex = 1;
            // 
            // changeOne_combobox_charact
            // 
            this.changeOne_combobox_charact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.changeOne_combobox_charact.FormattingEnabled = true;
            this.changeOne_combobox_charact.Location = new System.Drawing.Point(146, 120);
            this.changeOne_combobox_charact.Name = "changeOne_combobox_charact";
            this.changeOne_combobox_charact.Size = new System.Drawing.Size(143, 28);
            this.changeOne_combobox_charact.TabIndex = 0;
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(0, 0);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(75, 23);
            this.btnShowData.TabIndex = 0;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 1040);
            this.Controls.Add(this.changes);
            this.Controls.Add(this.personsBox);
            this.Controls.Add(settings_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "Form1";
            this.Tag = "";
            this.Text = "Bunk_generator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            settings_panel.ResumeLayout(false);
            settings_panel.PerformLayout();
            this.changes.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button changeOne_combobox_button;

        private System.Windows.Forms.Panel changes;

        private System.Windows.Forms.Panel blockPanel;

        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.GroupBox personsBox;

        private System.Windows.Forms.CheckBox checkBox_specialConditions;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;

        private System.Windows.Forms.Button btn_start;
        
        private System.Windows.Forms.Button btn_load_settings;

        private System.Windows.Forms.Button dec_count_persons;
        private System.Windows.Forms.Button inc_count_persons;

        private System.Windows.Forms.TextBox txt_person_counter;

        private System.Windows.Forms.Button btn_save_settings;
        
        private System.Windows.Forms.ComboBox changeOne_combobox_charact;
        private System.Windows.Forms.ComboBox changeOne_combobox_person_number;
        private System.Windows.Forms.Button btnShowData;

        #endregion
    }
}