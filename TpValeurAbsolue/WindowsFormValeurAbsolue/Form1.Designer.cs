namespace WindowsFormValeurAbsolue
{
    partial class Form1
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
            this.txtSaisie = new System.Windows.Forms.Label();
            this.boxSaisie = new System.Windows.Forms.TextBox();
            this.bntCalculer = new System.Windows.Forms.Button();
            this.txtAffiche = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSaisie
            // 
            this.txtSaisie.AutoSize = true;
            this.txtSaisie.Location = new System.Drawing.Point(38, 36);
            this.txtSaisie.Name = "txtSaisie";
            this.txtSaisie.Size = new System.Drawing.Size(105, 13);
            this.txtSaisie.TabIndex = 0;
            this.txtSaisie.Text = "Saisir un nombre réel";
            this.txtSaisie.Click += new System.EventHandler(this.label1_Click);
            // 
            // boxSaisie
            // 
            this.boxSaisie.Location = new System.Drawing.Point(162, 33);
            this.boxSaisie.Name = "boxSaisie";
            this.boxSaisie.Size = new System.Drawing.Size(100, 20);
            this.boxSaisie.TabIndex = 1;
            // 
            // bntCalculer
            // 
            this.bntCalculer.Location = new System.Drawing.Point(103, 91);
            this.bntCalculer.Name = "bntCalculer";
            this.bntCalculer.Size = new System.Drawing.Size(75, 23);
            this.bntCalculer.TabIndex = 2;
            this.bntCalculer.Text = "Calculer";
            this.bntCalculer.UseVisualStyleBackColor = true;
            this.bntCalculer.Click += new System.EventHandler(this.bntCalculer_Click);
            // 
            // txtAffiche
            // 
            this.txtAffiche.AutoSize = true;
            this.txtAffiche.Location = new System.Drawing.Point(38, 134);
            this.txtAffiche.Name = "txtAffiche";
            this.txtAffiche.Size = new System.Drawing.Size(168, 13);
            this.txtAffiche.TabIndex = 3;
            this.txtAffiche.Text = "Valeur absolue du nombre saisie : ";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(212, 131);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(50, 20);
            this.txtResult.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtAffiche);
            this.Controls.Add(this.bntCalculer);
            this.Controls.Add(this.boxSaisie);
            this.Controls.Add(this.txtSaisie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtSaisie;
        private System.Windows.Forms.TextBox boxSaisie;
        private System.Windows.Forms.Button bntCalculer;
        private System.Windows.Forms.Label txtAffiche;
        private System.Windows.Forms.TextBox txtResult;
    }
}

