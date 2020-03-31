namespace Dictionary2020
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
            this.BtnLoadWords = new System.Windows.Forms.Button();
            this.TxtSearchWord = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.LbxWords = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnLoadWords
            // 
            this.BtnLoadWords.Location = new System.Drawing.Point(13, 13);
            this.BtnLoadWords.Name = "BtnLoadWords";
            this.BtnLoadWords.Size = new System.Drawing.Size(176, 48);
            this.BtnLoadWords.TabIndex = 0;
            this.BtnLoadWords.Text = "Load Words";
            this.BtnLoadWords.UseVisualStyleBackColor = true;
            this.BtnLoadWords.Click += new System.EventHandler(this.BtnLoadWords_Click);
            // 
            // TxtSearchWord
            // 
            this.TxtSearchWord.Location = new System.Drawing.Point(14, 99);
            this.TxtSearchWord.Name = "TxtSearchWord";
            this.TxtSearchWord.Size = new System.Drawing.Size(176, 20);
            this.TxtSearchWord.TabIndex = 1;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Enabled = false;
            this.BtnSearch.Location = new System.Drawing.Point(12, 125);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(176, 48);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // LbxWords
            // 
            this.LbxWords.FormattingEnabled = true;
            this.LbxWords.Location = new System.Drawing.Point(196, 13);
            this.LbxWords.Name = "LbxWords";
            this.LbxWords.Size = new System.Drawing.Size(225, 160);
            this.LbxWords.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 188);
            this.Controls.Add(this.LbxWords);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtSearchWord);
            this.Controls.Add(this.BtnLoadWords);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLoadWords;
        private System.Windows.Forms.TextBox TxtSearchWord;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.ListBox LbxWords;
    }
}

