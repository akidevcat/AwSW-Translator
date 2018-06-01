namespace AwswTranslator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dragText = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.statBar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hideButton = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.circularProgressBar1 = new AwswTranslator.CircularProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.statBar)).BeginInit();
            this.SuspendLayout();
            // 
            // dragText
            // 
            this.dragText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dragText.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dragText.ForeColor = System.Drawing.Color.White;
            this.dragText.Location = new System.Drawing.Point(0, 28);
            this.dragText.Name = "dragText";
            this.dragText.Size = new System.Drawing.Size(275, 171);
            this.dragText.TabIndex = 0;
            this.dragText.Text = "Drag file here\r\n^-^";
            this.dragText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dragText.Click += new System.EventHandler(this.label1_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(250, 0);
            this.Close.Margin = new System.Windows.Forms.Padding(0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(25, 25);
            this.Close.TabIndex = 2;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // statBar
            // 
            this.statBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.statBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.statBar.Location = new System.Drawing.Point(0, 0);
            this.statBar.Name = "statBar";
            this.statBar.Size = new System.Drawing.Size(275, 25);
            this.statBar.TabIndex = 3;
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
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "AwSW Translator";
            // 
            // hideButton
            // 
            this.hideButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.hideButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.hideButton.FlatAppearance.BorderSize = 0;
            this.hideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideButton.ForeColor = System.Drawing.Color.White;
            this.hideButton.Location = new System.Drawing.Point(225, 0);
            this.hideButton.Margin = new System.Windows.Forms.Padding(0);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(25, 25);
            this.hideButton.TabIndex = 8;
            this.hideButton.Text = "-";
            this.hideButton.UseVisualStyleBackColor = false;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.settings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.settings.FlatAppearance.BorderSize = 0;
            this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings.ForeColor = System.Drawing.Color.White;
            this.settings.Location = new System.Drawing.Point(200, 0);
            this.settings.Margin = new System.Windows.Forms.Padding(0);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(25, 25);
            this.settings.TabIndex = 9;
            this.settings.Text = "⚙";
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.White;
            this.circularProgressBar1.LineColor = System.Drawing.Color.Silver;
            this.circularProgressBar1.Location = new System.Drawing.Point(95, 185);
            this.circularProgressBar1.Maximum = ((long)(100));
            this.circularProgressBar1.MinimumSize = new System.Drawing.Size(30, 30);
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.ProgressColor1 = System.Drawing.Color.Orange;
            this.circularProgressBar1.ProgressColor2 = System.Drawing.Color.Orange;
            this.circularProgressBar1.ProgressShape = AwswTranslator.CircularProgressBar._ProgressShape.Round;
            this.circularProgressBar1.Size = new System.Drawing.Size(82, 82);
            this.circularProgressBar1.TabIndex = 7;
            this.circularProgressBar1.Text = "circularProgressBar1";
            this.circularProgressBar1.Value = ((long)(0));
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(275, 275);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.dragText);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.statBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "AwSW Translator";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.file_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.file_DragEnter);
            this.DragLeave += new System.EventHandler(this.file_DragLeave);
            ((System.ComponentModel.ISupportInitialize)(this.statBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dragText;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.PictureBox statBar;
        private System.Windows.Forms.Label label2;
        private CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.Button settings;
    }
}

