
namespace MidTerm
{
    partial class OpenLockers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenLockers));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Option1 = new System.Windows.Forms.RadioButton();
            this.Option2 = new System.Windows.Forms.RadioButton();
            this.Option3 = new System.Windows.Forms.RadioButton();
            this.Option4 = new System.Windows.Forms.RadioButton();
            this.Feedback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Verify";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 212);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.UseCompatibleTextRendering = true;
            // 
            // Option1
            // 
            this.Option1.AutoSize = true;
            this.Option1.Location = new System.Drawing.Point(39, 259);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(125, 21);
            this.Option1.TabIndex = 4;
            this.Option1.TabStop = true;
            this.Option1.Text = "256,  361, 729 ";
            this.Option1.UseVisualStyleBackColor = true;
            // 
            // Option2
            // 
            this.Option2.AutoSize = true;
            this.Option2.Location = new System.Drawing.Point(39, 308);
            this.Option2.Name = "Option2";
            this.Option2.Size = new System.Drawing.Size(109, 21);
            this.Option2.TabIndex = 5;
            this.Option2.TabStop = true;
            this.Option2.Text = "49, 574, 829";
            this.Option2.UseVisualStyleBackColor = true;
            // 
            // Option3
            // 
            this.Option3.AutoSize = true;
            this.Option3.Location = new System.Drawing.Point(39, 354);
            this.Option3.Name = "Option3";
            this.Option3.Size = new System.Drawing.Size(93, 21);
            this.Option3.TabIndex = 6;
            this.Option3.TabStop = true;
            this.Option3.Text = "9, 66, 181";
            this.Option3.UseVisualStyleBackColor = true;
            // 
            // Option4
            // 
            this.Option4.AutoSize = true;
            this.Option4.Location = new System.Drawing.Point(39, 399);
            this.Option4.Name = "Option4";
            this.Option4.Size = new System.Drawing.Size(109, 21);
            this.Option4.TabIndex = 7;
            this.Option4.TabStop = true;
            this.Option4.Text = "88, 343, 784";
            this.Option4.UseVisualStyleBackColor = true;
            // 
            // Feedback
            // 
            this.Feedback.AutoSize = true;
            this.Feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Feedback.Location = new System.Drawing.Point(361, 355);
            this.Feedback.Name = "Feedback";
            this.Feedback.Size = new System.Drawing.Size(53, 20);
            this.Feedback.TabIndex = 8;
            this.Feedback.Text = "label2";
            // 
            // OpenLockers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Feedback);
            this.Controls.Add(this.Option4);
            this.Controls.Add(this.Option3);
            this.Controls.Add(this.Option2);
            this.Controls.Add(this.Option1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "OpenLockers";
            this.Text = "OpenLockers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Option1;
        private System.Windows.Forms.RadioButton Option2;
        private System.Windows.Forms.RadioButton Option3;
        private System.Windows.Forms.RadioButton Option4;
        private System.Windows.Forms.Label Feedback;
    }
}