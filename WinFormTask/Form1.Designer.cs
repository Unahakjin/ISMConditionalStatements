namespace WinFormTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelZ = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.buttonRes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.ForeColor = System.Drawing.Color.DimGray;
            this.labelX.Location = new System.Drawing.Point(94, 46);
            this.labelX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(40, 29);
            this.labelX.TabIndex = 0;
            this.labelX.Text = "x =";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.ForeColor = System.Drawing.Color.DimGray;
            this.labelY.Location = new System.Drawing.Point(94, 139);
            this.labelY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(44, 29);
            this.labelY.TabIndex = 1;
            this.labelY.Text = "y = ";
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.ForeColor = System.Drawing.Color.DimGray;
            this.labelZ.Location = new System.Drawing.Point(94, 238);
            this.labelZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(40, 29);
            this.labelZ.TabIndex = 2;
            this.labelZ.Text = "z =";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.ForeColor = System.Drawing.Color.DimGray;
            this.labelR.Location = new System.Drawing.Point(94, 434);
            this.labelR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(37, 29);
            this.labelR.TabIndex = 3;
            this.labelR.Text = "r =";
            // 
            // textBoxX
            // 
            this.textBoxX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxX.Location = new System.Drawing.Point(146, 46);
            this.textBoxX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(224, 34);
            this.textBoxX.TabIndex = 4;
            // 
            // textBoxY
            // 
            this.textBoxY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxY.Location = new System.Drawing.Point(146, 139);
            this.textBoxY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(224, 34);
            this.textBoxY.TabIndex = 5;
            // 
            // textBoxZ
            // 
            this.textBoxZ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxZ.Location = new System.Drawing.Point(146, 238);
            this.textBoxZ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.Size = new System.Drawing.Size(224, 34);
            this.textBoxZ.TabIndex = 6;
            // 
            // textBoxR
            // 
            this.textBoxR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxR.Location = new System.Drawing.Point(146, 434);
            this.textBoxR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.ReadOnly = true;
            this.textBoxR.Size = new System.Drawing.Size(224, 34);
            this.textBoxR.TabIndex = 7;
            // 
            // buttonRes
            // 
            this.buttonRes.BackColor = System.Drawing.Color.LightBlue;
            this.buttonRes.Location = new System.Drawing.Point(146, 319);
            this.buttonRes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRes.Name = "buttonRes";
            this.buttonRes.Size = new System.Drawing.Size(226, 56);
            this.buttonRes.TabIndex = 8;
            this.buttonRes.Text = "Обчислити";
            this.buttonRes.UseVisualStyleBackColor = false;
            this.buttonRes.Click += new System.EventHandler(this.ButtonRes_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Демченко Я. Д., гр. ІПЗ 19-2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRes);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.textBoxZ);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.labelZ);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 700);
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практична робота №2. Завдання 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.Button buttonRes;
        private System.Windows.Forms.Label label1;
    }
}

