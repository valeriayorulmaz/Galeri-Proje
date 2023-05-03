namespace WindowsFormsApp1
{
    partial class Raporlama
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şubelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Peru;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.araçlarToolStripMenuItem,
            this.müşterilerToolStripMenuItem,
            this.şubelerToolStripMenuItem,
            this.raporlamaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1104, 27);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // araçlarToolStripMenuItem
            // 
            this.araçlarToolStripMenuItem.Name = "araçlarToolStripMenuItem";
            this.araçlarToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.araçlarToolStripMenuItem.Text = "Araçlar";
            this.araçlarToolStripMenuItem.Click += new System.EventHandler(this.araçlarToolStripMenuItem_Click);
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(90, 23);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            this.müşterilerToolStripMenuItem.Click += new System.EventHandler(this.müşterilerToolStripMenuItem_Click);
            // 
            // şubelerToolStripMenuItem
            // 
            this.şubelerToolStripMenuItem.Name = "şubelerToolStripMenuItem";
            this.şubelerToolStripMenuItem.Size = new System.Drawing.Size(74, 23);
            this.şubelerToolStripMenuItem.Text = "Şubeler";
            this.şubelerToolStripMenuItem.Click += new System.EventHandler(this.şubelerToolStripMenuItem_Click);
            // 
            // raporlamaToolStripMenuItem
            // 
            this.raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            this.raporlamaToolStripMenuItem.Size = new System.Drawing.Size(97, 23);
            this.raporlamaToolStripMenuItem.Text = "Raporlama";
            this.raporlamaToolStripMenuItem.Click += new System.EventHandler(this.raporlamaToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(314, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(676, 182);
            this.dataGridView1.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SaddleBrown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 66);
            this.button1.TabIndex = 35;
            this.button1.Text = "Şubeler ve Araçlar Verilerini Birleştir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SaddleBrown;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(12, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(292, 66);
            this.button2.TabIndex = 36;
            this.button2.Text = "Müşteri Bakiyelerini Küçükten Büyüğe Sırala";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SaddleBrown;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(12, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(292, 66);
            this.button3.TabIndex = 37;
            this.button3.Text = "Şubelerin Ciro Ortalaması";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SaddleBrown;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(12, 322);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(292, 66);
            this.button4.TabIndex = 38;
            this.button4.Text = "Alfabetik Sıraya Göre Müşterileri Adları ve Aldıkları Araçlar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SaddleBrown;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(12, 400);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(292, 66);
            this.button5.TabIndex = 39;
            this.button5.Text = "Şubelere Göre Müşteri Listesi";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Raporlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1104, 611);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Raporlama";
            this.Text = "Raporlama";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şubelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}