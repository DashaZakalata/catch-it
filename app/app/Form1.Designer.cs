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
            this.Icon5 = new System.Windows.Forms.PictureBox();
            this.Icon4 = new System.Windows.Forms.PictureBox();
            this.Icon3 = new System.Windows.Forms.PictureBox();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Icon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon3)).BeginInit();
            this.SuspendLayout();
            // 
            // Icon1
            // 
            this.Icon1.BackColor = System.Drawing.Color.Transparent;
            this.Icon1.BackgroundImage = global::app.Properties.Resources.Icon1;
            this.Icon1.Location = new System.Drawing.Point(30, 10);
            this.Icon1.Name = "Icon1";
            this.Icon1.Size = new System.Drawing.Size(60, 60);
            this.Icon1.TabIndex = 1;
            this.Icon1.TabStop = false;
            this.Icon1.Click += new System.EventHandler(this.Icon1_Click);
            // 
            // Icon2
            // 
            this.Icon2.BackColor = System.Drawing.Color.Transparent;
            this.Icon2.BackgroundImage = global::app.Properties.Resources.Icon2;
            this.Icon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Icon2.Location = new System.Drawing.Point(241, -110);
            this.Icon2.Name = "Icon2";
            this.Icon2.Size = new System.Drawing.Size(60, 60);
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
            // Icon5
            // 
            this.Icon5.BackColor = System.Drawing.Color.Transparent;
            this.Icon5.BackgroundImage = global::app.Properties.Resources.Icon5;
            this.Icon5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Icon5.Location = new System.Drawing.Point(510, -230);
            this.Icon5.Name = "Icon5";
            this.Icon5.Size = new System.Drawing.Size(60, 60);
            this.Icon5.TabIndex = 4;
            this.Icon5.TabStop = false;
            // 
            // Icon4
            // 
            this.Icon4.BackColor = System.Drawing.Color.Transparent;
            this.Icon4.BackgroundImage = global::app.Properties.Resources.Icon4;
            this.Icon4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Icon4.Location = new System.Drawing.Point(394, -170);
            this.Icon4.Name = "Icon4";
            this.Icon4.Size = new System.Drawing.Size(60, 60);
            this.Icon4.TabIndex = 5;
            this.Icon4.TabStop = false;
            // 
            // Icon3
            // 
            this.Icon3.BackColor = System.Drawing.Color.Transparent;
            this.Icon3.BackgroundImage = global::app.Properties.Resources.Icon3;
            this.Icon3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Icon3.Location = new System.Drawing.Point(136, -70);
            this.Icon3.Name = "Icon3";
            this.Icon3.Size = new System.Drawing.Size(60, 60);
            this.Icon3.TabIndex = 5;
            this.Icon3.TabStop = false;
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.Wheat;
            this.TextBox.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.TextBox.Enabled = false;
            this.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TextBox.HideSelection = false;
            this.TextBox.Location = new System.Drawing.Point(540, 10);
            this.TextBox.Margin = new System.Windows.Forms.Padding(13);
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBox.Size = new System.Drawing.Size(82, 32);
            this.TextBox.TabIndex = 7;
            this.TextBox.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::app.Properties.Resources.xp_windows_vektor_74137_2560x1440;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Icon3);
            this.Controls.Add(this.Icon4);
            this.Controls.Add(this.Icon5);
            this.Controls.Add(this.player);
            this.Controls.Add(this.Icon2);
            this.Controls.Add(this.Icon1);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Icon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Icon1;
        private System.Windows.Forms.PictureBox Icon2;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox Icon5;
        private System.Windows.Forms.PictureBox Icon4;
        private System.Windows.Forms.PictureBox Icon3;
        private System.Windows.Forms.RichTextBox TextBox;
    }
}

