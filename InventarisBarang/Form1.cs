using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarisBarang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MaximizedBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            NavigatorPanel.Height = DashboardBtn.Height;
            NavigatorPanel.Top = DashboardBtn.Top;
        }

        private void UserBtn_Click(object sender, EventArgs e)
        {
            NavigatorPanel.Height = PrintReportNavBtn.Height;
            NavigatorPanel.Top = PrintReportNavBtn.Top;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
          
            bool IsOpen = false;
            foreach (Form  hp in Application.OpenForms) {
                if (hp.Name == "HelpPage")
                {
                    IsOpen = true;
                    hp.BringToFront();
                    break;
                }
            }
            if (IsOpen == false)
            {
                HelpPage Halbantuan = new HelpPage();
                Halbantuan.Show();
            }
           
  
        }
    }
}
