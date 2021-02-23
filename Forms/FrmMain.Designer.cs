
namespace GlucoCheck.Forms
{
    partial class FrmMain
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
            this.BtnNewEntry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnNewEntry
            // 
            this.BtnNewEntry.Location = new System.Drawing.Point(649, 363);
            this.BtnNewEntry.Name = "BtnNewEntry";
            this.BtnNewEntry.Size = new System.Drawing.Size(245, 78);
            this.BtnNewEntry.TabIndex = 0;
            this.BtnNewEntry.Text = "Add New Entry";
            this.BtnNewEntry.UseVisualStyleBackColor = true;
            this.BtnNewEntry.Click += new System.EventHandler(this.BtnNewEntry_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 887);
            this.Controls.Add(this.BtnNewEntry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNewEntry;
    }
}