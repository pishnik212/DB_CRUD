namespace DB_
{
    partial class ChangeTableNameForm
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
            this.TB_NewTableName = new System.Windows.Forms.TextBox();
            this.BTN_ChangeTableName = new System.Windows.Forms.Button();
            this.LBL_NewName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_NewTableName
            // 
            this.TB_NewTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_NewTableName.Location = new System.Drawing.Point(12, 66);
            this.TB_NewTableName.Name = "TB_NewTableName";
            this.TB_NewTableName.Size = new System.Drawing.Size(239, 27);
            this.TB_NewTableName.TabIndex = 0;
            // 
            // BTN_ChangeTableName
            // 
            this.BTN_ChangeTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_ChangeTableName.Location = new System.Drawing.Point(284, 65);
            this.BTN_ChangeTableName.Name = "BTN_ChangeTableName";
            this.BTN_ChangeTableName.Size = new System.Drawing.Size(121, 36);
            this.BTN_ChangeTableName.TabIndex = 1;
            this.BTN_ChangeTableName.Text = "Применить";
            this.BTN_ChangeTableName.UseVisualStyleBackColor = true;
            this.BTN_ChangeTableName.Click += new System.EventHandler(this.BTN_ChangeTableName_Click);
            // 
            // LBL_NewName
            // 
            this.LBL_NewName.AutoSize = true;
            this.LBL_NewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBL_NewName.Location = new System.Drawing.Point(9, 28);
            this.LBL_NewName.Name = "LBL_NewName";
            this.LBL_NewName.Size = new System.Drawing.Size(299, 20);
            this.LBL_NewName.TabIndex = 2;
            this.LBL_NewName.Text = "Введите новое название таблицы";
            // 
            // ChangeTableNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 135);
            this.Controls.Add(this.LBL_NewName);
            this.Controls.Add(this.BTN_ChangeTableName);
            this.Controls.Add(this.TB_NewTableName);
            this.MinimumSize = new System.Drawing.Size(435, 182);
            this.Name = "ChangeTableNameForm";
            this.Text = "Изменение имени таблицы";
            this.Load += new System.EventHandler(this.ChangeTableNameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_NewTableName;
        private System.Windows.Forms.Button BTN_ChangeTableName;
        private System.Windows.Forms.Label LBL_NewName;
    }
}