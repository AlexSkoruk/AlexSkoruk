namespace WinFormsApp1_2
{
    public partial class MainForm : Form
    {
        private int uniqueidentifier = 0;

        private void CalculateAllRecords()
        {
            tbAllRecords.Text = $"{flpRecords.Controls.Count}";
        }

        private void CalculateAgeSum()
        {
            int ageSum = 0;

            foreach (PersonRecordUserControl record in flpRecords.Controls)
            {
                ageSum += Convert.ToInt32(record.Age);
            }

            tbAgeSum.Text = $"{ageSum}";
        }

        public MainForm()
        {
            InitializeComponent();
            CalculateAllRecords();
            CalculateAgeSum();
        }

        private void PersonRecordEditDialog_onUpdatePersonRecord(Person currRecord, PersonRecordUserControl control)
        {
            PersonRecordEditDialog dialog = new(currRecord);
            dialog.ShowDialog();

            if (dialog.DialogResult == DialogResult.OK)
            {
                control.setPersonDataToTextBoxes(dialog.newRecord);
                CalculateAgeSum();
            }
        }

        private void PersonRecordEditDialog_onDeletePersonRecord(Person currRecord)
        {
            foreach (PersonRecordUserControl record in flpRecords.Controls)
            {
                if (record.Id == currRecord.Id)
                {
                    flpRecords.Controls.Remove(record);
                    break;
                }
            }

            CalculateAllRecords();
            CalculateAgeSum();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PersonRecordEditDialog dialog = new(++uniqueidentifier);
            dialog.ShowDialog();

            if (dialog.DialogResult == DialogResult.OK)
            {
                var record = new PersonRecordUserControl(dialog.newRecord);
                record.onUpdatePersonRecord += PersonRecordEditDialog_onUpdatePersonRecord;
                record.onDeletePersonRecord += PersonRecordEditDialog_onDeletePersonRecord;

                flpRecords.Controls.Add(record);
                CalculateAllRecords();
                CalculateAgeSum();
            }
        }
    }
}
