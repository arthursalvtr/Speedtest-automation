namespace Speedtest
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_detect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_cli_path = new System.Windows.Forms.Label();
            this.list_servers = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.testResult = new System.Windows.Forms.TextBox();
            this.btn_start_test = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_detect
            // 
            this.btn_detect.Location = new System.Drawing.Point(12, 32);
            this.btn_detect.Name = "btn_detect";
            this.btn_detect.Size = new System.Drawing.Size(175, 111);
            this.btn_detect.TabIndex = 0;
            this.btn_detect.Text = "&Detect Speedtest-CLI";
            this.btn_detect.UseVisualStyleBackColor = true;
            this.btn_detect.Click += new System.EventHandler(this.btn_detect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your speedtest-cli: ";
            // 
            // lbl_cli_path
            // 
            this.lbl_cli_path.AutoSize = true;
            this.lbl_cli_path.Location = new System.Drawing.Point(152, 9);
            this.lbl_cli_path.Name = "lbl_cli_path";
            this.lbl_cli_path.Size = new System.Drawing.Size(163, 20);
            this.lbl_cli_path.TabIndex = 4;
            this.lbl_cli_path.Text = "Press the Detect button";
            // 
            // list_servers
            // 
            this.list_servers.Enabled = false;
            this.list_servers.FormattingEnabled = true;
            this.list_servers.ItemHeight = 20;
            this.list_servers.Items.AddRange(new object[] {
            "7556",
            "4235"});
            this.list_servers.Location = new System.Drawing.Point(18, 35);
            this.list_servers.Name = "list_servers";
            this.list_servers.Size = new System.Drawing.Size(92, 264);
            this.list_servers.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.testResult);
            this.groupBox1.Controls.Add(this.btn_start_test);
            this.groupBox1.Controls.Add(this.list_servers);
            this.groupBox1.Location = new System.Drawing.Point(313, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(892, 354);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Speedtest Result";
            // 
            // testResult
            // 
            this.testResult.Enabled = false;
            this.testResult.Location = new System.Drawing.Point(138, 35);
            this.testResult.Multiline = true;
            this.testResult.Name = "testResult";
            this.testResult.Size = new System.Drawing.Size(736, 264);
            this.testResult.TabIndex = 7;
            // 
            // btn_start_test
            // 
            this.btn_start_test.Enabled = false;
            this.btn_start_test.Location = new System.Drawing.Point(18, 305);
            this.btn_start_test.Name = "btn_start_test";
            this.btn_start_test.Size = new System.Drawing.Size(94, 29);
            this.btn_start_test.TabIndex = 6;
            this.btn_start_test.Text = "Start";
            this.btn_start_test.UseVisualStyleBackColor = true;
            this.btn_start_test.Click += new System.EventHandler(this.btn_start_test_Click);
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(1224, 443);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_cli_path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_detect);
            this.Name = "Main";
            this.Text = "Speedtest Automation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_detect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_cli_path;
        private System.Windows.Forms.ListBox list_servers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox testResult;
        private System.Windows.Forms.Button btn_start_test;
    }
}
