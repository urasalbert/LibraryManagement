namespace LibraryManagement
{
    partial class ReturnBook
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_kitaplariniz = new System.Windows.Forms.Label();
            this.btn_return = new System.Windows.Forms.Button();
            this.txt_studenID = new System.Windows.Forms.TextBox();
            this.btn_viewstudent = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1106, 434);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // lbl_kitaplariniz
            // 
            this.lbl_kitaplariniz.AutoSize = true;
            this.lbl_kitaplariniz.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kitaplariniz.Location = new System.Drawing.Point(12, 19);
            this.lbl_kitaplariniz.Name = "lbl_kitaplariniz";
            this.lbl_kitaplariniz.Size = new System.Drawing.Size(372, 33);
            this.lbl_kitaplariniz.TabIndex = 1;
            this.lbl_kitaplariniz.Text = "Rented Books Enter Student ID: ";
            // 
            // btn_return
            // 
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_return.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_return.Location = new System.Drawing.Point(834, 19);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(127, 43);
            this.btn_return.TabIndex = 2;
            this.btn_return.Text = "Return book";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // txt_studenID
            // 
            this.txt_studenID.Location = new System.Drawing.Point(390, 31);
            this.txt_studenID.Name = "txt_studenID";
            this.txt_studenID.Size = new System.Drawing.Size(191, 20);
            this.txt_studenID.TabIndex = 3;
            this.txt_studenID.TextChanged += new System.EventHandler(this.txt_studenID_TextChanged);
            // 
            // btn_viewstudent
            // 
            this.btn_viewstudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_viewstudent.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_viewstudent.Location = new System.Drawing.Point(967, 19);
            this.btn_viewstudent.Name = "btn_viewstudent";
            this.btn_viewstudent.Size = new System.Drawing.Size(137, 43);
            this.btn_viewstudent.TabIndex = 2;
            this.btn_viewstudent.Text = "View Student";
            this.btn_viewstudent.UseVisualStyleBackColor = true;
            this.btn_viewstudent.Click += new System.EventHandler(this.btn_viewstudent_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(724, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1106, 513);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_studenID);
            this.Controls.Add(this.btn_viewstudent);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.lbl_kitaplariniz);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_kitaplariniz;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.TextBox txt_studenID;
        private System.Windows.Forms.Button btn_viewstudent;
        private System.Windows.Forms.Button button1;
    }
}