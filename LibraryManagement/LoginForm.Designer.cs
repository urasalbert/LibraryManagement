namespace LibraryManagement
{
    partial class LoginForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginScreenIcon_pictureBox = new System.Windows.Forms.PictureBox();
            this.username_txtBox = new System.Windows.Forms.TextBox();
            this.password_txtBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.login_button = new System.Windows.Forms.Button();
            this.x_button = new System.Windows.Forms.Button();
            this.help_button = new System.Windows.Forms.Button();
            this.btn_student = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loginScreenIcon_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // loginScreenIcon_pictureBox
            // 
            this.loginScreenIcon_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("loginScreenIcon_pictureBox.Image")));
            this.loginScreenIcon_pictureBox.Location = new System.Drawing.Point(142, 57);
            this.loginScreenIcon_pictureBox.Name = "loginScreenIcon_pictureBox";
            this.loginScreenIcon_pictureBox.Size = new System.Drawing.Size(107, 103);
            this.loginScreenIcon_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginScreenIcon_pictureBox.TabIndex = 0;
            this.loginScreenIcon_pictureBox.TabStop = false;
            // 
            // username_txtBox
            // 
            this.username_txtBox.BackColor = System.Drawing.Color.Teal;
            this.username_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_txtBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.username_txtBox.ForeColor = System.Drawing.SystemColors.Info;
            this.username_txtBox.Location = new System.Drawing.Point(92, 222);
            this.username_txtBox.Name = "username_txtBox";
            this.username_txtBox.Size = new System.Drawing.Size(209, 24);
            this.username_txtBox.TabIndex = 1;
            this.username_txtBox.Text = "E-Mail";
            this.username_txtBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.username_txtBox_MouseClick);
            // 
            // password_txtBox
            // 
            this.password_txtBox.BackColor = System.Drawing.Color.Teal;
            this.password_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_txtBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password_txtBox.ForeColor = System.Drawing.SystemColors.Info;
            this.password_txtBox.Location = new System.Drawing.Point(92, 299);
            this.password_txtBox.Name = "password_txtBox";
            this.password_txtBox.Size = new System.Drawing.Size(209, 24);
            this.password_txtBox.TabIndex = 2;
            this.password_txtBox.Text = "Password";
            this.password_txtBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.password_txtBox_MouseClick);
            this.password_txtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_txtBox_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 214);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 291);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(92, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 4);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(92, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 4);
            this.panel2.TabIndex = 6;
            // 
            // login_button
            // 
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_button.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login_button.Location = new System.Drawing.Point(92, 389);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(209, 33);
            this.login_button.TabIndex = 7;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // x_button
            // 
            this.x_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.x_button.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.x_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.x_button.Location = new System.Drawing.Point(356, 12);
            this.x_button.Name = "x_button";
            this.x_button.Size = new System.Drawing.Size(25, 25);
            this.x_button.TabIndex = 9;
            this.x_button.Text = "X";
            this.x_button.UseVisualStyleBackColor = false;
            this.x_button.Click += new System.EventHandler(this.x_button_Click);
            // 
            // help_button
            // 
            this.help_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("help_button.BackgroundImage")));
            this.help_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.help_button.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.help_button.FlatAppearance.BorderSize = 0;
            this.help_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.help_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help_button.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.help_button.ForeColor = System.Drawing.Color.Teal;
            this.help_button.Location = new System.Drawing.Point(12, 12);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(39, 38);
            this.help_button.TabIndex = 10;
            this.help_button.UseVisualStyleBackColor = true;
            // 
            // btn_student
            // 
            this.btn_student.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_student.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_student.Location = new System.Drawing.Point(92, 438);
            this.btn_student.Name = "btn_student";
            this.btn_student.Size = new System.Drawing.Size(209, 33);
            this.btn_student.TabIndex = 8;
            this.btn_student.Text = "Admin Login";
            this.btn_student.UseVisualStyleBackColor = true;
            this.btn_student.Click += new System.EventHandler(this.btn_student_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(393, 536);
            this.Controls.Add(this.help_button);
            this.Controls.Add(this.x_button);
            this.Controls.Add(this.btn_student);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.password_txtBox);
            this.Controls.Add(this.username_txtBox);
            this.Controls.Add(this.loginScreenIcon_pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.loadScreen_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginScreenIcon_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox loginScreenIcon_pictureBox;
        private System.Windows.Forms.TextBox username_txtBox;
        private System.Windows.Forms.TextBox password_txtBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button x_button;
        private System.Windows.Forms.Button help_button;
        private System.Windows.Forms.Button btn_student;
    }
}

