namespace Lab1
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
            this.TextA = new System.Windows.Forms.TextBox();
            this.textB = new System.Windows.Forms.TextBox();
            this.textN = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.buttonCal = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.LabelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextA
            // 
            this.TextA.Location = new System.Drawing.Point(48, 12);
            this.TextA.Name = "TextA";
            this.TextA.Size = new System.Drawing.Size(85, 22);
            this.TextA.TabIndex = 0;
            // 
            // textB
            // 
            this.textB.Location = new System.Drawing.Point(48, 52);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(85, 22);
            this.textB.TabIndex = 1;
            // 
            // textN
            // 
            this.textN.Location = new System.Drawing.Point(48, 90);
            this.textN.Name = "textN";
            this.textN.Size = new System.Drawing.Size(85, 22);
            this.textN.TabIndex = 2;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(22, 15);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(20, 17);
            this.labelA.TabIndex = 3;
            this.labelA.Text = "a:";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(22, 52);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(20, 17);
            this.labelB.TabIndex = 4;
            this.labelB.Text = "b:";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(22, 90);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(20, 17);
            this.labelN.TabIndex = 5;
            this.labelN.Text = "n:";
            // 
            // buttonCal
            // 
            this.buttonCal.Location = new System.Drawing.Point(158, 40);
            this.buttonCal.Name = "buttonCal";
            this.buttonCal.Size = new System.Drawing.Size(180, 73);
            this.buttonCal.TabIndex = 6;
            this.buttonCal.Text = "Вычислить";
            this.buttonCal.UseVisualStyleBackColor = true;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(241, 12);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(100, 22);
            this.textBoxResult.TabIndex = 7;
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.Location = new System.Drawing.Point(155, 12);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(80, 17);
            this.LabelResult.TabIndex = 8;
            this.LabelResult.Text = "Результат:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 128);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonCal);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.textN);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.TextA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextA;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.TextBox textN;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Button buttonCal;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label LabelResult;
    }
}

