
namespace Project___SKP
{
    partial class ShowDetails
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label client_NumberLabel;
            System.Windows.Forms.Label brandLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label year_ProductLabel;
            System.Windows.Forms.Label mileageLabel;
            System.Windows.Forms.Label vin_NumberLabel;
            System.Windows.Forms.Label fuelLabel;
            System.Windows.Forms.Label engine_CapacityLabel;
            System.Windows.Forms.Label date_First_RegistrationLabel;
            System.Windows.Forms.Label is_LPGLabel;
            System.Windows.Forms.Label is_LateLabel;
            System.Windows.Forms.Label noteLabel;
            System.Windows.Forms.Label date_TestLabel;
            System.Windows.Forms.Label correctLabel;
            System.Windows.Forms.Label priceLabel;
            this.carsDataSet1 = new Project___SKP.CarsDataSet1();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsTableAdapter = new Project___SKP.CarsDataSet1TableAdapters.CarsTableAdapter();
            this.tableAdapterManager = new Project___SKP.CarsDataSet1TableAdapters.TableAdapterManager();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.client_NumberTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.year_ProductTextBox = new System.Windows.Forms.TextBox();
            this.mileageTextBox = new System.Windows.Forms.TextBox();
            this.vin_NumberTextBox = new System.Windows.Forms.TextBox();
            this.fuelTextBox = new System.Windows.Forms.TextBox();
            this.engine_CapacityTextBox = new System.Windows.Forms.TextBox();
            this.is_LPGCheckBox = new System.Windows.Forms.CheckBox();
            this.is_LateCheckBox = new System.Windows.Forms.CheckBox();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.correctCheckBox = new System.Windows.Forms.CheckBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.dateTimePickerFirstRegistration = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateTest = new System.Windows.Forms.DateTimePicker();
            iDLabel = new System.Windows.Forms.Label();
            client_NumberLabel = new System.Windows.Forms.Label();
            brandLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            year_ProductLabel = new System.Windows.Forms.Label();
            mileageLabel = new System.Windows.Forms.Label();
            vin_NumberLabel = new System.Windows.Forms.Label();
            fuelLabel = new System.Windows.Forms.Label();
            engine_CapacityLabel = new System.Windows.Forms.Label();
            date_First_RegistrationLabel = new System.Windows.Forms.Label();
            is_LPGLabel = new System.Windows.Forms.Label();
            is_LateLabel = new System.Windows.Forms.Label();
            noteLabel = new System.Windows.Forms.Label();
            date_TestLabel = new System.Windows.Forms.Label();
            correctLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(12, 9);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // client_NumberLabel
            // 
            client_NumberLabel.AutoSize = true;
            client_NumberLabel.Location = new System.Drawing.Point(12, 35);
            client_NumberLabel.Name = "client_NumberLabel";
            client_NumberLabel.Size = new System.Drawing.Size(75, 13);
            client_NumberLabel.TabIndex = 3;
            client_NumberLabel.Text = "Numer klienta:";
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Location = new System.Drawing.Point(12, 61);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new System.Drawing.Size(37, 13);
            brandLabel.TabIndex = 5;
            brandLabel.Text = "Marka";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(12, 87);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(39, 13);
            modelLabel.TabIndex = 7;
            modelLabel.Text = "Model:";
            // 
            // year_ProductLabel
            // 
            year_ProductLabel.AutoSize = true;
            year_ProductLabel.Location = new System.Drawing.Point(12, 113);
            year_ProductLabel.Name = "year_ProductLabel";
            year_ProductLabel.Size = new System.Drawing.Size(73, 13);
            year_ProductLabel.TabIndex = 9;
            year_ProductLabel.Text = "Rok produkcji";
            // 
            // mileageLabel
            // 
            mileageLabel.AutoSize = true;
            mileageLabel.Location = new System.Drawing.Point(12, 139);
            mileageLabel.Name = "mileageLabel";
            mileageLabel.Size = new System.Drawing.Size(48, 13);
            mileageLabel.TabIndex = 11;
            mileageLabel.Text = "Przebieg";
            // 
            // vin_NumberLabel
            // 
            vin_NumberLabel.AutoSize = true;
            vin_NumberLabel.Location = new System.Drawing.Point(12, 165);
            vin_NumberLabel.Name = "vin_NumberLabel";
            vin_NumberLabel.Size = new System.Drawing.Size(62, 13);
            vin_NumberLabel.TabIndex = 13;
            vin_NumberLabel.Text = "Numer VIN:";
            // 
            // fuelLabel
            // 
            fuelLabel.AutoSize = true;
            fuelLabel.Location = new System.Drawing.Point(12, 191);
            fuelLabel.Name = "fuelLabel";
            fuelLabel.Size = new System.Drawing.Size(41, 13);
            fuelLabel.TabIndex = 15;
            fuelLabel.Text = "Paliwo:";
            // 
            // engine_CapacityLabel
            // 
            engine_CapacityLabel.AutoSize = true;
            engine_CapacityLabel.Location = new System.Drawing.Point(12, 217);
            engine_CapacityLabel.Name = "engine_CapacityLabel";
            engine_CapacityLabel.Size = new System.Drawing.Size(94, 13);
            engine_CapacityLabel.TabIndex = 17;
            engine_CapacityLabel.Text = "Pojemność silnika:";
            // 
            // date_First_RegistrationLabel
            // 
            date_First_RegistrationLabel.AutoSize = true;
            date_First_RegistrationLabel.Location = new System.Drawing.Point(338, 9);
            date_First_RegistrationLabel.Name = "date_First_RegistrationLabel";
            date_First_RegistrationLabel.Size = new System.Drawing.Size(126, 13);
            date_First_RegistrationLabel.TabIndex = 19;
            date_First_RegistrationLabel.Text = "Data pierwszej rejestracji:";
            // 
            // is_LPGLabel
            // 
            is_LPGLabel.AutoSize = true;
            is_LPGLabel.Location = new System.Drawing.Point(338, 61);
            is_LPGLabel.Name = "is_LPGLabel";
            is_LPGLabel.Size = new System.Drawing.Size(31, 13);
            is_LPGLabel.TabIndex = 21;
            is_LPGLabel.Text = "LPG:";
            // 
            // is_LateLabel
            // 
            is_LateLabel.AutoSize = true;
            is_LateLabel.Location = new System.Drawing.Point(338, 87);
            is_LateLabel.Name = "is_LateLabel";
            is_LateLabel.Size = new System.Drawing.Size(61, 13);
            is_LateLabel.TabIndex = 23;
            is_LateLabel.Text = "Opóźnione:";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Location = new System.Drawing.Point(339, 165);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(48, 13);
            noteLabel.TabIndex = 25;
            noteLabel.Text = "Notatka:";
            // 
            // date_TestLabel
            // 
            date_TestLabel.AutoSize = true;
            date_TestLabel.Location = new System.Drawing.Point(338, 35);
            date_TestLabel.Name = "date_TestLabel";
            date_TestLabel.Size = new System.Drawing.Size(59, 13);
            date_TestLabel.TabIndex = 27;
            date_TestLabel.Text = "Data testu:";
            // 
            // correctLabel
            // 
            correctLabel.AutoSize = true;
            correctLabel.Location = new System.Drawing.Point(338, 113);
            correctLabel.Name = "correctLabel";
            correctLabel.Size = new System.Drawing.Size(102, 13);
            correctLabel.TabIndex = 29;
            correctLabel.Text = "Badanie pozytywne:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(338, 139);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(35, 13);
            priceLabel.TabIndex = 31;
            priceLabel.Text = "Cena:";
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
            // iDTextBox
            // 
            this.iDTextBox.Location = new System.Drawing.Point(132, 6);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(200, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // client_NumberTextBox
            // 
            this.client_NumberTextBox.Location = new System.Drawing.Point(132, 32);
            this.client_NumberTextBox.Name = "client_NumberTextBox";
            this.client_NumberTextBox.ReadOnly = true;
            this.client_NumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.client_NumberTextBox.TabIndex = 4;
            // 
            // brandTextBox
            // 
            this.brandTextBox.Location = new System.Drawing.Point(132, 58);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.ReadOnly = true;
            this.brandTextBox.Size = new System.Drawing.Size(200, 20);
            this.brandTextBox.TabIndex = 6;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(132, 84);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.ReadOnly = true;
            this.modelTextBox.Size = new System.Drawing.Size(200, 20);
            this.modelTextBox.TabIndex = 8;
            // 
            // year_ProductTextBox
            // 
            this.year_ProductTextBox.Location = new System.Drawing.Point(132, 110);
            this.year_ProductTextBox.Name = "year_ProductTextBox";
            this.year_ProductTextBox.ReadOnly = true;
            this.year_ProductTextBox.Size = new System.Drawing.Size(200, 20);
            this.year_ProductTextBox.TabIndex = 10;
            // 
            // mileageTextBox
            // 
            this.mileageTextBox.Location = new System.Drawing.Point(132, 136);
            this.mileageTextBox.Name = "mileageTextBox";
            this.mileageTextBox.ReadOnly = true;
            this.mileageTextBox.Size = new System.Drawing.Size(200, 20);
            this.mileageTextBox.TabIndex = 12;
            // 
            // vin_NumberTextBox
            // 
            this.vin_NumberTextBox.Location = new System.Drawing.Point(132, 162);
            this.vin_NumberTextBox.Name = "vin_NumberTextBox";
            this.vin_NumberTextBox.ReadOnly = true;
            this.vin_NumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.vin_NumberTextBox.TabIndex = 14;
            // 
            // fuelTextBox
            // 
            this.fuelTextBox.Location = new System.Drawing.Point(132, 188);
            this.fuelTextBox.Name = "fuelTextBox";
            this.fuelTextBox.ReadOnly = true;
            this.fuelTextBox.Size = new System.Drawing.Size(200, 20);
            this.fuelTextBox.TabIndex = 16;
            // 
            // engine_CapacityTextBox
            // 
            this.engine_CapacityTextBox.Location = new System.Drawing.Point(132, 214);
            this.engine_CapacityTextBox.Name = "engine_CapacityTextBox";
            this.engine_CapacityTextBox.ReadOnly = true;
            this.engine_CapacityTextBox.Size = new System.Drawing.Size(200, 20);
            this.engine_CapacityTextBox.TabIndex = 18;
            // 
            // is_LPGCheckBox
            // 
            this.is_LPGCheckBox.AutoCheck = false;
            this.is_LPGCheckBox.Location = new System.Drawing.Point(489, 57);
            this.is_LPGCheckBox.Name = "is_LPGCheckBox";
            this.is_LPGCheckBox.Size = new System.Drawing.Size(200, 24);
            this.is_LPGCheckBox.TabIndex = 22;
            this.is_LPGCheckBox.UseVisualStyleBackColor = true;
            // 
            // is_LateCheckBox
            // 
            this.is_LateCheckBox.AutoCheck = false;
            this.is_LateCheckBox.Location = new System.Drawing.Point(489, 83);
            this.is_LateCheckBox.Name = "is_LateCheckBox";
            this.is_LateCheckBox.Size = new System.Drawing.Size(200, 24);
            this.is_LateCheckBox.TabIndex = 24;
            this.is_LateCheckBox.UseVisualStyleBackColor = true;
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(490, 163);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.ReadOnly = true;
            this.noteTextBox.Size = new System.Drawing.Size(200, 71);
            this.noteTextBox.TabIndex = 26;
            // 
            // correctCheckBox
            // 
            this.correctCheckBox.AutoCheck = false;
            this.correctCheckBox.Location = new System.Drawing.Point(489, 109);
            this.correctCheckBox.Name = "correctCheckBox";
            this.correctCheckBox.Size = new System.Drawing.Size(200, 24);
            this.correctCheckBox.TabIndex = 30;
            this.correctCheckBox.UseVisualStyleBackColor = true;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(489, 137);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(200, 20);
            this.priceTextBox.TabIndex = 32;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(307, 249);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 33;
            this.buttonExit.Text = "Zakończ";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // dateTimePickerFirstRegistration
            // 
            this.dateTimePickerFirstRegistration.Enabled = false;
            this.dateTimePickerFirstRegistration.Location = new System.Drawing.Point(489, 6);
            this.dateTimePickerFirstRegistration.Name = "dateTimePickerFirstRegistration";
            this.dateTimePickerFirstRegistration.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFirstRegistration.TabIndex = 34;
            // 
            // dateTimePickerDateTest
            // 
            this.dateTimePickerDateTest.Enabled = false;
            this.dateTimePickerDateTest.Location = new System.Drawing.Point(489, 35);
            this.dateTimePickerDateTest.Name = "dateTimePickerDateTest";
            this.dateTimePickerDateTest.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDateTest.TabIndex = 35;
            // 
            // ShowDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 279);
            this.Controls.Add(this.dateTimePickerDateTest);
            this.Controls.Add(this.dateTimePickerFirstRegistration);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(client_NumberLabel);
            this.Controls.Add(this.client_NumberTextBox);
            this.Controls.Add(brandLabel);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(year_ProductLabel);
            this.Controls.Add(this.year_ProductTextBox);
            this.Controls.Add(mileageLabel);
            this.Controls.Add(this.mileageTextBox);
            this.Controls.Add(vin_NumberLabel);
            this.Controls.Add(this.vin_NumberTextBox);
            this.Controls.Add(fuelLabel);
            this.Controls.Add(this.fuelTextBox);
            this.Controls.Add(engine_CapacityLabel);
            this.Controls.Add(this.engine_CapacityTextBox);
            this.Controls.Add(date_First_RegistrationLabel);
            this.Controls.Add(is_LPGLabel);
            this.Controls.Add(this.is_LPGCheckBox);
            this.Controls.Add(is_LateLabel);
            this.Controls.Add(this.is_LateCheckBox);
            this.Controls.Add(noteLabel);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(date_TestLabel);
            this.Controls.Add(correctLabel);
            this.Controls.Add(this.correctCheckBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Name = "ShowDetails";
            this.ShowIcon = false;
            this.Text = "Szczegóły";
            this.Load += new System.EventHandler(this.ShowDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CarsDataSet1 carsDataSet1;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private CarsDataSet1TableAdapters.CarsTableAdapter carsTableAdapter;
        private CarsDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox client_NumberTextBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox year_ProductTextBox;
        private System.Windows.Forms.TextBox mileageTextBox;
        private System.Windows.Forms.TextBox vin_NumberTextBox;
        private System.Windows.Forms.TextBox fuelTextBox;
        private System.Windows.Forms.TextBox engine_CapacityTextBox;
        private System.Windows.Forms.CheckBox is_LPGCheckBox;
        private System.Windows.Forms.CheckBox is_LateCheckBox;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.CheckBox correctCheckBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DateTimePicker dateTimePickerFirstRegistration;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateTest;
    }
}