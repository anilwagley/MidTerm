
namespace MidTerm
{
    partial class BeerGame
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
            this.threePint = new System.Windows.Forms.Panel();
            this.fivePint = new System.Windows.Forms.Panel();
            this.fillThree = new System.Windows.Forms.Button();
            this.fillFive = new System.Windows.Forms.Button();
            this.emptyThree = new System.Windows.Forms.Button();
            this.emptyFive = new System.Windows.Forms.Button();
            this.pourToFive = new System.Windows.Forms.Button();
            this.pourToThree = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // threePint
            // 
            this.threePint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.threePint.Location = new System.Drawing.Point(79, 131);
            this.threePint.Name = "threePint";
            this.threePint.Size = new System.Drawing.Size(70, 150);
            this.threePint.TabIndex = 0;
            // 
            // fivePint
            // 
            this.fivePint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fivePint.Location = new System.Drawing.Point(218, 31);
            this.fivePint.Name = "fivePint";
            this.fivePint.Size = new System.Drawing.Size(70, 250);
            this.fivePint.TabIndex = 0;
            // 
            // fillThree
            // 
            this.fillThree.Location = new System.Drawing.Point(83, 299);
            this.fillThree.Name = "fillThree";
            this.fillThree.Size = new System.Drawing.Size(65, 32);
            this.fillThree.TabIndex = 1;
            this.fillThree.Text = "Fill";
            this.fillThree.UseVisualStyleBackColor = true;
            this.fillThree.Click += new System.EventHandler(this.fillThree_Click);
            // 
            // fillFive
            // 
            this.fillFive.Location = new System.Drawing.Point(218, 299);
            this.fillFive.Name = "fillFive";
            this.fillFive.Size = new System.Drawing.Size(65, 32);
            this.fillFive.TabIndex = 2;
            this.fillFive.Text = "Fill";
            this.fillFive.UseVisualStyleBackColor = true;
            this.fillFive.Click += new System.EventHandler(this.fillFive_Click);
            // 
            // emptyThree
            // 
            this.emptyThree.Location = new System.Drawing.Point(84, 337);
            this.emptyThree.Name = "emptyThree";
            this.emptyThree.Size = new System.Drawing.Size(65, 32);
            this.emptyThree.TabIndex = 3;
            this.emptyThree.Text = "Empty";
            this.emptyThree.UseVisualStyleBackColor = true;
            this.emptyThree.Click += new System.EventHandler(this.emptyThree_Click);
            // 
            // emptyFive
            // 
            this.emptyFive.Location = new System.Drawing.Point(218, 337);
            this.emptyFive.Name = "emptyFive";
            this.emptyFive.Size = new System.Drawing.Size(65, 32);
            this.emptyFive.TabIndex = 4;
            this.emptyFive.Text = "Empty";
            this.emptyFive.UseVisualStyleBackColor = true;
            this.emptyFive.Click += new System.EventHandler(this.emptyFive_Click);
            // 
            // pourToFive
            // 
            this.pourToFive.Location = new System.Drawing.Point(63, 375);
            this.pourToFive.Name = "pourToFive";
            this.pourToFive.Size = new System.Drawing.Size(86, 32);
            this.pourToFive.TabIndex = 5;
            this.pourToFive.Text = "Pour to Five";
            this.pourToFive.UseVisualStyleBackColor = true;
            this.pourToFive.Click += new System.EventHandler(this.pourToFive_Click);
            // 
            // pourToThree
            // 
            this.pourToThree.Location = new System.Drawing.Point(218, 375);
            this.pourToThree.Name = "pourToThree";
            this.pourToThree.Size = new System.Drawing.Size(86, 32);
            this.pourToThree.TabIndex = 6;
            this.pourToThree.Text = "Pour to three";
            this.pourToThree.UseVisualStyleBackColor = true;
            this.pourToThree.Click += new System.EventHandler(this.pourToThree_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pourToThree);
            this.Controls.Add(this.pourToFive);
            this.Controls.Add(this.emptyFive);
            this.Controls.Add(this.emptyThree);
            this.Controls.Add(this.fillFive);
            this.Controls.Add(this.fillThree);
            this.Controls.Add(this.fivePint);
            this.Controls.Add(this.threePint);
            this.Name = "BeerGame";
            this.Text = "Beer Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel threePint;
        private System.Windows.Forms.Panel fivePint;
        private System.Windows.Forms.Button fillThree;
        private System.Windows.Forms.Button fillFive;
        private System.Windows.Forms.Button emptyThree;
        private System.Windows.Forms.Button emptyFive;
        private System.Windows.Forms.Button pourToFive;
        private System.Windows.Forms.Button pourToThree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

