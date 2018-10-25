namespace CheatEngineBot
{
   partial class MainForm
   {
      /// <summary>
      /// 필수 디자이너 변수입니다.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// 사용 중인 모든 리소스를 정리합니다.
      /// </summary>
      /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form 디자이너에서 생성한 코드

      /// <summary>
      /// 디자이너 지원에 필요한 메서드입니다. 
      /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
      /// </summary>
      private void InitializeComponent()
      {
         this.label1 = new System.Windows.Forms.Label();
         this.ProcessSelectLBL = new System.Windows.Forms.Label();
         this.HelpLBL = new System.Windows.Forms.Label();
         this.CrackStatusLBL = new System.Windows.Forms.Label();
         this.ValueLBL = new System.Windows.Forms.Label();
         this.ProcessSelctCB = new System.Windows.Forms.ComboBox();
         this.CloseBT = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("맑은 고딕", 16.128F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label1.ForeColor = System.Drawing.Color.Green;
         this.label1.Location = new System.Drawing.Point(54, 40);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(298, 40);
         this.label1.TabIndex = 0;
         this.label1.Text = "치트엔진 튜토리얼 봇";
         this.label1.Click += new System.EventHandler(this.label1_Click);
         // 
         // ProcessSelectLBL
         // 
         this.ProcessSelectLBL.AutoSize = true;
         this.ProcessSelectLBL.Font = new System.Drawing.Font("맑은 고딕", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.ProcessSelectLBL.Location = new System.Drawing.Point(56, 147);
         this.ProcessSelectLBL.Name = "ProcessSelectLBL";
         this.ProcessSelectLBL.Size = new System.Drawing.Size(230, 30);
         this.ProcessSelectLBL.TabIndex = 1;
         this.ProcessSelectLBL.Text = "프로세스를 선택하세요";
         this.ProcessSelectLBL.Click += new System.EventHandler(this.label2_Click);
         // 
         // HelpLBL
         // 
         this.HelpLBL.AutoSize = true;
         this.HelpLBL.Font = new System.Drawing.Font("맑은 고딕", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.HelpLBL.Location = new System.Drawing.Point(56, 288);
         this.HelpLBL.Name = "HelpLBL";
         this.HelpLBL.Size = new System.Drawing.Size(479, 30);
         this.HelpLBL.TabIndex = 2;
         this.HelpLBL.Text = "※마우스우클릭으로 크랙의 활성화/비활성화 전환";
         // 
         // CrackStatusLBL
         // 
         this.CrackStatusLBL.AutoSize = true;
         this.CrackStatusLBL.Font = new System.Drawing.Font("맑은 고딕", 10.944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.CrackStatusLBL.Location = new System.Drawing.Point(407, 388);
         this.CrackStatusLBL.Name = "CrackStatusLBL";
         this.CrackStatusLBL.Size = new System.Drawing.Size(103, 28);
         this.CrackStatusLBL.TabIndex = 3;
         this.CrackStatusLBL.Text = "크랙상태 :";
         this.CrackStatusLBL.Click += new System.EventHandler(this.CrackStatusLBL_Click);
         // 
         // ValueLBL
         // 
         this.ValueLBL.AutoSize = true;
         this.ValueLBL.Font = new System.Drawing.Font("맑은 고딕", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.ValueLBL.Location = new System.Drawing.Point(407, 199);
         this.ValueLBL.Name = "ValueLBL";
         this.ValueLBL.Size = new System.Drawing.Size(138, 30);
         this.ValueLBL.TabIndex = 4;
         this.ValueLBL.Text = "Step2 Value :";
         // 
         // ProcessSelctCB
         // 
         this.ProcessSelctCB.DropDownHeight = 300;
         this.ProcessSelctCB.Font = new System.Drawing.Font("맑은 고딕", 10.944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.ProcessSelctCB.FormattingEnabled = true;
         this.ProcessSelctCB.IntegralHeight = false;
         this.ProcessSelctCB.Location = new System.Drawing.Point(61, 196);
         this.ProcessSelctCB.Name = "ProcessSelctCB";
         this.ProcessSelctCB.Size = new System.Drawing.Size(277, 33);
         this.ProcessSelctCB.TabIndex = 5;
         this.ProcessSelctCB.Text = "프로세스 선택";
         this.ProcessSelctCB.SelectedIndexChanged += new System.EventHandler(this.ProcessSelctCB_SelectedIndexChanged);
         this.ProcessSelctCB.Click += new System.EventHandler(this.ProcessSelctCB_Click);
         // 
         // CloseBT
         // 
         this.CloseBT.Font = new System.Drawing.Font("맑은 고딕", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.CloseBT.Location = new System.Drawing.Point(624, 449);
         this.CloseBT.Name = "CloseBT";
         this.CloseBT.Size = new System.Drawing.Size(115, 39);
         this.CloseBT.TabIndex = 7;
         this.CloseBT.Text = "닫기";
         this.CloseBT.UseVisualStyleBackColor = true;
         this.CloseBT.Click += new System.EventHandler(this.CloseBT_Click);
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(805, 512);
         this.Controls.Add(this.CloseBT);
         this.Controls.Add(this.ProcessSelctCB);
         this.Controls.Add(this.ValueLBL);
         this.Controls.Add(this.CrackStatusLBL);
         this.Controls.Add(this.HelpLBL);
         this.Controls.Add(this.ProcessSelectLBL);
         this.Controls.Add(this.label1);
         this.Name = "MainForm";
         this.Text = "cheatBot";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label ProcessSelectLBL;
      private System.Windows.Forms.Label HelpLBL;
      private System.Windows.Forms.Label CrackStatusLBL;
      private System.Windows.Forms.Label ValueLBL;
      private System.Windows.Forms.ComboBox ProcessSelctCB;
      private System.Windows.Forms.Button CloseBT;
   }
}

