namespace DB_
{
    partial class UC_TableView
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
            this.BTN_Close = new System.Windows.Forms.Button();
            this.BTN_DeleteTable = new System.Windows.Forms.Button();
            this.BTN_AddField = new System.Windows.Forms.Button();
            this.dgTable = new System.Windows.Forms.DataGridView();
            this.LBL_TableName = new System.Windows.Forms.Label();
            this.BTN_ChangeTableName = new System.Windows.Forms.Button();
            this.LBL_Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgTable)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Close
            // 
            this.BTN_Close.Location = new System.Drawing.Point(365, 10);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(33, 29);
            this.BTN_Close.TabIndex = 28;
            this.BTN_Close.Text = "X";
            this.BTN_Close.UseVisualStyleBackColor = true;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // BTN_DeleteTable
            // 
            this.BTN_DeleteTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_DeleteTable.Location = new System.Drawing.Point(237, 63);
            this.BTN_DeleteTable.Name = "BTN_DeleteTable";
            this.BTN_DeleteTable.Size = new System.Drawing.Size(161, 28);
            this.BTN_DeleteTable.TabIndex = 27;
            this.BTN_DeleteTable.Text = "Удалить таблицу";
            this.BTN_DeleteTable.UseVisualStyleBackColor = true;
            this.BTN_DeleteTable.Click += new System.EventHandler(this.BTN_DeleteTable_Click);
            // 
            // BTN_AddField
            // 
            this.BTN_AddField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_AddField.Location = new System.Drawing.Point(29, 97);
            this.BTN_AddField.Name = "BTN_AddField";
            this.BTN_AddField.Size = new System.Drawing.Size(161, 28);
            this.BTN_AddField.TabIndex = 26;
            this.BTN_AddField.Text = "Добавить поле";
            this.BTN_AddField.UseVisualStyleBackColor = true;
            this.BTN_AddField.Click += new System.EventHandler(this.BTN_AddField_Click);
            // 
            // dgTable
            // 
            this.dgTable.AllowUserToAddRows = false;
            this.dgTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTable.Location = new System.Drawing.Point(29, 134);
            this.dgTable.MinimumSize = new System.Drawing.Size(100, 100);
            this.dgTable.Name = "dgTable";
            this.dgTable.RowHeadersVisible = false;
            this.dgTable.RowHeadersWidth = 51;
            this.dgTable.RowTemplate.Height = 24;
            this.dgTable.Size = new System.Drawing.Size(369, 100);
            this.dgTable.TabIndex = 25;
            this.dgTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTable_CellDoubleClick);
            // 
            // LBL_TableName
            // 
            this.LBL_TableName.AutoSize = true;
            this.LBL_TableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBL_TableName.Location = new System.Drawing.Point(168, 13);
            this.LBL_TableName.Name = "LBL_TableName";
            this.LBL_TableName.Size = new System.Drawing.Size(119, 20);
            this.LBL_TableName.TabIndex = 24;
            this.LBL_TableName.Text = "Имя таблицы";
            // 
            // BTN_ChangeTableName
            // 
            this.BTN_ChangeTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_ChangeTableName.Location = new System.Drawing.Point(208, 97);
            this.BTN_ChangeTableName.Name = "BTN_ChangeTableName";
            this.BTN_ChangeTableName.Size = new System.Drawing.Size(190, 28);
            this.BTN_ChangeTableName.TabIndex = 29;
            this.BTN_ChangeTableName.Text = "Изменить имя таблицы";
            this.BTN_ChangeTableName.UseVisualStyleBackColor = true;
            this.BTN_ChangeTableName.Click += new System.EventHandler(this.BTN_ChangeTableName_Click);
            // 
            // LBL_Name
            // 
            this.LBL_Name.AutoSize = true;
            this.LBL_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBL_Name.Location = new System.Drawing.Point(29, 13);
            this.LBL_Name.Name = "LBL_Name";
            this.LBL_Name.Size = new System.Drawing.Size(124, 20);
            this.LBL_Name.TabIndex = 30;
            this.LBL_Name.Text = "Имя таблицы:";
            // 
            // UC_TableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LBL_Name);
            this.Controls.Add(this.BTN_ChangeTableName);
            this.Controls.Add(this.BTN_Close);
            this.Controls.Add(this.BTN_DeleteTable);
            this.Controls.Add(this.BTN_AddField);
            this.Controls.Add(this.dgTable);
            this.Controls.Add(this.LBL_TableName);
            this.MinimumSize = new System.Drawing.Size(418, 381);
            this.Name = "UC_TableView";
            this.Size = new System.Drawing.Size(418, 381);
            this.Load += new System.EventHandler(this.UC_TableView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Close;
        private System.Windows.Forms.Button BTN_DeleteTable;
        private System.Windows.Forms.Button BTN_AddField;
        private System.Windows.Forms.DataGridView dgTable;
        private System.Windows.Forms.Label LBL_TableName;
        private System.Windows.Forms.Button BTN_ChangeTableName;
        private System.Windows.Forms.Label LBL_Name;
    }
}
