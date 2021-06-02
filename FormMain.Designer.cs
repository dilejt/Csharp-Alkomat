
namespace Alkomat
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBoxAlko = new System.Windows.Forms.PictureBox();
            this.labelBodyMass = new System.Windows.Forms.Label();
            this.textBoxBodyMass = new System.Windows.Forms.TextBox();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.labelBigBeer = new System.Windows.Forms.Label();
            this.labelSmallBeer = new System.Windows.Forms.Label();
            this.labelWine = new System.Windows.Forms.Label();
            this.labelVodka = new System.Windows.Forms.Label();
            this.textBoxBigBeer = new System.Windows.Forms.TextBox();
            this.textBoxSmallBeer = new System.Windows.Forms.TextBox();
            this.textBoxWine = new System.Windows.Forms.TextBox();
            this.textBoxVodka = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.labelShow = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlko)).BeginInit();
            this.groupBoxGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAlko
            // 
            this.pictureBoxAlko.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAlko.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxAlko.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAlko.Image")));
            this.pictureBoxAlko.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAlko.Name = "pictureBoxAlko";
            this.pictureBoxAlko.Size = new System.Drawing.Size(497, 584);
            this.pictureBoxAlko.TabIndex = 0;
            this.pictureBoxAlko.TabStop = false;
            // 
            // labelBodyMass
            // 
            this.labelBodyMass.AutoSize = true;
            this.labelBodyMass.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBodyMass.Location = new System.Drawing.Point(589, 25);
            this.labelBodyMass.Name = "labelBodyMass";
            this.labelBodyMass.Size = new System.Drawing.Size(175, 32);
            this.labelBodyMass.TabIndex = 2;
            this.labelBodyMass.Text = "Body mass [kg]";
            // 
            // textBoxBodyMass
            // 
            this.textBoxBodyMass.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxBodyMass.Location = new System.Drawing.Point(846, 25);
            this.textBoxBodyMass.Name = "textBoxBodyMass";
            this.textBoxBodyMass.Size = new System.Drawing.Size(100, 32);
            this.textBoxBodyMass.TabIndex = 5;
            this.textBoxBodyMass.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxBodyMass_Validating);
            this.textBoxBodyMass.Validated += new System.EventHandler(this.textBoxBodyMass_Validated);
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.radioButtonMale);
            this.groupBoxGender.Controls.Add(this.radioButtonFemale);
            this.groupBoxGender.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxGender.Location = new System.Drawing.Point(660, 82);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(219, 85);
            this.groupBoxGender.TabIndex = 6;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Gender";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Checked = true;
            this.radioButtonMale.Location = new System.Drawing.Point(155, 33);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(54, 36);
            this.radioButtonMale.TabIndex = 5;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "M";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(103, 33);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(46, 36);
            this.radioButtonFemale.TabIndex = 4;
            this.radioButtonFemale.Text = "K";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // labelBigBeer
            // 
            this.labelBigBeer.AutoSize = true;
            this.labelBigBeer.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBigBeer.Location = new System.Drawing.Point(589, 205);
            this.labelBigBeer.Name = "labelBigBeer";
            this.labelBigBeer.Size = new System.Drawing.Size(190, 32);
            this.labelBigBeer.TabIndex = 7;
            this.labelBigBeer.Text = "Big beer [500ml]";
            // 
            // labelSmallBeer
            // 
            this.labelSmallBeer.AutoSize = true;
            this.labelSmallBeer.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSmallBeer.Location = new System.Drawing.Point(589, 276);
            this.labelSmallBeer.Name = "labelSmallBeer";
            this.labelSmallBeer.Size = new System.Drawing.Size(214, 32);
            this.labelSmallBeer.TabIndex = 8;
            this.labelSmallBeer.Text = "Small beer [350ml]";
            // 
            // labelWine
            // 
            this.labelWine.AutoSize = true;
            this.labelWine.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWine.Location = new System.Drawing.Point(589, 346);
            this.labelWine.Name = "labelWine";
            this.labelWine.Size = new System.Drawing.Size(156, 32);
            this.labelWine.TabIndex = 9;
            this.labelWine.Text = "Wine [175ml]";
            // 
            // labelVodka
            // 
            this.labelVodka.AutoSize = true;
            this.labelVodka.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVodka.Location = new System.Drawing.Point(589, 423);
            this.labelVodka.Name = "labelVodka";
            this.labelVodka.Size = new System.Drawing.Size(153, 32);
            this.labelVodka.TabIndex = 10;
            this.labelVodka.Text = "Vodka [50ml]";
            // 
            // textBoxBigBeer
            // 
            this.textBoxBigBeer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxBigBeer.Location = new System.Drawing.Point(846, 205);
            this.textBoxBigBeer.Name = "textBoxBigBeer";
            this.textBoxBigBeer.Size = new System.Drawing.Size(100, 32);
            this.textBoxBigBeer.TabIndex = 11;
            this.textBoxBigBeer.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxBigBeer_Validating);
            this.textBoxBigBeer.Validated += new System.EventHandler(this.textBoxBigBeer_Validated);
            // 
            // textBoxSmallBeer
            // 
            this.textBoxSmallBeer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSmallBeer.Location = new System.Drawing.Point(846, 276);
            this.textBoxSmallBeer.Name = "textBoxSmallBeer";
            this.textBoxSmallBeer.Size = new System.Drawing.Size(100, 32);
            this.textBoxSmallBeer.TabIndex = 12;
            this.textBoxSmallBeer.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSmallBeer_Validating);
            this.textBoxSmallBeer.Validated += new System.EventHandler(this.textBoxSmallBeer_Validated);
            // 
            // textBoxWine
            // 
            this.textBoxWine.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxWine.Location = new System.Drawing.Point(846, 346);
            this.textBoxWine.Name = "textBoxWine";
            this.textBoxWine.Size = new System.Drawing.Size(100, 32);
            this.textBoxWine.TabIndex = 13;
            this.textBoxWine.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxWine_Validating);
            this.textBoxWine.Validated += new System.EventHandler(this.textBoxWine_Validated);
            // 
            // textBoxVodka
            // 
            this.textBoxVodka.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxVodka.Location = new System.Drawing.Point(846, 423);
            this.textBoxVodka.Name = "textBoxVodka";
            this.textBoxVodka.Size = new System.Drawing.Size(100, 32);
            this.textBoxVodka.TabIndex = 14;
            this.textBoxVodka.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxVodka_Validating);
            this.textBoxVodka.Validated += new System.EventHandler(this.textBoxVodka_Validated);
            // 
            // buttonCalc
            // 
            this.buttonCalc.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buttonCalc.FlatAppearance.BorderSize = 4;
            this.buttonCalc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCalc.Location = new System.Drawing.Point(671, 503);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(161, 42);
            this.buttonCalc.TabIndex = 15;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // labelShow
            // 
            this.labelShow.BackColor = System.Drawing.Color.Transparent;
            this.labelShow.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelShow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelShow.Location = new System.Drawing.Point(245, 131);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(164, 57);
            this.labelShow.TabIndex = 16;
            this.labelShow.Text = "0,000";
            this.labelShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(992, 584);
            this.Controls.Add(this.labelShow);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.textBoxVodka);
            this.Controls.Add(this.textBoxWine);
            this.Controls.Add(this.textBoxSmallBeer);
            this.Controls.Add(this.textBoxBigBeer);
            this.Controls.Add(this.labelVodka);
            this.Controls.Add(this.labelWine);
            this.Controls.Add(this.labelSmallBeer);
            this.Controls.Add(this.labelBigBeer);
            this.Controls.Add(this.groupBoxGender);
            this.Controls.Add(this.textBoxBodyMass);
            this.Controls.Add(this.labelBodyMass);
            this.Controls.Add(this.pictureBoxAlko);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Text = "Alkomat by Damian Jancewicz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlko)).EndInit();
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBodyMass;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.Label labelBigBeer;
        private System.Windows.Forms.Label labelSmallBeer;
        private System.Windows.Forms.TextBox textBoxBigBeer;
        private System.Windows.Forms.TextBox textBoxSmallBeer;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label labelVodka;
        private System.Windows.Forms.TextBox textBoxVodka;
        private System.Windows.Forms.Label labelWine;
        private System.Windows.Forms.TextBox textBoxWine;
        private System.Windows.Forms.TextBox textBoxBodyMass;
        private System.Windows.Forms.PictureBox pictureBoxAlko;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

