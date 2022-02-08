namespace Kolekcija_List
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
            this.buttonUnos = new System.Windows.Forms.Button();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxRazred = new System.Windows.Forms.ComboBox();
            this.buttonPregled = new System.Windows.Forms.Button();
            this.buttonObrada = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonUnos
            // 
            this.buttonUnos.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnos.Location = new System.Drawing.Point(411, 27);
            this.buttonUnos.Name = "buttonUnos";
            this.buttonUnos.Size = new System.Drawing.Size(137, 80);
            this.buttonUnos.TabIndex = 0;
            this.buttonUnos.Text = "Unos";
            this.buttonUnos.UseVisualStyleBackColor = true;
            this.buttonUnos.Click += new System.EventHandler(this.buttonUnos_Click);
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(92, 27);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(294, 20);
            this.textBoxIme.TabIndex = 1;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(92, 53);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(294, 20);
            this.textBoxPrezime.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prezime";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Razred";
            // 
            // comboBoxRazred
            // 
            this.comboBoxRazred.FormattingEnabled = true;
            this.comboBoxRazred.Items.AddRange(new object[] {
            "1.",
            "2.",
            "3.",
            "4."});
            this.comboBoxRazred.Location = new System.Drawing.Point(92, 86);
            this.comboBoxRazred.Name = "comboBoxRazred";
            this.comboBoxRazred.Size = new System.Drawing.Size(294, 21);
            this.comboBoxRazred.TabIndex = 6;
            // 
            // buttonPregled
            // 
            this.buttonPregled.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPregled.Location = new System.Drawing.Point(554, 27);
            this.buttonPregled.Name = "buttonPregled";
            this.buttonPregled.Size = new System.Drawing.Size(114, 80);
            this.buttonPregled.TabIndex = 7;
            this.buttonPregled.Text = "Pregled";
            this.buttonPregled.UseVisualStyleBackColor = true;
            this.buttonPregled.Click += new System.EventHandler(this.buttonPregled_Click);
            // 
            // buttonObrada
            // 
            this.buttonObrada.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObrada.Location = new System.Drawing.Point(674, 27);
            this.buttonObrada.Name = "buttonObrada";
            this.buttonObrada.Size = new System.Drawing.Size(128, 80);
            this.buttonObrada.TabIndex = 8;
            this.buttonObrada.Text = "Obrada";
            this.buttonObrada.UseVisualStyleBackColor = true;
            this.buttonObrada.Click += new System.EventHandler(this.buttonObrada_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 125);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(861, 172);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 309);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonObrada);
            this.Controls.Add(this.buttonPregled);
            this.Controls.Add(this.comboBoxRazred);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.buttonUnos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUnos;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxRazred;
        private System.Windows.Forms.Button buttonPregled;
        private System.Windows.Forms.Button buttonObrada;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

