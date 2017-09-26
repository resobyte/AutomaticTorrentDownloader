using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quartz;

namespace uTorrent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);


        private void btnSelect_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            file.Filter = "Torrentler |*.torrent";
    
            string DosyaYolu = "";
            string DosyaAdi = " ";

            if (file.ShowDialog() == DialogResult.OK)
            {
                DosyaYolu = file.FileName;
                DosyaAdi = file.SafeFileName;

            }

            ////ISimpleTrigger trigger = (ISimpleTrigger)TriggerBuilder.Create()
            ////    .WithIdentity("trigger1", "group1") // Trigger name ve group
            ////    .WithSimpleSchedule(x => x
            ////        .WithIntervalInMinutes(1) // Ne kadar süre aralığında çalığacağı belirleniyor - 1 dakika
            ////        .RepeatForever()) // Sonsuza Dek
            ////    .EndAt(DateBuilder.DateOf(22, 0, 0)) // Belirlenen saat: 22:00
            ////    .Build();
            /// 

            Process.Start(Path.Combine(DosyaYolu));
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            DateTime dt1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0,0);

            TimeSpan dtTotal = (dt1 - dt);
            double total = (dtTotal.Hours * 3600 + dtTotal.Minutes * 60 + dtTotal.Seconds);

            process.StartInfo.Arguments = "/K shutdown -s -t "+total ;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            process.Start();
            Thread.Sleep(2000);
            process.Kill();

            
        }
    }
}
