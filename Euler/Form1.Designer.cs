namespace Euler
{
    partial class Form1
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
            this.btnQ1 = new System.Windows.Forms.Button();
            this.grpQuestions = new System.Windows.Forms.GroupBox();
            this.btnQ10 = new System.Windows.Forms.Button();
            this.btnQ4 = new System.Windows.Forms.Button();
            this.btnQ3 = new System.Windows.Forms.Button();
            this.btnQ2 = new System.Windows.Forms.Button();
            this.grpAnswers = new System.Windows.Forms.GroupBox();
            this.lblAnswers = new System.Windows.Forms.TextBox();
            this.lblQuestions = new System.Windows.Forms.Label();
            this.btnQ5 = new System.Windows.Forms.Button();
            this.grpQuestions.SuspendLayout();
            this.grpAnswers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQ1
            // 
            this.btnQ1.Location = new System.Drawing.Point(10, 24);
            this.btnQ1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQ1.Name = "btnQ1";
            this.btnQ1.Size = new System.Drawing.Size(50, 20);
            this.btnQ1.TabIndex = 0;
            this.btnQ1.Text = "Q1";
            this.btnQ1.UseVisualStyleBackColor = true;
            this.btnQ1.Click += new System.EventHandler(this.btnQ1_Click);
            // 
            // grpQuestions
            // 
            this.grpQuestions.Controls.Add(this.btnQ5);
            this.grpQuestions.Controls.Add(this.btnQ10);
            this.grpQuestions.Controls.Add(this.btnQ4);
            this.grpQuestions.Controls.Add(this.btnQ3);
            this.grpQuestions.Controls.Add(this.btnQ2);
            this.grpQuestions.Controls.Add(this.btnQ1);
            this.grpQuestions.Location = new System.Drawing.Point(8, 8);
            this.grpQuestions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpQuestions.Name = "grpQuestions";
            this.grpQuestions.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpQuestions.Size = new System.Drawing.Size(569, 150);
            this.grpQuestions.TabIndex = 2;
            this.grpQuestions.TabStop = false;
            this.grpQuestions.Text = "Questions";
            // 
            // btnQ10
            // 
            this.btnQ10.Location = new System.Drawing.Point(280, 24);
            this.btnQ10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQ10.Name = "btnQ10";
            this.btnQ10.Size = new System.Drawing.Size(50, 20);
            this.btnQ10.TabIndex = 4;
            this.btnQ10.Text = "Q10";
            this.btnQ10.UseVisualStyleBackColor = true;
            this.btnQ10.Click += new System.EventHandler(this.btnQ10_Click);
            // 
            // btnQ4
            // 
            this.btnQ4.Location = new System.Drawing.Point(172, 24);
            this.btnQ4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQ4.Name = "btnQ4";
            this.btnQ4.Size = new System.Drawing.Size(50, 20);
            this.btnQ4.TabIndex = 3;
            this.btnQ4.Text = "Q4";
            this.btnQ4.UseVisualStyleBackColor = true;
            this.btnQ4.Click += new System.EventHandler(this.btnQ4_Click);
            // 
            // btnQ3
            // 
            this.btnQ3.Location = new System.Drawing.Point(118, 24);
            this.btnQ3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQ3.Name = "btnQ3";
            this.btnQ3.Size = new System.Drawing.Size(50, 20);
            this.btnQ3.TabIndex = 2;
            this.btnQ3.Text = "Q3";
            this.btnQ3.UseVisualStyleBackColor = true;
            this.btnQ3.Click += new System.EventHandler(this.btnQ3_Click);
            // 
            // btnQ2
            // 
            this.btnQ2.Location = new System.Drawing.Point(64, 24);
            this.btnQ2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQ2.Name = "btnQ2";
            this.btnQ2.Size = new System.Drawing.Size(50, 20);
            this.btnQ2.TabIndex = 1;
            this.btnQ2.Text = "Q2";
            this.btnQ2.UseVisualStyleBackColor = true;
            this.btnQ2.Click += new System.EventHandler(this.btnQ2_Click);
            // 
            // grpAnswers
            // 
            this.grpAnswers.Controls.Add(this.lblAnswers);
            this.grpAnswers.Controls.Add(this.lblQuestions);
            this.grpAnswers.Location = new System.Drawing.Point(8, 199);
            this.grpAnswers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAnswers.Name = "grpAnswers";
            this.grpAnswers.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAnswers.Size = new System.Drawing.Size(569, 233);
            this.grpAnswers.TabIndex = 3;
            this.grpAnswers.TabStop = false;
            this.grpAnswers.Text = "Answers";
            // 
            // lblAnswers
            // 
            this.lblAnswers.Location = new System.Drawing.Point(10, 118);
            this.lblAnswers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblAnswers.Multiline = true;
            this.lblAnswers.Name = "lblAnswers";
            this.lblAnswers.ReadOnly = true;
            this.lblAnswers.Size = new System.Drawing.Size(547, 95);
            this.lblAnswers.TabIndex = 3;
            // 
            // lblQuestions
            // 
            this.lblQuestions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuestions.Location = new System.Drawing.Point(10, 27);
            this.lblQuestions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Size = new System.Drawing.Size(546, 61);
            this.lblQuestions.TabIndex = 2;
            // 
            // btnQ5
            // 
            this.btnQ5.Location = new System.Drawing.Point(226, 24);
            this.btnQ5.Margin = new System.Windows.Forms.Padding(2);
            this.btnQ5.Name = "btnQ5";
            this.btnQ5.Size = new System.Drawing.Size(50, 20);
            this.btnQ5.TabIndex = 5;
            this.btnQ5.Text = "Q5";
            this.btnQ5.UseVisualStyleBackColor = true;
            this.btnQ5.Click += new System.EventHandler(this.btnQ5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 440);
            this.Controls.Add(this.grpAnswers);
            this.Controls.Add(this.grpQuestions);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpQuestions.ResumeLayout(false);
            this.grpAnswers.ResumeLayout(false);
            this.grpAnswers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQ1;
        private System.Windows.Forms.GroupBox grpQuestions;
        private System.Windows.Forms.GroupBox grpAnswers;
        private System.Windows.Forms.Label lblQuestions;
        private System.Windows.Forms.Button btnQ2;
        private System.Windows.Forms.Button btnQ3;
        private System.Windows.Forms.Button btnQ4;
        private System.Windows.Forms.Button btnQ10;
        private System.Windows.Forms.TextBox lblAnswers;
        private System.Windows.Forms.Button btnQ5;
    }
}

