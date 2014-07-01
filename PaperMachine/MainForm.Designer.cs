namespace PaperMachine
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.label_InfoText = new System.Windows.Forms.Label();
            this.label_InfoTime = new System.Windows.Forms.Label();
            this.textBox_InputTime = new System.Windows.Forms.TextBox();
            this.label_InfoNum = new System.Windows.Forms.Label();
            this.textBox_InputNum = new System.Windows.Forms.TextBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.label_Info = new System.Windows.Forms.Label();
            this.button_Stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Input
            // 
            this.textBox_Input.Location = new System.Drawing.Point(12, 24);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(296, 21);
            this.textBox_Input.TabIndex = 0;
            // 
            // label_InfoText
            // 
            this.label_InfoText.AutoSize = true;
            this.label_InfoText.Location = new System.Drawing.Point(10, 9);
            this.label_InfoText.Name = "label_InfoText";
            this.label_InfoText.Size = new System.Drawing.Size(140, 12);
            this.label_InfoText.TabIndex = 1;
            this.label_InfoText.Text = "Please input your text : ";
            // 
            // label_InfoTime
            // 
            this.label_InfoTime.AutoSize = true;
            this.label_InfoTime.Location = new System.Drawing.Point(10, 62);
            this.label_InfoTime.Name = "label_InfoTime";
            this.label_InfoTime.Size = new System.Drawing.Size(236, 12);
            this.label_InfoTime.TabIndex = 2;
            this.label_InfoTime.Text = "Please input sleep time (milliseconds) : ";
            // 
            // textBox_InputTime
            // 
            this.textBox_InputTime.Location = new System.Drawing.Point(252, 57);
            this.textBox_InputTime.Name = "textBox_InputTime";
            this.textBox_InputTime.Size = new System.Drawing.Size(56, 21);
            this.textBox_InputTime.TabIndex = 1;
            // 
            // label_InfoNum
            // 
            this.label_InfoNum.AutoSize = true;
            this.label_InfoNum.Location = new System.Drawing.Point(10, 95);
            this.label_InfoNum.Name = "label_InfoNum";
            this.label_InfoNum.Size = new System.Drawing.Size(236, 12);
            this.label_InfoNum.TabIndex = 4;
            this.label_InfoNum.Text = "Please input the number of iterations    : ";
            // 
            // textBox_InputNum
            // 
            this.textBox_InputNum.Location = new System.Drawing.Point(252, 91);
            this.textBox_InputNum.Name = "textBox_InputNum";
            this.textBox_InputNum.Size = new System.Drawing.Size(56, 21);
            this.textBox_InputNum.TabIndex = 2;
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(12, 152);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(296, 23);
            this.button_Start.TabIndex = 3;
            this.button_Start.Text = "Start papering";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Location = new System.Drawing.Point(12, 134);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(152, 12);
            this.label_Info.TabIndex = 6;
            this.label_Info.Text = "Please click button now : ";
            // 
            // button_Stop
            // 
            this.button_Stop.Enabled = false;
            this.button_Stop.Location = new System.Drawing.Point(12, 181);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(296, 23);
            this.button_Stop.TabIndex = 3;
            this.button_Stop.Text = "Stop papering";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(318, 211);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.label_InfoNum);
            this.Controls.Add(this.textBox_InputNum);
            this.Controls.Add(this.textBox_InputTime);
            this.Controls.Add(this.label_InfoTime);
            this.Controls.Add(this.label_InfoText);
            this.Controls.Add(this.textBox_Input);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "PaperMachine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.Label label_InfoText;
        private System.Windows.Forms.Label label_InfoTime;
        private System.Windows.Forms.TextBox textBox_InputTime;
        private System.Windows.Forms.Label label_InfoNum;
        private System.Windows.Forms.TextBox textBox_InputNum;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.Button button_Stop;
    }
}

