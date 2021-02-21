
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
            this.TxtboxBSL = new System.Windows.Forms.TextBox();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.TxtboxCarbs = new System.Windows.Forms.TextBox();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.TxtboxInsulin = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblWarningBSL = new System.Windows.Forms.Label();
            this.LblWarningCarbs = new System.Windows.Forms.Label();
            this.LblWarningInsulin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.Location = new System.Drawing.Point(17, 14);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(81, 16);
            this.Lbl1.TabIndex = 0;
            this.Lbl1.Text = "Current BSL:";
            // 
            // TxtboxBSL
            // 
            this.TxtboxBSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtboxBSL.Location = new System.Drawing.Point(20, 33);
            this.TxtboxBSL.MaxLength = 3;
            this.TxtboxBSL.Name = "TxtboxBSL";
            this.TxtboxBSL.Size = new System.Drawing.Size(100, 22);
            this.TxtboxBSL.TabIndex = 1;
            this.TxtboxBSL.TextChanged += new System.EventHandler(this.TxtboxBSL_TextChanged);
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2.Location = new System.Drawing.Point(17, 96);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(47, 16);
            this.Lbl2.TabIndex = 2;
            this.Lbl2.Text = "Carbs:";
            // 
            // TxtboxCarbs
            // 
            this.TxtboxCarbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtboxCarbs.Location = new System.Drawing.Point(20, 115);
            this.TxtboxCarbs.MaxLength = 3;
            this.TxtboxCarbs.Name = "TxtboxCarbs";
            this.TxtboxCarbs.Size = new System.Drawing.Size(100, 22);
            this.TxtboxCarbs.TabIndex = 3;
            this.TxtboxCarbs.TextChanged += new System.EventHandler(this.TxtboxCarbs_TextChanged);
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl3.Location = new System.Drawing.Point(17, 178);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(90, 16);
            this.Lbl3.TabIndex = 4;
            this.Lbl3.Text = "Insulin dosed:";
            // 
            // TxtboxInsulin
            // 
            this.TxtboxInsulin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtboxInsulin.Location = new System.Drawing.Point(20, 197);
            this.TxtboxInsulin.MaxLength = 3;
            this.TxtboxInsulin.Name = "TxtboxInsulin";
            this.TxtboxInsulin.Size = new System.Drawing.Size(100, 22);
            this.TxtboxInsulin.TabIndex = 5;
            this.TxtboxInsulin.TextChanged += new System.EventHandler(this.TxtboxInsulin_TextChanged);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(20, 232);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(100, 24);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(20, 262);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 24);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LblWarningBSL
            // 
            this.LblWarningBSL.AutoSize = true;
            this.LblWarningBSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWarningBSL.ForeColor = System.Drawing.Color.Red;
            this.LblWarningBSL.Location = new System.Drawing.Point(126, 29);
            this.LblWarningBSL.Name = "LblWarningBSL";
            this.LblWarningBSL.Size = new System.Drawing.Size(171, 32);
            this.LblWarningBSL.TabIndex = 8;
            this.LblWarningBSL.Text = "Must be a number,\r\nand must not be less than 0.";
            this.LblWarningBSL.Visible = false;
            // 
            // LblWarningCarbs
            // 
            this.LblWarningCarbs.AutoSize = true;
            this.LblWarningCarbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWarningCarbs.ForeColor = System.Drawing.Color.Red;
            this.LblWarningCarbs.Location = new System.Drawing.Point(126, 111);
            this.LblWarningCarbs.Name = "LblWarningCarbs";
            this.LblWarningCarbs.Size = new System.Drawing.Size(171, 32);
            this.LblWarningCarbs.TabIndex = 9;
            this.LblWarningCarbs.Text = "Must be a number,\r\nand must not be less than 0.";
            this.LblWarningCarbs.Visible = false;
            // 
            // LblWarningInsulin
            // 
            this.LblWarningInsulin.AutoSize = true;
            this.LblWarningInsulin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWarningInsulin.ForeColor = System.Drawing.Color.Red;
            this.LblWarningInsulin.Location = new System.Drawing.Point(126, 193);
            this.LblWarningInsulin.Name = "LblWarningInsulin";
            this.LblWarningInsulin.Size = new System.Drawing.Size(171, 32);
            this.LblWarningInsulin.TabIndex = 10;
            this.LblWarningInsulin.Text = "Must be a number,\r\nand must not be less than 0.";
            this.LblWarningInsulin.Visible = false;
            // 
            // FrmAddEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 300);
            this.Controls.Add(this.LblWarningInsulin);
            this.Controls.Add(this.LblWarningCarbs);
            this.Controls.Add(this.LblWarningBSL);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtboxInsulin);
            this.Controls.Add(this.Lbl3);
            this.Controls.Add(this.TxtboxCarbs);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.TxtboxBSL);
            this.Controls.Add(this.Lbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmAddEntry";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add entry to log";
            this.Load += new System.EventHandler(this.FrmAddEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.TextBox TxtboxBSL;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.TextBox TxtboxCarbs;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.TextBox TxtboxInsulin;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LblWarningBSL;
        private System.Windows.Forms.Label LblWarningCarbs;
        private System.Windows.Forms.Label LblWarningInsulin;
    }
}