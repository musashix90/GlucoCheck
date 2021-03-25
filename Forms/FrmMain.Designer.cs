
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
            this.components = new System.ComponentModel.Container();
            this.BtnNewEntry = new System.Windows.Forms.Button();
            this.LblLastEntryLabel = new System.Windows.Forms.Label();
            this.LblLastEntry = new System.Windows.Forms.Label();
            this.LblLastEntryDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnViewGraph = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnViewLog = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnNewEntry
            // 
            this.BtnNewEntry.Location = new System.Drawing.Point(496, 289);
            this.BtnNewEntry.Name = "BtnNewEntry";
            this.BtnNewEntry.Size = new System.Drawing.Size(183, 63);
            this.BtnNewEntry.TabIndex = 0;
            this.BtnNewEntry.Text = "Add New Entry";
            this.BtnNewEntry.UseVisualStyleBackColor = true;
            this.BtnNewEntry.Click += new System.EventHandler(this.BtnNewEntry_Click);
            // 
            // LblLastEntryLabel
            // 
            this.LblLastEntryLabel.AutoSize = true;
            this.LblLastEntryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLastEntryLabel.Location = new System.Drawing.Point(454, 86);
            this.LblLastEntryLabel.Name = "LblLastEntryLabel";
            this.LblLastEntryLabel.Size = new System.Drawing.Size(263, 29);
            this.LblLastEntryLabel.TabIndex = 1;
            this.LblLastEntryLabel.Text = "Last Blood Sugar Entry:";
            // 
            // LblLastEntry
            // 
            this.LblLastEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLastEntry.Location = new System.Drawing.Point(532, 151);
            this.LblLastEntry.Name = "LblLastEntry";
            this.LblLastEntry.Size = new System.Drawing.Size(114, 68);
            this.LblLastEntry.TabIndex = 2;
            this.LblLastEntry.Text = "-";
            this.LblLastEntry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblLastEntryDate
            // 
            this.LblLastEntryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLastEntryDate.Location = new System.Drawing.Point(354, 243);
            this.LblLastEntryDate.Name = "LblLastEntryDate";
            this.LblLastEntryDate.Size = new System.Drawing.Size(466, 32);
            this.LblLastEntryDate.TabIndex = 3;
            this.LblLastEntryDate.Text = "Please click \"Add New Entry\" to get started";
            this.LblLastEntryDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "GlucoCheck";
            // 
            // BtnViewGraph
            // 
            this.BtnViewGraph.Location = new System.Drawing.Point(496, 377);
            this.BtnViewGraph.Name = "BtnViewGraph";
            this.BtnViewGraph.Size = new System.Drawing.Size(183, 63);
            this.BtnViewGraph.TabIndex = 5;
            this.BtnViewGraph.Text = "View Graph";
            this.BtnViewGraph.UseVisualStyleBackColor = true;
            this.BtnViewGraph.Click += new System.EventHandler(this.BtnViewGraph_Click);
            // 
            // BtnViewLog
            // 
            this.BtnViewLog.Location = new System.Drawing.Point(496, 465);
            this.BtnViewLog.Name = "BtnViewLog";
            this.BtnViewLog.Size = new System.Drawing.Size(183, 63);
            this.BtnViewLog.TabIndex = 6;
            this.BtnViewLog.Text = "View Log";
            this.BtnViewLog.UseVisualStyleBackColor = true;
            this.BtnViewLog.Click += new System.EventHandler(this.BtnViewLog_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Location = new System.Drawing.Point(496, 554);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(183, 63);
            this.SettingsBtn.TabIndex = 7;
            this.SettingsBtn.Text = "View Settings";
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 711);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.BtnViewLog);
            this.Controls.Add(this.BtnViewGraph);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblLastEntryDate);
            this.Controls.Add(this.LblLastEntry);
            this.Controls.Add(this.LblLastEntryLabel);
            this.Controls.Add(this.BtnNewEntry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GlucoCheck - Main";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNewEntry;
        private System.Windows.Forms.Label LblLastEntryLabel;
        private System.Windows.Forms.Label LblLastEntry;
        private System.Windows.Forms.Label LblLastEntryDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnViewGraph;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnViewLog;
        private System.Windows.Forms.Button SettingsBtn;
    }
}