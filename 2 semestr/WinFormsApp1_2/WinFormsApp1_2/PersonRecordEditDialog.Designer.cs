namespace WinFormsApp1_2
{
    partial class PersonRecordEditDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			tbAge = new TextBox();
			tbMiddleName = new TextBox();
			tbFirstName = new TextBox();
			tbLastName = new TextBox();
			tbId = new TextBox();
			lblAge = new Label();
			lblMiddleName = new Label();
			lblFirstName = new Label();
			lblLastName = new Label();
			lblId = new Label();
			btnSave = new Button();
			SuspendLayout();
			// 
			// tbAge
			// 
			tbAge.Font = new Font("Segoe UI", 14F);
			tbAge.Location = new Point(14, 493);
			tbAge.Margin = new Padding(3, 4, 3, 4);
			tbAge.Name = "tbAge";
			tbAge.Size = new Size(52, 39);
			tbAge.TabIndex = 21;
			// 
			// tbMiddleName
			// 
			tbMiddleName.Font = new Font("Segoe UI", 14F);
			tbMiddleName.Location = new Point(14, 380);
			tbMiddleName.Margin = new Padding(3, 4, 3, 4);
			tbMiddleName.Name = "tbMiddleName";
			tbMiddleName.Size = new Size(286, 39);
			tbMiddleName.TabIndex = 20;
			// 
			// tbFirstName
			// 
			tbFirstName.Font = new Font("Segoe UI", 14F);
			tbFirstName.Location = new Point(14, 265);
			tbFirstName.Margin = new Padding(3, 4, 3, 4);
			tbFirstName.Name = "tbFirstName";
			tbFirstName.Size = new Size(286, 39);
			tbFirstName.TabIndex = 19;
			// 
			// tbLastName
			// 
			tbLastName.Font = new Font("Segoe UI", 14F);
			tbLastName.Location = new Point(14, 156);
			tbLastName.Margin = new Padding(3, 4, 3, 4);
			tbLastName.Name = "tbLastName";
			tbLastName.Size = new Size(286, 39);
			tbLastName.TabIndex = 18;
			// 
			// tbId
			// 
			tbId.Font = new Font("Segoe UI", 14F);
			tbId.Location = new Point(14, 56);
			tbId.Margin = new Padding(3, 4, 3, 4);
			tbId.Name = "tbId";
			tbId.ReadOnly = true;
			tbId.Size = new Size(45, 39);
			tbId.TabIndex = 17;
			// 
			// lblAge
			// 
			lblAge.AutoSize = true;
			lblAge.Font = new Font("Segoe UI", 16F);
			lblAge.Location = new Point(7, 449);
			lblAge.Name = "lblAge";
			lblAge.Size = new Size(60, 37);
			lblAge.TabIndex = 16;
			lblAge.Text = "Лет";
			// 
			// lblMiddleName
			// 
			lblMiddleName.AutoSize = true;
			lblMiddleName.Font = new Font("Segoe UI", 16F);
			lblMiddleName.Location = new Point(14, 336);
			lblMiddleName.Name = "lblMiddleName";
			lblMiddleName.Size = new Size(130, 37);
			lblMiddleName.TabIndex = 15;
			lblMiddleName.Text = "Отчество";
			// 
			// lblFirstName
			// 
			lblFirstName.AutoSize = true;
			lblFirstName.Font = new Font("Segoe UI", 16F);
			lblFirstName.Location = new Point(14, 221);
			lblFirstName.Name = "lblFirstName";
			lblFirstName.Size = new Size(70, 37);
			lblFirstName.TabIndex = 14;
			lblFirstName.Text = "Имя";
			// 
			// lblLastName
			// 
			lblLastName.AutoSize = true;
			lblLastName.Font = new Font("Segoe UI", 16F);
			lblLastName.Location = new Point(14, 112);
			lblLastName.Name = "lblLastName";
			lblLastName.Size = new Size(130, 37);
			lblLastName.TabIndex = 13;
			lblLastName.Text = "Фамилия";
			// 
			// lblId
			// 
			lblId.AutoSize = true;
			lblId.Font = new Font("Segoe UI", 16F);
			lblId.Location = new Point(14, 12);
			lblId.Name = "lblId";
			lblId.Size = new Size(40, 37);
			lblId.TabIndex = 12;
			lblId.Text = "Id";
			// 
			// btnSave
			// 
			btnSave.Font = new Font("Segoe UI", 14F);
			btnSave.Location = new Point(165, 532);
			btnSave.Margin = new Padding(3, 4, 3, 4);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(149, 52);
			btnSave.TabIndex = 22;
			btnSave.Text = "Сохранить";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// PersonRecordEditDialog
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(326, 600);
			Controls.Add(btnSave);
			Controls.Add(tbAge);
			Controls.Add(tbMiddleName);
			Controls.Add(tbFirstName);
			Controls.Add(tbLastName);
			Controls.Add(tbId);
			Controls.Add(lblAge);
			Controls.Add(lblMiddleName);
			Controls.Add(lblFirstName);
			Controls.Add(lblLastName);
			Controls.Add(lblId);
			Margin = new Padding(3, 4, 3, 4);
			Name = "PersonRecordEditDialog";
			Text = "Edit Dialog";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox tbAge;
        private TextBox tbMiddleName;
        private TextBox tbFirstName;
        private TextBox tbLastName;
        private TextBox tbId;
        private Label lblAge;
        private Label lblMiddleName;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblId;
        private Button btnSave;
    }
}