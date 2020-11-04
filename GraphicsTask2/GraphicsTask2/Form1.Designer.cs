namespace GraphicsTask2
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
            this.DrawLineButton = new System.Windows.Forms.Button();
            this.TbLineY2 = new System.Windows.Forms.TextBox();
            this.TbLineX2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TbLineY1 = new System.Windows.Forms.TextBox();
            this.TbLineX1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DrawCircleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawLineButton
            // 
            this.DrawLineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DrawLineButton.Location = new System.Drawing.Point(12, 186);
            this.DrawLineButton.Name = "DrawLineButton";
            this.DrawLineButton.Size = new System.Drawing.Size(105, 33);
            this.DrawLineButton.TabIndex = 20;
            this.DrawLineButton.Text = "Draw line";
            this.DrawLineButton.UseVisualStyleBackColor = true;
            this.DrawLineButton.Click += new System.EventHandler(this.DrawLineButton_Click);
            // 
            // TbLineY2
            // 
            this.TbLineY2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbLineY2.Location = new System.Drawing.Point(46, 151);
            this.TbLineY2.Name = "TbLineY2";
            this.TbLineY2.Size = new System.Drawing.Size(71, 29);
            this.TbLineY2.TabIndex = 19;
            // 
            // TbLineX2
            // 
            this.TbLineX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbLineX2.Location = new System.Drawing.Point(46, 116);
            this.TbLineX2.Name = "TbLineX2";
            this.TbLineX2.Size = new System.Drawing.Size(71, 29);
            this.TbLineX2.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Y2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "X2: ";
            // 
            // TbLineY1
            // 
            this.TbLineY1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbLineY1.Location = new System.Drawing.Point(46, 81);
            this.TbLineY1.Name = "TbLineY1";
            this.TbLineY1.Size = new System.Drawing.Size(71, 29);
            this.TbLineY1.TabIndex = 15;
            // 
            // TbLineX1
            // 
            this.TbLineX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbLineX1.Location = new System.Drawing.Point(46, 46);
            this.TbLineX1.Name = "TbLineX1";
            this.TbLineX1.Size = new System.Drawing.Size(71, 29);
            this.TbLineX1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Y1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "X1: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Draw line";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(123, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(978, 541);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // DrawCircleBtn
            // 
            this.DrawCircleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DrawCircleBtn.Location = new System.Drawing.Point(12, 225);
            this.DrawCircleBtn.Name = "DrawCircleBtn";
            this.DrawCircleBtn.Size = new System.Drawing.Size(105, 61);
            this.DrawCircleBtn.TabIndex = 22;
            this.DrawCircleBtn.Text = "Draw Circle";
            this.DrawCircleBtn.UseVisualStyleBackColor = true;
            this.DrawCircleBtn.Click += new System.EventHandler(this.DrawCircleBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 541);
            this.Controls.Add(this.DrawCircleBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TbLineY1);
            this.Controls.Add(this.DrawLineButton);
            this.Controls.Add(this.TbLineY2);
            this.Controls.Add(this.TbLineX2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbLineX1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DrawLineButton;
        private System.Windows.Forms.TextBox TbLineY2;
        private System.Windows.Forms.TextBox TbLineX2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbLineY1;
        private System.Windows.Forms.TextBox TbLineX1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DrawCircleBtn;
    }
}

