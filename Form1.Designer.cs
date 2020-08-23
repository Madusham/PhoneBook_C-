namespace PhoneBook
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CNum3txt = new System.Windows.Forms.TextBox();
            this.CNum2txt = new System.Windows.Forms.TextBox();
            this.CNum1txt = new System.Windows.Forms.TextBox();
            this.CNametxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Deletbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DNum1 = new System.Windows.Forms.TextBox();
            this.DNum2 = new System.Windows.Forms.TextBox();
            this.DName = new System.Windows.Forms.TextBox();
            this.DNum3 = new System.Windows.Forms.TextBox();
            this.Searchbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnnum1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNum2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNum3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView = new System.Windows.Forms.ListView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNum1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNum2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNum3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Addbtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CNum3txt);
            this.groupBox1.Controls.Add(this.CNum2txt);
            this.groupBox1.Controls.Add(this.CNum1txt);
            this.groupBox1.Controls.Add(this.CNametxt);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1101, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Contacts";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Addbtn
            // 
            this.Addbtn.Image = ((System.Drawing.Image)(resources.GetObject("Addbtn.Image")));
            this.Addbtn.Location = new System.Drawing.Point(988, 75);
            this.Addbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(59, 57);
            this.Addbtn.TabIndex = 10;
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(308, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contacts Numbers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Contact Name";
            // 
            // CNum3txt
            // 
            this.CNum3txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CNum3txt.Location = new System.Drawing.Point(732, 102);
            this.CNum3txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CNum3txt.Name = "CNum3txt";
            this.CNum3txt.Size = new System.Drawing.Size(196, 30);
            this.CNum3txt.TabIndex = 5;
            // 
            // CNum2txt
            // 
            this.CNum2txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CNum2txt.Location = new System.Drawing.Point(522, 102);
            this.CNum2txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CNum2txt.Name = "CNum2txt";
            this.CNum2txt.Size = new System.Drawing.Size(196, 30);
            this.CNum2txt.TabIndex = 4;
            // 
            // CNum1txt
            // 
            this.CNum1txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CNum1txt.Location = new System.Drawing.Point(312, 102);
            this.CNum1txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CNum1txt.Name = "CNum1txt";
            this.CNum1txt.Size = new System.Drawing.Size(196, 30);
            this.CNum1txt.TabIndex = 3;
            // 
            // CNametxt
            // 
            this.CNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CNametxt.Location = new System.Drawing.Point(18, 102);
            this.CNametxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CNametxt.Name = "CNametxt";
            this.CNametxt.Size = new System.Drawing.Size(231, 30);
            this.CNametxt.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Deletbtn);
            this.groupBox2.Controls.Add(this.Updatebtn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.DNum1);
            this.groupBox2.Controls.Add(this.DNum2);
            this.groupBox2.Controls.Add(this.DName);
            this.groupBox2.Controls.Add(this.DNum3);
            this.groupBox2.Location = new System.Drawing.Point(756, 356);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(360, 376);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact Details";
            // 
            // Deletbtn
            // 
            this.Deletbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletbtn.Location = new System.Drawing.Point(247, 280);
            this.Deletbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Deletbtn.Name = "Deletbtn";
            this.Deletbtn.Size = new System.Drawing.Size(107, 51);
            this.Deletbtn.TabIndex = 13;
            this.Deletbtn.Text = "Delete";
            this.Deletbtn.UseVisualStyleBackColor = true;
            this.Deletbtn.Click += new System.EventHandler(this.Deletbtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.Location = new System.Drawing.Point(247, 222);
            this.Updatebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(107, 51);
            this.Updatebtn.TabIndex = 11;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contact Numbers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Contact Name";
            // 
            // DNum1
            // 
            this.DNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DNum1.Location = new System.Drawing.Point(20, 202);
            this.DNum1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DNum1.Name = "DNum1";
            this.DNum1.Size = new System.Drawing.Size(201, 30);
            this.DNum1.TabIndex = 5;
            // 
            // DNum2
            // 
            this.DNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DNum2.Location = new System.Drawing.Point(20, 254);
            this.DNum2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DNum2.Name = "DNum2";
            this.DNum2.Size = new System.Drawing.Size(201, 30);
            this.DNum2.TabIndex = 4;
            // 
            // DName
            // 
            this.DName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DName.Location = new System.Drawing.Point(20, 98);
            this.DName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DName.Name = "DName";
            this.DName.Size = new System.Drawing.Size(231, 30);
            this.DName.TabIndex = 0;
            // 
            // DNum3
            // 
            this.DNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DNum3.Location = new System.Drawing.Point(20, 302);
            this.DNum3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DNum3.Name = "DNum3";
            this.DNum3.Size = new System.Drawing.Size(201, 30);
            this.DNum3.TabIndex = 3;
            // 
            // Searchbox
            // 
            this.Searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Searchbox.Location = new System.Drawing.Point(756, 277);
            this.Searchbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Searchbox.Name = "Searchbox";
            this.Searchbox.Size = new System.Drawing.Size(231, 30);
            this.Searchbox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Contact List";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(751, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Search for";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // columnName
            // 
            this.columnName.Text = "Contact Name";
            this.columnName.Width = 250;
            // 
            // columnnum1
            // 
            this.columnnum1.Text = "Contact Number 1";
            this.columnnum1.Width = 150;
            // 
            // columnNum2
            // 
            this.columnNum2.Text = "Contact Number 2";
            this.columnNum2.Width = 150;
            // 
            // columnNum3
            // 
            this.columnNum3.Text = " Contact Number 3";
            this.columnNum3.Width = 158;
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnnum1,
            this.columnNum2,
            this.columnNum3});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(10, 243);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(723, 486);
            this.listView.TabIndex = 13;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            this.listView.DoubleClick += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CName,
            this.CNum1,
            this.CNum2,
            this.CNum3});
            this.dataGridView1.Location = new System.Drawing.Point(10, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(735, 472);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // CName
            // 
            this.CName.HeaderText = "Contact Name";
            this.CName.Name = "CName";
            this.CName.ReadOnly = true;
            this.CName.Width = 200;
            // 
            // CNum1
            // 
            this.CNum1.HeaderText = "Contact Number1";
            this.CNum1.Name = "CNum1";
            this.CNum1.ReadOnly = true;
            this.CNum1.Width = 170;
            // 
            // CNum2
            // 
            this.CNum2.HeaderText = "Contact Number2";
            this.CNum2.Name = "CNum2";
            this.CNum2.ReadOnly = true;
            this.CNum2.Width = 170;
            // 
            // CNum3
            // 
            this.CNum3.HeaderText = "Contact Number3";
            this.CNum3.Name = "CNum3";
            this.CNum3.ReadOnly = true;
            this.CNum3.Width = 170;
            // 
            // Searchbtn
            // 
            this.Searchbtn.Image = global::PhoneBook.Properties.Resources.iconfinder_system_search_118797__1_;
            this.Searchbtn.Location = new System.Drawing.Point(1024, 243);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(69, 64);
            this.Searchbtn.TabIndex = 15;
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 741);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Searchbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Contacts";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CNum3txt;
        private System.Windows.Forms.TextBox CNum2txt;
        private System.Windows.Forms.TextBox CNum1txt;
        private System.Windows.Forms.TextBox CNametxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DNum1;
        private System.Windows.Forms.TextBox DNum2;
        private System.Windows.Forms.TextBox DName;
        private System.Windows.Forms.TextBox DNum3;
        private System.Windows.Forms.TextBox Searchbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Deletbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnnum1;
        private System.Windows.Forms.ColumnHeader columnNum2;
        private System.Windows.Forms.ColumnHeader columnNum3;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNum1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNum2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNum3;
        private System.Windows.Forms.Button Searchbtn;
    }
}

