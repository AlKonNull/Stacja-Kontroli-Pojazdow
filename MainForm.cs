//Projekt bazy danych dla stacji kontroli pojazdów, zapisujący poszczególnie badania.
//Uwzględnia dodawanie aut, notatek, sortowanie, wyszukiwanie po datach itp.

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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Ładowanie
        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'carsDataSet1.Cars' . Możesz go przenieść lub usunąć.
            this.carsTableAdapter1.Fill(this.carsDataSet1.Cars);
        }

        //Metoda GetID
        private int GetID(string id)
        {
            if (id == "") 
            { 
                MessageBox.Show("Nie wprowadzono żadnej wartości."); 
                return -1; 
            }
            foreach(char x in id)
            {
                if (char.IsDigit(x)) { }
                else
                {
                    MessageBox.Show("Wprowadzono nieprawidłowe ID badania, spróbuj ponownie.");
                    return -1;
                }
            }
            return int.Parse(id);
        }

        //Przycisk dodaj nowe auto
        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            //Stworzenie obiektu forma
            AddCarForm okienko = new AddCarForm();
            okienko.ShowDialog();

            //Zaktualizowanie okna bazy
            this.carsTableAdapter1.Fill(this.carsDataSet1.Cars);
        }

        //Przycisk usuń pojazd
        private void buttonDeleteCar_Click(object sender, EventArgs e)
        {
            //Stworzenie obiektu forma
            DeleteCarForm okienko = new DeleteCarForm();
            okienko.ShowDialog();

            //Zakutalizowanie okna bazy
            this.carsTableAdapter1.Fill(this.carsDataSet1.Cars);
        }

        //Przycik pokaż szczegóły
        private void buttonShowDetail_Click(object sender, EventArgs e)
        {
            //Wyciągamy id z textbox
            int id = GetID(textBoxID.Text);
            //Sprawdzamy poprawność id
            if (id == -1) { MessageBox.Show("Coś poszło nie tak."); }
            else
            {
                //Tworzymy okno forms
                ShowDetails okienko = new ShowDetails(id);
                //Otwieramy
                try { okienko.ShowDialog(); }
                catch { }
            }
        }

        //Przycisk sortuj po marce
        private void buttonBrandSort_Click(object sender, EventArgs e)
        {
            this.carsTableAdapter1.BrandSort(this.carsDataSet1.Cars);
        }

        //Przycisk sortuj po modelu
        private void buttonModelSort_Click(object sender, EventArgs e)
        {
            this.carsTableAdapter1.ModelSort(this.carsDataSet1.Cars);
        }

        //Przycisk sortowania po dacie testu
        private void buttonDateSort_Click(object sender, EventArgs e)
        {
            this.carsTableAdapter1.Date_TestSort(this.carsDataSet1.Cars);
        }

        //Przycisk zaliczone
        private void buttonCorrectSort_Click(object sender, EventArgs e)
        {
            this.carsTableAdapter1.CorrectSearch(this.carsDataSet1.Cars);
        }

        //Przycisk Nie zaliczone
        private void buttonNotCorrectSort_Click(object sender, EventArgs e)
        {
            this.carsTableAdapter1.NotCorrectSearch(this.carsDataSet1.Cars);
        }

        //Przycisk zamknij
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Przycisk szukaj
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string marka = textBoxSearch.Text;
            if (marka == "")
            {
                MessageBox.Show("Nie podano marki.");
            }
            else
            {
                this.carsTableAdapter1.SearchByBrand(this.carsDataSet1.Cars, marka);
            }
        }
    }
}
