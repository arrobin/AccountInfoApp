namespace BookInfoApp
{
    partial class BookInfoApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bookDetailsAddTextBox = new System.Windows.Forms.TextBox();
            this.iSBNAddTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bookDetailsSearchTextBox = new System.Windows.Forms.TextBox();
            this.iSBNSearchTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.bookDetailsAddTextBox);
            this.groupBox1.Controls.Add(this.iSBNAddTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 123);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Book Info";
            // 
            // bookDetailsAddTextBox
            // 
            this.bookDetailsAddTextBox.Location = new System.Drawing.Point(147, 71);
            this.bookDetailsAddTextBox.Name = "bookDetailsAddTextBox";
            this.bookDetailsAddTextBox.Size = new System.Drawing.Size(171, 20);
            this.bookDetailsAddTextBox.TabIndex = 9;
            // 
            // iSBNAddTextBox
            // 
            this.iSBNAddTextBox.Location = new System.Drawing.Point(147, 30);
            this.iSBNAddTextBox.Name = "iSBNAddTextBox";
            this.iSBNAddTextBox.Size = new System.Drawing.Size(100, 20);
            this.iSBNAddTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Book Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ISBN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchButton);
            this.groupBox2.Controls.Add(this.bookDetailsSearchTextBox);
            this.groupBox2.Controls.Add(this.iSBNSearchTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(36, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 120);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Book";
            // 
            // bookDetailsSearchTextBox
            // 
            this.bookDetailsSearchTextBox.Location = new System.Drawing.Point(147, 70);
            this.bookDetailsSearchTextBox.Name = "bookDetailsSearchTextBox";
            this.bookDetailsSearchTextBox.Size = new System.Drawing.Size(171, 20);
            this.bookDetailsSearchTextBox.TabIndex = 9;
            // 
            // iSBNSearchTextBox
            // 
            this.iSBNSearchTextBox.Location = new System.Drawing.Point(147, 29);
            this.iSBNSearchTextBox.Name = "iSBNSearchTextBox";
            this.iSBNSearchTextBox.Size = new System.Drawing.Size(100, 20);
            this.iSBNSearchTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Book Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ISBN";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(324, 69);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(324, 68);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // BookInfoApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 293);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BookInfoApp";
            this.Text = "Book Info UI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox bookDetailsAddTextBox;
        private System.Windows.Forms.TextBox iSBNAddTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox bookDetailsSearchTextBox;
        private System.Windows.Forms.TextBox iSBNSearchTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button searchButton;
    }
}

