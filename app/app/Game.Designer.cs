namespace app
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.Icon1 = new System.Windows.Forms.PictureBox();
            this.Icon2 = new System.Windows.Forms.PictureBox();
            this.Icon3 = new System.Windows.Forms.PictureBox();
            this.Icon4 = new System.Windows.Forms.PictureBox();
            this.Icon5 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon5)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.Wheat;
            this.TextBox.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.TextBox.Enabled = false;
            this.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TextBox.HideSelection = false;
            this.TextBox.Location = new System.Drawing.Point(653, 61);
            this.TextBox.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBox.ShowSelectionMargin = true;
            this.TextBox.Size = new System.Drawing.Size(108, 38);
            this.TextBox.TabIndex = 10;
            this.TextBox.Text = "0";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = global::app.Properties.Resources.prog1;
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player.Location = new System.Drawing.Point(1, 296);
            this.player.Margin = new System.Windows.Forms.Padding(4);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(176, 156);
            this.player.TabIndex = 9;
            this.player.TabStop = false;
            // 
            // Icon1
            // 
            this.Icon1.BackColor = System.Drawing.Color.Transparent;
            this.Icon1.BackgroundImage = global::app.Properties.Resources.Icon1;
            this.Icon1.Location = new System.Drawing.Point(65, 13);
            this.Icon1.Margin = new System.Windows.Forms.Padding(4);
            this.Icon1.Name = "Icon1";
            this.Icon1.Size = new System.Drawing.Size(80, 74);
            this.Icon1.TabIndex = 8;
            this.Icon1.TabStop = false;
            // 
            // Icon2
            // 
            this.Icon2.BackColor = System.Drawing.Color.Transparent;
            this.Icon2.BackgroundImage = global::app.Properties.Resources.Icon2;
            this.Icon2.Location = new System.Drawing.Point(321, -135);
            this.Icon2.Margin = new System.Windows.Forms.Padding(4);
            this.Icon2.Name = "Icon2";
            this.Icon2.Size = new System.Drawing.Size(80, 74);
            this.Icon2.TabIndex = 11;
            this.Icon2.TabStop = false;
            // 
            // Icon3
            // 
            this.Icon3.BackColor = System.Drawing.Color.Transparent;
            this.Icon3.BackgroundImage = global::app.Properties.Resources.Icon3;
            this.Icon3.Location = new System.Drawing.Point(181, -86);
            this.Icon3.Margin = new System.Windows.Forms.Padding(4);
            this.Icon3.Name = "Icon3";
            this.Icon3.Size = new System.Drawing.Size(80, 74);
            this.Icon3.TabIndex = 12;
            this.Icon3.TabStop = false;
            // 
            // Icon4
            // 
            this.Icon4.BackColor = System.Drawing.Color.Transparent;
            this.Icon4.BackgroundImage = global::app.Properties.Resources.Icon4;
            this.Icon4.Location = new System.Drawing.Point(525, -209);
            this.Icon4.Margin = new System.Windows.Forms.Padding(4);
            this.Icon4.Name = "Icon4";
            this.Icon4.Size = new System.Drawing.Size(80, 74);
            this.Icon4.TabIndex = 13;
            this.Icon4.TabStop = false;
            // 
            // Icon5
            // 
            this.Icon5.BackColor = System.Drawing.Color.Transparent;
            this.Icon5.BackgroundImage = global::app.Properties.Resources.Icon5;
            this.Icon5.Location = new System.Drawing.Point(680, -283);
            this.Icon5.Margin = new System.Windows.Forms.Padding(4);
            this.Icon5.Name = "Icon5";
            this.Icon5.Size = new System.Drawing.Size(80, 74);
            this.Icon5.TabIndex = 14;
            this.Icon5.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(6, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(845, 444);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Icon5);
            this.Controls.Add(this.Icon4);
            this.Controls.Add(this.Icon3);
            this.Controls.Add(this.Icon2);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.player);
            this.Controls.Add(this.Icon1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catch It";
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox Icon1;
        private System.Windows.Forms.PictureBox Icon2;
        private System.Windows.Forms.PictureBox Icon3;
        private System.Windows.Forms.PictureBox Icon4;
        private System.Windows.Forms.PictureBox Icon5;
        private System.Windows.Forms.Button button1;
    }
}