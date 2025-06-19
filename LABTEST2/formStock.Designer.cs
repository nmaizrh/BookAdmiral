namespace LABTEST2
{
    partial class formStock
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
            System.Windows.Forms.Label stockIDLabel;
            System.Windows.Forms.Label authorIDLabel;
            System.Windows.Forms.Label iSBN_13Label;
            System.Windows.Forms.Label quantityInStockLabel;
            System.Windows.Forms.Label dateRecordedLabel;
            this.admiralBookstore = new LABTEST2.AdmiralBookstore();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new LABTEST2.AdmiralBookstoreTableAdapters.StockTableAdapter();
            this.tableAdapterManager = new LABTEST2.AdmiralBookstoreTableAdapters.TableAdapterManager();
            this.stockDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockIDtxtbx = new System.Windows.Forms.TextBox();
            this.authorIDtxtbx = new System.Windows.Forms.TextBox();
            this.iSBN13txtbx = new System.Windows.Forms.TextBox();
            this.quantityInStockTextBox = new System.Windows.Forms.TextBox();
            this.dateRecordtxtBx = new System.Windows.Forms.DateTimePicker();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.btnDeleteStock = new System.Windows.Forms.Button();
            this.btnAuthorS = new System.Windows.Forms.Button();
            this.btnBookS = new System.Windows.Forms.Button();
            stockIDLabel = new System.Windows.Forms.Label();
            authorIDLabel = new System.Windows.Forms.Label();
            iSBN_13Label = new System.Windows.Forms.Label();
            quantityInStockLabel = new System.Windows.Forms.Label();
            dateRecordedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.admiralBookstore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // admiralBookstore
            // 
            this.admiralBookstore.DataSetName = "AdmiralBookstore";
            this.admiralBookstore.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.admiralBookstore;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = this.stockTableAdapter;
            this.tableAdapterManager.UpdateOrder = LABTEST2.AdmiralBookstoreTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stockDGV
            // 
            this.stockDGV.AutoGenerateColumns = false;
            this.stockDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.stockDGV.DataSource = this.stockBindingSource;
            this.stockDGV.Location = new System.Drawing.Point(63, 30);
            this.stockDGV.Name = "stockDGV";
            this.stockDGV.RowHeadersWidth = 62;
            this.stockDGV.RowTemplate.Height = 28;
            this.stockDGV.Size = new System.Drawing.Size(870, 171);
            this.stockDGV.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StockID";
            this.dataGridViewTextBoxColumn1.HeaderText = "StockID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AuthorID";
            this.dataGridViewTextBoxColumn2.HeaderText = "AuthorID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ISBN-13";
            this.dataGridViewTextBoxColumn3.HeaderText = "ISBN-13";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "QuantityInStock";
            this.dataGridViewTextBoxColumn4.HeaderText = "QuantityInStock";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DateRecorded";
            this.dataGridViewTextBoxColumn5.HeaderText = "DateRecorded";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // stockIDLabel
            // 
            stockIDLabel.AutoSize = true;
            stockIDLabel.Location = new System.Drawing.Point(231, 231);
            stockIDLabel.Name = "stockIDLabel";
            stockIDLabel.Size = new System.Drawing.Size(75, 20);
            stockIDLabel.TabIndex = 1;
            stockIDLabel.Text = "Stock ID:";
            // 
            // stockIDtxtbx
            // 
            this.stockIDtxtbx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "StockID", true));
            this.stockIDtxtbx.Location = new System.Drawing.Point(372, 228);
            this.stockIDtxtbx.Name = "stockIDtxtbx";
            this.stockIDtxtbx.Size = new System.Drawing.Size(200, 26);
            this.stockIDtxtbx.TabIndex = 2;
            // 
            // authorIDLabel
            // 
            authorIDLabel.AutoSize = true;
            authorIDLabel.Location = new System.Drawing.Point(231, 263);
            authorIDLabel.Name = "authorIDLabel";
            authorIDLabel.Size = new System.Drawing.Size(82, 20);
            authorIDLabel.TabIndex = 3;
            authorIDLabel.Text = "Author ID:";
            // 
            // authorIDtxtbx
            // 
            this.authorIDtxtbx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "AuthorID", true));
            this.authorIDtxtbx.Location = new System.Drawing.Point(372, 260);
            this.authorIDtxtbx.Name = "authorIDtxtbx";
            this.authorIDtxtbx.Size = new System.Drawing.Size(200, 26);
            this.authorIDtxtbx.TabIndex = 4;
            // 
            // iSBN_13Label
            // 
            iSBN_13Label.AutoSize = true;
            iSBN_13Label.Location = new System.Drawing.Point(231, 295);
            iSBN_13Label.Name = "iSBN_13Label";
            iSBN_13Label.Size = new System.Drawing.Size(74, 20);
            iSBN_13Label.TabIndex = 5;
            iSBN_13Label.Text = "ISBN-13:";
            // 
            // iSBN13txtbx
            // 
            this.iSBN13txtbx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "ISBN-13", true));
            this.iSBN13txtbx.Location = new System.Drawing.Point(372, 292);
            this.iSBN13txtbx.Name = "iSBN13txtbx";
            this.iSBN13txtbx.Size = new System.Drawing.Size(200, 26);
            this.iSBN13txtbx.TabIndex = 6;
            // 
            // quantityInStockLabel
            // 
            quantityInStockLabel.AutoSize = true;
            quantityInStockLabel.Location = new System.Drawing.Point(231, 327);
            quantityInStockLabel.Name = "quantityInStockLabel";
            quantityInStockLabel.Size = new System.Drawing.Size(135, 20);
            quantityInStockLabel.TabIndex = 7;
            quantityInStockLabel.Text = "Quantity In Stock:";
            // 
            // quantityInStockTextBox
            // 
            this.quantityInStockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "QuantityInStock", true));
            this.quantityInStockTextBox.Location = new System.Drawing.Point(372, 324);
            this.quantityInStockTextBox.Name = "quantityInStockTextBox";
            this.quantityInStockTextBox.Size = new System.Drawing.Size(200, 26);
            this.quantityInStockTextBox.TabIndex = 8;
            // 
            // dateRecordedLabel
            // 
            dateRecordedLabel.AutoSize = true;
            dateRecordedLabel.Location = new System.Drawing.Point(231, 360);
            dateRecordedLabel.Name = "dateRecordedLabel";
            dateRecordedLabel.Size = new System.Drawing.Size(122, 20);
            dateRecordedLabel.TabIndex = 9;
            dateRecordedLabel.Text = "Date Recorded:";
            // 
            // dateRecordtxtBx
            // 
            this.dateRecordtxtBx.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.stockBindingSource, "DateRecorded", true));
            this.dateRecordtxtBx.Location = new System.Drawing.Point(372, 356);
            this.dateRecordtxtBx.Name = "dateRecordtxtBx";
            this.dateRecordtxtBx.Size = new System.Drawing.Size(200, 26);
            this.dateRecordtxtBx.TabIndex = 10;
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.Cyan;
            this.btnAddStock.Location = new System.Drawing.Point(275, 401);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(120, 45);
            this.btnAddStock.TabIndex = 13;
            this.btnAddStock.Text = "Add";
            this.btnAddStock.UseVisualStyleBackColor = false;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.BackColor = System.Drawing.Color.Cyan;
            this.btnUpdateStock.Location = new System.Drawing.Point(401, 401);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(120, 45);
            this.btnUpdateStock.TabIndex = 14;
            this.btnUpdateStock.Text = "Update";
            this.btnUpdateStock.UseVisualStyleBackColor = false;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // btnDeleteStock
            // 
            this.btnDeleteStock.BackColor = System.Drawing.Color.Cyan;
            this.btnDeleteStock.Location = new System.Drawing.Point(527, 401);
            this.btnDeleteStock.Name = "btnDeleteStock";
            this.btnDeleteStock.Size = new System.Drawing.Size(120, 45);
            this.btnDeleteStock.TabIndex = 15;
            this.btnDeleteStock.Text = "Delete";
            this.btnDeleteStock.UseVisualStyleBackColor = false;
            this.btnDeleteStock.Click += new System.EventHandler(this.btnDeleteStock_Click);
            // 
            // btnAuthorS
            // 
            this.btnAuthorS.BackColor = System.Drawing.Color.Cyan;
            this.btnAuthorS.Location = new System.Drawing.Point(850, 376);
            this.btnAuthorS.Name = "btnAuthorS";
            this.btnAuthorS.Size = new System.Drawing.Size(120, 32);
            this.btnAuthorS.TabIndex = 16;
            this.btnAuthorS.Text = "Go to Author";
            this.btnAuthorS.UseVisualStyleBackColor = false;
            this.btnAuthorS.Click += new System.EventHandler(this.btnAuthorS_Click_1);
            // 
            // btnBookS
            // 
            this.btnBookS.BackColor = System.Drawing.Color.Cyan;
            this.btnBookS.Location = new System.Drawing.Point(850, 414);
            this.btnBookS.Name = "btnBookS";
            this.btnBookS.Size = new System.Drawing.Size(120, 32);
            this.btnBookS.TabIndex = 17;
            this.btnBookS.Text = "Go to Book";
            this.btnBookS.UseVisualStyleBackColor = false;
            this.btnBookS.Click += new System.EventHandler(this.btnBookS_Click_1);
            // 
            // formStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 477);
            this.Controls.Add(this.btnBookS);
            this.Controls.Add(this.btnAuthorS);
            this.Controls.Add(this.btnDeleteStock);
            this.Controls.Add(this.btnUpdateStock);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(stockIDLabel);
            this.Controls.Add(this.stockIDtxtbx);
            this.Controls.Add(authorIDLabel);
            this.Controls.Add(this.authorIDtxtbx);
            this.Controls.Add(iSBN_13Label);
            this.Controls.Add(this.iSBN13txtbx);
            this.Controls.Add(quantityInStockLabel);
            this.Controls.Add(this.quantityInStockTextBox);
            this.Controls.Add(dateRecordedLabel);
            this.Controls.Add(this.dateRecordtxtBx);
            this.Controls.Add(this.stockDGV);
            this.Name = "formStock";
            this.Text = "Form Stock";
            this.Load += new System.EventHandler(this.formStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.admiralBookstore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdmiralBookstore admiralBookstore;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private AdmiralBookstoreTableAdapters.StockTableAdapter stockTableAdapter;
        private AdmiralBookstoreTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView stockDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox stockIDtxtbx;
        private System.Windows.Forms.TextBox authorIDtxtbx;
        private System.Windows.Forms.TextBox iSBN13txtbx;
        private System.Windows.Forms.TextBox quantityInStockTextBox;
        private System.Windows.Forms.DateTimePicker dateRecordtxtBx;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.Button btnDeleteStock;
        private System.Windows.Forms.Button btnAuthorS;
        private System.Windows.Forms.Button btnBookS;
    }
}