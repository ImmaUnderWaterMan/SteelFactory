namespace SteelFactoryForm
{
    partial class SteelFactory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SteelFactory));
            this.labelHead = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonWarehouse = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHead
            // 
            this.labelHead.AutoSize = true;
            this.labelHead.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHead.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelHead.Location = new System.Drawing.Point(105, 9);
            this.labelHead.Name = "labelHead";
            this.labelHead.Size = new System.Drawing.Size(492, 40);
            this.labelHead.TabIndex = 3;
            this.labelHead.Text = "Терминал для создания стали";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(262, 589);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(467, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 68);
            this.button1.TabIndex = 20;
            this.button1.Text = "Создать заказ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // buttonWarehouse
            // 
            this.buttonWarehouse.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWarehouse.Location = new System.Drawing.Point(112, 99);
            this.buttonWarehouse.Name = "buttonWarehouse";
            this.buttonWarehouse.Size = new System.Drawing.Size(112, 70);
            this.buttonWarehouse.TabIndex = 21;
            this.buttonWarehouse.Text = "Склад";
            this.buttonWarehouse.UseVisualStyleBackColor = true;
            this.buttonWarehouse.Click += new System.EventHandler(this.buttonWarehouse_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(293, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 68);
            this.button3.TabIndex = 22;
            this.button3.Text = "Очередь заказов";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonOrderQueue_Click);
            // 
            // SteelFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonWarehouse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.labelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SteelFactory";
            this.Text = "SteelFactory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelHead;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonWarehouse;
        private System.Windows.Forms.Button button3;
    }
}

