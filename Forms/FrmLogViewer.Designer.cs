
namespace GlucoCheck.Forms
{
    partial class FrmLogViewer
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
            this.DateTimePkrFrom = new System.Windows.Forms.DateTimePicker();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.DateTimePkrTo = new System.Windows.Forms.DateTimePicker();
            this.LstboxEntries = new System.Windows.Forms.ListBox();
            this.LblEntriesHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DateTimePkrFrom
            // 
            this.DateTimePkrFrom.Location = new System.Drawing.Point(16, 44);
            this.DateTimePkrFrom.Name = "DateTimePkrFrom";
            this.DateTimePkrFrom.Size = new System.Drawing.Size(200, 20);
            this.DateTimePkrFrom.TabIndex = 0;
            this.DateTimePkrFrom.ValueChanged += new System.EventHandler(this.DateTimePkrFrom_ValueChanged);
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.Location = new System.Drawing.Point(12, 21);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(50, 20);
            this.Lbl1.TabIndex = 1;
            this.Lbl1.Text = "From:";
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2.Location = new System.Drawing.Point(223, 21);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(31, 20);
            this.Lbl2.TabIndex = 2;
            this.Lbl2.Text = "To:";
            // 
            // DateTimePkrTo
            // 
            this.DateTimePkrTo.Location = new System.Drawing.Point(227, 44);
            this.DateTimePkrTo.Name = "DateTimePkrTo";
            this.DateTimePkrTo.Size = new System.Drawing.Size(200, 20);
            this.DateTimePkrTo.TabIndex = 3;
            this.DateTimePkrTo.ValueChanged += new System.EventHandler(this.DateTimePkrTo_ValueChanged);
            // 
            // LstboxEntries
            // 
            this.LstboxEntries.FormattingEnabled = true;
            this.LstboxEntries.Location = new System.Drawing.Point(16, 95);
            this.LstboxEntries.Name = "LstboxEntries";
            this.LstboxEntries.Size = new System.Drawing.Size(411, 238);
            this.LstboxEntries.TabIndex = 4;
            this.LstboxEntries.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstboxEntries_MouseDoubleClick);
            // 
            // LblEntriesHeader
            // 
            this.LblEntriesHeader.AutoSize = true;
            this.LblEntriesHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEntriesHeader.Location = new System.Drawing.Point(12, 72);
            this.LblEntriesHeader.Name = "LblEntriesHeader";
            this.LblEntriesHeader.Size = new System.Drawing.Size(88, 20);
            this.LblEntriesHeader.TabIndex = 5;
            this.LblEntriesHeader.Text = "Log entires";
            // 
            // FrmLogViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 346);
            this.Controls.Add(this.LblEntriesHeader);
            this.Controls.Add(this.LstboxEntries);
            this.Controls.Add(this.DateTimePkrTo);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.DateTimePkrFrom);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmLogViewer";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log viewer";
            this.Load += new System.EventHandler(this.FrmLogViewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimePkrFrom;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.DateTimePicker DateTimePkrTo;
        private System.Windows.Forms.ListBox LstboxEntries;
        private System.Windows.Forms.Label LblEntriesHeader;
    }
}