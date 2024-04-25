namespace WinFormsApp1_2
{
    partial class MainForm
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
            btnAdd = new Button();
            flpRecords = new FlowLayoutPanel();
            lblAllRecords = new Label();
            lblAgeSum = new Label();
            tbAllRecords = new TextBox();
            tbAgeSum = new TextBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 14F);
            btnAdd.Location = new Point(12, 27);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 50);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // flpRecords
            // 
            flpRecords.AutoScroll = true;
            flpRecords.BorderStyle = BorderStyle.FixedSingle;
            flpRecords.Location = new Point(12, 93);
            flpRecords.Name = "flpRecords";
            flpRecords.Size = new Size(560, 456);
            flpRecords.TabIndex = 1;
            // 
            // lblAllRecords
            // 
            lblAllRecords.AutoSize = true;
            lblAllRecords.Location = new Point(238, 27);
            lblAllRecords.Name = "lblAllRecords";
            lblAllRecords.Size = new Size(88, 15);
            lblAllRecords.TabIndex = 2;
            lblAllRecords.Text = "Всего записей:";
            // 
            // lblAgeSum
            // 
            lblAgeSum.AutoSize = true;
            lblAgeSum.Location = new Point(238, 62);
            lblAgeSum.Name = "lblAgeSum";
            lblAgeSum.Size = new Size(69, 15);
            lblAgeSum.TabIndex = 3;
            lblAgeSum.Text = "Сумма лет:";
            // 
            // tbAllRecords
            // 
            tbAllRecords.Location = new Point(332, 24);
            tbAllRecords.Name = "tbAllRecords";
            tbAllRecords.ReadOnly = true;
            tbAllRecords.Size = new Size(43, 23);
            tbAllRecords.TabIndex = 4;
            // 
            // tbAgeSum
            // 
            tbAgeSum.Location = new Point(313, 59);
            tbAgeSum.Name = "tbAgeSum";
            tbAgeSum.ReadOnly = true;
            tbAgeSum.Size = new Size(43, 23);
            tbAgeSum.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 561);
            Controls.Add(tbAgeSum);
            Controls.Add(tbAllRecords);
            Controls.Add(lblAgeSum);
            Controls.Add(lblAllRecords);
            Controls.Add(flpRecords);
            Controls.Add(btnAdd);
            MaximumSize = new Size(600, 600);
            MinimumSize = new Size(600, 600);
            Name = "MainForm";
            Text = "Main Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private FlowLayoutPanel flpRecords;
        private Label lblAllRecords;
        private Label lblAgeSum;
        private TextBox tbAllRecords;
        private TextBox tbAgeSum;
    }
}