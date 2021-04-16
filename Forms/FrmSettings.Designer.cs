
namespace GlucoCheck.Forms
{
    partial class FrmSettings
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
            this.HighThresholdTextBox = new System.Windows.Forms.TextBox();
            this.HighThresholdLabel = new System.Windows.Forms.Label();
            this.LowThresholdTextBox = new System.Windows.Forms.TextBox();
            this.LowThresholdLabel = new System.Windows.Forms.Label();
            this.ThresholdSectionLabel = new System.Windows.Forms.Label();
            this.MmolButton = new System.Windows.Forms.RadioButton();
            this.MeasurementGroupBox = new System.Windows.Forms.GroupBox();
            this.MgButton = new System.Windows.Forms.RadioButton();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ActiveHoursLabel = new System.Windows.Forms.Label();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RemindersLabel = new System.Windows.Forms.Label();
            this.DailyReminderLabel = new System.Windows.Forms.Label();
            this.SecondEntryReminder = new System.Windows.Forms.Label();
            this.DailyReminderUpDown = new System.Windows.Forms.NumericUpDown();
            this.SecondReminderUpDown = new System.Windows.Forms.NumericUpDown();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.MeasurementGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DailyReminderUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondReminderUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // HighThresholdTextBox
            // 
            this.HighThresholdTextBox.Location = new System.Drawing.Point(42, 39);
            this.HighThresholdTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HighThresholdTextBox.Name = "HighThresholdTextBox";
            this.HighThresholdTextBox.Size = new System.Drawing.Size(68, 20);
            this.HighThresholdTextBox.TabIndex = 0;
            // 
            // HighThresholdLabel
            // 
            this.HighThresholdLabel.AutoSize = true;
            this.HighThresholdLabel.Location = new System.Drawing.Point(8, 41);
            this.HighThresholdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HighThresholdLabel.Name = "HighThresholdLabel";
            this.HighThresholdLabel.Size = new System.Drawing.Size(32, 13);
            this.HighThresholdLabel.TabIndex = 1;
            this.HighThresholdLabel.Text = "High:";
            // 
            // LowThresholdTextBox
            // 
            this.LowThresholdTextBox.Location = new System.Drawing.Point(180, 39);
            this.LowThresholdTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LowThresholdTextBox.Name = "LowThresholdTextBox";
            this.LowThresholdTextBox.Size = new System.Drawing.Size(68, 20);
            this.LowThresholdTextBox.TabIndex = 2;
            // 
            // LowThresholdLabel
            // 
            this.LowThresholdLabel.AutoSize = true;
            this.LowThresholdLabel.Location = new System.Drawing.Point(148, 41);
            this.LowThresholdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LowThresholdLabel.Name = "LowThresholdLabel";
            this.LowThresholdLabel.Size = new System.Drawing.Size(30, 13);
            this.LowThresholdLabel.TabIndex = 4;
            this.LowThresholdLabel.Text = "Low:";
            // 
            // ThresholdSectionLabel
            // 
            this.ThresholdSectionLabel.AutoSize = true;
            this.ThresholdSectionLabel.Location = new System.Drawing.Point(8, 18);
            this.ThresholdSectionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ThresholdSectionLabel.Name = "ThresholdSectionLabel";
            this.ThresholdSectionLabel.Size = new System.Drawing.Size(149, 13);
            this.ThresholdSectionLabel.TabIndex = 5;
            this.ThresholdSectionLabel.Text = "Blood Sugar Level Thresholds";
            // 
            // MmolButton
            // 
            this.MmolButton.AutoSize = true;
            this.MmolButton.Location = new System.Drawing.Point(4, 26);
            this.MmolButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MmolButton.Name = "MmolButton";
            this.MmolButton.Size = new System.Drawing.Size(150, 17);
            this.MmolButton.TabIndex = 7;
            this.MmolButton.TabStop = true;
            this.MmolButton.Text = "Millimoles per liter (mmol/L)";
            this.MmolButton.UseVisualStyleBackColor = true;
            this.MmolButton.CheckedChanged += new System.EventHandler(this.MmolButton_CheckedChanged);
            // 
            // MeasurementGroupBox
            // 
            this.MeasurementGroupBox.Controls.Add(this.MgButton);
            this.MeasurementGroupBox.Controls.Add(this.MmolButton);
            this.MeasurementGroupBox.Location = new System.Drawing.Point(10, 85);
            this.MeasurementGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MeasurementGroupBox.Name = "MeasurementGroupBox";
            this.MeasurementGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MeasurementGroupBox.Size = new System.Drawing.Size(184, 67);
            this.MeasurementGroupBox.TabIndex = 8;
            this.MeasurementGroupBox.TabStop = false;
            this.MeasurementGroupBox.Text = "Unit of Measurement";
            // 
            // MgButton
            // 
            this.MgButton.AutoSize = true;
            this.MgButton.Location = new System.Drawing.Point(4, 46);
            this.MgButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MgButton.Name = "MgButton";
            this.MgButton.Size = new System.Drawing.Size(167, 17);
            this.MgButton.TabIndex = 9;
            this.MgButton.TabStop = true;
            this.MgButton.Text = "Milligrams per deciliter (mg/dL)";
            this.MgButton.UseVisualStyleBackColor = true;
            this.MgButton.CheckedChanged += new System.EventHandler(this.MgButton_CheckedChanged);
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.CustomFormat = "hh:mm tt";
            this.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartTimePicker.Location = new System.Drawing.Point(42, 192);
            this.StartTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.ShowUpDown = true;
            this.StartTimePicker.Size = new System.Drawing.Size(94, 20);
            this.StartTimePicker.TabIndex = 9;
            this.StartTimePicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartTimePicker_MouseDown);
            // 
            // ActiveHoursLabel
            // 
            this.ActiveHoursLabel.AutoSize = true;
            this.ActiveHoursLabel.Location = new System.Drawing.Point(8, 171);
            this.ActiveHoursLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ActiveHoursLabel.Name = "ActiveHoursLabel";
            this.ActiveHoursLabel.Size = new System.Drawing.Size(68, 13);
            this.ActiveHoursLabel.TabIndex = 10;
            this.ActiveHoursLabel.Text = "Active Hours";
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Location = new System.Drawing.Point(8, 196);
            this.StartTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(32, 13);
            this.StartTimeLabel.TabIndex = 11;
            this.StartTimeLabel.Text = "Start:";
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.Location = new System.Drawing.Point(148, 196);
            this.EndTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(29, 13);
            this.EndTimeLabel.TabIndex = 12;
            this.EndTimeLabel.Text = "End:";
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.CustomFormat = "hh:mm tt";
            this.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndTimePicker.Location = new System.Drawing.Point(180, 192);
            this.EndTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.ShowUpDown = true;
            this.EndTimePicker.Size = new System.Drawing.Size(98, 20);
            this.EndTimePicker.TabIndex = 13;
            this.EndTimePicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EndTimePicker_MouseDown);
            // 
            // RemindersLabel
            // 
            this.RemindersLabel.AutoSize = true;
            this.RemindersLabel.Location = new System.Drawing.Point(8, 235);
            this.RemindersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RemindersLabel.Name = "RemindersLabel";
            this.RemindersLabel.Size = new System.Drawing.Size(57, 13);
            this.RemindersLabel.TabIndex = 14;
            this.RemindersLabel.Text = "Reminders";
            // 
            // DailyReminderLabel
            // 
            this.DailyReminderLabel.AutoSize = true;
            this.DailyReminderLabel.Location = new System.Drawing.Point(8, 257);
            this.DailyReminderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DailyReminderLabel.Name = "DailyReminderLabel";
            this.DailyReminderLabel.Size = new System.Drawing.Size(203, 13);
            this.DailyReminderLabel.TabIndex = 15;
            this.DailyReminderLabel.Text = "Hours Elapsed Between Daily Reminders:";
            // 
            // SecondEntryReminder
            // 
            this.SecondEntryReminder.AutoSize = true;
            this.SecondEntryReminder.Location = new System.Drawing.Point(8, 277);
            this.SecondEntryReminder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SecondEntryReminder.Name = "SecondEntryReminder";
            this.SecondEntryReminder.Size = new System.Drawing.Size(250, 13);
            this.SecondEntryReminder.TabIndex = 16;
            this.SecondEntryReminder.Text = "Hours Elapsed Between First and Second Reading:";
            // 
            // DailyReminderUpDown
            // 
            this.DailyReminderUpDown.Location = new System.Drawing.Point(214, 256);
            this.DailyReminderUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DailyReminderUpDown.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.DailyReminderUpDown.Name = "DailyReminderUpDown";
            this.DailyReminderUpDown.Size = new System.Drawing.Size(38, 20);
            this.DailyReminderUpDown.TabIndex = 17;
            // 
            // SecondReminderUpDown
            // 
            this.SecondReminderUpDown.Location = new System.Drawing.Point(262, 276);
            this.SecondReminderUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SecondReminderUpDown.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.SecondReminderUpDown.Name = "SecondReminderUpDown";
            this.SecondReminderUpDown.Size = new System.Drawing.Size(38, 20);
            this.SecondReminderUpDown.TabIndex = 18;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(10, 311);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(132, 27);
            this.SaveBtn.TabIndex = 19;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 351);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.SecondReminderUpDown);
            this.Controls.Add(this.DailyReminderUpDown);
            this.Controls.Add(this.SecondEntryReminder);
            this.Controls.Add(this.DailyReminderLabel);
            this.Controls.Add(this.RemindersLabel);
            this.Controls.Add(this.EndTimePicker);
            this.Controls.Add(this.EndTimeLabel);
            this.Controls.Add(this.StartTimeLabel);
            this.Controls.Add(this.ActiveHoursLabel);
            this.Controls.Add(this.StartTimePicker);
            this.Controls.Add(this.MeasurementGroupBox);
            this.Controls.Add(this.ThresholdSectionLabel);
            this.Controls.Add(this.LowThresholdLabel);
            this.Controls.Add(this.LowThresholdTextBox);
            this.Controls.Add(this.HighThresholdLabel);
            this.Controls.Add(this.HighThresholdTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GlucoCheck - Settings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.MeasurementGroupBox.ResumeLayout(false);
            this.MeasurementGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DailyReminderUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondReminderUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HighThresholdTextBox;
        private System.Windows.Forms.Label HighThresholdLabel;
        private System.Windows.Forms.TextBox LowThresholdTextBox;
        private System.Windows.Forms.Label LowThresholdLabel;
        private System.Windows.Forms.Label ThresholdSectionLabel;
        private System.Windows.Forms.RadioButton MmolButton;
        private System.Windows.Forms.GroupBox MeasurementGroupBox;
        private System.Windows.Forms.RadioButton MgButton;
        private System.Windows.Forms.DateTimePicker StartTimePicker;
        private System.Windows.Forms.Label ActiveHoursLabel;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.Label EndTimeLabel;
        private System.Windows.Forms.DateTimePicker EndTimePicker;
        private System.Windows.Forms.Label RemindersLabel;
        private System.Windows.Forms.Label DailyReminderLabel;
        private System.Windows.Forms.Label SecondEntryReminder;
        private System.Windows.Forms.NumericUpDown DailyReminderUpDown;
        private System.Windows.Forms.NumericUpDown SecondReminderUpDown;
        private System.Windows.Forms.Button SaveBtn;
    }
}