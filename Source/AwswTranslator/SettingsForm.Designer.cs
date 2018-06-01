namespace AwswTranslator
{
    partial class SettingsForm
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
            this.statBar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.closeButtonSettings = new System.Windows.Forms.Button();
            this.translateEverything = new System.Windows.Forms.CheckBox();
            this.from = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.TextBox();
            this.backup = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reverseTranslation = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.statBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statBar
            // 
            this.statBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.statBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.statBar.Location = new System.Drawing.Point(0, 0);
            this.statBar.Name = "statBar";
            this.statBar.Size = new System.Drawing.Size(184, 25);
            this.statBar.TabIndex = 4;
            this.statBar.TabStop = false;
            this.statBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragWindow);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Settings";
            // 
            // closeButtonSettings
            // 
            this.closeButtonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.closeButtonSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.closeButtonSettings.FlatAppearance.BorderSize = 0;
            this.closeButtonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButtonSettings.ForeColor = System.Drawing.Color.White;
            this.closeButtonSettings.Location = new System.Drawing.Point(159, 0);
            this.closeButtonSettings.Margin = new System.Windows.Forms.Padding(0);
            this.closeButtonSettings.Name = "closeButtonSettings";
            this.closeButtonSettings.Size = new System.Drawing.Size(25, 25);
            this.closeButtonSettings.TabIndex = 6;
            this.closeButtonSettings.Text = "X";
            this.closeButtonSettings.UseVisualStyleBackColor = false;
            this.closeButtonSettings.Click += new System.EventHandler(this.closeButtonSettings_Click);
            // 
            // translateEverything
            // 
            this.translateEverything.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.translateEverything.ForeColor = System.Drawing.Color.White;
            this.translateEverything.Location = new System.Drawing.Point(15, 94);
            this.translateEverything.Name = "translateEverything";
            this.translateEverything.Size = new System.Drawing.Size(157, 24);
            this.translateEverything.TabIndex = 7;
            this.translateEverything.Text = "Translate Everything";
            this.translateEverything.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.translateEverything.UseVisualStyleBackColor = true;
            this.translateEverything.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // from
            // 
            this.from.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.from.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.from.ForeColor = System.Drawing.Color.White;
            this.from.Location = new System.Drawing.Point(30, 56);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(55, 22);
            this.from.TabIndex = 8;
            this.from.Text = "En";
            this.from.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Translate From | To";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // to
            // 
            this.to.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.to.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.to.ForeColor = System.Drawing.Color.White;
            this.to.Location = new System.Drawing.Point(98, 56);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(55, 22);
            this.to.TabIndex = 10;
            this.to.Text = "Ru";
            this.to.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // backup
            // 
            this.backup.Checked = true;
            this.backup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.backup.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.backup.ForeColor = System.Drawing.Color.White;
            this.backup.Location = new System.Drawing.Point(15, 117);
            this.backup.Name = "backup";
            this.backup.Size = new System.Drawing.Size(157, 17);
            this.backup.TabIndex = 11;
            this.backup.Text = "Create Backup";
            this.backup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backup.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(3, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Super hidden button";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.DoubleClick += new System.EventHandler(this.ade);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::AwswTranslator.Properties.Resources.blush;
            this.pictureBox1.Location = new System.Drawing.Point(56, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // reverseTranslation
            // 
            this.reverseTranslation.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.reverseTranslation.ForeColor = System.Drawing.Color.White;
            this.reverseTranslation.Location = new System.Drawing.Point(15, 136);
            this.reverseTranslation.Name = "reverseTranslation";
            this.reverseTranslation.Size = new System.Drawing.Size(157, 17);
            this.reverseTranslation.TabIndex = 14;
            this.reverseTranslation.Text = "Vodka translation";
            this.reverseTranslation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reverseTranslation.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(184, 275);
            this.Controls.Add(this.reverseTranslation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backup);
            this.Controls.Add(this.to);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.from);
            this.Controls.Add(this.translateEverything);
            this.Controls.Add(this.closeButtonSettings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.statBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox statBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button closeButtonSettings;
        private System.Windows.Forms.CheckBox translateEverything;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.CheckBox backup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox reverseTranslation;
    }
}