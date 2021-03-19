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
            this.DGVLogEntries = new System.Windows.Forms.DataGridView();
            this.DTPFrom = new System.Windows.Forms.DateTimePicker();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.DTPTo = new System.Windows.Forms.DateTimePicker();
            this.SplContainerMain = new System.Windows.Forms.SplitContainer();
            this.Lbl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLogEntries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplContainerMain)).BeginInit();
            this.SplContainerMain.Panel1.SuspendLayout();
            this.SplContainerMain.Panel2.SuspendLayout();
            this.SplContainerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVLogEntries
            // 
            this.DGVLogEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLogEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVLogEntries.Location = new System.Drawing.Point(0, 0);
            this.DGVLogEntries.Name = "DGVLogEntries";
            this.DGVLogEntries.Size = new System.Drawing.Size(517, 459);
            this.DGVLogEntries.TabIndex = 0;
            // 
            // DTPFrom
            // 
            this.DTPFrom.Location = new System.Drawing.Point(16, 67);
            this.DTPFrom.Name = "DTPFrom";
            this.DTPFrom.Size = new System.Drawing.Size(200, 20);
            this.DTPFrom.TabIndex = 1;
            this.DTPFrom.ValueChanged += new System.EventHandler(this.DTPFrom_ValueChanged);
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2.Location = new System.Drawing.Point(13, 48);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(42, 16);
            this.Lbl2.TabIndex = 3;
            this.Lbl2.Text = "From:";
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl3.Location = new System.Drawing.Point(13, 97);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(28, 16);
            this.Lbl3.TabIndex = 4;
            this.Lbl3.Text = "To:";
            // 
            // DTPTo
            // 
            this.DTPTo.Location = new System.Drawing.Point(16, 116);
            this.DTPTo.Name = "DTPTo";
            this.DTPTo.Size = new System.Drawing.Size(200, 20);
            this.DTPTo.TabIndex = 5;
            this.DTPTo.ValueChanged += new System.EventHandler(this.DTPTo_ValueChanged);
            // 
            // SplContainerMain
            // 
            this.SplContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SplContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplContainerMain.Location = new System.Drawing.Point(0, 0);
            this.SplContainerMain.Name = "SplContainerMain";
            // 
            // SplContainerMain.Panel1
            // 
            this.SplContainerMain.Panel1.Controls.Add(this.Lbl1);
            this.SplContainerMain.Panel1.Controls.Add(this.Lbl2);
            this.SplContainerMain.Panel1.Controls.Add(this.DTPTo);
            this.SplContainerMain.Panel1.Controls.Add(this.DTPFrom);
            this.SplContainerMain.Panel1.Controls.Add(this.Lbl3);
            // 
            // SplContainerMain.Panel2
            // 
            this.SplContainerMain.Panel2.Controls.Add(this.DGVLogEntries);
            this.SplContainerMain.Size = new System.Drawing.Size(784, 461);
            this.SplContainerMain.SplitterDistance = 261;
            this.SplContainerMain.TabIndex = 6;
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.Location = new System.Drawing.Point(12, 9);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(100, 20);
            this.Lbl1.TabIndex = 6;
            this.Lbl1.Text = "Filter options";
            // 
            // FrmLogViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.SplContainerMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmLogViewer";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log viewer";
            this.Load += new System.EventHandler(this.FrmLogViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVLogEntries)).EndInit();
            this.SplContainerMain.Panel1.ResumeLayout(false);
            this.SplContainerMain.Panel1.PerformLayout();
            this.SplContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplContainerMain)).EndInit();
            this.SplContainerMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVLogEntries;
        private System.Windows.Forms.DateTimePicker DTPFrom;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.DateTimePicker DTPTo;
        private System.Windows.Forms.SplitContainer SplContainerMain;
        private System.Windows.Forms.Label Lbl1;
    }
}