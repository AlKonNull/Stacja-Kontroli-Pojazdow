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
    public partial class AddCarForm : Form
    {
        public AddCarForm()
        {
            InitializeComponent();
        }
        //Metoda resetująca Textbox
        private void ResetTextbox()
        {
            textBoxCarBrand.Clear();
            textBoxCarModel.Clear();
            textBoxCarYearProduction.Clear();
            textBoxCarMileage.Clear();
            textBoxCarVIN.Clear();
            comboBoxCarFuel.SelectedIndex = 1;
            textBoxCarEngineCapacity.Clear();
            dateTimePickerCarFirstRegistration.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0,0,0);
            checkBoxGas.Checked = false;
            checkBoxLate.Checked = false;
            textBoxClientNumber.Clear();
            dateTimePickerTestDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            textBoxPrice.Clear();
            textBoxNote.Clear();
        }
        //Metoda sprawdzająca czy formularz jest dobrze wypłeniony
        private bool IsOk()
        {
            try
            {
                //Sprawdzamy warunki
                //Marka = czy nie pusta
                if (textBoxCarBrand.Text == "")
                {
                    MessageBox.Show("Nie wprowadzono marki.");
                    return false;
                }
                //Model = czy nie pusty
                if (textBoxCarModel.Text == "")
                {
                    MessageBox.Show("Nie wprowadzono modelu.");
                    return false;
                }
                //Rok produkcji = czy nie pusty, czy nie inny niż 4 liczby i nie inny niż cyfry
                string yearproduction = textBoxCarYearProduction.Text;
                if (textBoxCarYearProduction.Text == "")
                {
                    MessageBox.Show("Nie wprowadzono roku produkcji.");
                    return false;
                }
                else
                {
                    if (textBoxCarYearProduction.Text.Length != 4)
                    {
                        MessageBox.Show("Podano nieprawidłowy rok produkcji.");
                        return false;
                    }
                    else
                    {
                        bool succes = int.TryParse(yearproduction, out int test);
                        if (succes)
                        {

                        }
                        else
                        {
                            MessageBox.Show("Wprowadzono nieprawidłowy przebieg.");
                            return false;
                        }
                    }
                }
                //Przebieg czy nie pusty i czy nie inny niż cyfry
                string mileage = textBoxCarMileage.Text;
                if(mileage == "")
                {
                    MessageBox.Show("Nie wprowadzono przebiegu");
                }
                else
                {
                    bool succes = int.TryParse(mileage, out int test);
                    if (succes)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Wprowadzono nieprawidłowy przebieg.");
                        return false;
                    }
                }
                //VIN czy 17 znakowy i zwiększamy znaki
                string vin = textBoxCarVIN.Text;
                if(vin.Length != 17)
                {
                    MessageBox.Show("Podano nieprawidłowy VIN.");
                    return false;
                }
                else
                {
                    textBoxCarVIN.Text = vin.ToUpper();
                }
                //Pojemność silnika czy w int
                string capacity = textBoxCarEngineCapacity.Text;
                if (capacity == "")
                {
                    MessageBox.Show("Nie wprowadzono pojemności silnika.");
                    return false;
                }
                else
                {
                    bool success = int.TryParse(capacity, out int test);
                    if (success)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Wprowadzono nieprawodłową pojemność silnika.");
                        return false;
                    }
                }
                //czy numer klienta to numer
                string clientNumber = textBoxClientNumber.Text;
                if (clientNumber == "")
                {
                    MessageBox.Show("Nie wprowadzono numeru klienta");
                    return false;
                }
                else
                {
                    bool success = int.TryParse(clientNumber, out int test);
                    if (success)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Wprowadzono nieprawidłowy numer klienta.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
        //Metoda oddająca cenę przeglądu
        private int Price(bool gas, bool late)
        {
            //cena przeglądu bez dodatkó
            int price = 98;
            if (gas) { price += 64; }
            if (late) { price += (price / 2); }
            return price;
        }

        //Ładowanie
        private void AddCarForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'carsDataSet1.Cars' . Możesz go przenieść lub usunąć.
            this.carsTableAdapter.Fill(this.carsDataSet1.Cars);
            //Resetujemy textbox'y
            ResetTextbox();
        }

        //Przycisk dodaj pojazd
        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            //Sprawdzamy kontrolki
            bool isOk = IsOk();
            if (isOk)
            {
                //Zmienne
                string brand = textBoxCarBrand.Text;                                //Marka
                string model = textBoxCarModel.Text;                                //Model
                string vin = textBoxCarVIN.Text;                                    //Vin
                string fuel = comboBoxCarFuel.Text;                                 //Paliwo
                string note = textBoxNote.Text;                                     //Notatka
                int productionYear = int.Parse(textBoxCarYearProduction.Text);      //Rok produkcji
                int mileage = int.Parse(textBoxCarMileage.Text);                    //Przebieg
                int capacity = int.Parse(textBoxCarEngineCapacity.Text);            //Pojemność silnika
                int client = int.Parse(textBoxClientNumber.Text);                   //Numer klienta
                bool isGas = checkBoxGas.Checked;                                   //Gaz
                bool isLate = checkBoxLate.Checked;                                 //Spóźnienie
                bool correct;                                                       //Wynik przeglądu
                if (radioButtonNegativ.Checked) { correct = false; }
                else { correct = true; }
                // dateTimePickerCarFirstRegistration.Value --- DataBindingAdd test
                // dateTimePickerCarFirstRegistration.Value --- Data pierwszej rejestracji

                //Dodajemy cenę
                textBoxPrice.Text = (Price(isGas, isLate).ToString());
                int price = int.Parse(textBoxPrice.Text);

                //Dodajemy do tabeli
                carsTableAdapter.InsertQuery(client, 
                                             brand, 
                                             model, 
                                             productionYear, 
                                             mileage, 
                                             vin, 
                                             fuel, 
                                             capacity, 
                                             dateTimePickerCarFirstRegistration.Text, 
                                             isGas, 
                                             isLate, 
                                             note, 
                                             dateTimePickerTestDate.Text, 
                                             correct, 
                                             price);

                //Komunikat
                MessageBox.Show("Przegląd techniczny dodany do bazy.");
                //Resetujemy kontrolki
                ResetTextbox();
                this.Close();
            }
            else
            {
                MessageBox.Show("Coś poszło nie tak. Spróbuj uzupełnić dane ponownie.");
            }
        }

        //Przycisk zamknij
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}