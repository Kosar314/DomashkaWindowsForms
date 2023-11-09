namespace FirstApp
{
    partial class FMain
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonHide = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonStar = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(125, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 23);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите своё имя";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkMagenta;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(161, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ввод";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Номер группы";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(125, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(111, 23);
            this.textBox2.TabIndex = 4;
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.Red;
            this.buttonRed.Location = new System.Drawing.Point(12, 106);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(75, 23);
            this.buttonRed.TabIndex = 5;
            this.buttonRed.Text = "Красный";
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonBlue
            // 
            this.buttonBlue.BackColor = System.Drawing.Color.Blue;
            this.buttonBlue.Location = new System.Drawing.Point(93, 106);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(75, 23);
            this.buttonBlue.TabIndex = 6;
            this.buttonBlue.Text = "Синий";
            this.buttonBlue.UseVisualStyleBackColor = false;
            this.buttonBlue.Click += new System.EventHandler(this.buttonBlue_Click);
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackColor = System.Drawing.Color.Green;
            this.buttonGreen.Location = new System.Drawing.Point(12, 135);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(75, 23);
            this.buttonGreen.TabIndex = 7;
            this.buttonGreen.Text = "Зелёный";
            this.buttonGreen.UseVisualStyleBackColor = false;
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
            // 
            // buttonYellow
            // 
            this.buttonYellow.BackColor = System.Drawing.Color.Yellow;
            this.buttonYellow.Location = new System.Drawing.Point(93, 135);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(75, 23);
            this.buttonYellow.TabIndex = 8;
            this.buttonYellow.Text = "Жёлтый";
            this.buttonYellow.UseVisualStyleBackColor = false;
            this.buttonYellow.Click += new System.EventHandler(this.buttonYellow_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 221);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 9;
            // 
            // buttonHide
            // 
            this.buttonHide.Location = new System.Drawing.Point(15, 192);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(75, 23);
            this.buttonHide.TabIndex = 10;
            this.buttonHide.Text = "Скрыть";
            this.buttonHide.UseVisualStyleBackColor = true;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(97, 192);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 23);
            this.buttonShow.TabIndex = 11;
            this.buttonShow.Text = "Показать";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(179, 192);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonStar
            // 
            this.buttonStar.Location = new System.Drawing.Point(15, 268);
            this.buttonStar.Name = "buttonStar";
            this.buttonStar.Size = new System.Drawing.Size(75, 23);
            this.buttonStar.TabIndex = 13;
            this.buttonStar.Text = "*****";
            this.buttonStar.UseVisualStyleBackColor = true;
            this.buttonStar.Click += new System.EventHandler(this.buttonStar_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(97, 268);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(75, 23);
            this.buttonPlus.TabIndex = 14;
            this.buttonPlus.Text = "++++++";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonZero
            // 
            this.buttonZero.Location = new System.Drawing.Point(179, 268);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(75, 23);
            this.buttonZero.TabIndex = 15;
            this.buttonZero.Text = "000000";
            this.buttonZero.UseVisualStyleBackColor = true;
            this.buttonZero.Click += new System.EventHandler(this.buttonZero_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(15, 298);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 16;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(530, 507);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonStar);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonHide);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.buttonYellow);
            this.Controls.Add(this.buttonGreen);
            this.Controls.Add(this.buttonBlue);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FMain";
            this.Text = "Первое приложение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonBlue;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonYellow;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonStar;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.TextBox textBox4;
    }
}

