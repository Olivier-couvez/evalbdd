
namespace WinFormsrestaurant.Ihm
{
    partial class GestCategorie
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
            this.dataGridCategorie = new System.Windows.Forms.DataGridView();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategorie)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCategorie
            // 
            this.dataGridCategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCategorie.Location = new System.Drawing.Point(66, 115);
            this.dataGridCategorie.Name = "dataGridCategorie";
            this.dataGridCategorie.RowTemplate.Height = 25;
            this.dataGridCategorie.Size = new System.Drawing.Size(640, 236);
            this.dataGridCategorie.TabIndex = 0;
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(66, 371);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(160, 49);
            this.btnAjout.TabIndex = 1;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(321, 371);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(160, 49);
            this.btnModif.TabIndex = 2;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(559, 371);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(160, 49);
            this.btnSupp.TabIndex = 3;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(66, 23);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(133, 49);
            this.btnRetour.TabIndex = 4;
            this.btnRetour.Text = "Retour Article";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // GestCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.dataGridCategorie);
            this.Name = "GestCategorie";
            this.Text = "GestCategorie";
            this.Load += new System.EventHandler(this.GestCategorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategorie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCategorie;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnRetour;
    }
}