namespace DentalAppt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtPhoneNumber = new TextBox();
            label3 = new Label();
            cbxDoctor = new ComboBox();
            label4 = new Label();
            dtpAppointment = new DateTimePicker();
            label5 = new Label();
            cbxOfficeLo = new ComboBox();
            btnConfirm = new Button();
            label6 = new Label();
            txtReasonVisit = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 22);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 0;
            label1.Text = "Full Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(256, 22);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Last Name, First Name";
            txtName.Size = new Size(385, 31);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 76);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 2;
            label2.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(256, 76);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(385, 31);
            txtPhoneNumber.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(137, 143);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 4;
            label3.Text = "Doctor";
            // 
            // cbxDoctor
            // 
            cbxDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDoctor.FormattingEnabled = true;
            cbxDoctor.Location = new Point(256, 135);
            cbxDoctor.Name = "cbxDoctor";
            cbxDoctor.Size = new Size(182, 33);
            cbxDoctor.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 200);
            label4.Name = "label4";
            label4.Size = new Size(160, 25);
            label4.TabIndex = 6;
            label4.Text = "Appointment Date";
            label4.Click += label4_Click;
            // 
            // dtpAppointment
            // 
            dtpAppointment.Location = new Point(256, 200);
            dtpAppointment.Name = "dtpAppointment";
            dtpAppointment.Size = new Size(300, 31);
            dtpAppointment.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 256);
            label5.Name = "label5";
            label5.Size = new Size(131, 25);
            label5.TabIndex = 8;
            label5.Text = "Office Location";
            // 
            // cbxOfficeLo
            // 
            cbxOfficeLo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxOfficeLo.FormattingEnabled = true;
            cbxOfficeLo.Location = new Point(256, 253);
            cbxOfficeLo.Name = "cbxOfficeLo";
            cbxOfficeLo.Size = new Size(182, 33);
            cbxOfficeLo.TabIndex = 9;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(113, 455);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(422, 98);
            btnConfirm.TabIndex = 10;
            btnConfirm.Text = "Confirm Appointment";
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2, 314);
            label6.Name = "label6";
            label6.Size = new Size(202, 25);
            label6.TabIndex = 11;
            label6.Text = "Reason of Appointment";
            // 
            // txtReasonVisit
            // 
            txtReasonVisit.Location = new Point(256, 314);
            txtReasonVisit.Multiline = true;
            txtReasonVisit.Name = "txtReasonVisit";
            txtReasonVisit.Size = new Size(385, 115);
            txtReasonVisit.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 599);
            Controls.Add(txtReasonVisit);
            Controls.Add(label6);
            Controls.Add(btnConfirm);
            Controls.Add(cbxOfficeLo);
            Controls.Add(label5);
            Controls.Add(dtpAppointment);
            Controls.Add(label4);
            Controls.Add(cbxDoctor);
            Controls.Add(label3);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtPhoneNumber;
        private Label label3;
        private ComboBox cbxDoctor;
        private Label label4;
        private DateTimePicker dtpAppointment;
        private Label label5;
        private ComboBox cbxOfficeLo;
        private Button btnConfirm;
        private Label label6;
        private TextBox txtReasonVisit;
    }
}
