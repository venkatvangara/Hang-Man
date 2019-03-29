namespace HangMan_WinForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelChances = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.word = new System.Windows.Forms.Label();
            this.hist = new System.Windows.Forms.Label();
            this.histo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(76, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 110);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelChances
            // 
            this.labelChances.AutoSize = true;
            this.labelChances.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChances.Location = new System.Drawing.Point(70, 135);
            this.labelChances.Name = "labelChances";
            this.labelChances.Size = new System.Drawing.Size(30, 33);
            this.labelChances.TabIndex = 1;
            this.labelChances.Text = "6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "chances";
            // 
            // word
            // 
            this.word.AutoSize = true;
            this.word.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word.Location = new System.Drawing.Point(123, 188);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(178, 33);
            this.word.TabIndex = 3;
            this.word.Text = "word to guess";
            // 
            // hist
            // 
            this.hist.AutoSize = true;
            this.hist.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hist.Location = new System.Drawing.Point(12, 243);
            this.hist.Name = "hist";
            this.hist.Size = new System.Drawing.Size(122, 33);
            this.hist.TabIndex = 5;
            this.hist.Text = "Historic : ";
            // 
            // histo
            // 
            this.histo.AutoSize = true;
            this.histo.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.histo.Location = new System.Drawing.Point(123, 243);
            this.histo.Name = "histo";
            this.histo.Size = new System.Drawing.Size(85, 33);
            this.histo.TabIndex = 6;
            this.histo.Text = "*****";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Word :  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 307);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.histo);
            this.Controls.Add(this.hist);
            this.Controls.Add(this.word);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelChances);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "HangMan";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelChances;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label word;
        private System.Windows.Forms.Label hist;
        private System.Windows.Forms.Label histo;
        private System.Windows.Forms.Label label2;
    }
}

