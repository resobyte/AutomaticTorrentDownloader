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
            file.ShowDialog();
            string DosyaYolu = "";
            string DosyaAdi = " ";
            if (file.ShowDialog() == DialogResult.OK)
            {
                DosyaYolu = file.FileName;
                DosyaAdi = file.SafeFileName;
                    
            }
           
                ISimpleTrigger trigger = (ISimpleTrigger)TriggerBuilder.Create()
                    .WithIdentity("trigger1", "group1") // Trigger name ve group
                    .WithSimpleSchedule(x => x
                        .WithIntervalInMinutes(1) // Ne kadar süre aralığında çalığacağı belirleniyor - 1 dakika
                        .RepeatForever()) // Sonsuza Dek
                    .EndAt(DateBuilder.DateOf(22, 0, 0)) // Belirlenen saat: 22:00
                    .Build();
               

            
            


        }
    }
}
