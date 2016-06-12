namespace BazaDanych
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dodajUczestnikaBtn = new System.Windows.Forms.Button();
            this.tbDBAdress = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btnPolacz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(283, 26);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(876, 402);
            this.dataGridView1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(14, 182);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(261, 246);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dodajUczestnikaBtn
            // 
            this.dodajUczestnikaBtn.Location = new System.Drawing.Point(14, 443);
            this.dodajUczestnikaBtn.Name = "dodajUczestnikaBtn";
            this.dodajUczestnikaBtn.Size = new System.Drawing.Size(262, 25);
            this.dodajUczestnikaBtn.TabIndex = 2;
            this.dodajUczestnikaBtn.Text = "Dodaj uczestnika";
            this.dodajUczestnikaBtn.UseVisualStyleBackColor = true;
            this.dodajUczestnikaBtn.Click += new System.EventHandler(this.dodajUczestnikaBtn_Click);
            // 
            // tbDBAdress
            // 
            this.tbDBAdress.Location = new System.Drawing.Point(14, 26);
            this.tbDBAdress.Name = "tbDBAdress";
            this.tbDBAdress.Size = new System.Drawing.Size(186, 22);
            this.tbDBAdress.TabIndex = 3;
            this.tbDBAdress.Text = "localhost";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(100, 110);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(176, 22);
            this.tbPassword.TabIndex = 4;
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(206, 26);
            this.numPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(70, 22);
            this.numPort.TabIndex = 5;
            this.numPort.Value = new decimal(new int[] {
            1521,
            0,
            0,
            0});
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(99, 82);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(176, 22);
            this.tbUsername.TabIndex = 6;
            this.tbUsername.Text = "MARTA";
            // 
            // btnPolacz
            // 
            this.btnPolacz.Location = new System.Drawing.Point(201, 138);
            this.btnPolacz.Name = "btnPolacz";
            this.btnPolacz.Size = new System.Drawing.Size(75, 23);
            this.btnPolacz.TabIndex = 7;
            this.btnPolacz.Text = "Połącz";
            this.btnPolacz.UseVisualStyleBackColor = true;
            this.btnPolacz.Click += new System.EventHandler(this.btnPolacz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hasło";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Użytkownik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Port";
            // 
            // tbSID
            // 
            this.tbSID.Location = new System.Drawing.Point(100, 54);
            this.tbSID.Name = "tbSID";
            this.tbSID.Size = new System.Drawing.Size(175, 22);
            this.tbSID.TabIndex = 12;
            this.tbSID.Text = "xe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "SID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 481);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPolacz);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.numPort);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbDBAdress);
            this.Controls.Add(this.dodajUczestnikaBtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Baza danych Swing Revolution";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button dodajUczestnikaBtn;
        private System.Windows.Forms.TextBox tbDBAdress;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btnPolacz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSID;
        private System.Windows.Forms.Label label5;
    }
}

