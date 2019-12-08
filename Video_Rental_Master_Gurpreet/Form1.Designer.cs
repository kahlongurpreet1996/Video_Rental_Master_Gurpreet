namespace Video_Rental_Master_Gurpreet
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvGrid = new System.Windows.Forms.DataGridView();
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.btnCustomerUpdate = new System.Windows.Forms.Button();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerContact = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.btnMovieAdd = new System.Windows.Forms.Button();
            this.txtMovieID = new System.Windows.Forms.TextBox();
            this.txtMovieTitle = new System.Windows.Forms.TextBox();
            this.txtMovieGenre = new System.Windows.Forms.TextBox();
            this.TxtMovieYear = new System.Windows.Forms.TextBox();
            this.txtMovieCost = new System.Windows.Forms.TextBox();
            this.btnMovieUpdate = new System.Windows.Forms.Button();
            this.btnMovieDelete = new System.Windows.Forms.Button();
            this.btnMovieIssue = new System.Windows.Forms.Button();
            this.btnMovieReturn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbReturned = new System.Windows.Forms.RadioButton();
            this.rbRented = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.txtMovieCopies = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Customers";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(119, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Movies";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(212, 15);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "Rentals";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvGrid
            // 
            this.dgvGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrid.Location = new System.Drawing.Point(11, 50);
            this.dgvGrid.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGrid.Name = "dgvGrid";
            this.dgvGrid.RowHeadersWidth = 51;
            this.dgvGrid.Size = new System.Drawing.Size(1109, 261);
            this.dgvGrid.TabIndex = 3;
            this.dgvGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dgvGrid.DoubleClick += new System.EventHandler(this.dgvGrid_DoubleClick);
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCustomerAdd.Location = new System.Drawing.Point(21, 348);
            this.btnCustomerAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(100, 65);
            this.btnCustomerAdd.TabIndex = 4;
            this.btnCustomerAdd.Text = "Add Customer";
            this.btnCustomerAdd.UseVisualStyleBackColor = false;
            this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(149, 348);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(96, 22);
            this.txtCustomerID.TabIndex = 5;
            this.txtCustomerID.Click += new System.EventHandler(this.txtCustomerID_Click);
            // 
            // btnCustomerUpdate
            // 
            this.btnCustomerUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCustomerUpdate.Location = new System.Drawing.Point(255, 348);
            this.btnCustomerUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustomerUpdate.Name = "btnCustomerUpdate";
            this.btnCustomerUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnCustomerUpdate.TabIndex = 6;
            this.btnCustomerUpdate.Text = "Update";
            this.btnCustomerUpdate.UseVisualStyleBackColor = false;
            this.btnCustomerUpdate.Click += new System.EventHandler(this.btnCustomerUpdate_Click);
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCustomerDelete.Location = new System.Drawing.Point(363, 348);
            this.btnCustomerDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(100, 28);
            this.btnCustomerDelete.TabIndex = 7;
            this.btnCustomerDelete.Text = "Delete";
            this.btnCustomerDelete.UseVisualStyleBackColor = false;
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(149, 389);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(105, 22);
            this.txtCustomerName.TabIndex = 8;
            this.txtCustomerName.Text = "Name";
            this.txtCustomerName.Click += new System.EventHandler(this.txtCustomerName_Click);
            // 
            // txtCustomerContact
            // 
            this.txtCustomerContact.Location = new System.Drawing.Point(264, 389);
            this.txtCustomerContact.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerContact.Name = "txtCustomerContact";
            this.txtCustomerContact.Size = new System.Drawing.Size(105, 22);
            this.txtCustomerContact.TabIndex = 9;
            this.txtCustomerContact.Text = "Contact";
            this.txtCustomerContact.Click += new System.EventHandler(this.txtCustomerContact_Click);
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(393, 389);
            this.txtCustomerAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(105, 22);
            this.txtCustomerAddress.TabIndex = 10;
            this.txtCustomerAddress.Text = "Address";
            this.txtCustomerAddress.Click += new System.EventHandler(this.txtCustomerAddress_Click);
            // 
            // btnMovieAdd
            // 
            this.btnMovieAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMovieAdd.Location = new System.Drawing.Point(21, 446);
            this.btnMovieAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnMovieAdd.Name = "btnMovieAdd";
            this.btnMovieAdd.Size = new System.Drawing.Size(100, 65);
            this.btnMovieAdd.TabIndex = 12;
            this.btnMovieAdd.Text = "Add Movie";
            this.btnMovieAdd.UseVisualStyleBackColor = false;
            this.btnMovieAdd.Click += new System.EventHandler(this.btnMovieAdd_Click);
            // 
            // txtMovieID
            // 
            this.txtMovieID.Location = new System.Drawing.Point(129, 446);
            this.txtMovieID.Margin = new System.Windows.Forms.Padding(4);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.ReadOnly = true;
            this.txtMovieID.Size = new System.Drawing.Size(45, 22);
            this.txtMovieID.TabIndex = 13;
            // 
            // txtMovieTitle
            // 
            this.txtMovieTitle.Location = new System.Drawing.Point(184, 446);
            this.txtMovieTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtMovieTitle.Name = "txtMovieTitle";
            this.txtMovieTitle.Size = new System.Drawing.Size(105, 22);
            this.txtMovieTitle.TabIndex = 14;
            this.txtMovieTitle.Text = "Title";
            this.txtMovieTitle.Click += new System.EventHandler(this.txtMovieTitle_Click);
            // 
            // txtMovieGenre
            // 
            this.txtMovieGenre.Location = new System.Drawing.Point(299, 446);
            this.txtMovieGenre.Margin = new System.Windows.Forms.Padding(4);
            this.txtMovieGenre.Name = "txtMovieGenre";
            this.txtMovieGenre.Size = new System.Drawing.Size(105, 22);
            this.txtMovieGenre.TabIndex = 15;
            this.txtMovieGenre.Text = "Genre";
            this.txtMovieGenre.Click += new System.EventHandler(this.txtMovieGenre_Click);
            // 
            // TxtMovieYear
            // 
            this.TxtMovieYear.Location = new System.Drawing.Point(413, 446);
            this.TxtMovieYear.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMovieYear.Name = "TxtMovieYear";
            this.TxtMovieYear.Size = new System.Drawing.Size(105, 22);
            this.TxtMovieYear.TabIndex = 16;
            this.TxtMovieYear.Text = "Year";
            this.TxtMovieYear.Click += new System.EventHandler(this.TxtMovieYear_Click);
            this.TxtMovieYear.Leave += new System.EventHandler(this.TxtMovieYear_Leave);
            // 
            // txtMovieCost
            // 
            this.txtMovieCost.Location = new System.Drawing.Point(528, 446);
            this.txtMovieCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtMovieCost.Name = "txtMovieCost";
            this.txtMovieCost.ReadOnly = true;
            this.txtMovieCost.Size = new System.Drawing.Size(49, 22);
            this.txtMovieCost.TabIndex = 17;
            this.txtMovieCost.Text = "0";
            this.txtMovieCost.Click += new System.EventHandler(this.txtMovieCost_Click);
            // 
            // btnMovieUpdate
            // 
            this.btnMovieUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMovieUpdate.Location = new System.Drawing.Point(156, 482);
            this.btnMovieUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnMovieUpdate.Name = "btnMovieUpdate";
            this.btnMovieUpdate.Size = new System.Drawing.Size(135, 28);
            this.btnMovieUpdate.TabIndex = 18;
            this.btnMovieUpdate.Text = "Update Movie";
            this.btnMovieUpdate.UseVisualStyleBackColor = false;
            this.btnMovieUpdate.Click += new System.EventHandler(this.btnMovieUpdate_Click);
            // 
            // btnMovieDelete
            // 
            this.btnMovieDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMovieDelete.Location = new System.Drawing.Point(305, 482);
            this.btnMovieDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnMovieDelete.Name = "btnMovieDelete";
            this.btnMovieDelete.Size = new System.Drawing.Size(157, 28);
            this.btnMovieDelete.TabIndex = 19;
            this.btnMovieDelete.Text = "Delete Movie";
            this.btnMovieDelete.UseVisualStyleBackColor = false;
            this.btnMovieDelete.Click += new System.EventHandler(this.btnMovieDelete_Click);
            // 
            // btnMovieIssue
            // 
            this.btnMovieIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMovieIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovieIssue.ForeColor = System.Drawing.Color.Red;
            this.btnMovieIssue.Location = new System.Drawing.Point(723, 348);
            this.btnMovieIssue.Margin = new System.Windows.Forms.Padding(4);
            this.btnMovieIssue.Name = "btnMovieIssue";
            this.btnMovieIssue.Size = new System.Drawing.Size(187, 63);
            this.btnMovieIssue.TabIndex = 20;
            this.btnMovieIssue.Text = "Issue Movie";
            this.btnMovieIssue.UseVisualStyleBackColor = false;
            this.btnMovieIssue.Click += new System.EventHandler(this.btnMovieIssue_Click);
            // 
            // btnMovieReturn
            // 
            this.btnMovieReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMovieReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovieReturn.ForeColor = System.Drawing.Color.Green;
            this.btnMovieReturn.Location = new System.Drawing.Point(966, 347);
            this.btnMovieReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnMovieReturn.Name = "btnMovieReturn";
            this.btnMovieReturn.Size = new System.Drawing.Size(181, 65);
            this.btnMovieReturn.TabIndex = 21;
            this.btnMovieReturn.Text = "Return Movie";
            this.btnMovieReturn.UseVisualStyleBackColor = false;
            this.btnMovieReturn.Click += new System.EventHandler(this.btnMovieReturn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.rbReturned);
            this.groupBox1.Controls.Add(this.rbRented);
            this.groupBox1.Location = new System.Drawing.Point(742, 482);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(231, 65);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rented Movies";
            // 
            // rbReturned
            // 
            this.rbReturned.AutoSize = true;
            this.rbReturned.Location = new System.Drawing.Point(117, 28);
            this.rbReturned.Margin = new System.Windows.Forms.Padding(4);
            this.rbReturned.Name = "rbReturned";
            this.rbReturned.Size = new System.Drawing.Size(102, 21);
            this.rbReturned.TabIndex = 1;
            this.rbReturned.TabStop = true;
            this.rbReturned.Text = "Out Rented";
            this.rbReturned.UseVisualStyleBackColor = true;
            this.rbReturned.CheckedChanged += new System.EventHandler(this.rbReturned_CheckedChanged);
            // 
            // rbRented
            // 
            this.rbRented.AutoSize = true;
            this.rbRented.Location = new System.Drawing.Point(8, 28);
            this.rbRented.Margin = new System.Windows.Forms.Padding(4);
            this.rbRented.Name = "rbRented";
            this.rbRented.Size = new System.Drawing.Size(94, 21);
            this.rbRented.TabIndex = 0;
            this.rbRented.TabStop = true;
            this.rbRented.Text = "All Rented";
            this.rbRented.UseVisualStyleBackColor = true;
            this.rbRented.CheckedChanged += new System.EventHandler(this.rbRented_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 581);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "Most Borrowed Video is ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 581);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "Most Popular Customer is ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIssueDate.Location = new System.Drawing.Point(701, 316);
            this.dtpIssueDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(120, 22);
            this.dtpIssueDate.TabIndex = 25;
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(853, 316);
            this.dtpReturnDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(120, 22);
            this.dtpReturnDate.TabIndex = 26;
            // 
            // txtMovieCopies
            // 
            this.txtMovieCopies.Location = new System.Drawing.Point(587, 446);
            this.txtMovieCopies.Margin = new System.Windows.Forms.Padding(4);
            this.txtMovieCopies.Name = "txtMovieCopies";
            this.txtMovieCopies.Size = new System.Drawing.Size(105, 22);
            this.txtMovieCopies.TabIndex = 27;
            this.txtMovieCopies.Text = "Copies";
            this.txtMovieCopies.Click += new System.EventHandler(this.txtMovieCopies_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1191, 690);
            this.Controls.Add(this.txtMovieCopies);
            this.Controls.Add(this.dtpReturnDate);
            this.Controls.Add(this.dtpIssueDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMovieReturn);
            this.Controls.Add(this.btnMovieIssue);
            this.Controls.Add(this.btnMovieDelete);
            this.Controls.Add(this.btnMovieUpdate);
            this.Controls.Add(this.txtMovieCost);
            this.Controls.Add(this.TxtMovieYear);
            this.Controls.Add(this.txtMovieGenre);
            this.Controls.Add(this.txtMovieTitle);
            this.Controls.Add(this.txtMovieID);
            this.Controls.Add(this.btnMovieAdd);
            this.Controls.Add(this.txtCustomerAddress);
            this.Controls.Add(this.txtCustomerContact);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.btnCustomerDelete);
            this.Controls.Add(this.btnCustomerUpdate);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.btnCustomerAdd);
            this.Controls.Add(this.dgvGrid);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvGrid;
        private System.Windows.Forms.Button btnCustomerAdd;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Button btnCustomerUpdate;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerContact;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Button btnMovieAdd;
        private System.Windows.Forms.TextBox txtMovieID;
        private System.Windows.Forms.TextBox txtMovieTitle;
        private System.Windows.Forms.TextBox txtMovieGenre;
        private System.Windows.Forms.TextBox TxtMovieYear;
        private System.Windows.Forms.TextBox txtMovieCost;
        private System.Windows.Forms.Button btnMovieUpdate;
        private System.Windows.Forms.Button btnMovieDelete;
        private System.Windows.Forms.Button btnMovieIssue;
        private System.Windows.Forms.Button btnMovieReturn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbReturned;
        private System.Windows.Forms.RadioButton rbRented;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.TextBox txtMovieCopies;
    }
}

