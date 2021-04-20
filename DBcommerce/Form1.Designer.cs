namespace DBcommerce
{
    partial class MainForm
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
            this.buttonOnShopRequest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOnDepotRequest = new System.Windows.Forms.Button();
            this.buttonItemsNeeded = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOnShopRequest
            // 
            this.buttonOnShopRequest.Location = new System.Drawing.Point(16, 50);
            this.buttonOnShopRequest.Name = "buttonOnShopRequest";
            this.buttonOnShopRequest.Size = new System.Drawing.Size(137, 34);
            this.buttonOnShopRequest.TabIndex = 0;
            this.buttonOnShopRequest.Text = "Какие товары имеются в магазине";
            this.buttonOnShopRequest.UseVisualStyleBackColor = true;
            this.buttonOnShopRequest.Click += new System.EventHandler(this.buttonOnShopRequest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Запросы";
            // 
            // buttonOnDepotRequest
            // 
            this.buttonOnDepotRequest.Location = new System.Drawing.Point(16, 90);
            this.buttonOnDepotRequest.Name = "buttonOnDepotRequest";
            this.buttonOnDepotRequest.Size = new System.Drawing.Size(137, 34);
            this.buttonOnDepotRequest.TabIndex = 3;
            this.buttonOnDepotRequest.Text = "Какие товары имеются на базе";
            this.buttonOnDepotRequest.UseVisualStyleBackColor = true;
            this.buttonOnDepotRequest.Click += new System.EventHandler(this.buttonOnDepotRequest_Click);
            // 
            // buttonItemsNeeded
            // 
            this.buttonItemsNeeded.Location = new System.Drawing.Point(16, 130);
            this.buttonItemsNeeded.Name = "buttonItemsNeeded";
            this.buttonItemsNeeded.Size = new System.Drawing.Size(137, 61);
            this.buttonItemsNeeded.TabIndex = 4;
            this.buttonItemsNeeded.Text = "Какие отстутствующие товары может заказать магазин на базе";
            this.buttonItemsNeeded.UseVisualStyleBackColor = true;
            this.buttonItemsNeeded.Click += new System.EventHandler(this.buttonItemsNeeded_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Список заведующих отделами магазина";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 61);
            this.button2.TabIndex = 6;
            this.button2.Text = "В каких отделах магазина продаются одинаковые товары";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(201, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Изменение данных";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(205, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 34);
            this.button3.TabIndex = 8;
            this.button3.Text = "Добавление товара в отдел";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(205, 90);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 34);
            this.button4.TabIndex = 9;
            this.button4.Text = "Закрытие отдела";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(205, 130);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 34);
            this.button5.TabIndex = 10;
            this.button5.Text = "Изменение цены товара";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(201, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Справки";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(205, 228);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(137, 70);
            this.button6.TabIndex = 12;
            this.button6.Text = "Наличие товаров в отделе";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(348, 228);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(137, 70);
            this.button7.TabIndex = 13;
            this.button7.Text = "Отчет по магазину";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 338);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonItemsNeeded);
            this.Controls.Add(this.buttonOnDepotRequest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOnShopRequest);
            this.Name = "MainForm";
            this.Text = "База данных";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOnShopRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOnDepotRequest;
        private System.Windows.Forms.Button buttonItemsNeeded;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

