
namespace APT
{
    partial class PregledBiljeskeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PregledBiljeskeForm));
            this.btnPovratak = new System.Windows.Forms.Button();
            this.txtBiljeska = new System.Windows.Forms.TextBox();
            this.btnSpremiPromjene = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPovratak.Location = new System.Drawing.Point(622, 399);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(150, 50);
            this.btnPovratak.TabIndex = 7;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // txtBiljeska
            // 
            this.txtBiljeska.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBiljeska.ForeColor = System.Drawing.Color.Black;
            this.txtBiljeska.Location = new System.Drawing.Point(12, 12);
            this.txtBiljeska.Multiline = true;
            this.txtBiljeska.Name = "txtBiljeska";
            this.txtBiljeska.Size = new System.Drawing.Size(760, 381);
            this.txtBiljeska.TabIndex = 8;
            this.txtBiljeska.TextChanged += new System.EventHandler(this.txtBiljeska_TextChanged);
            // 
            // btnSpremiPromjene
            // 
            this.btnSpremiPromjene.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSpremiPromjene.Location = new System.Drawing.Point(12, 399);
            this.btnSpremiPromjene.Name = "btnSpremiPromjene";
            this.btnSpremiPromjene.Size = new System.Drawing.Size(150, 50);
            this.btnSpremiPromjene.TabIndex = 9;
            this.btnSpremiPromjene.Text = "Spremi promjene";
            this.btnSpremiPromjene.UseVisualStyleBackColor = false;
            this.btnSpremiPromjene.Visible = false;
            this.btnSpremiPromjene.Click += new System.EventHandler(this.btnSpremiPromjene_Click);
            // 
            // PregledBiljeskeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::APT.Properties.Resources.logo_transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.ControlBox = false;
            this.Controls.Add(this.btnSpremiPromjene);
            this.Controls.Add(this.txtBiljeska);
            this.Controls.Add(this.btnPovratak);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PregledBiljeskeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PregledBiljeskeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.TextBox txtBiljeska;
        private System.Windows.Forms.Button btnSpremiPromjene;
    }
}