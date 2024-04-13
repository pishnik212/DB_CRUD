namespace DB_
{
    partial class UpdateForm
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
            this.LBL_IsPK = new System.Windows.Forms.Label();
            this.CB_PKType = new System.Windows.Forms.ComboBox();
            this.LBL_FieldType = new System.Windows.Forms.Label();
            this.TB_PK = new System.Windows.Forms.TextBox();
            this.LBL_FieldName = new System.Windows.Forms.Label();
            this.BTN_SaveChanges = new System.Windows.Forms.Button();
            this.CB_CheckPK = new System.Windows.Forms.CheckBox();
            this.BTN_DeleteField = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_IsPK
            // 
            this.LBL_IsPK.AutoSize = true;
            this.LBL_IsPK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBL_IsPK.Location = new System.Drawing.Point(22, 149);
            this.LBL_IsPK.Name = "LBL_IsPK";
            this.LBL_IsPK.Size = new System.Drawing.Size(151, 20);
            this.LBL_IsPK.TabIndex = 34;
            this.LBL_IsPK.Text = "Первичный ключ";
            // 
            // CB_PKType
            // 
            this.CB_PKType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_PKType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CB_PKType.FormattingEnabled = true;
            this.CB_PKType.Items.AddRange(new object[] {
            "INTEGER",
            "DECIMAL",
            "TEXT",
            "TIMESTAMP"});
            this.CB_PKType.Location = new System.Drawing.Point(232, 102);
            this.CB_PKType.Name = "CB_PKType";
            this.CB_PKType.Size = new System.Drawing.Size(172, 28);
            this.CB_PKType.TabIndex = 33;
            // 
            // LBL_FieldType
            // 
            this.LBL_FieldType.AutoSize = true;
            this.LBL_FieldType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBL_FieldType.Location = new System.Drawing.Point(22, 102);
            this.LBL_FieldType.Name = "LBL_FieldType";
            this.LBL_FieldType.Size = new System.Drawing.Size(89, 20);
            this.LBL_FieldType.TabIndex = 32;
            this.LBL_FieldType.Text = "Тип поля ";
            // 
            // TB_PK
            // 
            this.TB_PK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_PK.Location = new System.Drawing.Point(232, 58);
            this.TB_PK.Name = "TB_PK";
            this.TB_PK.Size = new System.Drawing.Size(172, 27);
            this.TB_PK.TabIndex = 31;
            // 
            // LBL_FieldName
            // 
            this.LBL_FieldName.AutoSize = true;
            this.LBL_FieldName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBL_FieldName.Location = new System.Drawing.Point(22, 58);
            this.LBL_FieldName.Name = "LBL_FieldName";
            this.LBL_FieldName.Size = new System.Drawing.Size(87, 20);
            this.LBL_FieldName.TabIndex = 30;
            this.LBL_FieldName.Text = "Имя поля";
            // 
            // BTN_SaveChanges
            // 
            this.BTN_SaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_SaveChanges.Location = new System.Drawing.Point(232, 197);
            this.BTN_SaveChanges.Name = "BTN_SaveChanges";
            this.BTN_SaveChanges.Size = new System.Drawing.Size(77, 33);
            this.BTN_SaveChanges.TabIndex = 28;
            this.BTN_SaveChanges.Text = "ОК";
            this.BTN_SaveChanges.UseVisualStyleBackColor = true;
            this.BTN_SaveChanges.Click += new System.EventHandler(this.BTN_SaveChanges_Click);
            // 
            // CB_CheckPK
            // 
            this.CB_CheckPK.AutoSize = true;
            this.CB_CheckPK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CB_CheckPK.Location = new System.Drawing.Point(232, 150);
            this.CB_CheckPK.Name = "CB_CheckPK";
            this.CB_CheckPK.Size = new System.Drawing.Size(18, 17);
            this.CB_CheckPK.TabIndex = 36;
            this.CB_CheckPK.UseVisualStyleBackColor = true;
            // 
            // BTN_DeleteField
            // 
            this.BTN_DeleteField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_DeleteField.Location = new System.Drawing.Point(26, 12);
            this.BTN_DeleteField.Name = "BTN_DeleteField";
            this.BTN_DeleteField.Size = new System.Drawing.Size(172, 35);
            this.BTN_DeleteField.TabIndex = 37;
            this.BTN_DeleteField.Text = "Удалить поле";
            this.BTN_DeleteField.UseVisualStyleBackColor = true;
            this.BTN_DeleteField.Click += new System.EventHandler(this.BTN_DeleteField_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 254);
            this.Controls.Add(this.BTN_DeleteField);
            this.Controls.Add(this.CB_CheckPK);
            this.Controls.Add(this.LBL_IsPK);
            this.Controls.Add(this.CB_PKType);
            this.Controls.Add(this.LBL_FieldType);
            this.Controls.Add(this.TB_PK);
            this.Controls.Add(this.LBL_FieldName);
            this.Controls.Add(this.BTN_SaveChanges);
            this.Name = "UpdateForm";
            this.Text = "Обновление поля таблицы";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBL_IsPK;
        private System.Windows.Forms.ComboBox CB_PKType;
        private System.Windows.Forms.Label LBL_FieldType;
        private System.Windows.Forms.TextBox TB_PK;
        private System.Windows.Forms.Label LBL_FieldName;
        private System.Windows.Forms.Button BTN_SaveChanges;
        private System.Windows.Forms.CheckBox CB_CheckPK;
        private System.Windows.Forms.Button BTN_DeleteField;
    }
}