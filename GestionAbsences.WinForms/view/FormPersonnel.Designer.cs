namespace GestionAbsences.WinForms.view
{
    partial class FormPersonnel
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAbsences = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.btnAbsencesTous = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Gestion du Personnel";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAjouter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAjouter.Location = new System.Drawing.Point(12, 56);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(118, 38);
            this.btnAjouter.TabIndex = 15;
            this.btnAjouter.Text = "+ Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnModifier.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnModifier.Location = new System.Drawing.Point(260, 56);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(118, 38);
            this.btnModifier.TabIndex = 16;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.IndianRed;
            this.btnSupprimer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSupprimer.Location = new System.Drawing.Point(136, 56);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(118, 38);
            this.btnSupprimer.TabIndex = 17;
            this.btnSupprimer.Text = "- Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAbsences
            // 
            this.btnAbsences.BackColor = System.Drawing.Color.MediumPurple;
            this.btnAbsences.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAbsences.FlatAppearance.BorderSize = 0;
            this.btnAbsences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbsences.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbsences.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAbsences.Location = new System.Drawing.Point(384, 57);
            this.btnAbsences.Name = "btnAbsences";
            this.btnAbsences.Size = new System.Drawing.Size(200, 38);
            this.btnAbsences.TabIndex = 18;
            this.btnAbsences.Text = "Gestion des Absences";
            this.btnAbsences.UseVisualStyleBackColor = false;
            this.btnAbsences.Click += new System.EventHandler(this.btnAbsences_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(12, 108);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(668, 247);
            this.DataGridView.TabIndex = 19;
            // 
            // btnAbsencesTous
            // 
            this.btnAbsencesTous.BackColor = System.Drawing.Color.Gray;
            this.btnAbsencesTous.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAbsencesTous.FlatAppearance.BorderSize = 0;
            this.btnAbsencesTous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbsencesTous.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbsencesTous.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAbsencesTous.Location = new System.Drawing.Point(590, 57);
            this.btnAbsencesTous.Name = "btnAbsencesTous";
            this.btnAbsencesTous.Size = new System.Drawing.Size(90, 38);
            this.btnAbsencesTous.TabIndex = 20;
            this.btnAbsencesTous.Text = "Toutes les absences";
            this.btnAbsencesTous.UseVisualStyleBackColor = false;
            this.btnAbsencesTous.Click += new System.EventHandler(this.btnAbsencesTous_Click);
            // 
            // FormPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(701, 370);
            this.Controls.Add(this.btnAbsencesTous);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.btnAbsences);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label4);
            this.Name = "FormPersonnel";
            this.Text = "FormPersonnel";
            this.Load += new System.EventHandler(this.FormPersonnel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAbsences;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button btnAbsencesTous;
    }
}