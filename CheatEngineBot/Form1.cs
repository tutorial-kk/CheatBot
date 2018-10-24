using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheatEngineBot
{
   public partial class MainForm : Form
   {
      public MainForm()
      {
         InitializeComponent();
      }

      private void label1_Click(object sender, EventArgs e)
      {

      }

      private void label2_Click(object sender, EventArgs e)
      {

      }

      private void CrackStatusLBL_Click(object sender, EventArgs e)
      {

      }

      private void ProcessSelctCB_SelectedIndexChanged(object sender, EventArgs e)
      {

      }

      private void CloseBT_Click(object sender, EventArgs e) //닫기버튼
      {
         DialogResult result;
         result = MessageBox.Show("종료하시겠습니까?", "종료메세지", MessageBoxButtons.YesNo);
         if (result ==  DialogResult.Yes)
         {
            this.DialogResult = DialogResult.Abort;
            Application.Exit();
         }
      }
   }
}
