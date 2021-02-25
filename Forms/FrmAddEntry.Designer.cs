
namespace GlucoCheck.Forms
{
    partial class FrmAddEntry
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
            this.Lbl1 = new System.Windows.Forms.Label();
            this.NumUpDownCurrentBSL = new System.Windows.Forms.NumericUpDown();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.NumUpDownCarbs = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownInsulinDosed = new System.Windows.Forms.NumericUpDown();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownCurrentBSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownCarbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownInsulinDosed)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.Location = new System.Drawing.Point(12, 14);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(101, 20);
            this.Lbl1.TabIndex = 0;
            this.Lbl1.Text = "Current BSL:";
            // 
            // NumUpDownCurrentBSL
            // 
            this.NumUpDownCurrentBSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumUpDownCurrentBSL.Location = new System.Drawing.Point(16, 37);
            this.NumUpDownCurrentBSL.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.NumUpDownCurrentBSL.Name = "NumUpDownCurrentBSL";
            this.NumUpDownCurrentBSL.Size = new System.Drawing.Size(154, 26);
            this.NumUpDownCurrentBSL.TabIndex = 1;
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2.Location = new System.Drawing.Point(12, 97);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(55, 20);
            this.Lbl2.TabIndex = 2;
            this.Lbl2.Text = "Carbs:";
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl3.Location = new System.Drawing.Point(12, 180);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(107, 20);
            this.Lbl3.TabIndex = 3;
            this.Lbl3.Text = "Insulin dosed:";
            // 
            // NumUpDownCarbs
            // 
            this.NumUpDownCarbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumUpDownCarbs.Location = new System.Drawing.Point(16, 120);
            this.NumUpDownCarbs.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.NumUpDownCarbs.Name = "NumUpDownCarbs";
            this.NumUpDownCarbs.Size = new System.Drawing.Size(154, 26);
            this.NumUpDownCarbs.TabIndex = 4;
            // 
            // NumUpDownInsulinDosed
            // 
            this.NumUpDownInsulinDosed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumUpDownInsulinDosed.Location = new System.Drawing.Point(16, 203);
            this.NumUpDownInsulinDosed.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.NumUpDownInsulinDosed.Name = "NumUpDownInsulinDosed";
            this.NumUpDownInsulinDosed.Size = new System.Drawing.Size(154, 26);
            this.NumUpDownInsulinDosed.TabIndex = 5;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(96, 235);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(74, 23);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(16, 235);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(74, 23);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmAddEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 271);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.NumUpDownInsulinDosed);
            this.Controls.Add(this.NumUpDownCarbs);
            this.Controls.Add(this.Lbl3);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.NumUpDownCurrentBSL);
            this.Controls.Add(this.Lbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAddEntry";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add entry to log";
            this.Load += new System.EventHandler(this.FrmAddEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownCurrentBSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownCarbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownInsulinDosed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.NumericUpDown NumUpDownCurrentBSL;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.NumericUpDown NumUpDownCarbs;
        private System.Windows.Forms.NumericUpDown NumUpDownInsulinDosed;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnCancel;
    }
}