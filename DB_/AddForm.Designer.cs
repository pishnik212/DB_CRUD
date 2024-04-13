namespace DB_
{
    partial class AddForm
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
            this.CB_PKType = new System.Windows.Forms.ComboBox();
            this.LBL_FieldType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_PK = new System.Windows.Forms.TextBox();
            this.LBL_FieldName = new System.Windows.Forms.Label();
            this.BTN_AddField = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_IsPK = new System.Windows.Forms.Label();
            this.CB_CheckPK = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
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
            this.CB_PKType.Location = new System.Drawing.Point(231, 74);
            this.CB_PKType.Name = "CB_PKType";
            this.CB_PKType.Size = new System.Drawing.Size(172, 28);
            this.CB_PKType.TabIndex = 25;
            // 
            // LBL_FieldType
            // 
            this.LBL_FieldType.AutoSize = true;
            this.LBL_FieldType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBL_FieldType.Location = new System.Drawing.Point(21, 74);
            this.LBL_FieldType.Name = "LBL_FieldType";
            this.LBL_FieldType.Size = new System.Drawing.Size(89, 20);
            this.LBL_FieldType.TabIndex = 24;
            this.LBL_FieldType.Text = "Тип поля ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-20, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 23;
            // 
            // TB_PK
            // 
            this.TB_PK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_PK.Location = new System.Drawing.Point(231, 30);
            this.TB_PK.Name = "TB_PK";
            this.TB_PK.Size = new System.Drawing.Size(172, 27);
            this.TB_PK.TabIndex = 22;
            // 
            // LBL_FieldName
            // 
            this.LBL_FieldName.AutoSize = true;
            this.LBL_FieldName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBL_FieldName.Location = new System.Drawing.Point(21, 30);
            this.LBL_FieldName.Name = "LBL_FieldName";
            this.LBL_FieldName.Size = new System.Drawing.Size(87, 20);
            this.LBL_FieldName.TabIndex = 21;
            this.LBL_FieldName.Text = "Имя поля";
            // 
            // BTN_AddField
            // 
            this.BTN_AddField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_AddField.Location = new System.Drawing.Point(231, 167);
            this.BTN_AddField.Name = "BTN_AddField";
            this.BTN_AddField.Size = new System.Drawing.Size(81, 33);
            this.BTN_AddField.TabIndex = 19;
            this.BTN_AddField.Text = "ОК";
            this.BTN_AddField.UseVisualStyleBackColor = true;
            this.BTN_AddField.Click += new System.EventHandler(this.BTN_AddField_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-20, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 17;
            // 
            // LBL_IsPK
            // 
            this.LBL_IsPK.AutoSize = true;
            this.LBL_IsPK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBL_IsPK.Location = new System.Drawing.Point(21, 121);
            this.LBL_IsPK.Name = "LBL_IsPK";
            this.LBL_IsPK.Size = new System.Drawing.Size(151, 20);
            this.LBL_IsPK.TabIndex = 26;
            this.LBL_IsPK.Text = "Первичный ключ";
            // 
            // CB_CheckPK
            // 
            this.CB_CheckPK.AutoSize = true;
            this.CB_CheckPK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CB_CheckPK.Location = new System.Drawing.Point(231, 122);
            this.CB_CheckPK.Name = "CB_CheckPK";
            this.CB_CheckPK.Size = new System.Drawing.Size(18, 17);
            this.CB_CheckPK.TabIndex = 28;
            this.CB_CheckPK.UseVisualStyleBackColor = true;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 212);
            this.Controls.Add(this.CB_CheckPK);
            this.Controls.Add(this.LBL_IsPK);
            this.Controls.Add(this.CB_PKType);
            this.Controls.Add(this.LBL_FieldType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_PK);
            this.Controls.Add(this.LBL_FieldName);
            this.Controls.Add(this.BTN_AddField);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(445, 259);
            this.Name = "AddForm";
            this.Text = "Добавление поля в таблицу";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_PKType;
        private System.Windows.Forms.Label LBL_FieldType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_PK;
        private System.Windows.Forms.Label LBL_FieldName;
        private System.Windows.Forms.Button BTN_AddField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_IsPK;
        private System.Windows.Forms.CheckBox CB_CheckPK;
    }
}