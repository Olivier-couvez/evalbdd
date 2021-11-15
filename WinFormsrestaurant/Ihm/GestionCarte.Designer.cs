
namespace WinFormsrestaurant.Ihm
{
    partial class GestionCarte
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
            this.btnaccueil = new System.Windows.Forms.Button();
            this.btnCat = new System.Windows.Forms.Button();
            this.dataGridCarte = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCarte)).BeginInit();
            this.SuspendLayout();
            // 
            // btnaccueil
            // 
            this.btnaccueil.Location = new System.Drawing.Point(40, 30);
            this.btnaccueil.Name = "btnaccueil";
            this.btnaccueil.Size = new System.Drawing.Size(133, 49);
            this.btnaccueil.TabIndex = 0;
            this.btnaccueil.Text = "Accueil";
            this.btnaccueil.UseVisualStyleBackColor = true;
            this.btnaccueil.Click += new System.EventHandler(this.btnaccueil_Click);
            // 
            // btnCat
            // 
            this.btnCat.Location = new System.Drawing.Point(616, 30);
            this.btnCat.Name = "btnCat";
            this.btnCat.Size = new System.Drawing.Size(157, 49);
            this.btnCat.TabIndex = 1;
            this.btnCat.Text = "Gérer les catégories";
            this.btnCat.UseVisualStyleBackColor = true;
            this.btnCat.Click += new System.EventHandler(this.btnCat_Click);
            // 
            // dataGridCarte
            // 
            this.dataGridCarte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCarte.Location = new System.Drawing.Point(40, 125);
            this.dataGridCarte.Name = "dataGridCarte";
            this.dataGridCarte.RowTemplate.Height = 25;
            this.dataGridCarte.Size = new System.Drawing.Size(698, 248);
            this.dataGridCarte.TabIndex = 2;
            // 
            // GestionCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridCarte);
            this.Controls.Add(this.btnCat);
            this.Controls.Add(this.btnaccueil);
            this.Name = "GestionCarte";
            this.Text = "GestionCarte";
            this.Load += new System.EventHandler(this.GestionCarte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCarte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnaccueil;
        private System.Windows.Forms.Button btnCat;
        private System.Windows.Forms.DataGridView dataGridCarte;
    }
}