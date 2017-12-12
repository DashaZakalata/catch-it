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
            this.player = new System.Windows.Forms.PictureBox();
            this.Icon1 = new System.Windows.Forms.PictureBox();
            this.Icon2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon2)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = global::app.Properties.Resources.prog;
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player.Location = new System.Drawing.Point(-7, 252);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(173, 163);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // Icon1
            // 
            this.Icon1.Location = new System.Drawing.Point(130, 29);
            this.Icon1.Name = "Icon1";
            this.Icon1.Size = new System.Drawing.Size(65, 50);
            this.Icon1.TabIndex = 1;
            this.Icon1.TabStop = false;
            // 
            // Icon2
            // 
            this.Icon2.Location = new System.Drawing.Point(285, 29);
            this.Icon2.Name = "Icon2";
            this.Icon2.Size = new System.Drawing.Size(65, 50);
            this.Icon2.TabIndex = 2;
            this.Icon2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::app.Properties.Resources.xp_windows_vektor_74137_2560x1440;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.Icon2);
            this.Controls.Add(this.Icon1);
            this.Controls.Add(this.player);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox Icon1;
        private System.Windows.Forms.PictureBox Icon2;
    }
}

