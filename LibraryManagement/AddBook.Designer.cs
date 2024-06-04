namespace LibraryManagement
{
    partial class AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            this.top_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botton_panel = new System.Windows.Forms.Panel();
            this.cancel_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.bookdate_dtp = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bookprice_txtbox = new System.Windows.Forms.TextBox();
            this.bookpublic_txtbox = new System.Windows.Forms.TextBox();
            this.bookquantity_txtbox = new System.Windows.Forms.TextBox();
            this.bookauthor_txtbox = new System.Windows.Forms.TextBox();
            this.bookname_txtbox = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.botton_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.top_panel.Controls.Add(this.label1);
            this.top_panel.Controls.Add(this.pictureBox1);
            this.top_panel.Location = new System.Drawing.Point(-1, -3);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(577, 137);
            this.top_panel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(268, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Book";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(163, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // botton_panel
            // 
            this.botton_panel.BackColor = System.Drawing.Color.Teal;
            this.botton_panel.Controls.Add(this.btn_back);
            this.botton_panel.Controls.Add(this.cancel_button);
            this.botton_panel.Controls.Add(this.save_button);
            this.botton_panel.Controls.Add(this.bookdate_dtp);
            this.botton_panel.Controls.Add(this.label7);
            this.botton_panel.Controls.Add(this.label6);
            this.botton_panel.Controls.Add(this.label5);
            this.botton_panel.Controls.Add(this.label4);
            this.botton_panel.Controls.Add(this.label3);
            this.botton_panel.Controls.Add(this.label2);
            this.botton_panel.Controls.Add(this.bookprice_txtbox);
            this.botton_panel.Controls.Add(this.bookpublic_txtbox);
            this.botton_panel.Controls.Add(this.bookquantity_txtbox);
            this.botton_panel.Controls.Add(this.bookauthor_txtbox);
            this.botton_panel.Controls.Add(this.bookname_txtbox);
            this.botton_panel.Location = new System.Drawing.Point(-4, 101);
            this.botton_panel.Name = "botton_panel";
            this.botton_panel.Size = new System.Drawing.Size(577, 347);
            this.botton_panel.TabIndex = 2;
            this.botton_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.botton_panel_Paint);
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.Color.Teal;
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel_button.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cancel_button.Location = new System.Drawing.Point(254, 281);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(117, 39);
            this.cancel_button.TabIndex = 3;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.Teal;
            this.save_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.save_button.FlatAppearance.BorderSize = 15;
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save_button.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.save_button.Location = new System.Drawing.Point(119, 281);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(118, 39);
            this.save_button.TabIndex = 3;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // bookdate_dtp
            // 
            this.bookdate_dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bookdate_dtp.Location = new System.Drawing.Point(197, 221);
            this.bookdate_dtp.Name = "bookdate_dtp";
            this.bookdate_dtp.Size = new System.Drawing.Size(280, 26);
            this.bookdate_dtp.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(11, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Book Purchase Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(11, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Book Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(11, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Book Publication";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Book Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Book Author Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Name";
            // 
            // bookprice_txtbox
            // 
            this.bookprice_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bookprice_txtbox.Location = new System.Drawing.Point(197, 182);
            this.bookprice_txtbox.Name = "bookprice_txtbox";
            this.bookprice_txtbox.Size = new System.Drawing.Size(281, 26);
            this.bookprice_txtbox.TabIndex = 0;
            // 
            // bookpublic_txtbox
            // 
            this.bookpublic_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bookpublic_txtbox.Location = new System.Drawing.Point(197, 142);
            this.bookpublic_txtbox.Name = "bookpublic_txtbox";
            this.bookpublic_txtbox.Size = new System.Drawing.Size(281, 26);
            this.bookpublic_txtbox.TabIndex = 0;
            // 
            // bookquantity_txtbox
            // 
            this.bookquantity_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bookquantity_txtbox.Location = new System.Drawing.Point(197, 103);
            this.bookquantity_txtbox.Name = "bookquantity_txtbox";
            this.bookquantity_txtbox.Size = new System.Drawing.Size(281, 26);
            this.bookquantity_txtbox.TabIndex = 0;
            // 
            // bookauthor_txtbox
            // 
            this.bookauthor_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bookauthor_txtbox.Location = new System.Drawing.Point(197, 68);
            this.bookauthor_txtbox.Name = "bookauthor_txtbox";
            this.bookauthor_txtbox.Size = new System.Drawing.Size(281, 26);
            this.bookauthor_txtbox.TabIndex = 0;
            // 
            // bookname_txtbox
            // 
            this.bookname_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bookname_txtbox.Location = new System.Drawing.Point(197, 30);
            this.bookname_txtbox.Name = "bookname_txtbox";
            this.bookname_txtbox.Size = new System.Drawing.Size(281, 26);
            this.bookname_txtbox.TabIndex = 0;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Teal;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_back.Location = new System.Drawing.Point(389, 281);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(117, 39);
            this.btn_back.TabIndex = 14;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 443);
            this.Controls.Add(this.botton_panel);
            this.Controls.Add(this.top_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBook";
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.botton_panel.ResumeLayout(false);
            this.botton_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Panel botton_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bookprice_txtbox;
        private System.Windows.Forms.TextBox bookpublic_txtbox;
        private System.Windows.Forms.TextBox bookquantity_txtbox;
        private System.Windows.Forms.TextBox bookauthor_txtbox;
        private System.Windows.Forms.TextBox bookname_txtbox;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.DateTimePicker bookdate_dtp;
        private System.Windows.Forms.Button btn_back;
    }
}