namespace bai_4._2
{
    partial class Form1
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
            this.mtxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mtxtPhone
            // 
            this.mtxtPhone.Location = new System.Drawing.Point(371, 169);
            this.mtxtPhone.Mask = "(000) 000-0000";
            this.mtxtPhone.Name = "mtxtPhone";
            this.mtxtPhone.Size = new System.Drawing.Size(180, 22);
            this.mtxtPhone.TabIndex = 0;
            this.mtxtPhone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtPhone_MaskInputRejected);
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(371, 208);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(200, 22);
            this.dtpBirthDate.TabIndex = 1;
            // 
            // cboCourse
            // 
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Location = new System.Drawing.Point(440, 291);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(121, 24);
            this.cboCourse.TabIndex = 2;
            this.cboCourse.SelectedIndexChanged += new System.EventHandler(this.cboCourse_SelectedIndexChanged);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(244, 169);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(75, 23);
            this.btnDangKy.TabIndex = 3;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 785);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.cboCourse);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.mtxtPhone);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtPhone;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.Button btnDangKy;
    }
}

