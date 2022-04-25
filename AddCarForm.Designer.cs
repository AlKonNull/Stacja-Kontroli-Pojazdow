
namespace Project___SKP
{
    partial class AddCarForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxCarFuel = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxCarMileage = new System.Windows.Forms.TextBox();
            this.checkBoxLate = new System.Windows.Forms.CheckBox();
            this.checkBoxGas = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerCarFirstRegistration = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCarEngineCapacity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCarVIN = new System.Windows.Forms.TextBox();
            this.textBoxCarYearProduction = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCarBrand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCarModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsDataSet1 = new Project___SKP.CarsDataSet1();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxClientNumber = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerTestDate = new System.Windows.Forms.DateTimePicker();
            this.radioButtonNegativ = new System.Windows.Forms.RadioButton();
            this.radioButtonPositive = new System.Windows.Forms.RadioButton();
            this.buttonAddCar = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.carsTableAdapter = new Project___SKP.CarsDataSet1TableAdapters.CarsTableAdapter();
            this.tableAdapterManager = new Project___SKP.CarsDataSet1TableAdapters.TableAdapterManager();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxCarFuel);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxCarMileage);
            this.groupBox1.Controls.Add(this.checkBoxLate);
            this.groupBox1.Controls.Add(this.checkBoxGas);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateTimePickerCarFirstRegistration);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxCarEngineCapacity);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxCarVIN);
            this.groupBox1.Controls.Add(this.textBoxCarYearProduction);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxCarBrand);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxCarModel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 273);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wprowadź dane pojazdu";
            // 
            // comboBoxCarFuel
            // 
            this.comboBoxCarFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCarFuel.FormattingEnabled = true;
            this.comboBoxCarFuel.Items.AddRange(new object[] {
            "Benzyna",
            "Olej napędowy"});
            this.comboBoxCarFuel.Location = new System.Drawing.Point(123, 158);
            this.comboBoxCarFuel.Name = "comboBoxCarFuel";
            this.comboBoxCarFuel.Size = new System.Drawing.Size(203, 21);
            this.comboBoxCarFuel.TabIndex = 5;
            this.toolTip1.SetToolTip(this.comboBoxCarFuel, "Wybierz rodzaj paliwa");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Przebieg:";
            // 
            // textBoxCarMileage
            // 
            this.textBoxCarMileage.Location = new System.Drawing.Point(123, 108);
            this.textBoxCarMileage.Name = "textBoxCarMileage";
            this.textBoxCarMileage.Size = new System.Drawing.Size(203, 20);
            this.textBoxCarMileage.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBoxCarMileage, "Podaj przebieg w kiloemtrach");
            // 
            // checkBoxLate
            // 
            this.checkBoxLate.AutoSize = true;
            this.checkBoxLate.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxLate.Location = new System.Drawing.Point(143, 238);
            this.checkBoxLate.Name = "checkBoxLate";
            this.checkBoxLate.Size = new System.Drawing.Size(121, 17);
            this.checkBoxLate.TabIndex = 9;
            this.checkBoxLate.Text = "Spóźniony przegląd:";
            this.checkBoxLate.UseVisualStyleBackColor = true;
            // 
            // checkBoxGas
            // 
            this.checkBoxGas.AutoSize = true;
            this.checkBoxGas.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxGas.Location = new System.Drawing.Point(50, 238);
            this.checkBoxGas.Name = "checkBoxGas";
            this.checkBoxGas.Size = new System.Drawing.Size(87, 17);
            this.checkBoxGas.TabIndex = 8;
            this.checkBoxGas.Text = "Posiada gaz:";
            this.checkBoxGas.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Data 1 rejestracji:";
            // 
            // dateTimePickerCarFirstRegistration
            // 
            this.dateTimePickerCarFirstRegistration.Location = new System.Drawing.Point(123, 210);
            this.dateTimePickerCarFirstRegistration.Name = "dateTimePickerCarFirstRegistration";
            this.dateTimePickerCarFirstRegistration.Size = new System.Drawing.Size(203, 20);
            this.dateTimePickerCarFirstRegistration.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pojemność silnika:";
            // 
            // textBoxCarEngineCapacity
            // 
            this.textBoxCarEngineCapacity.Location = new System.Drawing.Point(123, 184);
            this.textBoxCarEngineCapacity.Name = "textBoxCarEngineCapacity";
            this.textBoxCarEngineCapacity.Size = new System.Drawing.Size(203, 20);
            this.textBoxCarEngineCapacity.TabIndex = 6;
            this.toolTip1.SetToolTip(this.textBoxCarEngineCapacity, "Podaj pojemność silnika w cm3");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rodzaj paliwa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "VIN:";
            // 
            // textBoxCarVIN
            // 
            this.textBoxCarVIN.Location = new System.Drawing.Point(124, 135);
            this.textBoxCarVIN.Name = "textBoxCarVIN";
            this.textBoxCarVIN.Size = new System.Drawing.Size(202, 20);
            this.textBoxCarVIN.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textBoxCarVIN, "Podaj VIN (17 znakowy)");
            // 
            // textBoxCarYearProduction
            // 
            this.textBoxCarYearProduction.Location = new System.Drawing.Point(124, 82);
            this.textBoxCarYearProduction.Name = "textBoxCarYearProduction";
            this.textBoxCarYearProduction.Size = new System.Drawing.Size(202, 20);
            this.textBoxCarYearProduction.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBoxCarYearProduction, "Podaj rok produkcji");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rok produkcji:";
            // 
            // textBoxCarBrand
            // 
            this.textBoxCarBrand.Location = new System.Drawing.Point(123, 29);
            this.textBoxCarBrand.Name = "textBoxCarBrand";
            this.textBoxCarBrand.Size = new System.Drawing.Size(203, 20);
            this.textBoxCarBrand.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBoxCarBrand, "Podaj model");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model auta:";
            // 
            // textBoxCarModel
            // 
            this.textBoxCarModel.Location = new System.Drawing.Point(123, 56);
            this.textBoxCarModel.Name = "textBoxCarModel";
            this.textBoxCarModel.Size = new System.Drawing.Size(203, 20);
            this.textBoxCarModel.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBoxCarModel, "Podaj markę");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka auta:";
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.carsDataSet1;
            // 
            // carsDataSet1
            // 
            this.carsDataSet1.DataSetName = "CarsDataSet1";
            this.carsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxClientNumber);
            this.groupBox2.Location = new System.Drawing.Point(392, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 56);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wprowadź numer klienta";
            // 
            // textBoxClientNumber
            // 
            this.textBoxClientNumber.Location = new System.Drawing.Point(6, 19);
            this.textBoxClientNumber.Name = "textBoxClientNumber";
            this.textBoxClientNumber.Size = new System.Drawing.Size(272, 20);
            this.textBoxClientNumber.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxNote);
            this.groupBox3.Location = new System.Drawing.Point(392, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(299, 57);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wprowadź notatkę";
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(7, 27);
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(271, 20);
            this.textBoxNote.TabIndex = 14;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.dateTimePickerTestDate);
            this.groupBox4.Controls.Add(this.radioButtonNegativ);
            this.groupBox4.Controls.Add(this.radioButtonPositive);
            this.groupBox4.Location = new System.Drawing.Point(392, 179);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(299, 106);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Podsumowanie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Data testu:";
            // 
            // dateTimePickerTestDate
            // 
            this.dateTimePickerTestDate.Location = new System.Drawing.Point(71, 71);
            this.dateTimePickerTestDate.Name = "dateTimePickerTestDate";
            this.dateTimePickerTestDate.Size = new System.Drawing.Size(203, 20);
            this.dateTimePickerTestDate.TabIndex = 13;
            // 
            // radioButtonNegativ
            // 
            this.radioButtonNegativ.AutoSize = true;
            this.radioButtonNegativ.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonNegativ.Location = new System.Drawing.Point(5, 43);
            this.radioButtonNegativ.Name = "radioButtonNegativ";
            this.radioButtonNegativ.Size = new System.Drawing.Size(120, 17);
            this.radioButtonNegativ.TabIndex = 12;
            this.radioButtonNegativ.TabStop = true;
            this.radioButtonNegativ.Text = "Przegląd negatywny";
            this.radioButtonNegativ.UseVisualStyleBackColor = true;
            // 
            // radioButtonPositive
            // 
            this.radioButtonPositive.AutoSize = true;
            this.radioButtonPositive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonPositive.Checked = true;
            this.radioButtonPositive.Location = new System.Drawing.Point(4, 20);
            this.radioButtonPositive.Name = "radioButtonPositive";
            this.radioButtonPositive.Size = new System.Drawing.Size(121, 17);
            this.radioButtonPositive.TabIndex = 11;
            this.radioButtonPositive.TabStop = true;
            this.radioButtonPositive.Text = "Przegląd pozytywny ";
            this.radioButtonPositive.UseVisualStyleBackColor = true;
            // 
            // buttonAddCar
            // 
            this.buttonAddCar.Location = new System.Drawing.Point(12, 305);
            this.buttonAddCar.Name = "buttonAddCar";
            this.buttonAddCar.Size = new System.Drawing.Size(118, 23);
            this.buttonAddCar.TabIndex = 15;
            this.buttonAddCar.Text = "Dodaj pojazd";
            this.buttonAddCar.UseVisualStyleBackColor = true;
            this.buttonAddCar.Click += new System.EventHandler(this.buttonAddCar_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(201, 305);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 16;
            this.buttonClose.Text = "Zamknij okno";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
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
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(528, 153);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 8;
            this.textBoxPrice.Visible = false;
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 343);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAddCar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddCarForm";
            this.ShowIcon = false;
            this.Text = "Dodaj pojazd";
            this.Load += new System.EventHandler(this.AddCarForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCarVIN;
        private System.Windows.Forms.TextBox textBoxCarYearProduction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCarBrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCarModel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxClientNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCarEngineCapacity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerCarFirstRegistration;
        private System.Windows.Forms.CheckBox checkBoxGas;
        private System.Windows.Forms.CheckBox checkBoxLate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButtonNegativ;
        private System.Windows.Forms.RadioButton radioButtonPositive;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerTestDate;
        private System.Windows.Forms.Button buttonAddCar;
        private System.Windows.Forms.Button buttonClose;
        private CarsDataSet1 carsDataSet1;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private CarsDataSet1TableAdapters.CarsTableAdapter carsTableAdapter;
        private CarsDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxCarMileage;
        private System.Windows.Forms.ComboBox comboBoxCarFuel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}