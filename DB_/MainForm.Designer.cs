namespace DB_
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
            this.FLP_Left = new System.Windows.Forms.FlowLayoutPanel();
            this.BTN_ToStartForm = new System.Windows.Forms.Button();
            this.BTN_AddTable = new System.Windows.Forms.Button();
            this.LBL_TablesList = new System.Windows.Forms.Label();
            this.dgData = new System.Windows.Forms.DataGridView();
            this.FLP_Right = new System.Windows.Forms.FlowLayoutPanel();
            this.FLP_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.SuspendLayout();
            // 
            // FLP_Left
            // 
            this.FLP_Left.Controls.Add(this.BTN_ToStartForm);
            this.FLP_Left.Controls.Add(this.BTN_AddTable);
            this.FLP_Left.Controls.Add(this.LBL_TablesList);
            this.FLP_Left.Controls.Add(this.dgData);
            this.FLP_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.FLP_Left.Location = new System.Drawing.Point(0, 0);
            this.FLP_Left.MinimumSize = new System.Drawing.Size(243, 450);
            this.FLP_Left.Name = "FLP_Left";
            this.FLP_Left.Size = new System.Drawing.Size(243, 454);
            this.FLP_Left.TabIndex = 0;
            // 
            // BTN_ToStartForm
            // 
            this.BTN_ToStartForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_ToStartForm.Location = new System.Drawing.Point(3, 3);
            this.BTN_ToStartForm.Name = "BTN_ToStartForm";
            this.BTN_ToStartForm.Size = new System.Drawing.Size(226, 35);
            this.BTN_ToStartForm.TabIndex = 26;
            this.BTN_ToStartForm.Text = "К выбору подключения";
            this.BTN_ToStartForm.UseVisualStyleBackColor = true;
            this.BTN_ToStartForm.Click += new System.EventHandler(this.BTN_ToStartForm_Click);
            // 
            // BTN_AddTable
            // 
            this.BTN_AddTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_AddTable.Location = new System.Drawing.Point(3, 44);
            this.BTN_AddTable.Name = "BTN_AddTable";
            this.BTN_AddTable.Size = new System.Drawing.Size(226, 39);
            this.BTN_AddTable.TabIndex = 27;
            this.BTN_AddTable.Text = "Добавить таблицу";
            this.BTN_AddTable.UseVisualStyleBackColor = true;
            this.BTN_AddTable.Click += new System.EventHandler(this.BTN_AddTable_Click);
            // 
            // LBL_TablesList
            // 
            this.LBL_TablesList.AutoSize = true;
            this.LBL_TablesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBL_TablesList.Location = new System.Drawing.Point(3, 86);
            this.LBL_TablesList.Name = "LBL_TablesList";
            this.LBL_TablesList.Padding = new System.Windows.Forms.Padding(10);
            this.LBL_TablesList.Size = new System.Drawing.Size(154, 40);
            this.LBL_TablesList.TabIndex = 25;
            this.LBL_TablesList.Text = "Список таблиц";
            // 
            // dgData
            // 
            this.dgData.AllowUserToAddRows = false;
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Location = new System.Drawing.Point(3, 129);
            this.dgData.Name = "dgData";
            this.dgData.RowHeadersVisible = false;
            this.dgData.RowHeadersWidth = 51;
            this.dgData.RowTemplate.Height = 24;
            this.dgData.Size = new System.Drawing.Size(226, 185);
            this.dgData.TabIndex = 24;
            this.dgData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.f);
            this.dgData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgData_CellDoubleClick);
            // 
            // FLP_Right
            // 
            this.FLP_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.FLP_Right.Location = new System.Drawing.Point(249, 0);
            this.FLP_Right.MinimumSize = new System.Drawing.Size(449, 450);
            this.FLP_Right.Name = "FLP_Right";
            this.FLP_Right.Size = new System.Drawing.Size(515, 454);
            this.FLP_Right.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 454);
            this.Controls.Add(this.FLP_Left);
            this.Controls.Add(this.FLP_Right);
            this.MinimumSize = new System.Drawing.Size(782, 501);
            this.Name = "MainForm";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FLP_Left.ResumeLayout(false);
            this.FLP_Left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLP_Left;
        private System.Windows.Forms.FlowLayoutPanel FLP_Right;
        private System.Windows.Forms.Button BTN_AddTable;
        private System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.Button BTN_ToStartForm;
        private System.Windows.Forms.Label LBL_TablesList;
    }
}