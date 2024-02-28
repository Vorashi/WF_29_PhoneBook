namespace Task_01
{
    partial class InputPhone
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
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblSurname = new System.Windows.Forms.Label();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblPhone = new System.Windows.Forms.Label();
            this.TbxSurname = new System.Windows.Forms.TextBox();
            this.TbxAddress = new System.Windows.Forms.TextBox();
            this.MtbxPhone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // BtnOk
            // 
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOk.Location = new System.Drawing.Point(95, 220);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(108, 45);
            this.BtnOk.TabIndex = 0;
            this.BtnOk.Text = "Ок";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancel.Location = new System.Drawing.Point(300, 220);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(108, 45);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.Location = new System.Drawing.Point(24, 30);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(66, 16);
            this.LblSurname.TabIndex = 2;
            this.LblSurname.Text = "Фамилия";
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Location = new System.Drawing.Point(24, 87);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(47, 16);
            this.LblAddress.TabIndex = 3;
            this.LblAddress.Text = "Адрес";
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.Location = new System.Drawing.Point(24, 146);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(67, 16);
            this.LblPhone.TabIndex = 4;
            this.LblPhone.Text = "Телефон";
            // 
            // TbxSurname
            // 
            this.TbxSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxSurname.Location = new System.Drawing.Point(146, 28);
            this.TbxSurname.Name = "TbxSurname";
            this.TbxSurname.Size = new System.Drawing.Size(274, 22);
            this.TbxSurname.TabIndex = 6;
            // 
            // TbxAddress
            // 
            this.TbxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxAddress.Location = new System.Drawing.Point(146, 85);
            this.TbxAddress.Name = "TbxAddress";
            this.TbxAddress.Size = new System.Drawing.Size(274, 22);
            this.TbxAddress.TabIndex = 7;
            // 
            // MtbxPhone
            // 
            this.MtbxPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MtbxPhone.Location = new System.Drawing.Point(146, 146);
            this.MtbxPhone.Mask = "999-000-0000";
            this.MtbxPhone.Name = "MtbxPhone";
            this.MtbxPhone.Size = new System.Drawing.Size(274, 22);
            this.MtbxPhone.TabIndex = 8;
            // 
            // InputPhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 293);
            this.Controls.Add(this.MtbxPhone);
            this.Controls.Add(this.TbxAddress);
            this.Controls.Add(this.TbxSurname);
            this.Controls.Add(this.LblPhone);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.LblSurname);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Name = "InputPhone";
            this.Text = "Ввод значений";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LblSurname;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.TextBox TbxSurname;
        private System.Windows.Forms.TextBox TbxAddress;
        private System.Windows.Forms.MaskedTextBox MtbxPhone;
    }
}