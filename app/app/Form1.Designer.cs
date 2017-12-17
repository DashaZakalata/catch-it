namespace app
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
            this.Icon1 = new System.Windows.Forms.PictureBox();
            this.Icon2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Icon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // Icon1
            // 
            this.Icon1.Location = new System.Drawing.Point(154, 12);
            this.Icon1.Name = "Icon1";
            this.Icon1.Size = new System.Drawing.Size(65, 50);
            this.Icon1.TabIndex = 1;
            this.Icon1.TabStop = false;
            this.Icon1.Click += new System.EventHandler(this.Icon1_Click);
            // 
            // Icon2
            // 
            this.Icon2.Location = new System.Drawing.Point(285, -129);
            this.Icon2.Name = "Icon2";
            this.Icon2.Size = new System.Drawing.Size(65, 50);
            this.Icon2.TabIndex = 2;
            this.Icon2.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = global::app.Properties.Resources.prog1;
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player.Location = new System.Drawing.Point(-7, 225);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(146, 141);
            this.player.TabIndex = 3;
            this.player.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::app.Properties.Resources.xp_windows_vektor_74137_2560x1440;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.player);
            this.Controls.Add(this.Icon2);
            this.Controls.Add(this.Icon1);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Icon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Icon1;
        private System.Windows.Forms.PictureBox Icon2;
        private System.Windows.Forms.PictureBox player;
    }
}

