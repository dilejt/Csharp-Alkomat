using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;

namespace Alkomat
{
    public partial class FormInfo : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);

        private Result result;
        private SoundPlayer soundPlayer;

        //public FormInfo()
        //{
        //    InitializeComponent();
        //}

        public FormInfo(Result result)
        {
            InitializeComponent();
            this.result = result;
            Progress();
            ShowStuff();
        }
        public void Progress()
        {
            int promile = Convert.ToInt32(result.resultPromile * 1000);
            this.progressBarPromile.Value = (promile > 4500)? 4500:promile;
            if (promile >= 4000)
            {
                SendMessage(this.progressBarPromile.Handle, 1040, (IntPtr)2, IntPtr.Zero);
                PlayMusic("HeavyMetal.wav");
            }
            else if (promile >= 1500 && promile < 4000)
            {
                SendMessage(this.progressBarPromile.Handle, 1040, (IntPtr)3, IntPtr.Zero);
                PlayMusic("Rasputin.wav");
            }
            else
            {
                SendMessage(this.progressBarPromile.Handle, 1040, (IntPtr)1, IntPtr.Zero);
                PlayMusic("Lullaby.wav");
            }
        }
        public void ShowStuff()
        {
            FileOperation operation = new FileOperation();
            Random random = new Random();
            int promile = Convert.ToInt32(result.resultPromile * 1000);
            
            if (promile < 200)
            {
                this.labelDrunk.Text = operation.descriptions[0][random.Next(operation.descriptions[0].Length)];
                this.labelSign.ForeColor = Color.YellowGreen;
                this.pictureBoxDrunk.ImageLocation = @"drunk1.jpg";
            }
            else if(promile >= 200 && promile < 600)
            {
                this.labelDrunk.Text = operation.descriptions[1][random.Next(operation.descriptions[1].Length)];
                this.labelSign.ForeColor = Color.Green;
                this.pictureBoxDrunk.ImageLocation = @"drunk2.jpg";
            }
            else if (promile >= 600 && promile < 1600)
            {
                this.labelDrunk.Text = operation.descriptions[2][random.Next(operation.descriptions[2].Length)];
                this.labelSign.ForeColor = Color.Yellow;
                this.pictureBoxDrunk.ImageLocation = @"drunk3.jpg";
            }
            else if (promile >= 1600 && promile < 4000)
            {
                this.labelDrunk.Text = operation.descriptions[3][random.Next(operation.descriptions[3].Length)];
                this.labelSign.ForeColor = Color.OrangeRed;
                this.pictureBoxDrunk.ImageLocation = @"drunk4.jpg";
            }
            else
            {
                this.labelDrunk.Text = operation.descriptions[4][random.Next(operation.descriptions[4].Length)];
                this.labelSign.ForeColor = Color.DarkRed;
                this.pictureBoxDrunk.ImageLocation = @"drunk5.jpg";
            }
            this.labelSign.Text = result.resultPromile + " ‰";
            this.labelTime.Text = result.timeDetox + " left to detox!";
        }
        public void PlayMusic(string fileName)
        {
            this.soundPlayer = new SoundPlayer(fileName);
            this.soundPlayer.Play();
        }

        private void FormInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.soundPlayer.Stop();
        }
    }
    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}
