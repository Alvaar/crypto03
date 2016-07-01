namespace crypto03
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.copy_button = new System.Windows.Forms.Button();
            this.more_options = new System.Windows.Forms.Button();
            this.encrypt_B = new System.Windows.Forms.Button();
            this.decrypt_B = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.swap_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(112, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(250, 160);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox2.Location = new System.Drawing.Point(112, 178);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(250, 160);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // copy_button
            // 
            this.copy_button.BackColor = System.Drawing.Color.Violet;
            this.copy_button.Location = new System.Drawing.Point(31, 178);
            this.copy_button.Name = "copy_button";
            this.copy_button.Size = new System.Drawing.Size(75, 23);
            this.copy_button.TabIndex = 2;
            this.copy_button.Text = "copy";
            this.copy_button.UseVisualStyleBackColor = false;
            this.copy_button.Click += new System.EventHandler(this.copy_button_Click);
            // 
            // more_options
            // 
            this.more_options.BackColor = System.Drawing.Color.LightSkyBlue;
            this.more_options.Location = new System.Drawing.Point(31, 207);
            this.more_options.Name = "more_options";
            this.more_options.Size = new System.Drawing.Size(75, 23);
            this.more_options.TabIndex = 3;
            this.more_options.Text = "more";
            this.more_options.UseVisualStyleBackColor = false;
            this.more_options.Click += new System.EventHandler(this.more_options_Click);
            // 
            // encrypt_B
            // 
            this.encrypt_B.BackColor = System.Drawing.Color.DarkRed;
            this.encrypt_B.ForeColor = System.Drawing.SystemColors.Control;
            this.encrypt_B.Location = new System.Drawing.Point(31, 120);
            this.encrypt_B.Name = "encrypt_B";
            this.encrypt_B.Size = new System.Drawing.Size(75, 23);
            this.encrypt_B.TabIndex = 3;
            this.encrypt_B.Text = "encrypt";
            this.encrypt_B.UseVisualStyleBackColor = false;
            this.encrypt_B.Click += new System.EventHandler(this.encrypt_B_Click);
            // 
            // decrypt_B
            // 
            this.decrypt_B.BackColor = System.Drawing.Color.LimeGreen;
            this.decrypt_B.Location = new System.Drawing.Point(31, 149);
            this.decrypt_B.Name = "decrypt_B";
            this.decrypt_B.Size = new System.Drawing.Size(75, 23);
            this.decrypt_B.TabIndex = 4;
            this.decrypt_B.Text = "decrypt";
            this.decrypt_B.UseVisualStyleBackColor = false;
            this.decrypt_B.Click += new System.EventHandler(this.decrypt_B_Click);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox3.Location = new System.Drawing.Point(362, 12);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(250, 160);
            this.richTextBox3.TabIndex = 5;
            this.richTextBox3.Text = "test field";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox4.Location = new System.Drawing.Point(362, 178);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(250, 160);
            this.richTextBox4.TabIndex = 6;
            this.richTextBox4.Text = "";
            // 
            // swap_button
            // 
            this.swap_button.Location = new System.Drawing.Point(281, 163);
            this.swap_button.Name = "swap_button";
            this.swap_button.Size = new System.Drawing.Size(75, 23);
            this.swap_button.TabIndex = 7;
            this.swap_button.Text = "swap";
            this.swap_button.UseVisualStyleBackColor = true;
            this.swap_button.Click += new System.EventHandler(this.swap_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(624, 351);
            this.Controls.Add(this.swap_button);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.decrypt_B);
            this.Controls.Add(this.encrypt_B);
            this.Controls.Add(this.more_options);
            this.Controls.Add(this.copy_button);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "XOR cipher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button copy_button;
        private System.Windows.Forms.Button more_options;
        private System.Windows.Forms.Button encrypt_B;
        private System.Windows.Forms.Button decrypt_B;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Button swap_button;
    }
}

