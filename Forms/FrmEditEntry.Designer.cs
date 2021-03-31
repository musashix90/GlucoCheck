
namespace GlucoCheck.Forms
{
    partial class FrmEditEntry
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.NumUpDownInsulinDosed = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownCarbs = new System.Windows.Forms.NumericUpDown();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.NumUpDownBSL = new System.Windows.Forms.NumericUpDown();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.DTPEntryDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownInsulinDosed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownCarbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownBSL)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(32, 625);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(186, 44);
            this.BtnCancel.TabIndex = 15;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(230, 625);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(202, 44);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // NumUpDownInsulinDosed
            // 
            this.NumUpDownInsulinDosed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumUpDownInsulinDosed.Location = new System.Drawing.Point(32, 404);
            this.NumUpDownInsulinDosed.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NumUpDownInsulinDosed.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.NumUpDownInsulinDosed.Name = "NumUpDownInsulinDosed";
            this.NumUpDownInsulinDosed.Size = new System.Drawing.Size(400, 44);
            this.NumUpDownInsulinDosed.TabIndex = 13;
            // 
            // NumUpDownCarbs
            // 
            this.NumUpDownCarbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumUpDownCarbs.Location = new System.Drawing.Point(32, 233);
            this.NumUpDownCarbs.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NumUpDownCarbs.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.NumUpDownCarbs.Name = "NumUpDownCarbs";
            this.NumUpDownCarbs.Size = new System.Drawing.Size(400, 44);
            this.NumUpDownCarbs.TabIndex = 12;
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl3.Location = new System.Drawing.Point(24, 360);
            this.Lbl3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(214, 37);
            this.Lbl3.TabIndex = 11;
            this.Lbl3.Text = "Insulin dosed:";
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2.Location = new System.Drawing.Point(24, 188);
            this.Lbl2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(112, 37);
            this.Lbl2.TabIndex = 10;
            this.Lbl2.Text = "Carbs:";
            // 
            // NumUpDownBSL
            // 
            this.NumUpDownBSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumUpDownBSL.Location = new System.Drawing.Point(32, 62);
            this.NumUpDownBSL.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NumUpDownBSL.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.NumUpDownBSL.Name = "NumUpDownBSL";
            this.NumUpDownBSL.Size = new System.Drawing.Size(400, 44);
            this.NumUpDownBSL.TabIndex = 9;
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.Location = new System.Drawing.Point(24, 17);
            this.Lbl1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(86, 37);
            this.Lbl1.TabIndex = 8;
            this.Lbl1.Text = "BSL:";
            // 
            // DTPEntryDate
            // 
            this.DTPEntryDate.Location = new System.Drawing.Point(32, 575);
            this.DTPEntryDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DTPEntryDate.Name = "DTPEntryDate";
            this.DTPEntryDate.Size = new System.Drawing.Size(396, 31);
            this.DTPEntryDate.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 531);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "Date and time:";
            // 
            // FrmEditEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 704);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTPEntryDate);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.NumUpDownInsulinDosed);
            this.Controls.Add(this.NumUpDownCarbs);
            this.Controls.Add(this.Lbl3);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.NumUpDownBSL);
            this.Controls.Add(this.Lbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmEditEntry";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit entry";
            this.Load += new System.EventHandler(this.FrmEditEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownInsulinDosed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownCarbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownBSL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.NumericUpDown NumUpDownInsulinDosed;
        private System.Windows.Forms.NumericUpDown NumUpDownCarbs;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.NumericUpDown NumUpDownBSL;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.DateTimePicker DTPEntryDate;
        private System.Windows.Forms.Label label1;
    }
}