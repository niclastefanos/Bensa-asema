namespace bensis
{
    partial class Laatu
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
            this.label1 = new System.Windows.Forms.Label();
            this.ysivitonen = new System.Windows.Forms.Button();
            this.ysikasi = new System.Windows.Forms.Button();
            this.diesel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "FuelMaster";
            // 
            // ysivitonen
            // 
            this.ysivitonen.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ysivitonen.Location = new System.Drawing.Point(182, 90);
            this.ysivitonen.Name = "ysivitonen";
            this.ysivitonen.Size = new System.Drawing.Size(243, 95);
            this.ysivitonen.TabIndex = 2;
            this.ysivitonen.Text = "95";
            this.ysivitonen.UseVisualStyleBackColor = true;
            this.ysivitonen.Click += new System.EventHandler(this.ysivitonen_Click);
            // 
            // ysikasi
            // 
            this.ysikasi.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ysikasi.Location = new System.Drawing.Point(182, 191);
            this.ysikasi.Name = "ysikasi";
            this.ysikasi.Size = new System.Drawing.Size(243, 95);
            this.ysikasi.TabIndex = 3;
            this.ysikasi.Text = "98";
            this.ysikasi.UseVisualStyleBackColor = true;
            this.ysikasi.Click += new System.EventHandler(this.ysikasi_Click);
            // 
            // diesel
            // 
            this.diesel.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diesel.Location = new System.Drawing.Point(182, 292);
            this.diesel.Name = "diesel";
            this.diesel.Size = new System.Drawing.Size(243, 95);
            this.diesel.TabIndex = 4;
            this.diesel.Text = "Diesel";
            this.diesel.UseVisualStyleBackColor = true;
            this.diesel.Click += new System.EventHandler(this.diesel_Click);
            // 
            // Laatu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(609, 465);
            this.Controls.Add(this.diesel);
            this.Controls.Add(this.ysikasi);
            this.Controls.Add(this.ysivitonen);
            this.Controls.Add(this.label1);
            this.Name = "Laatu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Laatu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ysivitonen;
        private System.Windows.Forms.Button ysikasi;
        private System.Windows.Forms.Button diesel;
    }
}