
namespace Alkomat
{
    partial class FormInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            this.pictureBoxSign = new System.Windows.Forms.PictureBox();
            this.labelDrunk = new System.Windows.Forms.Label();
            this.labelSign = new System.Windows.Forms.Label();
            this.progressBarPromile = new System.Windows.Forms.ProgressBar();
            this.pictureBoxDrunk = new System.Windows.Forms.PictureBox();
            this.labelTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrunk)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSign
            // 
            this.pictureBoxSign.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSign.Image")));
            this.pictureBoxSign.Location = new System.Drawing.Point(540, 126);
            this.pictureBoxSign.Name = "pictureBoxSign";
            this.pictureBoxSign.Size = new System.Drawing.Size(260, 301);
            this.pictureBoxSign.TabIndex = 3;
            this.pictureBoxSign.TabStop = false;
            // 
            // labelDrunk
            // 
            this.labelDrunk.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelDrunk.Location = new System.Drawing.Point(310, 9);
            this.labelDrunk.Name = "labelDrunk";
            this.labelDrunk.Size = new System.Drawing.Size(478, 114);
            this.labelDrunk.TabIndex = 4;
            this.labelDrunk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSign
            // 
            this.labelSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(145)))), ((int)(((byte)(42)))));
            this.labelSign.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSign.Location = new System.Drawing.Point(555, 161);
            this.labelSign.Name = "labelSign";
            this.labelSign.Size = new System.Drawing.Size(184, 62);
            this.labelSign.TabIndex = 5;
            this.labelSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBarPromile
            // 
            this.progressBarPromile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarPromile.Location = new System.Drawing.Point(0, 427);
            this.progressBarPromile.MarqueeAnimationSpeed = 60;
            this.progressBarPromile.Maximum = 4500;
            this.progressBarPromile.Name = "progressBarPromile";
            this.progressBarPromile.Size = new System.Drawing.Size(800, 23);
            this.progressBarPromile.TabIndex = 6;
            // 
            // pictureBoxDrunk
            // 
            this.pictureBoxDrunk.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxDrunk.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDrunk.Name = "pictureBoxDrunk";
            this.pictureBoxDrunk.Size = new System.Drawing.Size(304, 427);
            this.pictureBoxDrunk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDrunk.TabIndex = 7;
            this.pictureBoxDrunk.TabStop = false;
            // 
            // labelTime
            // 
            this.labelTime.BackColor = System.Drawing.Color.Black;
            this.labelTime.Font = new System.Drawing.Font("Berlin Sans FB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTime.ForeColor = System.Drawing.Color.Green;
            this.labelTime.Location = new System.Drawing.Point(310, 302);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(224, 122);
            this.labelTime.TabIndex = 8;
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.pictureBoxDrunk);
            this.Controls.Add(this.progressBarPromile);
            this.Controls.Add(this.labelSign);
            this.Controls.Add(this.labelDrunk);
            this.Controls.Add(this.pictureBoxSign);
            this.Name = "FormInfo";
            this.Text = "Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormInfo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrunk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxSign;
        private System.Windows.Forms.Label labelDrunk;
        private System.Windows.Forms.Label labelSign;
        private System.Windows.Forms.ProgressBar progressBarPromile;
        private System.Windows.Forms.PictureBox pictureBoxDrunk;
        private System.Windows.Forms.Label labelTime;
    }
}