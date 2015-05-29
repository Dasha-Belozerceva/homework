namespace moveButton
{
    partial class MoveButtonApplication
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MoveButton
            // 
            this.MoveButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoveButton.Location = new System.Drawing.Point(155, 72);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(97, 71);
            this.MoveButton.TabIndex = 0;
            this.MoveButton.Text = "catch me!";
            this.MoveButton.UseVisualStyleBackColor = false;
            this.MoveButton.Click += new System.EventHandler(this.MoveButton_Click);
            this.MoveButton.MouseEnter += new System.EventHandler(this.MoveButton_MouseEnter);
            // 
            // MoveButtonApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(517, 320);
            this.Controls.Add(this.MoveButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(533, 359);
            this.MinimumSize = new System.Drawing.Size(533, 359);
            this.Name = "MoveButtonApplication";
            this.Text = "MoveButton Application";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MoveButton;
    }
}

