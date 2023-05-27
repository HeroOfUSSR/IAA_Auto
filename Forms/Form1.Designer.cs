namespace Auto
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
            this.guide = new System.Windows.Forms.Button();
            this.fuel = new System.Windows.Forms.Button();
            this.count = new System.Windows.Forms.Button();
            this.contact = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // guide
            // 
            this.guide.Location = new System.Drawing.Point(64, 70);
            this.guide.Name = "guide";
            this.guide.Size = new System.Drawing.Size(223, 33);
            this.guide.TabIndex = 1;
            this.guide.Text = "Справочник";
            this.guide.UseVisualStyleBackColor = true;
            this.guide.Click += new System.EventHandler(this.guide_Click);
            // 
            // fuel
            // 
            this.fuel.Location = new System.Drawing.Point(64, 109);
            this.fuel.Name = "fuel";
            this.fuel.Size = new System.Drawing.Size(223, 36);
            this.fuel.TabIndex = 2;
            this.fuel.Text = "Топливо";
            this.fuel.UseVisualStyleBackColor = true;
            this.fuel.Click += new System.EventHandler(this.fuel_Click);
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(64, 151);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(223, 37);
            this.count.TabIndex = 3;
            this.count.Text = "Учёт";
            this.count.UseVisualStyleBackColor = true;
            this.count.Click += new System.EventHandler(this.count_Click);
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(64, 194);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(223, 35);
            this.contact.TabIndex = 4;
            this.contact.Text = "Контакты";
            this.contact.UseVisualStyleBackColor = true;
            this.contact.Click += new System.EventHandler(this.contact_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(136, 281);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Выход";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 355);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.count);
            this.Controls.Add(this.fuel);
            this.Controls.Add(this.guide);
            this.Name = "Form1";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button guide;
        private System.Windows.Forms.Button fuel;
        private System.Windows.Forms.Button count;
        private System.Windows.Forms.Button contact;
        private System.Windows.Forms.Button button5;
    }
}

