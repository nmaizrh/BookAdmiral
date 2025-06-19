namespace LABTEST2
{
    partial class formBook
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iSBN_13Label;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label publisherLabel;
            System.Windows.Forms.Label publishDateLabel;
            this.admiralBookstore = new LABTEST2.AdmiralBookstore();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new LABTEST2.AdmiralBookstoreTableAdapters.BookTableAdapter();
            this.tableAdapterManager = new LABTEST2.AdmiralBookstoreTableAdapters.TableAdapterManager();
            this.bookDGV = new System.Windows.Forms.DataGridView();
            this.iSBN13DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNtxtbx = new System.Windows.Forms.TextBox();
            this.titletxtBx = new System.Windows.Forms.TextBox();
            this.publishertxtBx = new System.Windows.Forms.TextBox();
            this.publishDTP = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnStockB = new System.Windows.Forms.Button();
            this.btnAuthorB = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            iSBN_13Label = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            publisherLabel = new System.Windows.Forms.Label();
            publishDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.admiralBookstore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // iSBN_13Label
            // 
            iSBN_13Label.AutoSize = true;
            iSBN_13Label.Location = new System.Drawing.Point(155, 222);
            iSBN_13Label.Name = "iSBN_13Label";
            iSBN_13Label.Size = new System.Drawing.Size(74, 20);
            iSBN_13Label.TabIndex = 1;
            iSBN_13Label.Text = "ISBN-13:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(155, 254);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(42, 20);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Title:";
            // 
            // publisherLabel
            // 
            publisherLabel.AutoSize = true;
            publisherLabel.Location = new System.Drawing.Point(155, 286);
            publisherLabel.Name = "publisherLabel";
            publisherLabel.Size = new System.Drawing.Size(78, 20);
            publisherLabel.TabIndex = 5;
            publisherLabel.Text = "Publisher:";
            // 
            // publishDateLabel
            // 
            publishDateLabel.AutoSize = true;
            publishDateLabel.Location = new System.Drawing.Point(155, 319);
            publishDateLabel.Name = "publishDateLabel";
            publishDateLabel.Size = new System.Drawing.Size(103, 20);
            publishDateLabel.TabIndex = 7;
            publishDateLabel.Text = "Publish Date:";
            // 
            // admiralBookstore
            // 
            this.admiralBookstore.DataSetName = "AdmiralBookstore";
            this.admiralBookstore.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.admiralBookstore;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableAdapter = this.bookTableAdapter;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LABTEST2.AdmiralBookstoreTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bookDGV
            // 
            this.bookDGV.AutoGenerateColumns = false;
            this.bookDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iSBN13DataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.publishDateDataGridViewTextBoxColumn});
            this.bookDGV.DataSource = this.bookBindingSource;
            this.bookDGV.Location = new System.Drawing.Point(21, 38);
            this.bookDGV.Name = "bookDGV";
            this.bookDGV.RowHeadersWidth = 62;
            this.bookDGV.RowTemplate.Height = 28;
            this.bookDGV.Size = new System.Drawing.Size(975, 148);
            this.bookDGV.TabIndex = 1;
            // 
            // iSBN13DataGridViewTextBoxColumn
            // 
            this.iSBN13DataGridViewTextBoxColumn.DataPropertyName = "ISBN-13";
            this.iSBN13DataGridViewTextBoxColumn.HeaderText = "ISBN-13";
            this.iSBN13DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iSBN13DataGridViewTextBoxColumn.Name = "iSBN13DataGridViewTextBoxColumn";
            this.iSBN13DataGridViewTextBoxColumn.Width = 150;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 150;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            this.publisherDataGridViewTextBoxColumn.Width = 150;
            // 
            // publishDateDataGridViewTextBoxColumn
            // 
            this.publishDateDataGridViewTextBoxColumn.DataPropertyName = "PublishDate";
            this.publishDateDataGridViewTextBoxColumn.HeaderText = "PublishDate";
            this.publishDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.publishDateDataGridViewTextBoxColumn.Name = "publishDateDataGridViewTextBoxColumn";
            this.publishDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // iSBNtxtbx
            // 
            this.iSBNtxtbx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "ISBN-13", true));
            this.iSBNtxtbx.Location = new System.Drawing.Point(264, 219);
            this.iSBNtxtbx.Name = "iSBNtxtbx";
            this.iSBNtxtbx.Size = new System.Drawing.Size(200, 26);
            this.iSBNtxtbx.TabIndex = 2;
            // 
            // titletxtBx
            // 
            this.titletxtBx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Title", true));
            this.titletxtBx.Location = new System.Drawing.Point(264, 251);
            this.titletxtBx.Name = "titletxtBx";
            this.titletxtBx.Size = new System.Drawing.Size(200, 26);
            this.titletxtBx.TabIndex = 4;
            // 
            // publishertxtBx
            // 
            this.publishertxtBx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Publisher", true));
            this.publishertxtBx.Location = new System.Drawing.Point(264, 283);
            this.publishertxtBx.Name = "publishertxtBx";
            this.publishertxtBx.Size = new System.Drawing.Size(200, 26);
            this.publishertxtBx.TabIndex = 6;
            // 
            // publishDTP
            // 
            this.publishDTP.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bookBindingSource, "PublishDate", true));
            this.publishDTP.Location = new System.Drawing.Point(264, 315);
            this.publishDTP.Name = "publishDTP";
            this.publishDTP.Size = new System.Drawing.Size(200, 26);
            this.publishDTP.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Cyan;
            this.btnUpdate.Location = new System.Drawing.Point(344, 376);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 45);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnStockB
            // 
            this.btnStockB.BackColor = System.Drawing.Color.Cyan;
            this.btnStockB.Location = new System.Drawing.Point(631, 389);
            this.btnStockB.Name = "btnStockB";
            this.btnStockB.Size = new System.Drawing.Size(120, 32);
            this.btnStockB.TabIndex = 11;
            this.btnStockB.Text = "Go to Stock";
            this.btnStockB.UseVisualStyleBackColor = false;
            this.btnStockB.Click += new System.EventHandler(this.btnStockB_Click_1);
            // 
            // btnAuthorB
            // 
            this.btnAuthorB.BackColor = System.Drawing.Color.Cyan;
            this.btnAuthorB.Location = new System.Drawing.Point(631, 351);
            this.btnAuthorB.Name = "btnAuthorB";
            this.btnAuthorB.Size = new System.Drawing.Size(120, 32);
            this.btnAuthorB.TabIndex = 10;
            this.btnAuthorB.Text = "Go to Author";
            this.btnAuthorB.UseVisualStyleBackColor = false;
            this.btnAuthorB.Click += new System.EventHandler(this.btnAuthorA_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.Cyan;
            this.btnAddBook.Location = new System.Drawing.Point(218, 376);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(120, 45);
            this.btnAddBook.TabIndex = 12;
            this.btnAddBook.Text = "Add";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // formBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 450);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnStockB);
            this.Controls.Add(this.btnAuthorB);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(iSBN_13Label);
            this.Controls.Add(this.iSBNtxtbx);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titletxtBx);
            this.Controls.Add(publisherLabel);
            this.Controls.Add(this.publishertxtBx);
            this.Controls.Add(publishDateLabel);
            this.Controls.Add(this.publishDTP);
            this.Controls.Add(this.bookDGV);
            this.Name = "formBook";
            this.Text = "Form Book";
            this.Load += new System.EventHandler(this.formBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.admiralBookstore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdmiralBookstore admiralBookstore;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private AdmiralBookstoreTableAdapters.BookTableAdapter bookTableAdapter;
        private AdmiralBookstoreTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bookDGV;
        private System.Windows.Forms.TextBox iSBNtxtbx;
        private System.Windows.Forms.TextBox titletxtBx;
        private System.Windows.Forms.TextBox publishertxtBx;
        private System.Windows.Forms.DateTimePicker publishDTP;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnStockB;
        private System.Windows.Forms.Button btnAuthorB;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBN13DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAddBook;
    }
}