namespace _7_4Tutorial
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
            this.ScoresListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AvgLabel = new System.Windows.Forms.Label();
            this.AboveAvgLabel = new System.Windows.Forms.Label();
            this.BelowAvgLabel = new System.Windows.Forms.Label();
            this.ScoresButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScoresListBox
            // 
            this.ScoresListBox.FormattingEnabled = true;
            this.ScoresListBox.Location = new System.Drawing.Point(12, 22);
            this.ScoresListBox.Name = "ScoresListBox";
            this.ScoresListBox.Size = new System.Drawing.Size(185, 186);
            this.ScoresListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Average score ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Above Average Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Below Average Number";
            // 
            // AvgLabel
            // 
            this.AvgLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AvgLabel.Location = new System.Drawing.Point(534, 11);
            this.AvgLabel.Name = "AvgLabel";
            this.AvgLabel.Size = new System.Drawing.Size(100, 24);
            this.AvgLabel.TabIndex = 4;
            // 
            // AboveAvgLabel
            // 
            this.AboveAvgLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AboveAvgLabel.Location = new System.Drawing.Point(534, 82);
            this.AboveAvgLabel.Name = "AboveAvgLabel";
            this.AboveAvgLabel.Size = new System.Drawing.Size(100, 31);
            this.AboveAvgLabel.TabIndex = 5;
            // 
            // BelowAvgLabel
            // 
            this.BelowAvgLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BelowAvgLabel.Location = new System.Drawing.Point(534, 161);
            this.BelowAvgLabel.Name = "BelowAvgLabel";
            this.BelowAvgLabel.Size = new System.Drawing.Size(100, 31);
            this.BelowAvgLabel.TabIndex = 6;
            // 
            // ScoresButton
            // 
            this.ScoresButton.Location = new System.Drawing.Point(221, 258);
            this.ScoresButton.Name = "ScoresButton";
            this.ScoresButton.Size = new System.Drawing.Size(75, 23);
            this.ScoresButton.TabIndex = 7;
            this.ScoresButton.Text = "Get Scores ";
            this.ScoresButton.UseVisualStyleBackColor = true;
            this.ScoresButton.Click += new System.EventHandler(this.ScoresButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 306);
            this.Controls.Add(this.ScoresButton);
            this.Controls.Add(this.BelowAvgLabel);
            this.Controls.Add(this.AboveAvgLabel);
            this.Controls.Add(this.AvgLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScoresListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ScoresListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AvgLabel;
        private System.Windows.Forms.Label AboveAvgLabel;
        private System.Windows.Forms.Label BelowAvgLabel;
        private System.Windows.Forms.Button ScoresButton;
    }
}

