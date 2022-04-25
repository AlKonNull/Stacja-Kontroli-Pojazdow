using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project___SKP
{
    public partial class ShowDetails : Form
    {
        public ShowDetails(int id)
        {
            InitializeComponent();
            //Wczytywanie textboxów
            try
            {
                iDTextBox.Text = carsTableAdapter.GetID(id).ToString();
                client_NumberTextBox.Text = carsTableAdapter.GetClient_Number(id).ToString();
                brandTextBox.Text = carsTableAdapter.GetBrand(id).ToString();
                modelTextBox.Text = carsTableAdapter.GetModel(id).ToString();
                year_ProductTextBox.Text = carsTableAdapter.GetYear_Product(id).ToString();
                mileageTextBox.Text = carsTableAdapter.GetMileage(id).ToString();
                vin_NumberTextBox.Text = carsTableAdapter.GetVin(id);
                fuelTextBox.Text = carsTableAdapter.GetFuel(id);
                engine_CapacityTextBox.Text = carsTableAdapter.GetEngine_Capacity(id).ToString();
                dateTimePickerFirstRegistration.Value = (System.DateTime)carsTableAdapter.GetDate_First_Registration(id);
                dateTimePickerDateTest.Value = (System.DateTime)carsTableAdapter.GetDate_Test(id);
                is_LPGCheckBox.Checked = (bool)carsTableAdapter.GetIs_LPG(id);
                is_LateCheckBox.Checked = (bool)carsTableAdapter.GetIs_Late(id);
                correctCheckBox.Checked = (bool)carsTableAdapter.GetCorrect(id);
                string priceText = (carsTableAdapter.GetPrice(id).ToString());
                decimal price = decimal.Parse(priceText);
                priceTextBox.Text = price.ToString("C2");
                noteTextBox.Text = carsTableAdapter.GetNote(id);
            }
            catch 
            { 
                MessageBox.Show("Coś poszło nie tak. \nSpróbuj ponownie.");
                this.Close();
            }
        }

        //Ładowanie
        private void ShowDetails_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'carsDataSet1.Cars' . Możesz go przenieść lub usunąć.
            this.carsTableAdapter.Fill(this.carsDataSet1.Cars);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
