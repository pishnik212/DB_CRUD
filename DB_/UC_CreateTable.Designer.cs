namespace DB_
{
    partial class UC_CreateTable
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
            this.BTN_CreateTable = new System.Windows.Forms.Button();
            this.TB_TableName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_TableName = new System.Windows.Forms.Label();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.TB_PK = new System.Windows.Forms.TextBox();
            this.LBL_PK = new System.Windows.Forms.Label();
            this.LBL_PKType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_PKType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BTN_CreateTable
            // 
            this.BTN_CreateTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_CreateTable.Location = new System.Drawing.Point(338, 195);
            this.BTN_CreateTable.Name = "BTN_CreateTable";
            this.BTN_CreateTable.Size = new System.Drawing.Size(82, 33);
            this.BTN_CreateTable.TabIndex = 9;
            this.BTN_CreateTable.Text = "ОК";
            this.BTN_CreateTable.UseVisualStyleBackColor = true;
            this.BTN_CreateTable.Click += new System.EventHandler(this.BTN_CreateTable_Click);
            // 
            // TB_TableName
            // 
            this.TB_TableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_TableName.Location = new System.Drawing.Point(299, 66);
            this.TB_TableName.Name = "TB_TableName";
            this.TB_TableName.Size = new System.Drawing.Size(172, 27);
            this.TB_TableName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 7;
            // 
            // LBL_TableName
            // 
            this.LBL_TableName.AutoSize = true;
            this.LBL_TableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBL_TableName.Location = new System.Drawing.Point(31, 74);
            this.LBL_TableName.Name = "LBL_TableName";
            this.LBL_TableName.Size = new System.Drawing.Size(119, 20);
            this.LBL_TableName.TabIndex = 6;
            this.LBL_TableName.Text = "Имя таблицы";
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_Cancel.Location = new System.Drawing.Point(299, 18);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(136, 29);
            this.BTN_Cancel.TabIndex = 10;
            this.BTN_Cancel.Text = "Отмена";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // TB_PK
            // 
            this.TB_PK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_PK.Location = new System.Drawing.Point(299, 110);
            this.TB_PK.Name = "TB_PK";
            this.TB_PK.Size = new System.Drawing.Size(172, 27);
            this.TB_PK.TabIndex = 12;
            // 
            // LBL_PK
            // 
            this.LBL_PK.AutoSize = true;
            this.LBL_PK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBL_PK.Location = new System.Drawing.Point(31, 116);
            this.LBL_PK.Name = "LBL_PK";
            this.LBL_PK.Size = new System.Drawing.Size(247, 20);
            this.LBL_PK.TabIndex = 11;
            this.LBL_PK.Text = "Имя поля первичного ключа";
            // 
            // LBL_PKType
            // 
            this.LBL_PKType.AutoSize = true;
            this.LBL_PKType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBL_PKType.Location = new System.Drawing.Point(31, 154);
            this.LBL_PKType.Name = "LBL_PKType";
            this.LBL_PKType.Size = new System.Drawing.Size(244, 20);
            this.LBL_PKType.TabIndex = 14;
            this.LBL_PKType.Text = "Тип поля первичного ключа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 13;
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
            this.CB_PKType.Location = new System.Drawing.Point(299, 154);
            this.CB_PKType.Name = "CB_PKType";
            this.CB_PKType.Size = new System.Drawing.Size(172, 28);
            this.CB_PKType.TabIndex = 15;
            // 
            // UC_CreateTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CB_PKType);
            this.Controls.Add(this.LBL_PKType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_PK);
            this.Controls.Add(this.LBL_PK);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_CreateTable);
            this.Controls.Add(this.TB_TableName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBL_TableName);
            this.MinimumSize = new System.Drawing.Size(483, 254);
            this.Name = "UC_CreateTable";
            this.Size = new System.Drawing.Size(483, 254);
            this.Load += new System.EventHandler(this.UC_CreateTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_CreateTable;
        private System.Windows.Forms.TextBox TB_TableName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_TableName;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.TextBox TB_PK;
        private System.Windows.Forms.Label LBL_PK;
        private System.Windows.Forms.Label LBL_PKType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_PKType;
    }
}
