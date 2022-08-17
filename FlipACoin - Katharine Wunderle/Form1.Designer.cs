
namespace FlipACoin___Katharine_Wunderle
{
    partial class FlipACoin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlipACoin));
            this.flipButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.headsPicture = new System.Windows.Forms.PictureBox();
            this.tailsPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.headsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailsPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // flipButton
            // 
            this.flipButton.Location = new System.Drawing.Point(7, 172);
            this.flipButton.Name = "flipButton";
            this.flipButton.Size = new System.Drawing.Size(75, 23);
            this.flipButton.TabIndex = 0;
            this.flipButton.Text = "Flip a Coin";
            this.flipButton.UseVisualStyleBackColor = true;
            this.flipButton.Click += new System.EventHandler(this.flipButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Enabled = false;
            this.clearButton.Location = new System.Drawing.Point(86, 172);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(166, 172);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // headsPicture
            // 
            this.headsPicture.Image = ((System.Drawing.Image)(resources.GetObject("headsPicture.Image")));
            this.headsPicture.Location = new System.Drawing.Point(42, 12);
            this.headsPicture.Name = "headsPicture";
            this.headsPicture.Size = new System.Drawing.Size(167, 149);
            this.headsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headsPicture.TabIndex = 3;
            this.headsPicture.TabStop = false;
            this.headsPicture.Visible = false;
            // 
            // tailsPicture
            // 
            this.tailsPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.tailsPicture.Image = ((System.Drawing.Image)(resources.GetObject("tailsPicture.Image")));
            this.tailsPicture.Location = new System.Drawing.Point(42, 12);
            this.tailsPicture.Name = "tailsPicture";
            this.tailsPicture.Size = new System.Drawing.Size(167, 149);
            this.tailsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tailsPicture.TabIndex = 4;
            this.tailsPicture.TabStop = false;
            this.tailsPicture.Visible = false;
            // 
            // FlipACoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 207);
            this.Controls.Add(this.tailsPicture);
            this.Controls.Add(this.headsPicture);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.flipButton);
            this.Name = "FlipACoin";
            this.Text = "Flip a Coin";
            ((System.ComponentModel.ISupportInitialize)(this.headsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailsPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button flipButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox headsPicture;
        private System.Windows.Forms.PictureBox tailsPicture;
    }
}

