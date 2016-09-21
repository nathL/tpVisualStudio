namespace WindowsFormsTpNombresArmstrong
{
    partial class TxtNbrArmstrong
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalculer = new System.Windows.Forms.Button();
            this.listBoxNbrArmstrong = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCalculer
            // 
            this.btnCalculer.Location = new System.Drawing.Point(102, 159);
            this.btnCalculer.Name = "btnCalculer";
            this.btnCalculer.Size = new System.Drawing.Size(75, 23);
            this.btnCalculer.TabIndex = 1;
            this.btnCalculer.Text = "Calculer";
            this.btnCalculer.UseVisualStyleBackColor = true;
            this.btnCalculer.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxNbrArmstrong
            // 
            this.listBoxNbrArmstrong.FormattingEnabled = true;
            this.listBoxNbrArmstrong.Location = new System.Drawing.Point(82, 43);
            this.listBoxNbrArmstrong.Name = "listBoxNbrArmstrong";
            this.listBoxNbrArmstrong.Size = new System.Drawing.Size(120, 95);
            this.listBoxNbrArmstrong.TabIndex = 2;
            // 
            // TxtNbrArmstrong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.listBoxNbrArmstrong);
            this.Controls.Add(this.btnCalculer);
            this.Name = "TxtNbrArmstrong";
            this.Text = "Nombres de Armstrong";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCalculer;
        private System.Windows.Forms.ListBox listBoxNbrArmstrong;
    }
}

