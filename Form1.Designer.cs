namespace Adventure
{
    public partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PictureSword = new System.Windows.Forms.PictureBox();
            this.PictureBow = new System.Windows.Forms.PictureBox();
            this.PictureMace = new System.Windows.Forms.PictureBox();
            this.pictureBluePotion = new System.Windows.Forms.PictureBox();
            this.pictureRedPotion = new System.Windows.Forms.PictureBox();
            this.PictureBat = new System.Windows.Forms.PictureBox();
            this.txtPlayerHealth = new System.Windows.Forms.Label();
            this.txtBatHealth = new System.Windows.Forms.Label();
            this.txtGhostHealth = new System.Windows.Forms.Label();
            this.txtGhoulHealth = new System.Windows.Forms.Label();
            this.PictureGhost = new System.Windows.Forms.PictureBox();
            this.PictureGhoul = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRedPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureGhoul)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(613, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bewegen";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(613, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Angreifen";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(660, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hoch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.WalkUp);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(620, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Links";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.WalkLeft);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(701, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Rechts";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.WalkRight);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(660, 85);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Runter";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.WalkDown);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(660, 252);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Runter";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.AttackDown);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(701, 223);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Rechts";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.AttackRight);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(620, 223);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Links";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.AttackLeft);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Location = new System.Drawing.Point(660, 194);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 6;
            this.button8.Text = "Hoch";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.AttackUp);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(613, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Spieler";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(613, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fledermaus";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(613, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Geist";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(613, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ghul";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(74, 144);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // PictureSword
            // 
            this.PictureSword.BackColor = System.Drawing.Color.Transparent;
            this.PictureSword.Image = ((System.Drawing.Image)(resources.GetObject("PictureSword.Image")));
            this.PictureSword.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureSword.InitialImage")));
            this.PictureSword.Location = new System.Drawing.Point(124, 144);
            this.PictureSword.Name = "PictureSword";
            this.PictureSword.Size = new System.Drawing.Size(50, 50);
            this.PictureSword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureSword.TabIndex = 17;
            this.PictureSword.TabStop = false;
            this.PictureSword.Click += new System.EventHandler(this.PictureSword_Click);
            // 
            // PictureBow
            // 
            this.PictureBow.BackColor = System.Drawing.Color.Transparent;
            this.PictureBow.Image = ((System.Drawing.Image)(resources.GetObject("PictureBow.Image")));
            this.PictureBow.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureBow.InitialImage")));
            this.PictureBow.Location = new System.Drawing.Point(74, 94);
            this.PictureBow.Name = "PictureBow";
            this.PictureBow.Size = new System.Drawing.Size(50, 50);
            this.PictureBow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBow.TabIndex = 18;
            this.PictureBow.TabStop = false;
            this.PictureBow.Click += new System.EventHandler(this.PictureBow_Click);
            // 
            // PictureMace
            // 
            this.PictureMace.BackColor = System.Drawing.Color.Transparent;
            this.PictureMace.Image = ((System.Drawing.Image)(resources.GetObject("PictureMace.Image")));
            this.PictureMace.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureMace.InitialImage")));
            this.PictureMace.Location = new System.Drawing.Point(374, 94);
            this.PictureMace.Name = "PictureMace";
            this.PictureMace.Size = new System.Drawing.Size(50, 50);
            this.PictureMace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureMace.TabIndex = 19;
            this.PictureMace.TabStop = false;
            this.PictureMace.Click += new System.EventHandler(this.PictureMace_Click);
            // 
            // pictureBluePotion
            // 
            this.pictureBluePotion.BackColor = System.Drawing.Color.Transparent;
            this.pictureBluePotion.Image = ((System.Drawing.Image)(resources.GetObject("pictureBluePotion.Image")));
            this.pictureBluePotion.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBluePotion.InitialImage")));
            this.pictureBluePotion.Location = new System.Drawing.Point(474, 194);
            this.pictureBluePotion.Name = "pictureBluePotion";
            this.pictureBluePotion.Size = new System.Drawing.Size(50, 50);
            this.pictureBluePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBluePotion.TabIndex = 20;
            this.pictureBluePotion.TabStop = false;
            this.pictureBluePotion.Click += new System.EventHandler(this.PictureBluePotion_Click);
            // 
            // pictureRedPotion
            // 
            this.pictureRedPotion.BackColor = System.Drawing.Color.Transparent;
            this.pictureRedPotion.Image = ((System.Drawing.Image)(resources.GetObject("pictureRedPotion.Image")));
            this.pictureRedPotion.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureRedPotion.InitialImage")));
            this.pictureRedPotion.Location = new System.Drawing.Point(474, 44);
            this.pictureRedPotion.Name = "pictureRedPotion";
            this.pictureRedPotion.Size = new System.Drawing.Size(50, 50);
            this.pictureRedPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureRedPotion.TabIndex = 21;
            this.pictureRedPotion.TabStop = false;
            this.pictureRedPotion.Click += new System.EventHandler(this.PictureRedPotion_Click);
            // 
            // PictureBat
            // 
            this.PictureBat.BackColor = System.Drawing.Color.Transparent;
            this.PictureBat.Image = ((System.Drawing.Image)(resources.GetObject("PictureBat.Image")));
            this.PictureBat.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureBat.InitialImage")));
            this.PictureBat.Location = new System.Drawing.Point(324, 94);
            this.PictureBat.Name = "PictureBat";
            this.PictureBat.Size = new System.Drawing.Size(50, 50);
            this.PictureBat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBat.TabIndex = 22;
            this.PictureBat.TabStop = false;
            // 
            // txtPlayerHealth
            // 
            this.txtPlayerHealth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlayerHealth.AutoSize = true;
            this.txtPlayerHealth.Location = new System.Drawing.Point(698, 296);
            this.txtPlayerHealth.Name = "txtPlayerHealth";
            this.txtPlayerHealth.Size = new System.Drawing.Size(39, 13);
            this.txtPlayerHealth.TabIndex = 23;
            this.txtPlayerHealth.Text = "Spieler";
            // 
            // txtBatHealth
            // 
            this.txtBatHealth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBatHealth.AutoSize = true;
            this.txtBatHealth.Location = new System.Drawing.Point(698, 321);
            this.txtBatHealth.Name = "txtBatHealth";
            this.txtBatHealth.Size = new System.Drawing.Size(39, 13);
            this.txtBatHealth.TabIndex = 24;
            this.txtBatHealth.Text = "Spieler";
            // 
            // txtGhostHealth
            // 
            this.txtGhostHealth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhostHealth.AutoSize = true;
            this.txtGhostHealth.Location = new System.Drawing.Point(698, 343);
            this.txtGhostHealth.Name = "txtGhostHealth";
            this.txtGhostHealth.Size = new System.Drawing.Size(39, 13);
            this.txtGhostHealth.TabIndex = 25;
            this.txtGhostHealth.Text = "Spieler";
            // 
            // txtGhoulHealth
            // 
            this.txtGhoulHealth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhoulHealth.AutoSize = true;
            this.txtGhoulHealth.Location = new System.Drawing.Point(698, 365);
            this.txtGhoulHealth.Name = "txtGhoulHealth";
            this.txtGhoulHealth.Size = new System.Drawing.Size(39, 13);
            this.txtGhoulHealth.TabIndex = 26;
            this.txtGhoulHealth.Text = "Spieler";
            // 
            // PictureGhost
            // 
            this.PictureGhost.BackColor = System.Drawing.Color.Transparent;
            this.PictureGhost.Image = ((System.Drawing.Image)(resources.GetObject("PictureGhost.Image")));
            this.PictureGhost.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureGhost.InitialImage")));
            this.PictureGhost.Location = new System.Drawing.Point(324, 144);
            this.PictureGhost.Name = "PictureGhost";
            this.PictureGhost.Size = new System.Drawing.Size(50, 50);
            this.PictureGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureGhost.TabIndex = 27;
            this.PictureGhost.TabStop = false;
            // 
            // PictureGhoul
            // 
            this.PictureGhoul.BackColor = System.Drawing.Color.Transparent;
            this.PictureGhoul.Image = ((System.Drawing.Image)(resources.GetObject("PictureGhoul.Image")));
            this.PictureGhoul.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureGhoul.InitialImage")));
            this.PictureGhoul.Location = new System.Drawing.Point(324, 194);
            this.PictureGhoul.Name = "PictureGhoul";
            this.PictureGhoul.Size = new System.Drawing.Size(50, 50);
            this.PictureGhoul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureGhoul.TabIndex = 28;
            this.PictureGhoul.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(805, 398);
            this.Controls.Add(this.PictureGhoul);
            this.Controls.Add(this.PictureGhost);
            this.Controls.Add(this.txtGhoulHealth);
            this.Controls.Add(this.txtGhostHealth);
            this.Controls.Add(this.txtBatHealth);
            this.Controls.Add(this.txtPlayerHealth);
            this.Controls.Add(this.PictureBat);
            this.Controls.Add(this.pictureRedPotion);
            this.Controls.Add(this.pictureBluePotion);
            this.Controls.Add(this.PictureMace);
            this.Controls.Add(this.PictureBow);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.PictureSword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(821, 437);
            this.MinimumSize = new System.Drawing.Size(821, 437);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRedPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureGhoul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox PictureSword;
        private System.Windows.Forms.PictureBox PictureBow;
        private System.Windows.Forms.PictureBox PictureMace;
        private System.Windows.Forms.PictureBox pictureBluePotion;
        private System.Windows.Forms.PictureBox pictureRedPotion;
        private System.Windows.Forms.PictureBox PictureBat;
        private System.Windows.Forms.Label txtPlayerHealth;
        private System.Windows.Forms.Label txtBatHealth;
        private System.Windows.Forms.Label txtGhostHealth;
        private System.Windows.Forms.Label txtGhoulHealth;
        private System.Windows.Forms.PictureBox PictureGhost;
        private System.Windows.Forms.PictureBox PictureGhoul;
    }
}

