namespace assignment2_michealWalls
{
    partial class Form_About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_About));
            this.buttons_exitAbout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_aboutTitle = new System.Windows.Forms.Label();
            this.richTextBox_aboutParagraph = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttons_exitAbout
            // 
            this.buttons_exitAbout.Location = new System.Drawing.Point(113, 132);
            this.buttons_exitAbout.Name = "buttons_exitAbout";
            this.buttons_exitAbout.Size = new System.Drawing.Size(75, 23);
            this.buttons_exitAbout.TabIndex = 0;
            this.buttons_exitAbout.Text = "E&xit";
            this.buttons_exitAbout.UseVisualStyleBackColor = true;
            this.buttons_exitAbout.Click += new System.EventHandler(this.buttons_exitAbout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label_aboutTitle
            // 
            this.label_aboutTitle.AutoSize = true;
            this.label_aboutTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_aboutTitle.Location = new System.Drawing.Point(113, 13);
            this.label_aboutTitle.Name = "label_aboutTitle";
            this.label_aboutTitle.Size = new System.Drawing.Size(164, 16);
            this.label_aboutTitle.TabIndex = 2;
            this.label_aboutTitle.Text = "About Auto Centre v0.1";
            // 
            // richTextBox_aboutParagraph
            // 
            this.richTextBox_aboutParagraph.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox_aboutParagraph.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_aboutParagraph.Location = new System.Drawing.Point(113, 44);
            this.richTextBox_aboutParagraph.Name = "richTextBox_aboutParagraph";
            this.richTextBox_aboutParagraph.ReadOnly = true;
            this.richTextBox_aboutParagraph.Size = new System.Drawing.Size(171, 82);
            this.richTextBox_aboutParagraph.TabIndex = 4;
            this.richTextBox_aboutParagraph.Text = "Developed by Koala Korporation\'s team of highly trained Koala Bears, Auto Centre " +
    "v0.1 calculates the amount due on your customized Smart Car.";
            this.richTextBox_aboutParagraph.TextChanged += new System.EventHandler(this.richTextBox_aboutParagraph_TextChanged);
            // 
            // Form_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(296, 160);
            this.Controls.Add(this.richTextBox_aboutParagraph);
            this.Controls.Add(this.label_aboutTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttons_exitAbout);
            this.Name = "Form_About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Koala Korp\'s Auto Centre v0.1";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttons_exitAbout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_aboutTitle;
        private System.Windows.Forms.RichTextBox richTextBox_aboutParagraph;
    }
}