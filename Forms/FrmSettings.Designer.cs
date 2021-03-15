
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.RemindersLabel = new System.Windows.Forms.Label();
            this.DailyReminderLabel = new System.Windows.Forms.Label();
            this.SecondEntryReminder = new System.Windows.Forms.Label();
            this.DailyReminderUpDown = new System.Windows.Forms.NumericUpDown();
            this.SecondReminderUpDown = new System.Windows.Forms.NumericUpDown();
            this.MeasurementGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DailyReminderUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondReminderUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // HighThresholdTextBox
            // 
            this.HighThresholdTextBox.Location = new System.Drawing.Point(64, 60);
            this.HighThresholdTextBox.Name = "HighThresholdTextBox";
            this.HighThresholdTextBox.Size = new System.Drawing.Size(100, 26);
            this.HighThresholdTextBox.TabIndex = 0;
            // 
            // HighThresholdLabel
            // 
            this.HighThresholdLabel.AutoSize = true;
            this.HighThresholdLabel.Location = new System.Drawing.Point(12, 63);
            this.HighThresholdLabel.Name = "HighThresholdLabel";
            this.HighThresholdLabel.Size = new System.Drawing.Size(46, 20);
            this.HighThresholdLabel.TabIndex = 1;
            this.HighThresholdLabel.Text = "High:";
            // 
            // LowThresholdTextBox
            // 
            this.LowThresholdTextBox.Location = new System.Drawing.Point(269, 60);
            this.LowThresholdTextBox.Name = "LowThresholdTextBox";
            this.LowThresholdTextBox.Size = new System.Drawing.Size(100, 26);
            this.LowThresholdTextBox.TabIndex = 2;
            // 
            // LowThresholdLabel
            // 
            this.LowThresholdLabel.AutoSize = true;
            this.LowThresholdLabel.Location = new System.Drawing.Point(221, 63);
            this.LowThresholdLabel.Name = "LowThresholdLabel";
            this.LowThresholdLabel.Size = new System.Drawing.Size(42, 20);
            this.LowThresholdLabel.TabIndex = 4;
            this.LowThresholdLabel.Text = "Low:";
            // 
            // ThresholdSectionLabel
            // 
            this.ThresholdSectionLabel.AutoSize = true;
            this.ThresholdSectionLabel.Location = new System.Drawing.Point(12, 27);
            this.ThresholdSectionLabel.Name = "ThresholdSectionLabel";
            this.ThresholdSectionLabel.Size = new System.Drawing.Size(220, 20);
            this.ThresholdSectionLabel.TabIndex = 5;
            this.ThresholdSectionLabel.Text = "Blood Sugar Level Thresholds";
            // 
            // MmolButton
            // 
            this.MmolButton.AutoSize = true;
            this.MmolButton.Location = new System.Drawing.Point(6, 40);
            this.MmolButton.Name = "MmolButton";
            this.MmolButton.Size = new System.Drawing.Size(222, 24);
            this.MmolButton.TabIndex = 7;
            this.MmolButton.TabStop = true;
            this.MmolButton.Text = "Millimoles per liter (mmol/L)";
            this.MmolButton.UseVisualStyleBackColor = true;
            // 
            // MeasurementGroupBox
            // 
            this.MeasurementGroupBox.Controls.Add(this.MgButton);
            this.MeasurementGroupBox.Controls.Add(this.MmolButton);
            this.MeasurementGroupBox.Location = new System.Drawing.Point(16, 131);
            this.MeasurementGroupBox.Name = "MeasurementGroupBox";
            this.MeasurementGroupBox.Size = new System.Drawing.Size(276, 103);
            this.MeasurementGroupBox.TabIndex = 8;
            this.MeasurementGroupBox.TabStop = false;
            this.MeasurementGroupBox.Text = "Unit of Measurement";
            // 
            // MgButton
            // 
            this.MgButton.AutoSize = true;
            this.MgButton.Location = new System.Drawing.Point(6, 70);
            this.MgButton.Name = "MgButton";
            this.MgButton.Size = new System.Drawing.Size(246, 24);
            this.MgButton.TabIndex = 9;
            this.MgButton.TabStop = true;
            this.MgButton.Text = "Milligrams per deciliter (mg/dL)";
            this.MgButton.UseVisualStyleBackColor = true;
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.CustomFormat = "hh:mm tt";
            this.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartTimePicker.Location = new System.Drawing.Point(64, 296);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.ShowUpDown = true;
            this.StartTimePicker.Size = new System.Drawing.Size(138, 26);
            this.StartTimePicker.TabIndex = 9;
            // 
            // ActiveHoursLabel
            // 
            this.ActiveHoursLabel.AutoSize = true;
            this.ActiveHoursLabel.Location = new System.Drawing.Point(12, 263);
            this.ActiveHoursLabel.Name = "ActiveHoursLabel";
            this.ActiveHoursLabel.Size = new System.Drawing.Size(99, 20);
            this.ActiveHoursLabel.TabIndex = 10;
            this.ActiveHoursLabel.Text = "Active Hours";
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Location = new System.Drawing.Point(12, 301);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(48, 20);
            this.StartTimeLabel.TabIndex = 11;
            this.StartTimeLabel.Text = "Start:";
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.Location = new System.Drawing.Point(221, 301);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(42, 20);
            this.EndTimeLabel.TabIndex = 12;
            this.EndTimeLabel.Text = "End:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "hh:mm tt";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(269, 295);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 26);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // RemindersLabel
            // 
            this.RemindersLabel.AutoSize = true;
            this.RemindersLabel.Location = new System.Drawing.Point(12, 362);
            this.RemindersLabel.Name = "RemindersLabel";
            this.RemindersLabel.Size = new System.Drawing.Size(86, 20);
            this.RemindersLabel.TabIndex = 14;
            this.RemindersLabel.Text = "Reminders";
            // 
            // DailyReminderLabel
            // 
            this.DailyReminderLabel.AutoSize = true;
            this.DailyReminderLabel.Location = new System.Drawing.Point(12, 396);
            this.DailyReminderLabel.Name = "DailyReminderLabel";
            this.DailyReminderLabel.Size = new System.Drawing.Size(456, 30);
            this.DailyReminderLabel.TabIndex = 15;
            this.DailyReminderLabel.Text = "Hours Elapsed Between Daily Reminders:";
            // 
            // SecondEntryReminder
            // 
            this.SecondEntryReminder.AutoSize = true;
            this.SecondEntryReminder.Location = new System.Drawing.Point(12, 426);
            this.SecondEntryReminder.Name = "SecondEntryReminder";
            this.SecondEntryReminder.Size = new System.Drawing.Size(561, 30);
            this.SecondEntryReminder.TabIndex = 16;
            this.SecondEntryReminder.Text = "Hours Elapsed Between First and Second Reading:";
            // 
            // DailyReminderUpDown
            // 
            this.DailyReminderUpDown.Location = new System.Drawing.Point(322, 394);
            this.DailyReminderUpDown.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.DailyReminderUpDown.Name = "DailyReminderUpDown";
            this.DailyReminderUpDown.Size = new System.Drawing.Size(56, 26);
            this.DailyReminderUpDown.TabIndex = 17;
            // 
            // SecondReminderUpDown
            // 
            this.SecondReminderUpDown.Location = new System.Drawing.Point(392, 424);
            this.SecondReminderUpDown.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.SecondReminderUpDown.Name = "SecondReminderUpDown";
            this.SecondReminderUpDown.Size = new System.Drawing.Size(56, 26);
            this.SecondReminderUpDown.TabIndex = 18;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.SecondReminderUpDown);
            this.Controls.Add(this.DailyReminderUpDown);
            this.Controls.Add(this.SecondEntryReminder);
            this.Controls.Add(this.DailyReminderLabel);
            this.Controls.Add(this.RemindersLabel);
            this.Controls.Add(this.dateTimePicker1);
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
            this.Name = "FrmSettings";
            this.Text = "Settings";
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label RemindersLabel;
        private System.Windows.Forms.Label DailyReminderLabel;
        private System.Windows.Forms.Label SecondEntryReminder;
        private System.Windows.Forms.NumericUpDown DailyReminderUpDown;
        private System.Windows.Forms.NumericUpDown SecondReminderUpDown;
    }
}