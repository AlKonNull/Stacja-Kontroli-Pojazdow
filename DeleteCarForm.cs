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
    public partial class DeleteCarForm : Form
    {
        public DeleteCarForm()
        {
            InitializeComponent();
        }

        //Metoda sprawdzająca textbox'a
        private int ID()
        {
            string idString = textBoxID.Text;
            int highestID = (int)carsTableAdapter.HighestID();

            if (idString == "")
            {
                MessageBox.Show("Nie wprowadzono ID badania");
                return -1;
            }
            else
            {
                bool succes = int.TryParse(idString, out int id);
                if (succes & id>0)
                {
                    if(id<= highestID)
                    {
                        return id;
                    }
                    return -1;
                }
                else
                {
                    MessageBox.Show("Wprowadzono nieprawidłowe ID badania.");
                    return -1;
                }
            }
        }
        //Przycisk usuń
        private void buttonDeleteCar_Click(object sender, EventArgs e)
        {
            //Sprawdzamy textboxa
            int id = ID();

            //Usunięcie z tabeli
            if (id != -1)
            {
                carsTableAdapter.DeleteQuery(id);
                MessageBox.Show("Badanie zostało usunięte.");
                textBoxID.Clear();
            }
            else 
            {
                MessageBox.Show("Coś poszło nie tak. Spróbuj ponownie.");
                textBoxID.Clear();
            }
        }

        //Przycisk zamknij
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteCarForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'carsDataSet1.Cars' . Możesz go przenieść lub usunąć.
            this.carsTableAdapter.Fill(this.carsDataSet1.Cars);
        }
    }
}
