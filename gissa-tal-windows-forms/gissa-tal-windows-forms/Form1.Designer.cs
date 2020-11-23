
namespace gissa_tal_windows_forms
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
            this.kontrollera = new System.Windows.Forms.Button();
            this.beskrivning = new System.Windows.Forms.Label();
            this.gissningarResultat = new System.Windows.Forms.Label();
            this.svar = new System.Windows.Forms.Label();
            this.gissning = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // kontrollera
            // 
            this.kontrollera.Location = new System.Drawing.Point(412, 174);
            this.kontrollera.Name = "kontrollera";
            this.kontrollera.Size = new System.Drawing.Size(75, 23);
            this.kontrollera.TabIndex = 0;
            this.kontrollera.Text = "kontrollera";
            this.kontrollera.UseVisualStyleBackColor = true;
            this.kontrollera.Click += new System.EventHandler(this.kontrollera_Click);
            // 
            // beskrivning
            // 
            this.beskrivning.AutoSize = true;
            this.beskrivning.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beskrivning.Location = new System.Drawing.Point(183, 26);
            this.beskrivning.Name = "beskrivning";
            this.beskrivning.Size = new System.Drawing.Size(436, 37);
            this.beskrivning.TabIndex = 1;
            this.beskrivning.Text = "Gissa ett tal mellan 1 och 100";
            // 
            // gissningarResultat
            // 
            this.gissningarResultat.AutoSize = true;
            this.gissningarResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gissningarResultat.Location = new System.Drawing.Point(203, 120);
            this.gissningarResultat.Name = "gissningarResultat";
            this.gissningarResultat.Size = new System.Drawing.Size(497, 29);
            this.gissningarResultat.TabIndex = 2;
            this.gissningarResultat.Text = "Du klarade det på: Du har inte klarat det ännu.";
            // 
            // svar
            // 
            this.svar.AutoSize = true;
            this.svar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.svar.Location = new System.Drawing.Point(201, 76);
            this.svar.Name = "svar";
            this.svar.Size = new System.Drawing.Size(394, 29);
            this.svar.TabIndex = 3;
            this.svar.Text = "Du gissade: Du har inte gissat ännu.";
            // 
            // gissning
            // 
            this.gissning.Location = new System.Drawing.Point(261, 174);
            this.gissning.Name = "gissning";
            this.gissning.Size = new System.Drawing.Size(100, 20);
            this.gissning.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gissning);
            this.Controls.Add(this.svar);
            this.Controls.Add(this.gissningarResultat);
            this.Controls.Add(this.beskrivning);
            this.Controls.Add(this.kontrollera);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kontrollera;
        private System.Windows.Forms.Label beskrivning;
        private System.Windows.Forms.Label gissningarResultat;
        private System.Windows.Forms.Label svar;
        private System.Windows.Forms.TextBox gissning;
    }
}

