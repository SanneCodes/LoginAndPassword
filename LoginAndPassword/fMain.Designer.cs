﻿namespace VS.Del3_Sanne
{
    partial class fMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oppsettToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endrePassordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hjelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrukernavn = new System.Windows.Forms.TextBox();
            this.txtPassord = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAvslutt = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oppsettToolStripMenuItem,
            this.hjelpToolStripMenuItem,
            this.omToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(440, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oppsettToolStripMenuItem
            // 
            this.oppsettToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.endrePassordToolStripMenuItem});
            this.oppsettToolStripMenuItem.Name = "oppsettToolStripMenuItem";
            this.oppsettToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.oppsettToolStripMenuItem.Text = "Oppsett";
            // 
            // endrePassordToolStripMenuItem
            // 
            this.endrePassordToolStripMenuItem.Name = "endrePassordToolStripMenuItem";
            this.endrePassordToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.endrePassordToolStripMenuItem.Text = "Endre Passord";
            this.endrePassordToolStripMenuItem.Click += new System.EventHandler(this.endrePassordToolStripMenuItem_Click);
            // 
            // hjelpToolStripMenuItem
            // 
            this.hjelpToolStripMenuItem.Name = "hjelpToolStripMenuItem";
            this.hjelpToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.hjelpToolStripMenuItem.Text = "Hjelp";
            // 
            // omToolStripMenuItem
            // 
            this.omToolStripMenuItem.Name = "omToolStripMenuItem";
            this.omToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.omToolStripMenuItem.Text = "Om";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Brukernavn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Passord";
            // 
            // txtBrukernavn
            // 
            this.txtBrukernavn.Location = new System.Drawing.Point(124, 64);
            this.txtBrukernavn.Name = "txtBrukernavn";
            this.txtBrukernavn.Size = new System.Drawing.Size(100, 20);
            this.txtBrukernavn.TabIndex = 3;
            // 
            // txtPassord
            // 
            this.txtPassord.Location = new System.Drawing.Point(124, 124);
            this.txtPassord.Name = "txtPassord";
            this.txtPassord.Size = new System.Drawing.Size(100, 20);
            this.txtPassord.TabIndex = 4;
            this.txtPassord.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtPassord_PreviewKeyDown);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(264, 60);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAvslutt
            // 
            this.btnAvslutt.Location = new System.Drawing.Point(264, 124);
            this.btnAvslutt.Name = "btnAvslutt";
            this.btnAvslutt.Size = new System.Drawing.Size(75, 23);
            this.btnAvslutt.TabIndex = 6;
            this.btnAvslutt.Text = "Avslutt";
            this.btnAvslutt.UseVisualStyleBackColor = true;
            this.btnAvslutt.Click += new System.EventHandler(this.btnAvslutt_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 212);
            this.Controls.Add(this.btnAvslutt);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPassord);
            this.Controls.Add(this.txtBrukernavn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oppsettToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hjelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem omToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrukernavn;
        private System.Windows.Forms.TextBox txtPassord;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAvslutt;
        private System.Windows.Forms.ToolStripMenuItem endrePassordToolStripMenuItem;
    }
}

