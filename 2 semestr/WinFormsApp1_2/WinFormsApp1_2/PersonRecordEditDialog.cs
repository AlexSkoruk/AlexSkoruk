using System.Text.RegularExpressions;

namespace WinFormsApp1_2
{
    public partial class PersonRecordEditDialog : Form
    {
        public Person newRecord
        {
            get => new Person(
                Convert.ToInt32(tbId.Text),
                tbLastName.Text,
                tbFirstName.Text,
                tbMiddleName.Text,
                Convert.ToInt32(tbAge.Text)
            );
        }

        public PersonRecordEditDialog(int Id)
        {
            InitializeComponent();
            tbId.Text = $"{Id}";
        }

        public PersonRecordEditDialog(Person record)
        {
            InitializeComponent();

            tbId.Text = $"{record.Id}";
            tbLastName.Text = record.LastName;
            tbFirstName.Text = record.FirstName;
            tbMiddleName.Text = record.MiddleName;
            tbAge.Text = record.Age.ToString();
        }

        private bool ValidateTextBoxes()
        {
            Regex rgxAge = new Regex(@"^$|\D");
            Regex rgxOther = new Regex(@"^$|\W|\d");

            return (
                rgxOther.IsMatch(tbLastName.Text) ||
                rgxOther.IsMatch(tbFirstName.Text) ||
                rgxOther.IsMatch(tbMiddleName.Text) ||
                rgxAge.IsMatch(tbAge.Text)
            ) ? false : true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateTextBoxes())
            {
                MessageBox.Show("Uncorrect fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
