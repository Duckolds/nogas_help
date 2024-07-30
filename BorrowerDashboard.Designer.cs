namespace LibraryManagement
{
    partial class BorrowerDashboard
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
            this.tabPageTicket = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageBook);
            this.tabControl1.Controls.Add(this.tabPageTicket);
            this.tabControl1.Location = new System.Drawing.Point(-4, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(809, 452);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageBook
            // 
            this.tabPageBook.Controls.Add(this.lbBookList);
            this.tabPageBook.Controls.Add(this.dgvBookList);
            this.tabPageBook.Controls.Add(this.cbPublisher);
            this.tabPageBook.Controls.Add(this.cbAuthor);
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
            this.tabPageBook.Location = new System.Drawing.Point(4, 25);
            this.tabPageBook.Name = "tabPageBook";
            this.tabPageBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBook.Size = new System.Drawing.Size(801, 423);
            this.tabPageBook.TabIndex = 0;
            this.tabPageBook.Text = "Book";
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
            // tabPageTicket
            // 
            this.tabPageTicket.Location = new System.Drawing.Point(4, 25);
            this.tabPageTicket.Name = "tabPageTicket";
            this.tabPageTicket.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTicket.Size = new System.Drawing.Size(801, 423);
            this.tabPageTicket.TabIndex = 1;
            this.tabPageTicket.Text = "Ticket";
            this.tabPageTicket.UseVisualStyleBackColor = true;
            // 
            // BorrowerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "BorrowerDashboard";
            this.Text = "BorrowerDashboard";
            this.tabControl1.ResumeLayout(false);
            this.tabPageBook.ResumeLayout(false);
            this.tabPageBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBook;
        private System.Windows.Forms.Label lbBookList;
        private System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.ComboBox cbPublisher;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.DateTimePicker dtPublishDate;
        private System.Windows.Forms.Label lbPublishDate;
        private System.Windows.Forms.Label lbPublisher;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TabPage tabPageTicket;
    }
}