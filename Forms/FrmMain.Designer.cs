
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
            this.SuspendLayout();
            // 
            // BtnNewEntry
            // 
            this.BtnNewEntry.Location = new System.Drawing.Point(331, 188);
            this.BtnNewEntry.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNewEntry.Name = "BtnNewEntry";
            this.BtnNewEntry.Size = new System.Drawing.Size(122, 41);
            this.BtnNewEntry.TabIndex = 0;
            this.BtnNewEntry.Text = "Add New Entry";
            this.BtnNewEntry.UseVisualStyleBackColor = true;
            this.BtnNewEntry.Click += new System.EventHandler(this.BtnNewEntry_Click);
            // 
            // LblLastEntryLabel
            // 
            this.LblLastEntryLabel.AutoSize = true;
            this.LblLastEntryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLastEntryLabel.Location = new System.Drawing.Point(303, 56);
            this.LblLastEntryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblLastEntryLabel.Name = "LblLastEntryLabel";
            this.LblLastEntryLabel.Size = new System.Drawing.Size(177, 20);
            this.LblLastEntryLabel.TabIndex = 1;
            this.LblLastEntryLabel.Text = "Last Blood Sugar Entry:";
            // 
            // LblLastEntry
            // 
            this.LblLastEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLastEntry.Location = new System.Drawing.Point(355, 98);
            this.LblLastEntry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblLastEntry.Name = "LblLastEntry";
            this.LblLastEntry.Size = new System.Drawing.Size(76, 44);
            this.LblLastEntry.TabIndex = 2;
            this.LblLastEntry.Text = "-";
            this.LblLastEntry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblLastEntryDate
            // 
            this.LblLastEntryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLastEntryDate.Location = new System.Drawing.Point(236, 158);
            this.LblLastEntryDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblLastEntryDate.Name = "LblLastEntryDate";
            this.LblLastEntryDate.Size = new System.Drawing.Size(311, 21);
            this.LblLastEntryDate.TabIndex = 3;
            this.LblLastEntryDate.Text = "Please click \"Add New Entry\" to get started";
            this.LblLastEntryDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "GlucoCheck";
            // 
            // BtnViewGraph
            // 
            this.BtnViewGraph.Location = new System.Drawing.Point(331, 242);
            this.BtnViewGraph.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnViewGraph.Name = "BtnViewGraph";
            this.BtnViewGraph.Size = new System.Drawing.Size(122, 41);
            this.BtnViewGraph.TabIndex = 5;
            this.BtnViewGraph.Text = "View Graph";
            this.BtnViewGraph.UseVisualStyleBackColor = true;
            this.BtnViewGraph.Click += new System.EventHandler(this.BtnViewGraph_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.BtnViewGraph);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblLastEntryDate);
            this.Controls.Add(this.LblLastEntry);
            this.Controls.Add(this.LblLastEntryLabel);
            this.Controls.Add(this.BtnNewEntry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
    }
}