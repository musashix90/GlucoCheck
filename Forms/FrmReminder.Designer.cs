
namespace GlucoCheck.Forms
{
    partial class FrmReminder
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
            this.LblReminder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblReminder
            // 
            this.LblReminder.AutoSize = true;
            this.LblReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReminder.Location = new System.Drawing.Point(12, 9);
            this.LblReminder.Name = "LblReminder";
            this.LblReminder.Size = new System.Drawing.Size(18, 20);
            this.LblReminder.TabIndex = 0;
            this.LblReminder.Text = "a";
            // 
            // FrmReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 86);
            this.Controls.Add(this.LblReminder);
            this.Name = "FrmReminder";
            this.Text = "GlucoCheck - Reminder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblReminder;
    }
}