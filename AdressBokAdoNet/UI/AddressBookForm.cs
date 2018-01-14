using System;
using System.ComponentModel;
using System.Windows.Forms;
using AdressBokAdoNet.Model;
using AdressBokAdoNet.DAL;

namespace AdressBokAdoNet
{
    public partial class AddressBookForm : Form
    {
        DataAccess dataAccess = new DataAccess();

        public AddressBookForm()
        {
            InitializeComponent();
            LoadAddressBook();
            AddContactTypeDropdownItems();
        }

        private void LoadAddressBook()
        {
            string query = "SELECT * FROM Kontakter";

            var retrieveData = dataAccess.RetrieveData(query);
            AddressBookDataGridView.DataSource = retrieveData.Tables[0];
        }

        private void AddContactTypeDropdownItems()
        {
            ContactTypeComboBox.Items.Add("Personlig kontakt");
            ContactTypeComboBox.Items.Add("Jobb kontakt");
            ContactTypeComboBox.Items.Add("Övriga kontakter");
        }

        private void ClearText()
        {
            NameTextBox.Clear();
            AddressTextBox.Clear();
            PostalCodeTextBox.Clear();
            CityTextBox.Clear();
            TelephoneTextBox.Clear();
            EmailTextBox.Clear();
            ContactTypeComboBox.SelectedIndex = -1;
        }

        private void AddressBookForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'addressBookDataSet.Kontakter' table. You can move, or remove it, as needed.

        }

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            string query = "DECLARE @searchName varchar(200) = '" + NameTextBox.Text + "'" +
                           "DECLARE @searchCity varchar(200) = '" + CityTextBox.Text + "'" +
                           "DECLARE @searchContactType varchar(200) = '" + ContactTypeComboBox.Text + "'" +
                           "SELECT * FROM Kontakter " +
                           "WHERE Namn LIKE '%' + @searchName + '%' " +
                           "AND Postort LIKE '%' + @searchCity + '%' " +
                           "AND KontaktTyp LIKE '%' + @searchContactType + '%'";

            var searchData = dataAccess.RetrieveData(query);
            AddressBookDataGridView.DataSource = searchData.Tables[0];
        }

        private void CreateContactButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NameTextBox.Text ?? AddressTextBox.Text ?? PostalCodeTextBox.Text ?? CityTextBox.Text ??
                                     TelephoneTextBox.Text ?? EmailTextBox.Text ?? ContactTypeComboBox.Text))
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else
            {
                string query = "INSERT INTO Kontakter " +
                               "VALUES ('" + NameTextBox.Text + "', '" + AddressTextBox.Text + "', '" + PostalCodeTextBox.Text + "', " +
                               "'" + CityTextBox.Text + "', '" + TelephoneTextBox.Text + "', '" + EmailTextBox.Text + "', " +
                               "'" + ContactTypeComboBox.Text + "')";

                dataAccess.CreateUpdateDelete(query);
            }
            ClearText();
            LoadAddressBook();
        }

        private void AddressBookDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowSelected = AddressBookDataGridView.CurrentCell.RowIndex;

            NameTextBox.Text = AddressBookDataGridView.Rows[rowSelected].Cells[1].Value.ToString();
            AddressTextBox.Text = AddressBookDataGridView.Rows[rowSelected].Cells[2].Value.ToString();
            PostalCodeTextBox.Text = AddressBookDataGridView.Rows[rowSelected].Cells[3].Value.ToString();
            CityTextBox.Text = AddressBookDataGridView.Rows[rowSelected].Cells[4].Value.ToString();
            TelephoneTextBox.Text = AddressBookDataGridView.Rows[rowSelected].Cells[5].Value.ToString();
            EmailTextBox.Text = AddressBookDataGridView.Rows[rowSelected].Cells[6].Value.ToString();
            ContactTypeComboBox.Text = AddressBookDataGridView.Rows[rowSelected].Cells[7].Value.ToString();
        }

        private void UpdateAddressButton_Click(object sender, EventArgs e)
        {
            var kontaktID = AddressBookDataGridView.CurrentRow.Cells[0].Value.ToString();

            string query = "UPDATE Kontakter " +
                           "SET Gatuadress = '" + AddressTextBox.Text + "', Postnummer = '" + PostalCodeTextBox.Text + "', " +
                           "Postort = '" + CityTextBox.Text + "'" +
                           "WHERE ID = " + kontaktID + "";

            dataAccess.CreateUpdateDelete(query);
            LoadAddressBook();
            ClearText();
        }

        private void DeleteAddressButton_Click_1(object sender, EventArgs e)
        {
            var kontaktID = AddressBookDataGridView.CurrentRow.Cells[0].Value.ToString();

            string query = "UPDATE Kontakter " +
                           "SET Gatuadress = '', Postnummer = '', Postort = ''" +
                           "WHERE ID = " + kontaktID + "";

            dataAccess.CreateUpdateDelete(query);
            LoadAddressBook();
            ClearText();
        }
    }
}
