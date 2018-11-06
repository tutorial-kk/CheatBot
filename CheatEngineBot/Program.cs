using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal; //관리자권한실행관련
using System.Diagnostics; //진단



namespace CheatEngineBot
{
   static class Program
   {
      /// <summary>
      /// 해당 응용 프로그램의 주 진입점입니다.
      /// </summary>
      [STAThread]
      static void Main()
      {
         if (IsAdministrator() == false) //관리자권한으로 실행되지않으면
         {
            try
            {
               ProcessStartInfo procInfo = new ProcessStartInfo();
               procInfo.UseShellExecute = true;
               procInfo.FileName = Application.ExecutablePath;
               procInfo.WorkingDirectory = Environment.CurrentDirectory;
               procInfo.Verb = "runas";
               Process.Start(procInfo);
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message.ToString());
                return;
            }
          }
        else
         {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
         }
      }

      private static bool IsAdministrator()   
      {
         WindowsIdentity identity = WindowsIdentity.GetCurrent();

         if (null != identity)
         {
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
         }
         return false;
      }
   }

   // 구조체의 위치정보
   public class Step2Data
   {
      public int baseAdress;  //005FD5D0
      public int[] multiLevel; //0x480, ......
      public Step2DataStruct offsets; //해당구조체에 들어있는 각종변수(hp,mp, ....)분석

      public Step2Data(int addr, int[] level, Step2DataStruct offset)
      {
         this.baseAdress = addr;
         this.multiLevel = level;
         this.offsets = offset;
      }
   }

   //구조체멤버의 주소정보 전달
   public class Step2DataStruct
   {
      public int step2_health; //위치정보(오프셋) 0x480
      // int mp; //500

      public Step2DataStruct(int health)
      {
         step2_health = health;
      }
   }
}
