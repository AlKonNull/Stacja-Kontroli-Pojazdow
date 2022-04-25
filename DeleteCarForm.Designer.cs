
namespace Project___SKP
{
    partial class DeleteCarForm
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
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeleteCar = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.carsDataSet1 = new Project___SKP.CarsDataSet1();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsTableAdapter = new Project___SKP.CarsDataSet1TableAdapters.CarsTableAdapter();
            this.tableAdapterManager = new Project___SKP.CarsDataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(110, 16);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podaj ID badania:";
            // 
            // buttonDeleteCar
            // 
            this.buttonDeleteCar.Location = new System.Drawing.Point(12, 47);
            this.buttonDeleteCar.Name = "buttonDeleteCar";
            this.buttonDeleteCar.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteCar.TabIndex = 2;
            this.buttonDeleteCar.Text = "Usuń";
            this.buttonDeleteCar.UseVisualStyleBackColor = true;
            this.buttonDeleteCar.Click += new System.EventHandler(this.buttonDeleteCar_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(135, 47);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Zamknij";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // carsDataSet1
            // 
            this.carsDataSet1.DataSetName = "CarsDataSet1";
            this.carsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.carsDataSet1;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarsTableAdapter = this.carsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Project___SKP.CarsDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // DeleteCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 80);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDeleteCar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxID);
            this.Name = "DeleteCarForm";
            this.ShowIcon = false;
            this.Text = "Usuń badanie";
            this.Load += new System.EventHandler(this.DeleteCarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeleteCar;
        private System.Windows.Forms.Button buttonExit;
        private CarsDataSet1 carsDataSet1;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private CarsDataSet1TableAdapters.CarsTableAdapter carsTableAdapter;
        private CarsDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
    }
}