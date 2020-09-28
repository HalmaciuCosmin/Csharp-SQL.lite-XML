namespace WindowsFormsApp1
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
            this.Conectare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Inserare = new System.Windows.Forms.Button();
            this.Actualizare = new System.Windows.Forms.Button();
            this.Deconectare = new System.Windows.Forms.Button();
            this.Stergere = new System.Windows.Forms.Button();
            this.Cautare = new System.Windows.Forms.Button();
            this.Nume = new System.Windows.Forms.TextBox();
            this.Prenume = new System.Windows.Forms.TextBox();
            this.CNP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Modificare = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Refresh = new System.Windows.Forms.Button();
            this.Import_XML = new System.Windows.Forms.Button();
            this.Export_XML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Conectare
            // 
            this.Conectare.Location = new System.Drawing.Point(16, 290);
            this.Conectare.Name = "Conectare";
            this.Conectare.Size = new System.Drawing.Size(87, 43);
            this.Conectare.TabIndex = 0;
            this.Conectare.Text = "Conectare";
            this.Conectare.UseVisualStyleBackColor = true;
            this.Conectare.Click += new System.EventHandler(this.Conectare_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(330, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(336, 449);
            this.dataGridView1.TabIndex = 1;
            // 
            // Inserare
            // 
            this.Inserare.Location = new System.Drawing.Point(116, 290);
            this.Inserare.Name = "Inserare";
            this.Inserare.Size = new System.Drawing.Size(87, 43);
            this.Inserare.TabIndex = 2;
            this.Inserare.Text = "Inserare";
            this.Inserare.UseVisualStyleBackColor = true;
            this.Inserare.Click += new System.EventHandler(this.Inserare_Click);
            // 
            // Actualizare
            // 
            this.Actualizare.Location = new System.Drawing.Point(223, 290);
            this.Actualizare.Name = "Actualizare";
            this.Actualizare.Size = new System.Drawing.Size(87, 43);
            this.Actualizare.TabIndex = 3;
            this.Actualizare.Text = "Actualizare";
            this.Actualizare.UseVisualStyleBackColor = true;
            this.Actualizare.Click += new System.EventHandler(this.Actualizare_Click);
            // 
            // Deconectare
            // 
            this.Deconectare.Location = new System.Drawing.Point(16, 349);
            this.Deconectare.Name = "Deconectare";
            this.Deconectare.Size = new System.Drawing.Size(87, 43);
            this.Deconectare.TabIndex = 4;
            this.Deconectare.Text = "Deconectare";
            this.Deconectare.UseVisualStyleBackColor = true;
            this.Deconectare.Click += new System.EventHandler(this.Deconectare_Click);
            // 
            // Stergere
            // 
            this.Stergere.Location = new System.Drawing.Point(116, 349);
            this.Stergere.Name = "Stergere";
            this.Stergere.Size = new System.Drawing.Size(87, 43);
            this.Stergere.TabIndex = 5;
            this.Stergere.Text = "Stergere";
            this.Stergere.UseVisualStyleBackColor = true;
            this.Stergere.Click += new System.EventHandler(this.Stergere_Click);
            // 
            // Cautare
            // 
            this.Cautare.Location = new System.Drawing.Point(223, 349);
            this.Cautare.Name = "Cautare";
            this.Cautare.Size = new System.Drawing.Size(87, 43);
            this.Cautare.TabIndex = 6;
            this.Cautare.Text = "Cautare";
            this.Cautare.UseVisualStyleBackColor = true;
            this.Cautare.Click += new System.EventHandler(this.Cautare_Click);
            // 
            // Nume
            // 
            this.Nume.Location = new System.Drawing.Point(111, 33);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(199, 20);
            this.Nume.TabIndex = 7;
            // 
            // Prenume
            // 
            this.Prenume.Location = new System.Drawing.Point(111, 94);
            this.Prenume.Name = "Prenume";
            this.Prenume.Size = new System.Drawing.Size(199, 20);
            this.Prenume.TabIndex = 8;
            // 
            // CNP
            // 
            this.CNP.Location = new System.Drawing.Point(111, 150);
            this.CNP.Name = "CNP";
            this.CNP.Size = new System.Drawing.Size(199, 20);
            this.CNP.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Prenume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "CNP";
            // 
            // Modificare
            // 
            this.Modificare.Location = new System.Drawing.Point(116, 245);
            this.Modificare.Name = "Modificare";
            this.Modificare.Size = new System.Drawing.Size(199, 20);
            this.Modificare.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Operatie";
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(223, 408);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(87, 43);
            this.Refresh.TabIndex = 14;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Import_XML
            // 
            this.Import_XML.Location = new System.Drawing.Point(16, 408);
            this.Import_XML.Name = "Import_XML";
            this.Import_XML.Size = new System.Drawing.Size(87, 43);
            this.Import_XML.TabIndex = 15;
            this.Import_XML.Text = "Import XML";
            this.Import_XML.UseVisualStyleBackColor = true;
            this.Import_XML.Click += new System.EventHandler(this.Import_XML_Click);
            // 
            // Export_XML
            // 
            this.Export_XML.Location = new System.Drawing.Point(116, 408);
            this.Export_XML.Name = "Export_XML";
            this.Export_XML.Size = new System.Drawing.Size(87, 43);
            this.Export_XML.TabIndex = 16;
            this.Export_XML.Text = "Export XML";
            this.Export_XML.UseVisualStyleBackColor = true;
            this.Export_XML.Click += new System.EventHandler(this.Export_XML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 464);
            this.Controls.Add(this.Export_XML);
            this.Controls.Add(this.Import_XML);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Modificare);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CNP);
            this.Controls.Add(this.Prenume);
            this.Controls.Add(this.Nume);
            this.Controls.Add(this.Cautare);
            this.Controls.Add(this.Stergere);
            this.Controls.Add(this.Deconectare);
            this.Controls.Add(this.Actualizare);
            this.Controls.Add(this.Inserare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Conectare);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Conectare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Inserare;
        private System.Windows.Forms.Button Actualizare;
        private System.Windows.Forms.Button Deconectare;
        private System.Windows.Forms.Button Stergere;
        private System.Windows.Forms.Button Cautare;
        private System.Windows.Forms.TextBox Nume;
        private System.Windows.Forms.TextBox Prenume;
        private System.Windows.Forms.TextBox CNP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Modificare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Import_XML;
        private System.Windows.Forms.Button Export_XML;
    }
}

