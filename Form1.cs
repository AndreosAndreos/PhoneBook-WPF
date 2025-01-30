using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace lista_7
{
    public partial class Form1 : Form
    {
        public class Kontakt
        {
            public int ID { get; private set; }
            public string Imie { get; set; }
            public string Nazwisko { get; set; }
            public string Miejscowosc { get; set; }
            public int NrTel { get; set; }

            private static int LicznikKontaktow = 0;

            public Kontakt(string imie, string nazwisko, string miejscowosc, int nrTel)
            {
                ID = ++LicznikKontaktow;
                Imie = imie;
                Nazwisko = nazwisko;
                Miejscowosc = miejscowosc;
                NrTel = nrTel;
            }
        }

        List<Kontakt> listaKontaktow = new List<Kontakt>();
        string sciezkaPlikuXML = @"G:\semestr 4\.NET\Laborki\lista 7\lista 7\subscribers.xml";
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView1();
            buttonZapiszZmiany.Visible = false;
            
            WczytajDaneZPlikuXML(sciezkaPlikuXML);
        }
        private void InitializeDataGridView1()
        {
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Imie";
            dataGridView1.Columns[2].Name = "Nazwisko";
            dataGridView1.Columns[3].Name = "Miejscowosc";
            dataGridView1.Columns[4].Name = "Numer telefonu";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void WczytajDaneZPlikuXML(string sciezkaPliku)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(sciezkaPliku);

                XmlNodeList subscribers = doc.GetElementsByTagName("subscriber");
                foreach (XmlNode subscriber in subscribers)
                {
                    string imie = subscriber.SelectSingleNode("name").InnerText;
                    string nazwisko = subscriber.SelectSingleNode("surname").InnerText;
                    string miejscowosc = subscriber.SelectSingleNode("city").InnerText;
                    int nrTel = int.Parse(subscriber.SelectSingleNode("phoneNumber").InnerText);

                    listaKontaktow.Add(new Kontakt(imie, nazwisko, miejscowosc, nrTel));
                }

                UpdateDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas wczytywania danych z pliku XML: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ZapiszDoPlikuXML(string sciezkaPliku)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
                xmlDoc.AppendChild(xmlDeclaration);

                XmlNode rootNode = xmlDoc.CreateElement("subscribers");
                xmlDoc.AppendChild(rootNode);

                foreach (var kontakt in listaKontaktow)
                {
                    XmlNode subscriberNode = xmlDoc.CreateElement("subscriber");

                    XmlNode nameNode = xmlDoc.CreateElement("name");
                    nameNode.InnerText = kontakt.Imie;
                    subscriberNode.AppendChild(nameNode);

                    XmlNode surnameNode = xmlDoc.CreateElement("surname");
                    surnameNode.InnerText = kontakt.Nazwisko;
                    subscriberNode.AppendChild(surnameNode);

                    XmlNode cityNode = xmlDoc.CreateElement("city");
                    cityNode.InnerText = kontakt.Miejscowosc;
                    subscriberNode.AppendChild(cityNode);

                    XmlNode phoneNumberNode = xmlDoc.CreateElement("phoneNumber");
                    phoneNumberNode.InnerText = kontakt.NrTel.ToString();
                    subscriberNode.AppendChild(phoneNumberNode);

                    rootNode.AppendChild(subscriberNode);
                }

                xmlDoc.Save(sciezkaPliku);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas zapisywania danych do pliku XML: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSortowanieImie_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["Imie"], ListSortDirection.Ascending);
        }

        private void buttonSortowanieNazwisko_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["Nazwisko"], ListSortDirection.Ascending);
        }

        private void buttonSortowanieMiejscowosc_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["Miejscowosc"], ListSortDirection.Ascending);
        }

        private void buttonSortowanieNrTelefonu_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["Numer telefonu"], ListSortDirection.Ascending);
        }
        private void buttonSortowanieID_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["ID"], ListSortDirection.Ascending);
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxImie.Text) ||
                string.IsNullOrWhiteSpace(textBoxNazwisko.Text) ||
                string.IsNullOrWhiteSpace(textBoxMiejscowosc.Text) ||
                string.IsNullOrWhiteSpace(textBoxNrTel.Text))
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string imie = textBoxImie.Text;
            string nazwisko = textBoxNazwisko.Text;
            string miejscowosc = textBoxMiejscowosc.Text;

            if (!int.TryParse(textBoxNrTel.Text, out int nrTel))
            {
                MessageBox.Show("Numer telefonu musi być liczbą całkowitą.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listaKontaktow.Add(new Kontakt(imie, nazwisko, miejscowosc, nrTel));
            ZapiszDoPlikuXML(sciezkaPlikuXML);

            textBoxImie.Clear();
            textBoxNazwisko.Clear();
            textBoxMiejscowosc.Clear();
            textBoxNrTel.Clear();

            UpdateDataGridView();

        }

        private void UpdateDataGridView(List<Kontakt> kontaktList = null)
        {
            dataGridView1.Rows.Clear();
            var contacts = kontaktList ?? listaKontaktow;
            foreach (var kontakt in contacts)
            {
                dataGridView1.Rows.Add(kontakt.ID, kontakt.Imie, kontakt.Nazwisko, kontakt.Miejscowosc, kontakt.NrTel);
            }
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUsuwanie.Text))
            {
                MessageBox.Show("Podaj ID kontaktu do usunięcia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBoxUsuwanie.Text, out int idDoUsuniecia))
            {
                MessageBox.Show("ID kontaktu musi być liczbą całkowitą.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Kontakt kontaktDoUsuniecia = listaKontaktow.FirstOrDefault(k => k.ID == idDoUsuniecia);
            if (kontaktDoUsuniecia == null)
            {
                MessageBox.Show("Kontakt o podanym ID nie istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listaKontaktow.Remove(kontaktDoUsuniecia);
            ZapiszDoPlikuXML(sciezkaPlikuXML);
            UpdateDataGridView();
            textBoxUsuwanie.Clear();
        }

        private void buttonEdytuj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxIDedycja.Text))
            {
                MessageBox.Show("Podaj ID kontaktu do edycji.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBoxIDedycja.Text, out int idDoEdycji))
            {
                MessageBox.Show("ID kontaktu musi być liczbą całkowitą.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Kontakt kontaktDoEdycji = listaKontaktow.FirstOrDefault(k => k.ID == idDoEdycji);
            if (kontaktDoEdycji == null)
            {
                MessageBox.Show("Kontakt o podanym ID nie istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBoxImie.Text = kontaktDoEdycji.Imie;
            textBoxNazwisko.Text = kontaktDoEdycji.Nazwisko;
            textBoxMiejscowosc.Text = kontaktDoEdycji.Miejscowosc;
            textBoxNrTel.Text = kontaktDoEdycji.NrTel.ToString();
            buttonZapiszZmiany.Visible = true;
        }

        private void buttonZapiszZmiany_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxImie.Text) ||
                string.IsNullOrWhiteSpace(textBoxNazwisko.Text) ||
                string.IsNullOrWhiteSpace(textBoxMiejscowosc.Text) ||
                string.IsNullOrWhiteSpace(textBoxNrTel.Text))
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBoxNrTel.Text, out int nrTel))
            {
                MessageBox.Show("Numer telefonu musi być liczbą całkowitą.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBoxIDedycja.Text, out int idDoEdycji))
            {
                MessageBox.Show("ID kontaktu musi być liczbą całkowitą.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Kontakt kontaktDoEdycji = listaKontaktow.FirstOrDefault(k => k.ID == idDoEdycji);
            if (kontaktDoEdycji == null)
            {
                MessageBox.Show("Kontakt o podanym ID nie istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            kontaktDoEdycji.Imie = textBoxImie.Text;
            kontaktDoEdycji.Nazwisko = textBoxNazwisko.Text;
            kontaktDoEdycji.Miejscowosc = textBoxMiejscowosc.Text;
            kontaktDoEdycji.NrTel = nrTel;

            UpdateDataGridView();
            buttonZapiszZmiany.Visible = false;
            ZapiszDoPlikuXML(sciezkaPlikuXML);

            textBoxImie.Clear();
            textBoxNazwisko.Clear();
            textBoxMiejscowosc.Clear();
            textBoxNrTel.Clear();
            textBoxIDedycja.Clear();
        }

        private void buttonWyszukaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSzukajImie.Text) &&
                string.IsNullOrWhiteSpace(textBoxSzukajNazwisko.Text) &&
                string.IsNullOrWhiteSpace(textBoxSzukajMiejscowosc.Text) &&
                string.IsNullOrWhiteSpace(textBoxSzukajNrTel.Text))
            {
                MessageBox.Show("Podaj przynajmniej jedno kryterium wyszukiwania.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var wynikiWyszukiwania = listaKontaktow;

            if (!string.IsNullOrWhiteSpace(textBoxSzukajImie.Text))
            {
                wynikiWyszukiwania = wynikiWyszukiwania.Where(k => k.Imie.ToLower().Contains(textBoxSzukajImie.Text.ToLower())).ToList();
            }

            if (!string.IsNullOrWhiteSpace(textBoxSzukajNazwisko.Text))
            {
                wynikiWyszukiwania = wynikiWyszukiwania.Where(k => k.Nazwisko.ToLower().Contains(textBoxSzukajNazwisko.Text.ToLower())).ToList();
            }

            if (!string.IsNullOrWhiteSpace(textBoxSzukajMiejscowosc.Text))
            {
                wynikiWyszukiwania = wynikiWyszukiwania.Where(k => k.Miejscowosc.ToLower().Contains(textBoxSzukajMiejscowosc.Text.ToLower())).ToList();
            }

            if (!string.IsNullOrWhiteSpace(textBoxSzukajNrTel.Text))
            {
                wynikiWyszukiwania = wynikiWyszukiwania.Where(k => k.NrTel.ToString().Contains(textBoxSzukajNrTel.Text)).ToList();
            }

            UpdateDataGridView(wynikiWyszukiwania);

            int iloscKontaktow = wynikiWyszukiwania.Count;
            MessageBox.Show($"Znaleziono {iloscKontaktow} kontaktów zgodnych z kryteriami wyszukiwania.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBoxSzukajImie.Clear();
            textBoxSzukajNazwisko.Clear();
            textBoxSzukajMiejscowosc.Clear();
            textBoxSzukajNrTel.Clear();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            ExportToCSV("contacts.csv");
        }

        private void ExportToCSV(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("ID,Imie,Nazwisko,Miejscowosc,Numer telefonu");

                    foreach (var kontakt in listaKontaktow)
                    {
                        writer.WriteLine($"{kontakt.ID},{kontakt.Imie},{kontakt.Nazwisko},{kontakt.Miejscowosc},{kontakt.NrTel}");
                    }
                }

                MessageBox.Show("Pomyślnie wyeksportowano kontakty do pliku CSV.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas eksportowania danych do pliku CSV: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonWyczysc_Click(object sender, EventArgs e)
        {
            textBoxSzukajImie.Clear();
            textBoxSzukajNazwisko.Clear();
            textBoxSzukajMiejscowosc.Clear();
            textBoxSzukajNrTel.Clear();

            UpdateDataGridView(listaKontaktow);
        }
    }
}
