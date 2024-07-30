namespace LibraryManagement
{
    partial class AdminDashboard
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBook = new System.Windows.Forms.TabPage();
            this.lbBookList = new System.Windows.Forms.Label();
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.cbPublisher = new System.Windows.Forms.ComboBox();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.btnClearData = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtPublishDate = new System.Windows.Forms.DateTimePicker();
            this.lbPublishDate = new System.Windows.Forms.Label();
            this.lbPublisher = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tabPageBorrower = new System.Windows.Forms.TabPage();
            this.tabPageTicket = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageBook);
            this.tabControl1.Controls.Add(this.tabPageBorrower);
            this.tabControl1.Controls.Add(this.tabPageTicket);
            this.tabControl1.Location = new System.Drawing.Point(-5, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(809, 452);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageBook
            // 
            this.tabPageBook.Controls.Add(this.lbBookList);
            this.tabPageBook.Controls.Add(this.dgvBookList);
            this.tabPageBook.Controls.Add(this.cbPublisher);
            this.tabPageBook.Controls.Add(this.cbAuthor);
            this.tabPageBook.Controls.Add(this.btnClearData);
            this.tabPageBook.Controls.Add(this.btnDelete);
            this.tabPageBook.Controls.Add(this.btnUpdate);
            this.tabPageBook.Controls.Add(this.btnAdd);
            this.tabPageBook.Controls.Add(this.dtPublishDate);
            this.tabPageBook.Controls.Add(this.lbPublishDate);
            this.tabPageBook.Controls.Add(this.lbPublisher);
            this.tabPageBook.Controls.Add(this.lbCategory);
            this.tabPageBook.Controls.Add(this.cbCategory);
            this.tabPageBook.Controls.Add(this.lbAuthor);
            this.tabPageBook.Controls.Add(this.txtName);
            this.tabPageBook.Controls.Add(this.lbName);
            this.tabPageBook.Controls.Add(this.txtId);
            this.tabPageBook.Controls.Add(this.lbId);
            this.tabPageBook.Controls.Add(this.lbTitle);
            this.tabPageBook.Location = new System.Drawing.Point(4, 25);
            this.tabPageBook.Name = "tabPageBook";
            this.tabPageBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBook.Size = new System.Drawing.Size(801, 423);
            this.tabPageBook.TabIndex = 0;
            this.tabPageBook.Text = "Manage Book";
            this.tabPageBook.UseVisualStyleBackColor = true;
            // 
            // lbBookList
            // 
            this.lbBookList.AutoSize = true;
            this.lbBookList.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookList.Location = new System.Drawing.Point(298, 205);
            this.lbBookList.Name = "lbBookList";
            this.lbBookList.Size = new System.Drawing.Size(187, 36);
            this.lbBookList.TabIndex = 20;
            this.lbBookList.Text = "List of Books";
            // 
            // dgvBookList
            // 
            this.dgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookList.Location = new System.Drawing.Point(9, 244);
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.RowHeadersWidth = 51;
            this.dgvBookList.RowTemplate.Height = 24;
            this.dgvBookList.Size = new System.Drawing.Size(786, 173);
            this.dgvBookList.TabIndex = 19;
            // 
            // cbPublisher
            // 
            this.cbPublisher.FormattingEnabled = true;
            this.cbPublisher.Location = new System.Drawing.Point(553, 71);
            this.cbPublisher.Name = "cbPublisher";
            this.cbPublisher.Size = new System.Drawing.Size(200, 24);
            this.cbPublisher.TabIndex = 18;
            // 
            // cbAuthor
            // 
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(84, 127);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(166, 24);
            this.cbAuthor.TabIndex = 17;
            // 
            // btnClearData
            // 
            this.btnClearData.Location = new System.Drawing.Point(553, 168);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(105, 32);
            this.btnClearData.TabIndex = 16;
            this.btnClearData.Text = "Clear Data";
            this.btnClearData.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(664, 130);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 32);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(553, 130);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 32);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(442, 130);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 32);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dtPublishDate
            // 
            this.dtPublishDate.Location = new System.Drawing.Point(553, 102);
            this.dtPublishDate.Name = "dtPublishDate";
            this.dtPublishDate.Size = new System.Drawing.Size(200, 22);
            this.dtPublishDate.TabIndex = 12;
            this.dtPublishDate.Value = new System.DateTime(2024, 7, 30, 0, 0, 0, 0);
            // 
            // lbPublishDate
            // 
            this.lbPublishDate.AutoSize = true;
            this.lbPublishDate.Location = new System.Drawing.Point(443, 105);
            this.lbPublishDate.Name = "lbPublishDate";
            this.lbPublishDate.Size = new System.Drawing.Size(104, 16);
            this.lbPublishDate.TabIndex = 11;
            this.lbPublishDate.Text = "Publishing Date:";
            // 
            // lbPublisher
            // 
            this.lbPublisher.AutoSize = true;
            this.lbPublisher.Location = new System.Drawing.Point(443, 77);
            this.lbPublisher.Name = "lbPublisher";
            this.lbPublisher.Size = new System.Drawing.Size(66, 16);
            this.lbPublisher.TabIndex = 9;
            this.lbPublisher.Text = "Publisher:";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(13, 160);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(65, 16);
            this.lbCategory.TabIndex = 8;
            this.lbCategory.Text = "Category:";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(84, 157);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(166, 24);
            this.cbCategory.TabIndex = 7;
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Location = new System.Drawing.Point(13, 130);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(48, 16);
            this.lbAuthor.TabIndex = 5;
            this.lbAuthor.Text = "Author:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(84, 99);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(166, 22);
            this.txtName.TabIndex = 4;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(13, 102);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(47, 16);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Name:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(84, 71);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(166, 22);
            this.txtId.TabIndex = 2;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(13, 74);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(23, 16);
            this.lbId.TabIndex = 1;
            this.lbId.Text = "ID:";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(254, 14);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(263, 36);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Book Management";
            // 
            // tabPageBorrower
            // 
            this.tabPageBorrower.Location = new System.Drawing.Point(4, 25);
            this.tabPageBorrower.Name = "tabPageBorrower";
            this.tabPageBorrower.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBorrower.Size = new System.Drawing.Size(801, 423);
            this.tabPageBorrower.TabIndex = 1;
            this.tabPageBorrower.Text = "Manage Borrower";
            this.tabPageBorrower.UseVisualStyleBackColor = true;
            // 
            // tabPageTicket
            // 
            this.tabPageTicket.Location = new System.Drawing.Point(4, 25);
            this.tabPageTicket.Name = "tabPageTicket";
            this.tabPageTicket.Size = new System.Drawing.Size(801, 423);
            this.tabPageTicket.TabIndex = 2;
            this.tabPageTicket.Text = "Manage Ticket";
            this.tabPageTicket.UseVisualStyleBackColor = true;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.tabControl1.ResumeLayout(false);
            this.tabPageBook.ResumeLayout(false);
            this.tabPageBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBook;
        private System.Windows.Forms.TabPage tabPageBorrower;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TabPage tabPageTicket;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtPublishDate;
        private System.Windows.Forms.Label lbPublishDate;
        private System.Windows.Forms.Label lbPublisher;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.ComboBox cbPublisher;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.Label lbBookList;
    }
}