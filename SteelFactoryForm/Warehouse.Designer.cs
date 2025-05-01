namespace SteelFactoryForm
{
    partial class Warehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warehouse));
            this.labelOre = new System.Windows.Forms.Label();
            this.labelNickel = new System.Windows.Forms.Label();
            this.labelTimeFurnace = new System.Windows.Forms.Label();
            this.labelManganese = new System.Windows.Forms.Label();
            this.labelTimeRollingMachine = new System.Windows.Forms.Label();
            this.labelTimeConverter = new System.Windows.Forms.Label();
            this.labelChrome = new System.Windows.Forms.Label();
            this.textBoxOre = new System.Windows.Forms.TextBox();
            this.textBoxNickel = new System.Windows.Forms.TextBox();
            this.textBoxChrome = new System.Windows.Forms.TextBox();
            this.textBoxManganese = new System.Windows.Forms.TextBox();
            this.textBoxTimeFurnace = new System.Windows.Forms.TextBox();
            this.textBoxTimeConverter = new System.Windows.Forms.TextBox();
            this.textBoxTimeRollingMachine = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelOre
            // 
            this.labelOre.AutoSize = true;
            this.labelOre.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelOre.Location = new System.Drawing.Point(12, 27);
            this.labelOre.Name = "labelOre";
            this.labelOre.Size = new System.Drawing.Size(125, 24);
            this.labelOre.TabIndex = 0;
            this.labelOre.Text = "Руда (тонн):";
            // 
            // labelNickel
            // 
            this.labelNickel.AutoSize = true;
            this.labelNickel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNickel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNickel.Location = new System.Drawing.Point(12, 67);
            this.labelNickel.Name = "labelNickel";
            this.labelNickel.Size = new System.Drawing.Size(140, 24);
            this.labelNickel.TabIndex = 1;
            this.labelNickel.Text = "Никель (кг):  ";
            // 
            // labelTimeFurnace
            // 
            this.labelTimeFurnace.AutoSize = true;
            this.labelTimeFurnace.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeFurnace.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTimeFurnace.Location = new System.Drawing.Point(12, 192);
            this.labelTimeFurnace.Name = "labelTimeFurnace";
            this.labelTimeFurnace.Size = new System.Drawing.Size(233, 48);
            this.labelTimeFurnace.TabIndex = 2;
            this.labelTimeFurnace.Text = "Время работы\r\nдоменной печи (часы): ";
            // 
            // labelManganese
            // 
            this.labelManganese.AutoSize = true;
            this.labelManganese.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelManganese.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelManganese.Location = new System.Drawing.Point(12, 141);
            this.labelManganese.Name = "labelManganese";
            this.labelManganese.Size = new System.Drawing.Size(159, 24);
            this.labelManganese.TabIndex = 3;
            this.labelManganese.Text = "Марганец (кг): ";
            // 
            // labelTimeRollingMachine
            // 
            this.labelTimeRollingMachine.AutoSize = true;
            this.labelTimeRollingMachine.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeRollingMachine.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTimeRollingMachine.Location = new System.Drawing.Point(12, 337);
            this.labelTimeRollingMachine.Name = "labelTimeRollingMachine";
            this.labelTimeRollingMachine.Size = new System.Drawing.Size(261, 48);
            this.labelTimeRollingMachine.TabIndex = 4;
            this.labelTimeRollingMachine.Text = "Время работы \r\nпрокатного стана (часы):  ";
            // 
            // labelTimeConverter
            // 
            this.labelTimeConverter.AutoSize = true;
            this.labelTimeConverter.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeConverter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTimeConverter.Location = new System.Drawing.Point(12, 260);
            this.labelTimeConverter.Name = "labelTimeConverter";
            this.labelTimeConverter.Size = new System.Drawing.Size(193, 48);
            this.labelTimeConverter.TabIndex = 5;
            this.labelTimeConverter.Text = "Время работы \r\nконвертера (часы):";
            // 
            // labelChrome
            // 
            this.labelChrome.AutoSize = true;
            this.labelChrome.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChrome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelChrome.Location = new System.Drawing.Point(12, 101);
            this.labelChrome.Name = "labelChrome";
            this.labelChrome.Size = new System.Drawing.Size(119, 24);
            this.labelChrome.TabIndex = 6;
            this.labelChrome.Text = "Хром (кг):  ";
            // 
            // textBoxOre
            // 
            this.textBoxOre.Location = new System.Drawing.Point(269, 32);
            this.textBoxOre.Name = "textBoxOre";
            this.textBoxOre.Size = new System.Drawing.Size(100, 20);
            this.textBoxOre.TabIndex = 7;
            // 
            // textBoxNickel
            // 
            this.textBoxNickel.Location = new System.Drawing.Point(269, 71);
            this.textBoxNickel.Name = "textBoxNickel";
            this.textBoxNickel.Size = new System.Drawing.Size(100, 20);
            this.textBoxNickel.TabIndex = 8;
            // 
            // textBoxChrome
            // 
            this.textBoxChrome.Location = new System.Drawing.Point(269, 106);
            this.textBoxChrome.Name = "textBoxChrome";
            this.textBoxChrome.Size = new System.Drawing.Size(100, 20);
            this.textBoxChrome.TabIndex = 9;
            // 
            // textBoxManganese
            // 
            this.textBoxManganese.Location = new System.Drawing.Point(269, 146);
            this.textBoxManganese.Name = "textBoxManganese";
            this.textBoxManganese.Size = new System.Drawing.Size(100, 20);
            this.textBoxManganese.TabIndex = 10;
            // 
            // textBoxTimeFurnace
            // 
            this.textBoxTimeFurnace.Location = new System.Drawing.Point(269, 220);
            this.textBoxTimeFurnace.Name = "textBoxTimeFurnace";
            this.textBoxTimeFurnace.Size = new System.Drawing.Size(100, 20);
            this.textBoxTimeFurnace.TabIndex = 11;
            // 
            // textBoxTimeConverter
            // 
            this.textBoxTimeConverter.Location = new System.Drawing.Point(269, 288);
            this.textBoxTimeConverter.Name = "textBoxTimeConverter";
            this.textBoxTimeConverter.Size = new System.Drawing.Size(100, 20);
            this.textBoxTimeConverter.TabIndex = 12;
            // 
            // textBoxTimeRollingMachine
            // 
            this.textBoxTimeRollingMachine.Location = new System.Drawing.Point(269, 365);
            this.textBoxTimeRollingMachine.Name = "textBoxTimeRollingMachine";
            this.textBoxTimeRollingMachine.Size = new System.Drawing.Size(100, 20);
            this.textBoxTimeRollingMachine.TabIndex = 13;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(553, 168);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(140, 73);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(503, 37);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 16;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelId.Location = new System.Drawing.Point(448, 32);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(35, 24);
            this.labelId.TabIndex = 15;
            this.labelId.Text = "Id:";
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxTimeRollingMachine);
            this.Controls.Add(this.textBoxTimeConverter);
            this.Controls.Add(this.textBoxTimeFurnace);
            this.Controls.Add(this.textBoxManganese);
            this.Controls.Add(this.textBoxChrome);
            this.Controls.Add(this.textBoxNickel);
            this.Controls.Add(this.textBoxOre);
            this.Controls.Add(this.labelChrome);
            this.Controls.Add(this.labelTimeConverter);
            this.Controls.Add(this.labelTimeRollingMachine);
            this.Controls.Add(this.labelManganese);
            this.Controls.Add(this.labelTimeFurnace);
            this.Controls.Add(this.labelNickel);
            this.Controls.Add(this.labelOre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Warehouse";
            this.Text = "Warehouse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOre;
        private System.Windows.Forms.Label labelNickel;
        private System.Windows.Forms.Label labelTimeFurnace;
        private System.Windows.Forms.Label labelManganese;
        private System.Windows.Forms.Label labelTimeRollingMachine;
        private System.Windows.Forms.Label labelTimeConverter;
        private System.Windows.Forms.Label labelChrome;
        private System.Windows.Forms.TextBox textBoxOre;
        private System.Windows.Forms.TextBox textBoxNickel;
        private System.Windows.Forms.TextBox textBoxChrome;
        private System.Windows.Forms.TextBox textBoxManganese;
        private System.Windows.Forms.TextBox textBoxTimeFurnace;
        private System.Windows.Forms.TextBox textBoxTimeConverter;
        private System.Windows.Forms.TextBox textBoxTimeRollingMachine;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
    }
}