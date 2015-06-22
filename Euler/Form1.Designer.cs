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
            this.btnQ3 = new System.Windows.Forms.Button();
            this.btnQ2 = new System.Windows.Forms.Button();
            this.grpAnswers = new System.Windows.Forms.GroupBox();
            this.lblQuestions = new System.Windows.Forms.Label();
            this.btnQ4 = new System.Windows.Forms.Button();
            this.btnQ10 = new System.Windows.Forms.Button();
            this.lblAnswers = new System.Windows.Forms.TextBox();
            this.grpQuestions.SuspendLayout();
            this.grpAnswers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQ1
            // 
            this.btnQ1.Location = new System.Drawing.Point(15, 37);
            this.btnQ1.Name = "btnQ1";
            this.btnQ1.Size = new System.Drawing.Size(75, 31);
            this.btnQ1.TabIndex = 0;
            this.btnQ1.Text = "Q1";
            this.btnQ1.UseVisualStyleBackColor = true;
            this.btnQ1.Click += new System.EventHandler(this.btnQ1_Click);
            // 
            // grpQuestions
            // 
            this.grpQuestions.Controls.Add(this.btnQ10);
            this.grpQuestions.Controls.Add(this.btnQ4);
            this.grpQuestions.Controls.Add(this.btnQ3);
            this.grpQuestions.Controls.Add(this.btnQ2);
            this.grpQuestions.Controls.Add(this.btnQ1);
            this.grpQuestions.Location = new System.Drawing.Point(12, 12);
            this.grpQuestions.Name = "grpQuestions";
            this.grpQuestions.Size = new System.Drawing.Size(854, 231);
            this.grpQuestions.TabIndex = 2;
            this.grpQuestions.TabStop = false;
            this.grpQuestions.Text = "Questions";
            // 
            // btnQ3
            // 
            this.btnQ3.Location = new System.Drawing.Point(177, 37);
            this.btnQ3.Name = "btnQ3";
            this.btnQ3.Size = new System.Drawing.Size(75, 31);
            this.btnQ3.TabIndex = 2;
            this.btnQ3.Text = "Q3";
            this.btnQ3.UseVisualStyleBackColor = true;
            this.btnQ3.Click += new System.EventHandler(this.btnQ3_Click);
            // 
            // btnQ2
            // 
            this.btnQ2.Location = new System.Drawing.Point(96, 37);
            this.btnQ2.Name = "btnQ2";
            this.btnQ2.Size = new System.Drawing.Size(75, 31);
            this.btnQ2.TabIndex = 1;
            this.btnQ2.Text = "Q2";
            this.btnQ2.UseVisualStyleBackColor = true;
            this.btnQ2.Click += new System.EventHandler(this.btnQ2_Click);
            // 
            // grpAnswers
            // 
            this.grpAnswers.Controls.Add(this.lblAnswers);
            this.grpAnswers.Controls.Add(this.lblQuestions);
            this.grpAnswers.Location = new System.Drawing.Point(12, 306);
            this.grpAnswers.Name = "grpAnswers";
            this.grpAnswers.Size = new System.Drawing.Size(854, 358);
            this.grpAnswers.TabIndex = 3;
            this.grpAnswers.TabStop = false;
            this.grpAnswers.Text = "Answers";
            // 
            // lblQuestions
            // 
            this.lblQuestions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuestions.Location = new System.Drawing.Point(15, 42);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Size = new System.Drawing.Size(819, 94);
            this.lblQuestions.TabIndex = 2;
            // 
            // btnQ4
            // 
            this.btnQ4.Location = new System.Drawing.Point(258, 37);
            this.btnQ4.Name = "btnQ4";
            this.btnQ4.Size = new System.Drawing.Size(75, 31);
            this.btnQ4.TabIndex = 3;
            this.btnQ4.Text = "Q4";
            this.btnQ4.UseVisualStyleBackColor = true;
            this.btnQ4.Click += new System.EventHandler(this.btnQ4_Click);
            // 
            // btnQ10
            // 
            this.btnQ10.Location = new System.Drawing.Point(339, 37);
            this.btnQ10.Name = "btnQ10";
            this.btnQ10.Size = new System.Drawing.Size(75, 31);
            this.btnQ10.TabIndex = 4;
            this.btnQ10.Text = "Q10";
            this.btnQ10.UseVisualStyleBackColor = true;
            this.btnQ10.Click += new System.EventHandler(this.btnQ10_Click);
            // 
            // lblAnswers
            // 
            this.lblAnswers.Location = new System.Drawing.Point(15, 181);
            this.lblAnswers.Multiline = true;
            this.lblAnswers.Name = "lblAnswers";
            this.lblAnswers.ReadOnly = true;
            this.lblAnswers.Size = new System.Drawing.Size(819, 144);
            this.lblAnswers.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 677);
            this.Controls.Add(this.grpAnswers);
            this.Controls.Add(this.grpQuestions);
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
    }
}

