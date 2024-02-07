namespace VS.Del3_Sanne
{
    partial class fEndrePassord
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
            this.txtNyttPassord = new System.Windows.Forms.TextBox();
            this.btnAngre = new System.Windows.Forms.Button();
            this.btnOK2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Skriv inn nytt passord:";
            // 
            // txtNyttPassord
            // 
            this.txtNyttPassord.Location = new System.Drawing.Point(186, 70);
            this.txtNyttPassord.Name = "txtNyttPassord";
            this.txtNyttPassord.Size = new System.Drawing.Size(152, 20);
            this.txtNyttPassord.TabIndex = 1;
            // 
            // btnAngre
            // 
            this.btnAngre.Location = new System.Drawing.Point(182, 122);
            this.btnAngre.Name = "btnAngre";
            this.btnAngre.Size = new System.Drawing.Size(75, 23);
            this.btnAngre.TabIndex = 2;
            this.btnAngre.Text = "Angre";
            this.btnAngre.UseVisualStyleBackColor = true;
            this.btnAngre.Click += new System.EventHandler(this.btnAngre_Click);
            // 
            // btnOK2
            // 
            this.btnOK2.Location = new System.Drawing.Point(263, 122);
            this.btnOK2.Name = "btnOK2";
            this.btnOK2.Size = new System.Drawing.Size(75, 23);
            this.btnOK2.TabIndex = 3;
            this.btnOK2.Text = "OK";
            this.btnOK2.UseVisualStyleBackColor = true;
            this.btnOK2.Click += new System.EventHandler(this.btnOK2_Click);
            // 
            // fEndrePassord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 212);
            this.Controls.Add(this.btnOK2);
            this.Controls.Add(this.btnAngre);
            this.Controls.Add(this.txtNyttPassord);
            this.Controls.Add(this.label1);
            this.Name = "fEndrePassord";
            this.Text = "EndrePassord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNyttPassord;
        private System.Windows.Forms.Button btnAngre;
        private System.Windows.Forms.Button btnOK2;
    }
}