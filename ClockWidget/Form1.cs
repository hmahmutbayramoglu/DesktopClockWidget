using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockWidget
{
    public partial class Form1 : Form
    {

                string ProgramAdi = "DesktopClock";
        public Form1()
        {
            InitializeComponent();


            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);

                if (key.GetValue(ProgramAdi) == "\"" + Application.ExecutablePath + "\"")
                {
                    // Eğer regeditte varsa, checkbox ı işaretle
                    bunifuCheckbox1.Checked = true;
                }
            }
            catch
            {

            }



        }



      


        DateTime DateTime = new DateTime();
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_clock.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
 
           
            lbl_Hours.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
          
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    

        private void lbl_Hours_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked)
            { //işaretlendi ise Regedit e açılışta çalıştır olarak ekle
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.SetValue(ProgramAdi, "\"" + Application.ExecutablePath + "\"");
            }
            else
            {  //işaret kaldırıldı ise Regeditten açılışta çalıştırılacaklardan kaldır
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.DeleteValue(ProgramAdi);
            }
        }
    }
}
