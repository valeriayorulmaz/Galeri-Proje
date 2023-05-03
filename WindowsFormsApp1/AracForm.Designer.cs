namespace WindowsFormsApp1
{
    partial class AracForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracForm));
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şubelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Brown;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(229, 530);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 35);
            this.button5.TabIndex = 20;
            this.button5.Text = "Arama";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Brown;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(229, 474);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 35);
            this.button4.TabIndex = 19;
            this.button4.Text = "Güncelle";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Brown;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(368, 474);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 35);
            this.button3.TabIndex = 18;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Brown;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(229, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 35);
            this.button2.TabIndex = 17;
            this.button2.Text = "Listele";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(97, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(120, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(559, 185);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(131, 169);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 29);
            this.textBox5.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(33, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "Yıl :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(131, 69);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 29);
            this.textBox4.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(33, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Model :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(131, 34);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 29);
            this.textBox3.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(33, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Marka :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 29);
            this.textBox2.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(33, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Adet :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Fiyat :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.IndianRed;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.araçlarToolStripMenuItem,
            this.müşterilerToolStripMenuItem,
            this.şubelerToolStripMenuItem,
            this.raporlamaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1104, 27);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // araçlarToolStripMenuItem
            // 
            this.araçlarToolStripMenuItem.Name = "araçlarToolStripMenuItem";
            this.araçlarToolStripMenuItem.Size = new System.Drawing.Size(66, 23);
            this.araçlarToolStripMenuItem.Text = "Araçlar";
            this.araçlarToolStripMenuItem.Click += new System.EventHandler(this.araçlarToolStripMenuItem_Click);
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(82, 23);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            this.müşterilerToolStripMenuItem.Click += new System.EventHandler(this.müşterilerToolStripMenuItem_Click);
            // 
            // şubelerToolStripMenuItem
            // 
            this.şubelerToolStripMenuItem.Name = "şubelerToolStripMenuItem";
            this.şubelerToolStripMenuItem.Size = new System.Drawing.Size(67, 23);
            this.şubelerToolStripMenuItem.Text = "Şubeler";
            this.şubelerToolStripMenuItem.Click += new System.EventHandler(this.şubelerToolStripMenuItem_Click);
            // 
            // raporlamaToolStripMenuItem
            // 
            this.raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            this.raporlamaToolStripMenuItem.Size = new System.Drawing.Size(87, 23);
            this.raporlamaToolStripMenuItem.Text = "Raporlama";
            this.raporlamaToolStripMenuItem.Click += new System.EventHandler(this.raporlamaToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(716, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 289);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Bilgisi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(131, 239);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 29);
            this.textBox7.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(33, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 19);
            this.label7.TabIndex = 34;
            this.label7.Text = "Müşteri No :";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(131, 204);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 29);
            this.textBox6.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(33, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "Şube No :";
            // 
            // AracForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1104, 611);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "AracForm";
            this.Text = "AracForm";
            this.Load += new System.EventHandler(this.AracForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şubelerToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
    }
}