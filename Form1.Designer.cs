namespace _7.Binary_tree
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.valT = new System.Windows.Forms.TextBox();
            this.addB = new System.Windows.Forms.Button();
            this.delB = new System.Windows.Forms.Button();
            this.deepL = new System.Windows.Forms.Label();
            this.listL = new System.Windows.Forms.Label();
            this.CLR = new System.Windows.Forms.Button();
            this.LCR = new System.Windows.Forms.Button();
            this.RCL = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(230, 10);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(600, 400);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // valT
            // 
            this.valT.Location = new System.Drawing.Point(12, 27);
            this.valT.Name = "valT";
            this.valT.Size = new System.Drawing.Size(206, 20);
            this.valT.TabIndex = 2;
            // 
            // addB
            // 
            this.addB.Location = new System.Drawing.Point(12, 53);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(207, 23);
            this.addB.TabIndex = 3;
            this.addB.Text = "Добавить";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.Add);
            // 
            // delB
            // 
            this.delB.Location = new System.Drawing.Point(12, 82);
            this.delB.Name = "delB";
            this.delB.Size = new System.Drawing.Size(207, 23);
            this.delB.TabIndex = 4;
            this.delB.Text = "Удалить";
            this.delB.UseVisualStyleBackColor = true;
            this.delB.Click += new System.EventHandler(this.delB_Click);
            // 
            // deepL
            // 
            this.deepL.AutoSize = true;
            this.deepL.Location = new System.Drawing.Point(13, 135);
            this.deepL.Name = "deepL";
            this.deepL.Size = new System.Drawing.Size(54, 13);
            this.deepL.TabIndex = 5;
            this.deepL.Text = "Глубина: ";
            // 
            // listL
            // 
            this.listL.AutoSize = true;
            this.listL.Location = new System.Drawing.Point(12, 152);
            this.listL.Name = "listL";
            this.listL.Size = new System.Drawing.Size(116, 13);
            this.listL.TabIndex = 6;
            this.listL.Text = "Количество листьев: ";
            // 
            // CLR
            // 
            this.CLR.Location = new System.Drawing.Point(12, 169);
            this.CLR.Name = "CLR";
            this.CLR.Size = new System.Drawing.Size(55, 23);
            this.CLR.TabIndex = 7;
            this.CLR.Text = "CLR";
            this.CLR.UseVisualStyleBackColor = true;
            this.CLR.Click += new System.EventHandler(this.CLR_Click);
            // 
            // LCR
            // 
            this.LCR.Location = new System.Drawing.Point(88, 169);
            this.LCR.Name = "LCR";
            this.LCR.Size = new System.Drawing.Size(55, 23);
            this.LCR.TabIndex = 8;
            this.LCR.Text = "LCR";
            this.LCR.UseVisualStyleBackColor = true;
            this.LCR.Click += new System.EventHandler(this.LCR_Click);
            // 
            // RCL
            // 
            this.RCL.Location = new System.Drawing.Point(164, 169);
            this.RCL.Name = "RCL";
            this.RCL.Size = new System.Drawing.Size(55, 23);
            this.RCL.TabIndex = 9;
            this.RCL.Text = "RCL";
            this.RCL.UseVisualStyleBackColor = true;
            this.RCL.Click += new System.EventHandler(this.RCL_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 198);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 212);
            this.textBox1.TabIndex = 10;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 420);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RCL);
            this.Controls.Add(this.LCR);
            this.Controls.Add(this.CLR);
            this.Controls.Add(this.listL);
            this.Controls.Add(this.deepL);
            this.Controls.Add(this.delB);
            this.Controls.Add(this.addB);
            this.Controls.Add(this.valT);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бинарное дерево";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox valT;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.Button delB;
        private System.Windows.Forms.Label deepL;
        private System.Windows.Forms.Label listL;
        private System.Windows.Forms.Button CLR;
        private System.Windows.Forms.Button LCR;
        private System.Windows.Forms.Button RCL;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

