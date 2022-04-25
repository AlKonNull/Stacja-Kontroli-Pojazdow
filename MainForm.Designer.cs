
namespace Project___SKP
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.carsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.carsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carsDataSet1 = new Project___SKP.CarsDataSet1();
            this.buttonAddCar = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDeleteCar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonShowDetail = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonNotCorrectSort = new System.Windows.Forms.Button();
            this.buttonCorrectSort = new System.Windows.Forms.Button();
            this.buttonDateSort = new System.Windows.Forms.Button();
            this.buttonModelSort = new System.Windows.Forms.Button();
            this.buttonBrandSort = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.carsTableAdapter1 = new Project___SKP.CarsDataSet1TableAdapters.CarsTableAdapter();
            this.tableAdapterManager1 = new Project___SKP.CarsDataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // carsDataGridView
            // 
            this.carsDataGridView.AllowUserToAddRows = false;
            this.carsDataGridView.AllowUserToDeleteRows = false;
            this.carsDataGridView.AutoGenerateColumns = false;
            this.carsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewCheckBoxColumn3});
            this.carsDataGridView.DataSource = this.carsBindingSource1;
            this.carsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.carsDataGridView.Name = "carsDataGridView";
            this.carsDataGridView.ReadOnly = true;
            this.carsDataGridView.Size = new System.Drawing.Size(450, 261);
            this.carsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 25;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Brand";
            this.dataGridViewTextBoxColumn3.HeaderText = "Marka";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn4.HeaderText = "Model";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Date_Test";
            this.dataGridViewTextBoxColumn12.HeaderText = "Data Badania";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "Correct";
            this.dataGridViewCheckBoxColumn3.HeaderText = "Czy zaliczone";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.ReadOnly = true;
            this.dataGridViewCheckBoxColumn3.Width = 80;
            // 
            // carsBindingSource1
            // 
            this.carsBindingSource1.DataMember = "Cars";
            this.carsBindingSource1.DataSource = this.carsDataSet1;
            // 
            // carsDataSet1
            // 
            this.carsDataSet1.DataSetName = "CarsDataSet1";
            this.carsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonAddCar
            // 
            this.buttonAddCar.Location = new System.Drawing.Point(6, 19);
            this.buttonAddCar.Name = "buttonAddCar";
            this.buttonAddCar.Size = new System.Drawing.Size(116, 23);
            this.buttonAddCar.TabIndex = 0;
            this.buttonAddCar.Text = "Dodaj nowe badanie";
            this.buttonAddCar.UseVisualStyleBackColor = true;
            this.buttonAddCar.Click += new System.EventHandler(this.buttonAddCar_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(6, 232);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(116, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Zamknij program";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonDeleteCar
            // 
            this.buttonDeleteCar.Location = new System.Drawing.Point(6, 48);
            this.buttonDeleteCar.Name = "buttonDeleteCar";
            this.buttonDeleteCar.Size = new System.Drawing.Size(116, 23);
            this.buttonDeleteCar.TabIndex = 1;
            this.buttonDeleteCar.Text = "Usuń badanie";
            this.buttonDeleteCar.UseVisualStyleBackColor = true;
            this.buttonDeleteCar.Click += new System.EventHandler(this.buttonDeleteCar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonShowDetail);
            this.groupBox1.Controls.Add(this.buttonClose);
            this.groupBox1.Controls.Add(this.buttonAddCar);
            this.groupBox1.Controls.Add(this.buttonDeleteCar);
            this.groupBox1.Location = new System.Drawing.Point(468, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 261);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(13, 96);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Podaj ID badania:";
            // 
            // buttonShowDetail
            // 
            this.buttonShowDetail.Location = new System.Drawing.Point(6, 120);
            this.buttonShowDetail.Name = "buttonShowDetail";
            this.buttonShowDetail.Size = new System.Drawing.Size(116, 23);
            this.buttonShowDetail.TabIndex = 3;
            this.buttonShowDetail.Text = "Pokaż szczegóły";
            this.buttonShowDetail.UseVisualStyleBackColor = true;
            this.buttonShowDetail.Click += new System.EventHandler(this.buttonShowDetail_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonNotCorrectSort);
            this.groupBox2.Controls.Add(this.buttonCorrectSort);
            this.groupBox2.Controls.Add(this.buttonDateSort);
            this.groupBox2.Controls.Add(this.buttonModelSort);
            this.groupBox2.Controls.Add(this.buttonBrandSort);
            this.groupBox2.Location = new System.Drawing.Point(610, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(131, 162);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sortowanie";
            // 
            // buttonNotCorrectSort
            // 
            this.buttonNotCorrectSort.Location = new System.Drawing.Point(6, 133);
            this.buttonNotCorrectSort.Name = "buttonNotCorrectSort";
            this.buttonNotCorrectSort.Size = new System.Drawing.Size(116, 23);
            this.buttonNotCorrectSort.TabIndex = 4;
            this.buttonNotCorrectSort.Text = "Nie zaliczone";
            this.buttonNotCorrectSort.UseVisualStyleBackColor = true;
            this.buttonNotCorrectSort.Click += new System.EventHandler(this.buttonNotCorrectSort_Click);
            // 
            // buttonCorrectSort
            // 
            this.buttonCorrectSort.Location = new System.Drawing.Point(6, 104);
            this.buttonCorrectSort.Name = "buttonCorrectSort";
            this.buttonCorrectSort.Size = new System.Drawing.Size(116, 23);
            this.buttonCorrectSort.TabIndex = 3;
            this.buttonCorrectSort.Text = "Zaliczone";
            this.buttonCorrectSort.UseVisualStyleBackColor = true;
            this.buttonCorrectSort.Click += new System.EventHandler(this.buttonCorrectSort_Click);
            // 
            // buttonDateSort
            // 
            this.buttonDateSort.Location = new System.Drawing.Point(6, 75);
            this.buttonDateSort.Name = "buttonDateSort";
            this.buttonDateSort.Size = new System.Drawing.Size(116, 23);
            this.buttonDateSort.TabIndex = 2;
            this.buttonDateSort.Text = "Datą Badania";
            this.buttonDateSort.UseVisualStyleBackColor = true;
            this.buttonDateSort.Click += new System.EventHandler(this.buttonDateSort_Click);
            // 
            // buttonModelSort
            // 
            this.buttonModelSort.Location = new System.Drawing.Point(6, 48);
            this.buttonModelSort.Name = "buttonModelSort";
            this.buttonModelSort.Size = new System.Drawing.Size(116, 23);
            this.buttonModelSort.TabIndex = 1;
            this.buttonModelSort.Text = "Model Alfabetycznie";
            this.buttonModelSort.UseVisualStyleBackColor = true;
            this.buttonModelSort.Click += new System.EventHandler(this.buttonModelSort_Click);
            // 
            // buttonBrandSort
            // 
            this.buttonBrandSort.Location = new System.Drawing.Point(6, 19);
            this.buttonBrandSort.Name = "buttonBrandSort";
            this.buttonBrandSort.Size = new System.Drawing.Size(116, 23);
            this.buttonBrandSort.TabIndex = 0;
            this.buttonBrandSort.Text = "Marka Alfabetycznie";
            this.buttonBrandSort.UseVisualStyleBackColor = true;
            this.buttonBrandSort.Click += new System.EventHandler(this.buttonBrandSort_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonSearch);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBoxSearch);
            this.groupBox3.Location = new System.Drawing.Point(610, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(134, 93);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wyszukiwanie";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(9, 65);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(116, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Wyszukaj";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Podaj szukaną markę:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(12, 39);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 0;
            // 
            // carsTableAdapter1
            // 
            this.carsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CarsTableAdapter = this.carsTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Project___SKP.CarsDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 284);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.carsDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Baza SKP";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CarsDataSet1 carsDataSet1;
        private System.Windows.Forms.BindingSource carsBindingSource1;
        private CarsDataSet1TableAdapters.CarsTableAdapter carsTableAdapter1;
        private CarsDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView carsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.Button buttonAddCar;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonDeleteCar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonShowDetail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonBrandSort;
        private System.Windows.Forms.Button buttonModelSort;
        private System.Windows.Forms.Button buttonDateSort;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonNotCorrectSort;
        private System.Windows.Forms.Button buttonCorrectSort;
    }
}

