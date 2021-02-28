
namespace MidTerm
{
    partial class FindAges
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindAges));
            this.elderKidAge = new System.Windows.Forms.TextBox();
            this.youngerKidAge = new System.Windows.Forms.TextBox();
            this.FindOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Feedback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // elderKidAge
            // 
            this.elderKidAge.Location = new System.Drawing.Point(308, 272);
            this.elderKidAge.Name = "elderKidAge";
            this.elderKidAge.Size = new System.Drawing.Size(192, 22);
            this.elderKidAge.TabIndex = 1;
            // 
            // youngerKidAge
            // 
            this.youngerKidAge.Location = new System.Drawing.Point(308, 330);
            this.youngerKidAge.Name = "youngerKidAge";
            this.youngerKidAge.Size = new System.Drawing.Size(192, 22);
            this.youngerKidAge.TabIndex = 2;
            // 
            // FindOut
            // 
            this.FindOut.Location = new System.Drawing.Point(54, 390);
            this.FindOut.Name = "FindOut";
            this.FindOut.Size = new System.Drawing.Size(104, 42);
            this.FindOut.TabIndex = 3;
            this.FindOut.Text = "Find out";
            this.FindOut.UseVisualStyleBackColor = true;
            this.FindOut.Click += new System.EventHandler(this.FindOut_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(650, 216);
            this.label1.TabIndex = 4;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Age of elder one";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Age of younger ones";
            // 
            // Feedback
            // 
            this.Feedback.AutoSize = true;
            this.Feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Feedback.ForeColor = System.Drawing.Color.DarkOrange;
            this.Feedback.Location = new System.Drawing.Point(304, 398);
            this.Feedback.Name = "Feedback";
            this.Feedback.Size = new System.Drawing.Size(60, 24);
            this.Feedback.TabIndex = 7;
            this.Feedback.Text = "label4";
            // 
            // FindAges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 488);
            this.Controls.Add(this.Feedback);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FindOut);
            this.Controls.Add(this.youngerKidAge);
            this.Controls.Add(this.elderKidAge);
            this.Name = "FindAges";
            this.Text = "FindAges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox elderKidAge;
        private System.Windows.Forms.TextBox youngerKidAge;
        private System.Windows.Forms.Button FindOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Feedback;
    }
}