namespace WinFormsApp1_2
{
    partial class PersonRecordUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            lblId = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblMiddleName = new Label();
            lblAge = new Label();
            btnChange = new Button();
            btnDelete = new Button();
            tbId = new TextBox();
            tbLastName = new TextBox();
            tbFirstName = new TextBox();
            tbMiddleName = new TextBox();
            tbAge = new TextBox();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 16F);
            lblId.Location = new Point(15, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(31, 30);
            lblId.TabIndex = 0;
            lblId.Text = "id";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 16F);
            lblLastName.Location = new Point(61, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(103, 30);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "фамилия";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 16F);
            lblFirstName.Location = new Point(170, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(52, 30);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "имя";
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Font = new Font("Segoe UI", 16F);
            lblMiddleName.Location = new Point(279, 0);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(103, 30);
            lblMiddleName.TabIndex = 3;
            lblMiddleName.Text = "отчество";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 16F);
            lblAge.Location = new Point(388, 0);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(46, 30);
            lblAge.TabIndex = 4;
            lblAge.Text = "лет";
            // 
            // btnChange
            // 
            btnChange.Font = new Font("Segoe UI", 9F);
            btnChange.Location = new Point(440, 7);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(75, 23);
            btnChange.TabIndex = 5;
            btnChange.Text = "изменить";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(440, 35);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // tbId
            // 
            tbId.Location = new Point(15, 33);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(40, 23);
            tbId.TabIndex = 7;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(61, 33);
            tbLastName.Name = "tbLastName";
            tbLastName.ReadOnly = true;
            tbLastName.Size = new Size(103, 23);
            tbLastName.TabIndex = 8;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(170, 33);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.ReadOnly = true;
            tbFirstName.Size = new Size(103, 23);
            tbFirstName.TabIndex = 9;
            // 
            // tbMiddleName
            // 
            tbMiddleName.Location = new Point(279, 33);
            tbMiddleName.Name = "tbMiddleName";
            tbMiddleName.ReadOnly = true;
            tbMiddleName.Size = new Size(103, 23);
            tbMiddleName.TabIndex = 10;
            // 
            // tbAge
            // 
            tbAge.Location = new Point(388, 33);
            tbAge.Name = "tbAge";
            tbAge.ReadOnly = true;
            tbAge.Size = new Size(46, 23);
            tbAge.TabIndex = 11;
            // 
            // PersonRecordUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tbAge);
            Controls.Add(tbMiddleName);
            Controls.Add(tbFirstName);
            Controls.Add(tbLastName);
            Controls.Add(tbId);
            Controls.Add(btnDelete);
            Controls.Add(btnChange);
            Controls.Add(lblAge);
            Controls.Add(lblMiddleName);
            Controls.Add(lblFirstName);
            Controls.Add(lblLastName);
            Controls.Add(lblId);
            Name = "PersonRecordUserControl";
            Size = new Size(529, 65);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblMiddleName;
        private Label lblAge;
        private Button btnChange;
        private Button btnDelete;
        private TextBox tbId;
        private TextBox tbLastName;
        private TextBox tbFirstName;
        private TextBox tbMiddleName;
        private TextBox tbAge;
    }
}
