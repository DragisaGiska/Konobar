namespace _22._4._2014.kafic
{
    partial class Konobar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Konobar));
            this.pictureBoxKonobar = new System.Windows.Forms.PictureBox();
            this.labelKonobar = new System.Windows.Forms.Label();
            this.listBoxPonuda = new System.Windows.Forms.ListBox();
            this.groupBoxPonuda = new System.Windows.Forms.GroupBox();
            this.groupBoxRacun = new System.Windows.Forms.GroupBox();
            this.listBoxRacun = new System.Windows.Forms.ListBox();
            this.buttonPonudaURacun = new System.Windows.Forms.Button();
            this.buttonIzbaciIzRacuna = new System.Windows.Forms.Button();
            this.buttonIzdajRacun = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKonobar)).BeginInit();
            this.groupBoxPonuda.SuspendLayout();
            this.groupBoxRacun.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxKonobar
            // 
            this.pictureBoxKonobar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxKonobar.Image")));
            this.pictureBoxKonobar.Location = new System.Drawing.Point(12, 22);
            this.pictureBoxKonobar.Name = "pictureBoxKonobar";
            this.pictureBoxKonobar.Size = new System.Drawing.Size(164, 166);
            this.pictureBoxKonobar.TabIndex = 0;
            this.pictureBoxKonobar.TabStop = false;
            // 
            // labelKonobar
            // 
            this.labelKonobar.AutoSize = true;
            this.labelKonobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKonobar.Location = new System.Drawing.Point(194, 147);
            this.labelKonobar.Name = "labelKonobar";
            this.labelKonobar.Size = new System.Drawing.Size(177, 31);
            this.labelKonobar.TabIndex = 1;
            this.labelKonobar.Text = "ime konobara";
            // 
            // listBoxPonuda
            // 
            this.listBoxPonuda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPonuda.FormattingEnabled = true;
            this.listBoxPonuda.Location = new System.Drawing.Point(6, 19);
            this.listBoxPonuda.Name = "listBoxPonuda";
            this.listBoxPonuda.Size = new System.Drawing.Size(191, 264);
            this.listBoxPonuda.TabIndex = 2;
            // 
            // groupBoxPonuda
            // 
            this.groupBoxPonuda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxPonuda.Controls.Add(this.listBoxPonuda);
            this.groupBoxPonuda.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPonuda.Name = "groupBoxPonuda";
            this.groupBoxPonuda.Size = new System.Drawing.Size(205, 291);
            this.groupBoxPonuda.TabIndex = 3;
            this.groupBoxPonuda.TabStop = false;
            this.groupBoxPonuda.Text = "Ponuda";
            // 
            // groupBoxRacun
            // 
            this.groupBoxRacun.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRacun.Controls.Add(this.listBoxRacun);
            this.groupBoxRacun.Location = new System.Drawing.Point(289, 12);
            this.groupBoxRacun.Name = "groupBoxRacun";
            this.groupBoxRacun.Size = new System.Drawing.Size(205, 291);
            this.groupBoxRacun.TabIndex = 4;
            this.groupBoxRacun.TabStop = false;
            this.groupBoxRacun.Text = "Račun";
            // 
            // listBoxRacun
            // 
            this.listBoxRacun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxRacun.FormattingEnabled = true;
            this.listBoxRacun.Location = new System.Drawing.Point(6, 19);
            this.listBoxRacun.Name = "listBoxRacun";
            this.listBoxRacun.Size = new System.Drawing.Size(191, 264);
            this.listBoxRacun.TabIndex = 2;
            // 
            // buttonPonudaURacun
            // 
            this.buttonPonudaURacun.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPonudaURacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPonudaURacun.Location = new System.Drawing.Point(223, 108);
            this.buttonPonudaURacun.Name = "buttonPonudaURacun";
            this.buttonPonudaURacun.Size = new System.Drawing.Size(60, 35);
            this.buttonPonudaURacun.TabIndex = 5;
            this.buttonPonudaURacun.Text = ">>";
            this.buttonPonudaURacun.UseVisualStyleBackColor = true;
            this.buttonPonudaURacun.Click += new System.EventHandler(this.buttonPonudaURacun_Click);
            // 
            // buttonIzbaciIzRacuna
            // 
            this.buttonIzbaciIzRacuna.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIzbaciIzRacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIzbaciIzRacuna.Location = new System.Drawing.Point(223, 158);
            this.buttonIzbaciIzRacuna.Name = "buttonIzbaciIzRacuna";
            this.buttonIzbaciIzRacuna.Size = new System.Drawing.Size(60, 35);
            this.buttonIzbaciIzRacuna.TabIndex = 6;
            this.buttonIzbaciIzRacuna.Text = "<<";
            this.buttonIzbaciIzRacuna.UseVisualStyleBackColor = true;
            this.buttonIzbaciIzRacuna.Click += new System.EventHandler(this.buttonIzbaciIzRacuna_Click);
            // 
            // buttonIzdajRacun
            // 
            this.buttonIzdajRacun.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIzdajRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIzdajRacun.Location = new System.Drawing.Point(187, 318);
            this.buttonIzdajRacun.Name = "buttonIzdajRacun";
            this.buttonIzdajRacun.Size = new System.Drawing.Size(119, 28);
            this.buttonIzdajRacun.TabIndex = 7;
            this.buttonIzdajRacun.Text = "Izdaj račun";
            this.buttonIzdajRacun.UseVisualStyleBackColor = true;
            this.buttonIzdajRacun.Click += new System.EventHandler(this.buttonIzdajRacun_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buttonIzdajRacun);
            this.panel1.Controls.Add(this.buttonIzbaciIzRacuna);
            this.panel1.Controls.Add(this.buttonPonudaURacun);
            this.panel1.Controls.Add(this.groupBoxRacun);
            this.panel1.Controls.Add(this.groupBoxPonuda);
            this.panel1.Location = new System.Drawing.Point(2, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 360);
            this.panel1.TabIndex = 8;
            // 
            // Konobar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 566);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelKonobar);
            this.Controls.Add(this.pictureBoxKonobar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(524, 605);
            this.Name = "Konobar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKonobar)).EndInit();
            this.groupBoxPonuda.ResumeLayout(false);
            this.groupBoxRacun.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxKonobar;
        private System.Windows.Forms.Label labelKonobar;
        private System.Windows.Forms.ListBox listBoxPonuda;
        private System.Windows.Forms.GroupBox groupBoxPonuda;
        private System.Windows.Forms.GroupBox groupBoxRacun;
        private System.Windows.Forms.ListBox listBoxRacun;
        private System.Windows.Forms.Button buttonPonudaURacun;
        private System.Windows.Forms.Button buttonIzbaciIzRacuna;
        private System.Windows.Forms.Button buttonIzdajRacun;
        private System.Windows.Forms.Panel panel1;
    }
}