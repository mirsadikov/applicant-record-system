﻿
namespace RightJob
{
    partial class TestEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxQ1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxA1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxA2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxQ2 = new System.Windows.Forms.TextBox();
            this.tbxA3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxQ3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(322, 32);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 0;
            // 
            // tbxQ1
            // 
            this.tbxQ1.Location = new System.Drawing.Point(131, 99);
            this.tbxQ1.Name = "tbxQ1";
            this.tbxQ1.Size = new System.Drawing.Size(200, 20);
            this.tbxQ1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Question 1:";
            // 
            // tbxA1
            // 
            this.tbxA1.Location = new System.Drawing.Point(439, 99);
            this.tbxA1.Name = "tbxA1";
            this.tbxA1.Size = new System.Drawing.Size(200, 20);
            this.tbxA1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Answer 1:";
            // 
            // tbxA2
            // 
            this.tbxA2.Location = new System.Drawing.Point(439, 140);
            this.tbxA2.Name = "tbxA2";
            this.tbxA2.Size = new System.Drawing.Size(200, 20);
            this.tbxA2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Answer 2:";
            // 
            // tbxQ2
            // 
            this.tbxQ2.Location = new System.Drawing.Point(131, 140);
            this.tbxQ2.Name = "tbxQ2";
            this.tbxQ2.Size = new System.Drawing.Size(200, 20);
            this.tbxQ2.TabIndex = 3;
            // 
            // tbxA3
            // 
            this.tbxA3.Location = new System.Drawing.Point(439, 181);
            this.tbxA3.Name = "tbxA3";
            this.tbxA3.Size = new System.Drawing.Size(200, 20);
            this.tbxA3.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Answer 3:";
            // 
            // tbxQ3
            // 
            this.tbxQ3.Location = new System.Drawing.Point(131, 181);
            this.tbxQ3.Name = "tbxQ3";
            this.tbxQ3.Size = new System.Drawing.Size(200, 20);
            this.tbxQ3.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Question 2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Question 3:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(522, 351);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(617, 351);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // TestEditForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(740, 415);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxA3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxQ3);
            this.Controls.Add(this.tbxA2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxQ2);
            this.Controls.Add(this.tbxA1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxQ1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.label1);
            this.Name = "TestEditForm";
            this.Text = "TestEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxQ1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxA1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxA2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxQ2;
        private System.Windows.Forms.TextBox tbxA3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxQ3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}