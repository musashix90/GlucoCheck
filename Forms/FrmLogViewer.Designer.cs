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
            this.NumUDBSLValue = new System.Windows.Forms.NumericUpDown();
            this.ComboxBSLFilter = new System.Windows.Forms.ComboBox();
            this.Lbl4 = new System.Windows.Forms.Label();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.BtnApplyFilter = new System.Windows.Forms.Button();
            this.BtnClearFilter = new System.Windows.Forms.Button();
            this.NumUDCarbsValue = new System.Windows.Forms.NumericUpDown();
            this.ComboxCarbsFilter = new System.Windows.Forms.ComboBox();
            this.Lbl5 = new System.Windows.Forms.Label();
            this.NumUDInsulinValue = new System.Windows.Forms.NumericUpDown();
            this.ComboxInsulinFilter = new System.Windows.Forms.ComboBox();
            this.Lbl6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLogEntries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplContainerMain)).BeginInit();
            this.SplContainerMain.Panel1.SuspendLayout();
            this.SplContainerMain.Panel2.SuspendLayout();
            this.SplContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDBSLValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDCarbsValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDInsulinValue)).BeginInit();
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
            this.DTPFrom.Size = new System.Drawing.Size(224, 20);
            this.DTPFrom.TabIndex = 1;
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
            this.DTPTo.Size = new System.Drawing.Size(224, 20);
            this.DTPTo.TabIndex = 5;
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
            this.SplContainerMain.Panel1.Controls.Add(this.NumUDInsulinValue);
            this.SplContainerMain.Panel1.Controls.Add(this.ComboxInsulinFilter);
            this.SplContainerMain.Panel1.Controls.Add(this.Lbl6);
            this.SplContainerMain.Panel1.Controls.Add(this.NumUDCarbsValue);
            this.SplContainerMain.Panel1.Controls.Add(this.ComboxCarbsFilter);
            this.SplContainerMain.Panel1.Controls.Add(this.Lbl5);
            this.SplContainerMain.Panel1.Controls.Add(this.BtnClearFilter);
            this.SplContainerMain.Panel1.Controls.Add(this.BtnApplyFilter);
            this.SplContainerMain.Panel1.Controls.Add(this.NumUDBSLValue);
            this.SplContainerMain.Panel1.Controls.Add(this.ComboxBSLFilter);
            this.SplContainerMain.Panel1.Controls.Add(this.Lbl4);
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
            // NumUDBSLValue
            // 
            this.NumUDBSLValue.Location = new System.Drawing.Point(129, 188);
            this.NumUDBSLValue.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.NumUDBSLValue.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumUDBSLValue.Name = "NumUDBSLValue";
            this.NumUDBSLValue.Size = new System.Drawing.Size(111, 20);
            this.NumUDBSLValue.TabIndex = 9;
            this.NumUDBSLValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ComboxBSLFilter
            // 
            this.ComboxBSLFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboxBSLFilter.FormattingEnabled = true;
            this.ComboxBSLFilter.Items.AddRange(new object[] {
            "=",
            ">",
            "<"});
            this.ComboxBSLFilter.Location = new System.Drawing.Point(16, 188);
            this.ComboxBSLFilter.Name = "ComboxBSLFilter";
            this.ComboxBSLFilter.Size = new System.Drawing.Size(107, 21);
            this.ComboxBSLFilter.TabIndex = 8;
            // 
            // Lbl4
            // 
            this.Lbl4.AutoSize = true;
            this.Lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl4.Location = new System.Drawing.Point(13, 169);
            this.Lbl4.Name = "Lbl4";
            this.Lbl4.Size = new System.Drawing.Size(79, 16);
            this.Lbl4.TabIndex = 7;
            this.Lbl4.Text = "Where BSL:";
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
            // BtnApplyFilter
            // 
            this.BtnApplyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApplyFilter.Location = new System.Drawing.Point(16, 423);
            this.BtnApplyFilter.Name = "BtnApplyFilter";
            this.BtnApplyFilter.Size = new System.Drawing.Size(109, 25);
            this.BtnApplyFilter.TabIndex = 10;
            this.BtnApplyFilter.Text = "Apply filter";
            this.BtnApplyFilter.UseVisualStyleBackColor = true;
            this.BtnApplyFilter.Click += new System.EventHandler(this.BtnApplyFilter_Click);
            // 
            // BtnClearFilter
            // 
            this.BtnClearFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClearFilter.Location = new System.Drawing.Point(131, 423);
            this.BtnClearFilter.Name = "BtnClearFilter";
            this.BtnClearFilter.Size = new System.Drawing.Size(109, 25);
            this.BtnClearFilter.TabIndex = 11;
            this.BtnClearFilter.Text = "Clear filter";
            this.BtnClearFilter.UseVisualStyleBackColor = true;
            this.BtnClearFilter.Click += new System.EventHandler(this.BtnClearFilter_Click);
            // 
            // NumUDCarbsValue
            // 
            this.NumUDCarbsValue.Location = new System.Drawing.Point(131, 250);
            this.NumUDCarbsValue.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NumUDCarbsValue.Name = "NumUDCarbsValue";
            this.NumUDCarbsValue.Size = new System.Drawing.Size(109, 20);
            this.NumUDCarbsValue.TabIndex = 14;
            this.NumUDCarbsValue.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // ComboxCarbsFilter
            // 
            this.ComboxCarbsFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboxCarbsFilter.FormattingEnabled = true;
            this.ComboxCarbsFilter.Items.AddRange(new object[] {
            "=",
            ">",
            "<"});
            this.ComboxCarbsFilter.Location = new System.Drawing.Point(16, 249);
            this.ComboxCarbsFilter.Name = "ComboxCarbsFilter";
            this.ComboxCarbsFilter.Size = new System.Drawing.Size(107, 21);
            this.ComboxCarbsFilter.TabIndex = 13;
            // 
            // Lbl5
            // 
            this.Lbl5.AutoSize = true;
            this.Lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl5.Location = new System.Drawing.Point(15, 230);
            this.Lbl5.Name = "Lbl5";
            this.Lbl5.Size = new System.Drawing.Size(88, 16);
            this.Lbl5.TabIndex = 12;
            this.Lbl5.Text = "Where carbs:";
            // 
            // NumUDInsulinValue
            // 
            this.NumUDInsulinValue.Location = new System.Drawing.Point(131, 311);
            this.NumUDInsulinValue.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NumUDInsulinValue.Name = "NumUDInsulinValue";
            this.NumUDInsulinValue.Size = new System.Drawing.Size(109, 20);
            this.NumUDInsulinValue.TabIndex = 17;
            this.NumUDInsulinValue.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // ComboxInsulinFilter
            // 
            this.ComboxInsulinFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboxInsulinFilter.FormattingEnabled = true;
            this.ComboxInsulinFilter.Items.AddRange(new object[] {
            "=",
            ">",
            "<"});
            this.ComboxInsulinFilter.Location = new System.Drawing.Point(18, 310);
            this.ComboxInsulinFilter.Name = "ComboxInsulinFilter";
            this.ComboxInsulinFilter.Size = new System.Drawing.Size(107, 21);
            this.ComboxInsulinFilter.TabIndex = 16;
            // 
            // Lbl6
            // 
            this.Lbl6.AutoSize = true;
            this.Lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl6.Location = new System.Drawing.Point(15, 291);
            this.Lbl6.Name = "Lbl6";
            this.Lbl6.Size = new System.Drawing.Size(133, 16);
            this.Lbl6.TabIndex = 15;
            this.Lbl6.Text = "Where insulin dosed:";
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
            ((System.ComponentModel.ISupportInitialize)(this.NumUDBSLValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDCarbsValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDInsulinValue)).EndInit();
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
        private System.Windows.Forms.Label Lbl4;
        private System.Windows.Forms.ComboBox ComboxBSLFilter;
        private System.Windows.Forms.NumericUpDown NumUDBSLValue;
        private System.Windows.Forms.Button BtnApplyFilter;
        private System.Windows.Forms.Button BtnClearFilter;
        private System.Windows.Forms.NumericUpDown NumUDCarbsValue;
        private System.Windows.Forms.ComboBox ComboxCarbsFilter;
        private System.Windows.Forms.Label Lbl5;
        private System.Windows.Forms.NumericUpDown NumUDInsulinValue;
        private System.Windows.Forms.ComboBox ComboxInsulinFilter;
        private System.Windows.Forms.Label Lbl6;
    }
}