namespace WinFormsApp1_2
{
    public partial class PersonRecordUserControl : UserControl
    {
        public delegate void RecordUpdateHandler(Person currRecord, PersonRecordUserControl control);
        public delegate void RecordDeleteHandler(Person currRecord);

        public event RecordUpdateHandler? onUpdatePersonRecord;
        public event RecordDeleteHandler? onDeletePersonRecord;

        public int Id
        {
            get => Convert.ToInt32(tbId.Text);
            set => tbId.Text = $"{value}";
        }

        public string LastName
        {
            get => tbLastName.Text;
            set => tbLastName.Text = value;
        }

        public string FirstName
        {
            get => tbFirstName.Text;
            set => tbFirstName.Text = value;
        }

        public string MiddleName
        {
            get => tbMiddleName.Text;
            set => tbMiddleName.Text = value;
        }

        public int Age
        {
            get => Convert.ToInt32(tbAge.Text);
            set => tbAge.Text = $"{value}";
        }

        public void setPersonDataToTextBoxes(Person record)
        {
            Id = record.Id;
            LastName = record.LastName;
            FirstName = record.FirstName;
            MiddleName = record.MiddleName;
            Age = record.Age;
        }

        public PersonRecordUserControl(Person record)
        {
            InitializeComponent();
            setPersonDataToTextBoxes(record);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            var currRecord = new Person(Id, LastName, FirstName, MiddleName, Age);

            onUpdatePersonRecord?.Invoke(currRecord, this);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var currRecord = new Person(Id, LastName, FirstName, MiddleName, Age);

            onDeletePersonRecord?.Invoke(currRecord);
        }
    }
}
