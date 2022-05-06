
namespace Ionic_Arc
{
    partial class main_wndv
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
            this.choose_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AdresPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // choose_btn
            // 
            this.choose_btn.Location = new System.Drawing.Point(60, 54);
            this.choose_btn.Name = "choose_btn";
            this.choose_btn.Size = new System.Drawing.Size(100, 32);
            this.choose_btn.TabIndex = 0;
            this.choose_btn.Text = "Выберите  папку";
            this.choose_btn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Сохранить архив";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AdresPath
            // 
            this.AdresPath.Location = new System.Drawing.Point(12, 12);
            this.AdresPath.Name = "AdresPath";
            this.AdresPath.Size = new System.Drawing.Size(207, 20);
            this.AdresPath.TabIndex = 2;
            // 
            // main_wndv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 164);
            this.Controls.Add(this.AdresPath);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.choose_btn);
            this.Name = "main_wndv";
            this.Text = "Архиватор Ionic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button choose_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox AdresPath;
    }
}

