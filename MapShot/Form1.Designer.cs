namespace MapShot
{
    partial class Form1
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.captureButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.coTextbox = new System.Windows.Forms.TextBox();
            this.zoomComboBox = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.LevelCombobox = new System.Windows.Forms.ComboBox();
            this.ultraZoomComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(12, 43);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1309, 654);
            this.webBrowser1.TabIndex = 3;
            // 
            // captureButton
            // 
            this.captureButton.Location = new System.Drawing.Point(12, 11);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(178, 25);
            this.captureButton.TabIndex = 4;
            this.captureButton.Text = "캡쳐하기";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1027, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "전체샷 배율:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "중심점 주소:";
            // 
            // coTextbox
            // 
            this.coTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coTextbox.Location = new System.Drawing.Point(713, 11);
            this.coTextbox.Name = "coTextbox";
            this.coTextbox.Size = new System.Drawing.Size(308, 25);
            this.coTextbox.TabIndex = 10;
            // 
            // zoomComboBox
            // 
            this.zoomComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomComboBox.FormattingEnabled = true;
            this.zoomComboBox.Items.AddRange(new object[] {
            "1단계 (반경:1.5km)",
            "2단계 (반경:2.5km)",
            "3단계 (반경:3.5km)",
            "4단계 (반경:4.5km)",
            "5단계 (반경:5.5km)",
            "6단계 (반경:6.5km)",
            "7단계 (반경:7.5km)",
            "8단계 (반경:8.5km)",
            "9단계 (반경:9.5km)",
            "10단계 (반경:10.5km)"});
            this.zoomComboBox.Location = new System.Drawing.Point(1125, 12);
            this.zoomComboBox.Name = "zoomComboBox";
            this.zoomComboBox.Size = new System.Drawing.Size(194, 23);
            this.zoomComboBox.TabIndex = 11;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(196, 11);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(288, 25);
            this.progressBar1.TabIndex = 12;
            // 
            // LevelCombobox
            // 
            this.LevelCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LevelCombobox.FormattingEnabled = true;
            this.LevelCombobox.Items.AddRange(new object[] {
            "고화질",
            "초고화질"});
            this.LevelCombobox.Location = new System.Drawing.Point(490, 11);
            this.LevelCombobox.Name = "LevelCombobox";
            this.LevelCombobox.Size = new System.Drawing.Size(119, 23);
            this.LevelCombobox.TabIndex = 13;
            this.LevelCombobox.SelectedIndexChanged += new System.EventHandler(this.LevelCombobox_SelectedChanged);
            // 
            // ultraZoomComboBox
            // 
            this.ultraZoomComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraZoomComboBox.FormattingEnabled = true;
            this.ultraZoomComboBox.Items.AddRange(new object[] {
            "1단계 (반경:0.75km)",
            "2단계 (반경:1.25km)",
            "3단계 (반경:1.75km)",
            "4단계 (반경:2.25km)",
            "5단계 (반경:2.75km)",
            "6단계 (반경:3.25km)",
            "7단계 (반경:3.75km)",
            "8단계 (반경:4.25km)",
            "9단계 (반경:4.75km)",
            "10단계 (반경:5.25km)"});
            this.ultraZoomComboBox.Location = new System.Drawing.Point(1125, 12);
            this.ultraZoomComboBox.Name = "ultraZoomComboBox";
            this.ultraZoomComboBox.Size = new System.Drawing.Size(194, 23);
            this.ultraZoomComboBox.TabIndex = 14;
            this.ultraZoomComboBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 709);
            this.Controls.Add(this.ultraZoomComboBox);
            this.Controls.Add(this.LevelCombobox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.zoomComboBox);
            this.Controls.Add(this.coTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.captureButton);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "NoGaDa_Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox coTextbox;
        private System.Windows.Forms.ComboBox zoomComboBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox LevelCombobox;
        private System.Windows.Forms.ComboBox ultraZoomComboBox;
    }
}

