namespace HoneyBoozle
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.wordGridView = new System.Windows.Forms.DataGridView();
            this.Word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.wordLengthBox = new System.Windows.Forms.TextBox();
            this.charBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.knownPositionBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalWordsLoaded = new System.Windows.Forms.Label();
            this.filteredWords = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.wordGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wordGridView
            // 
            this.wordGridView.AllowUserToAddRows = false;
            this.wordGridView.AllowUserToDeleteRows = false;
            this.wordGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wordGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.Word});
            this.wordGridView.Location = new System.Drawing.Point(12, 12);
            this.wordGridView.Name = "wordGridView";
            this.wordGridView.ReadOnly = true;
            this.wordGridView.Size = new System.Drawing.Size(296, 368);
            this.wordGridView.TabIndex = 0;
            this.wordGridView.TabStop = false;
            // 
            // Word
            // 
            this.Word.HeaderText = "Word";
            this.Word.Name = "Word";
            this.Word.ReadOnly = true;
            this.Word.Width = 250;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // wordLengthBox
            // 
            this.wordLengthBox.Location = new System.Drawing.Point(103, 12);
            this.wordLengthBox.Name = "wordLengthBox";
            this.wordLengthBox.Size = new System.Drawing.Size(54, 20);
            this.wordLengthBox.TabIndex = 0;
            // 
            // charBox
            // 
            this.charBox.Location = new System.Drawing.Point(103, 38);
            this.charBox.Name = "charBox";
            this.charBox.Size = new System.Drawing.Size(154, 20);
            this.charBox.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // knownPositionBox
            // 
            this.knownPositionBox.Location = new System.Drawing.Point(103, 64);
            this.knownPositionBox.Name = "knownPositionBox";
            this.knownPositionBox.Size = new System.Drawing.Size(154, 20);
            this.knownPositionBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Word Length";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(48, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contains";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Known Positions";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(263, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Example: 1e,5f";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.wordLengthBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.charBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.knownPositionBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(358, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 131);
            this.panel1.TabIndex = 10;
            // 
            // totalWordsLoaded
            // 
            this.totalWordsLoaded.Location = new System.Drawing.Point(314, 12);
            this.totalWordsLoaded.Name = "totalWordsLoaded";
            this.totalWordsLoaded.Size = new System.Drawing.Size(162, 21);
            this.totalWordsLoaded.TabIndex = 10;
            this.totalWordsLoaded.Text = "Total words: 0";
            this.totalWordsLoaded.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // filteredWords
            // 
            this.filteredWords.Location = new System.Drawing.Point(314, 33);
            this.filteredWords.Name = "filteredWords";
            this.filteredWords.Size = new System.Drawing.Size(162, 21);
            this.filteredWords.TabIndex = 11;
            this.filteredWords.Text = "Possible results: 0";
            this.filteredWords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(497, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "Made with very big lovin\' exclusively for my Daria";
            this.label5.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 391);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.filteredWords);
            this.Controls.Add(this.totalWordsLoaded);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.wordGridView);
            this.Name = "MainForm";
            this.Text = "HoneyBoozle v1.1";
            ((System.ComponentModel.ISupportInitialize) (this.wordGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label filteredWords;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label totalWordsLoaded;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox knownPositionBox;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox wordLengthBox;
        private System.Windows.Forms.TextBox charBox;

        private System.Windows.Forms.DataGridView wordGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word;

        #endregion
    }
}