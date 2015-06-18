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
            this.lblAnswers = new System.Windows.Forms.Label();
            this.grpQuestions = new System.Windows.Forms.GroupBox();
            this.grpAnswers = new System.Windows.Forms.GroupBox();
            this.lblQuestions = new System.Windows.Forms.Label();
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
            // lblAnswers
            // 
            this.lblAnswers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnswers.Location = new System.Drawing.Point(15, 159);
            this.lblAnswers.Name = "lblAnswers";
            this.lblAnswers.Size = new System.Drawing.Size(819, 94);
            this.lblAnswers.TabIndex = 1;
            // 
            // grpQuestions
            // 
            this.grpQuestions.Controls.Add(this.btnQ1);
            this.grpQuestions.Location = new System.Drawing.Point(12, 12);
            this.grpQuestions.Name = "grpQuestions";
            this.grpQuestions.Size = new System.Drawing.Size(853, 231);
            this.grpQuestions.TabIndex = 2;
            this.grpQuestions.TabStop = false;
            this.grpQuestions.Text = "Questions";
            // 
            // grpAnswers
            // 
            this.grpAnswers.Controls.Add(this.lblQuestions);
            this.grpAnswers.Controls.Add(this.lblAnswers);
            this.grpAnswers.Location = new System.Drawing.Point(12, 306);
            this.grpAnswers.Name = "grpAnswers";
            this.grpAnswers.Size = new System.Drawing.Size(853, 359);
            this.grpAnswers.TabIndex = 3;
            this.grpAnswers.TabStop = false;
            this.grpAnswers.Text = "Answers";
            // 
            // lblQuestions
            // 
            this.lblQuestions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuestions.Location = new System.Drawing.Point(15, 41);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Size = new System.Drawing.Size(819, 94);
            this.lblQuestions.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 677);
            this.Controls.Add(this.grpAnswers);
            this.Controls.Add(this.grpQuestions);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpQuestions.ResumeLayout(false);
            this.grpAnswers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQ1;
        private System.Windows.Forms.Label lblAnswers;
        private System.Windows.Forms.GroupBox grpQuestions;
        private System.Windows.Forms.GroupBox grpAnswers;
        private System.Windows.Forms.Label lblQuestions;
    }
}

