
namespace HangMan2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LivesLabel = new System.Windows.Forms.Label();
            this.WordLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Pic6 = new System.Windows.Forms.PictureBox();
            this.Pic5 = new System.Windows.Forms.PictureBox();
            this.Pic4 = new System.Windows.Forms.PictureBox();
            this.Pic3 = new System.Windows.Forms.PictureBox();
            this.Pic2 = new System.Windows.Forms.PictureBox();
            this.Pic1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 359);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(331, 349);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(69, 62);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(30, 80);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(114, 148);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Not in the word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 252);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "In the word";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 24;
            this.listBox2.Location = new System.Drawing.Point(30, 278);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(114, 148);
            this.listBox2.TabIndex = 4;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(437, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "LIVES :";
            // 
            // LivesLabel
            // 
            this.LivesLabel.AutoSize = true;
            this.LivesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LivesLabel.Location = new System.Drawing.Point(496, 25);
            this.LivesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LivesLabel.Name = "LivesLabel";
            this.LivesLabel.Size = new System.Drawing.Size(16, 18);
            this.LivesLabel.TabIndex = 7;
            this.LivesLabel.Text = "6";
            // 
            // WordLabel
            // 
            this.WordLabel.AutoSize = true;
            this.WordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordLabel.Location = new System.Drawing.Point(492, 58);
            this.WordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WordLabel.Name = "WordLabel";
            this.WordLabel.Size = new System.Drawing.Size(0, 39);
            this.WordLabel.TabIndex = 8;
            this.WordLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(405, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Word => ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(306, 332);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Enter your letter here:";
            // 
            // Pic6
            // 
            this.Pic6.BackColor = System.Drawing.SystemColors.Control;
            this.Pic6.Enabled = false;
            this.Pic6.Image = ((System.Drawing.Image)(resources.GetObject("Pic6.Image")));
            this.Pic6.Location = new System.Drawing.Point(351, 94);
            this.Pic6.Name = "Pic6";
            this.Pic6.Size = new System.Drawing.Size(161, 227);
            this.Pic6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic6.TabIndex = 11;
            this.Pic6.TabStop = false;
            this.Pic6.Visible = false;
            this.Pic6.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Pic5
            // 
            this.Pic5.BackColor = System.Drawing.SystemColors.Control;
            this.Pic5.Enabled = false;
            this.Pic5.Image = ((System.Drawing.Image)(resources.GetObject("Pic5.Image")));
            this.Pic5.Location = new System.Drawing.Point(351, 94);
            this.Pic5.Name = "Pic5";
            this.Pic5.Size = new System.Drawing.Size(161, 227);
            this.Pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic5.TabIndex = 12;
            this.Pic5.TabStop = false;
            this.Pic5.Visible = false;
            // 
            // Pic4
            // 
            this.Pic4.BackColor = System.Drawing.SystemColors.Control;
            this.Pic4.Enabled = false;
            this.Pic4.Image = ((System.Drawing.Image)(resources.GetObject("Pic4.Image")));
            this.Pic4.Location = new System.Drawing.Point(351, 94);
            this.Pic4.Name = "Pic4";
            this.Pic4.Size = new System.Drawing.Size(161, 227);
            this.Pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic4.TabIndex = 13;
            this.Pic4.TabStop = false;
            this.Pic4.Visible = false;
            // 
            // Pic3
            // 
            this.Pic3.BackColor = System.Drawing.SystemColors.Control;
            this.Pic3.Enabled = false;
            this.Pic3.Image = ((System.Drawing.Image)(resources.GetObject("Pic3.Image")));
            this.Pic3.Location = new System.Drawing.Point(351, 94);
            this.Pic3.Name = "Pic3";
            this.Pic3.Size = new System.Drawing.Size(161, 227);
            this.Pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic3.TabIndex = 14;
            this.Pic3.TabStop = false;
            this.Pic3.Visible = false;
            // 
            // Pic2
            // 
            this.Pic2.BackColor = System.Drawing.SystemColors.Control;
            this.Pic2.Enabled = false;
            this.Pic2.Image = ((System.Drawing.Image)(resources.GetObject("Pic2.Image")));
            this.Pic2.Location = new System.Drawing.Point(351, 94);
            this.Pic2.Name = "Pic2";
            this.Pic2.Size = new System.Drawing.Size(161, 227);
            this.Pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic2.TabIndex = 15;
            this.Pic2.TabStop = false;
            this.Pic2.Visible = false;
            // 
            // Pic1
            // 
            this.Pic1.BackColor = System.Drawing.SystemColors.Control;
            this.Pic1.Enabled = false;
            this.Pic1.Image = ((System.Drawing.Image)(resources.GetObject("Pic1.Image")));
            this.Pic1.Location = new System.Drawing.Point(351, 94);
            this.Pic1.Name = "Pic1";
            this.Pic1.Size = new System.Drawing.Size(161, 227);
            this.Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic1.TabIndex = 16;
            this.Pic1.TabStop = false;
            this.Pic1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 457);
            this.Controls.Add(this.Pic1);
            this.Controls.Add(this.Pic2);
            this.Controls.Add(this.Pic3);
            this.Controls.Add(this.Pic4);
            this.Controls.Add(this.Pic5);
            this.Controls.Add(this.Pic6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WordLabel);
            this.Controls.Add(this.LivesLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.Pic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LivesLabel;
        private System.Windows.Forms.Label WordLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox Pic6;
        private System.Windows.Forms.PictureBox Pic5;
        private System.Windows.Forms.PictureBox Pic4;
        private System.Windows.Forms.PictureBox Pic3;
        private System.Windows.Forms.PictureBox Pic2;
        private System.Windows.Forms.PictureBox Pic1;
    }
}

