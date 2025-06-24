namespace LABTEST2
{
    partial class FormAuthor
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
            System.Windows.Forms.Label authorIDlbl;
            System.Windows.Forms.Label namelbl;
            System.Windows.Forms.Label birthYearlbl;
            this.admiralBookstore = new LABTEST2.AdmiralBookstore();
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorTableAdapter = new LABTEST2.AdmiralBookstoreTableAdapters.AuthorTableAdapter();
            this.tableAdapterManager = new LABTEST2.AdmiralBookstoreTableAdapters.TableAdapterManager();
            this.authorIDtextbx = new System.Windows.Forms.TextBox();
            this.nametxtbx = new System.Windows.Forms.TextBox();
            this.birthYeartxtbx = new System.Windows.Forms.TextBox();
            this.authorDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBookA = new System.Windows.Forms.Button();
            this.btnStockA = new System.Windows.Forms.Button();
            authorIDlbl = new System.Windows.Forms.Label();
            namelbl = new System.Windows.Forms.Label();
            birthYearlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.admiralBookstore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // authorIDlbl
            // 
            authorIDlbl.AutoSize = true;
            authorIDlbl.Location = new System.Drawing.Point(96, 251);
            authorIDlbl.Name = "authorIDlbl";
            authorIDlbl.Size = new System.Drawing.Size(82, 20);
            authorIDlbl.TabIndex = 1;
            authorIDlbl.Text = "Author ID:";
            // 
            // namelbl
            // 
            namelbl.AutoSize = true;
            namelbl.Location = new System.Drawing.Point(96, 283);
            namelbl.Name = "namelbl";
            namelbl.Size = new System.Drawing.Size(55, 20);
            namelbl.TabIndex = 3;
            namelbl.Text = "Name:";
            // 
            // birthYearlbl
            // 
            birthYearlbl.AutoSize = true;
            birthYearlbl.Location = new System.Drawing.Point(96, 315);
            birthYearlbl.Name = "birthYearlbl";
            birthYearlbl.Size = new System.Drawing.Size(84, 20);
            birthYearlbl.TabIndex = 5;
            birthYearlbl.Text = "Birth Year:";
            // 
            // admiralBookstore
            // 
            this.admiralBookstore.DataSetName = "AdmiralBookstore";
            this.admiralBookstore.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorBindingSource
            // 
            this.authorBindingSource.DataMember = "Author";
            this.authorBindingSource.DataSource = this.admiralBookstore;
            // 
            // authorTableAdapter
            // 
            this.authorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorTableAdapter = this.authorTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LABTEST2.AdmiralBookstoreTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // authorIDtextbx
            // 
            this.authorIDtextbx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorBindingSource, "AuthorID", true));
            this.authorIDtextbx.Location = new System.Drawing.Point(186, 248);
            this.authorIDtextbx.Name = "authorIDtextbx";
            this.authorIDtextbx.Size = new System.Drawing.Size(326, 26);
            this.authorIDtextbx.TabIndex = 2;
            this.authorIDtextbx.TextChanged += new System.EventHandler(this.authorIDtextbx_TextChanged);
            // 
            // nametxtbx
            // 
            this.nametxtbx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorBindingSource, "Name", true));
            this.nametxtbx.Location = new System.Drawing.Point(186, 280);
            this.nametxtbx.Name = "nametxtbx";
            this.nametxtbx.Size = new System.Drawing.Size(326, 26);
            this.nametxtbx.TabIndex = 4;
            this.nametxtbx.TextChanged += new System.EventHandler(this.nametxtbx_TextChanged);
            // 
            // birthYeartxtbx
            // 
            this.birthYeartxtbx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorBindingSource, "BirthYear", true));
            this.birthYeartxtbx.Location = new System.Drawing.Point(186, 312);
            this.birthYeartxtbx.Name = "birthYeartxtbx";
            this.birthYeartxtbx.Size = new System.Drawing.Size(326, 26);
            this.birthYeartxtbx.TabIndex = 6;
            this.birthYeartxtbx.TextChanged += new System.EventHandler(this.birthYeartxtbx_TextChanged);
            // 
            // authorDGV
            // 
            this.authorDGV.AutoGenerateColumns = false;
            this.authorDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.authorDGV.DataSource = this.authorBindingSource;
            this.authorDGV.Location = new System.Drawing.Point(84, 28);
            this.authorDGV.Name = "authorDGV";
            this.authorDGV.RowHeadersWidth = 62;
            this.authorDGV.RowTemplate.Height = 28;
            this.authorDGV.Size = new System.Drawing.Size(587, 175);
            this.authorDGV.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AuthorID";
            this.dataGridViewTextBoxColumn1.HeaderText = "AuthorID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BirthYear";
            this.dataGridViewTextBoxColumn3.HeaderText = "BirthYear";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Cyan;
            this.btnAdd.Location = new System.Drawing.Point(253, 372);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 45);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBookA
            // 
            this.btnBookA.BackColor = System.Drawing.Color.Cyan;
            this.btnBookA.Location = new System.Drawing.Point(624, 347);
            this.btnBookA.Name = "btnBookA";
            this.btnBookA.Size = new System.Drawing.Size(120, 32);
            this.btnBookA.TabIndex = 8;
            this.btnBookA.Text = "Go to Book";
            this.btnBookA.UseVisualStyleBackColor = false;
            this.btnBookA.Click += new System.EventHandler(this.btnBookA_Click);
            // 
            // btnStockA
            // 
            this.btnStockA.BackColor = System.Drawing.Color.Cyan;
            this.btnStockA.Location = new System.Drawing.Point(624, 385);
            this.btnStockA.Name = "btnStockA";
            this.btnStockA.Size = new System.Drawing.Size(120, 32);
            this.btnStockA.TabIndex = 9;
            this.btnStockA.Text = "Go to Stock";
            this.btnStockA.UseVisualStyleBackColor = false;
            this.btnStockA.Click += new System.EventHandler(this.btnStockA_Click);
            // 
            // FormAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStockA);
            this.Controls.Add(this.btnBookA);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.authorDGV);
            this.Controls.Add(authorIDlbl);
            this.Controls.Add(this.authorIDtextbx);
            this.Controls.Add(namelbl);
            this.Controls.Add(this.nametxtbx);
            this.Controls.Add(birthYearlbl);
            this.Controls.Add(this.birthYeartxtbx);
            this.Name = "FormAuthor";
            this.Text = "Form Author";
            this.Load += new System.EventHandler(this.FormAuthor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.admiralBookstore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdmiralBookstore admiralBookstore;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private AdmiralBookstoreTableAdapters.AuthorTableAdapter authorTableAdapter;
        private AdmiralBookstoreTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox authorIDtextbx;
        private System.Windows.Forms.TextBox nametxtbx;
        private System.Windows.Forms.TextBox birthYeartxtbx;
        private System.Windows.Forms.DataGridView authorDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBookA;
        private System.Windows.Forms.Button btnStockA;
    }
}

