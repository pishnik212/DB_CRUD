namespace DB_
{
    partial class StartForm
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
            this.BTN_Connect = new System.Windows.Forms.Button();
            this.TB_DataBaseName = new System.Windows.Forms.TextBox();
            this.LBL_Connection = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Server = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_password = new System.Windows.Forms.TextBox();
            this.BTN_Default = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_Connect
            // 
            this.BTN_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_Connect.Location = new System.Drawing.Point(318, 325);
            this.BTN_Connect.Name = "BTN_Connect";
            this.BTN_Connect.Size = new System.Drawing.Size(168, 31);
            this.BTN_Connect.TabIndex = 16;
            this.BTN_Connect.Text = "Подключиться";
            this.BTN_Connect.UseVisualStyleBackColor = true;
            this.BTN_Connect.Click += new System.EventHandler(this.BTN_Connect_Click);
            // 
            // TB_DataBaseName
            // 
            this.TB_DataBaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_DataBaseName.Location = new System.Drawing.Point(224, 275);
            this.TB_DataBaseName.MaxLength = 30;
            this.TB_DataBaseName.Name = "TB_DataBaseName";
            this.TB_DataBaseName.Size = new System.Drawing.Size(262, 30);
            this.TB_DataBaseName.TabIndex = 15;
            // 
            // LBL_Connection
            // 
            this.LBL_Connection.AutoSize = true;
            this.LBL_Connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBL_Connection.Location = new System.Drawing.Point(109, 29);
            this.LBL_Connection.Name = "LBL_Connection";
            this.LBL_Connection.Size = new System.Drawing.Size(330, 20);
            this.LBL_Connection.TabIndex = 14;
            this.LBL_Connection.Text = "Введите информацию о базе данных:";
            this.LBL_Connection.Click += new System.EventHandler(this.LBL_Connection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Имя базы данных:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Порт:";
            // 
            // TB_port
            // 
            this.TB_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_port.Location = new System.Drawing.Point(224, 125);
            this.TB_port.MaxLength = 30;
            this.TB_port.Name = "TB_port";
            this.TB_port.Size = new System.Drawing.Size(262, 30);
            this.TB_port.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(18, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Имя хоста:";
            // 
            // TB_Server
            // 
            this.TB_Server.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Server.Location = new System.Drawing.Point(224, 75);
            this.TB_Server.MaxLength = 30;
            this.TB_Server.Name = "TB_Server";
            this.TB_Server.Size = new System.Drawing.Size(262, 30);
            this.TB_Server.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(18, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Имя пользователя:";
            // 
            // TB_username
            // 
            this.TB_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_username.Location = new System.Drawing.Point(224, 172);
            this.TB_username.MaxLength = 30;
            this.TB_username.Name = "TB_username";
            this.TB_username.Size = new System.Drawing.Size(262, 30);
            this.TB_username.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(18, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Пароль:";
            // 
            // TB_password
            // 
            this.TB_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_password.Location = new System.Drawing.Point(224, 224);
            this.TB_password.MaxLength = 30;
            this.TB_password.Name = "TB_password";
            this.TB_password.PasswordChar = '*';
            this.TB_password.Size = new System.Drawing.Size(262, 30);
            this.TB_password.TabIndex = 24;
            // 
            // BTN_Default
            // 
            this.BTN_Default.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_Default.Location = new System.Drawing.Point(21, 325);
            this.BTN_Default.Name = "BTN_Default";
            this.BTN_Default.Size = new System.Drawing.Size(168, 31);
            this.BTN_Default.TabIndex = 26;
            this.BTN_Default.Text = "По умолчанию";
            this.BTN_Default.UseVisualStyleBackColor = true;
            this.BTN_Default.Click += new System.EventHandler(this.BTN_Default_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 372);
            this.Controls.Add(this.BTN_Default);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_Server);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_port);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Connect);
            this.Controls.Add(this.TB_DataBaseName);
            this.Controls.Add(this.LBL_Connection);
            this.MinimumSize = new System.Drawing.Size(540, 224);
            this.Name = "StartForm";
            this.Text = "Подключение к базе данных";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Connect;
        private System.Windows.Forms.TextBox TB_DataBaseName;
        private System.Windows.Forms.Label LBL_Connection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Server;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_password;
        private System.Windows.Forms.Button BTN_Default;
    }
}