using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using ProcessMemoryReaderLib;

namespace CheatEngineBot
{
   public partial class MainForm : Form
   {
      Process[ ] MyProcess;
      ProcessMemoryReader mem = new ProcessMemoryReader();
      bool attach = false;

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
      //클릭시 프로세스 리스트검색
      private void ProcessSelctCB_Click(object sender, EventArgs e)
      {
         ProcessSelctCB.Items.Clear(); // 기존목록 초기화
         MyProcess = Process.GetProcesses(); //목록불러오기
         for (int i=0; i<MyProcess.Length; i++)
         {
            string txt = MyProcess[i].ProcessName + "-" + MyProcess[i].Id;
            ProcessSelctCB.Items.Add(txt);
         }
      }
      //선택한 프로세스 어태치
      private void ProcessSelctCB_SelectedIndexChanged(object sender, EventArgs e)
      {
         try  // 어태치 성공
         {
            if(ProcessSelctCB.SelectedIndex != -1)
            {
               string selectedItem = ProcessSelctCB.SelectedItem.ToString();
               string txt = selectedItem.Split('-')[selectedItem.Split('-').Length - 1];
               int pid = int.Parse(txt);
               Process attachProc = Process.GetProcessById(pid);

               mem.ReadProcess = attachProc;
               mem.OpenProcess();
               attach = true;
               MessageBox.Show("프로세스 권한(어태치) 성공! - " + attachProc.ProcessName);
            }
         }
         catch(Exception ex)  
         {
            attach = false;
            MessageBox.Show("프로세스 어태치에 실패! - " + ex.Message);
         }
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
