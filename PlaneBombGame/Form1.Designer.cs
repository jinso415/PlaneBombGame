﻿using System.Drawing;
using System.Windows.Forms;

namespace PlaneBombGame
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TitleHome = new System.Windows.Forms.Label();
            this.TitleAi = new System.Windows.Forms.Label();
            this.TitleSocketSub = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            // for SocketPanel
            this.SocketPanellabel1 = new System.Windows.Forms.Label();
            this.SocketPanellabel2 = new System.Windows.Forms.Label();
            this.SocketPanellabel3 = new System.Windows.Forms.Label();
            this.SocketPaneltextBox1 = new System.Windows.Forms.TextBox();
            this.SocketPaneltextBox2 = new System.Windows.Forms.TextBox();
            this.SocketPanelbutton1 = new System.Windows.Forms.Button();
            this.SocketPanelbutton2 = new System.Windows.Forms.Button();
            this.SocketPanelcheckedListBox1 = new CheckedListBox();
            this.AiPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.SocketPanel = new System.Windows.Forms.Panel();    
            this.SocketSubPanel = new System.Windows.Forms.Panel(); 
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AiPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SocketPanel.SuspendLayout();
            this.SocketSubPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // for count down
            this.leftCountLabel = new System.Windows.Forms.Label();
            this.rightCountLabel = new System.Windows.Forms.Label();

            //for count down
            //
            //leftCountPanel
            //
            this.leftCountLabel.Font = new System.Drawing.Font("宋体", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.leftCountLabel.Location = new System.Drawing.Point(30, 5);
            this.leftCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.leftCountLabel.Name = "leftCountLabel";
            this.leftCountLabel.Size = new System.Drawing.Size(68, 50);
            this.leftCountLabel.TabIndex = 0;
            this.leftCountLabel.Text = "30";
            this.leftCountLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            //
            //rightCountPanel
            //
            this.rightCountLabel.Font = new System.Drawing.Font("宋体", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rightCountLabel.Location = new System.Drawing.Point(1085, 5);
            this.rightCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rightCountLabel.Name = "leftCountLabel";
            this.rightCountLabel.Size = new System.Drawing.Size(68, 50);
            this.rightCountLabel.TabIndex = 0;
            this.rightCountLabel.Text = "30";
            this.rightCountLabel.BackColor = System.Drawing.SystemColors.ControlLight;



            // for SocketPanel
            // 
            // SocketPanellabel1
            // 
            this.SocketPanellabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SocketPanellabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SocketPanellabel1.Location = new System.Drawing.Point(60, 41 + 20);
            this.SocketPanellabel1.Name = "SocketPanellabel1";
            this.SocketPanellabel1.Size = new System.Drawing.Size(29, 23);
            this.SocketPanellabel1.TabIndex = 0;
            this.SocketPanellabel1.Text = "IP";
            this.SocketPanellabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SocketPaneltextBox1
            // 
            this.SocketPaneltextBox1.Location = new System.Drawing.Point(169, 43 + 20);
            this.SocketPaneltextBox1.Name = "SocketPaneltextBox1";
            this.SocketPaneltextBox1.Size = new System.Drawing.Size(100, 21);
            this.SocketPaneltextBox1.TabIndex = 1;
            this.SocketPaneltextBox1.Text = "127.0.0.1";
            this.SocketPaneltextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SocketPanellabel2
            // 
            this.SocketPanellabel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SocketPanellabel2.Location = new System.Drawing.Point(60, 74 + 20);
            this.SocketPanellabel2.Name = "SocketPanellabel2";
            this.SocketPanellabel2.Size = new System.Drawing.Size(43, 21);
            this.SocketPanellabel2.TabIndex = 2;
            this.SocketPanellabel2.Text = "端口";
            // 
            // SocketPaneltextBox2
            // 
            this.SocketPaneltextBox2.Location = new System.Drawing.Point(169, 74 + 20);
            this.SocketPaneltextBox2.Name = "SocketPaneltextBox2";
            this.SocketPaneltextBox2.Size = new System.Drawing.Size(100, 21);
            this.SocketPaneltextBox2.TabIndex = 3;
            this.SocketPaneltextBox2.Text = "8885";
            this.SocketPaneltextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SocketPanelcheckedListBox1
            // 
            this.SocketPanelcheckedListBox1.FormattingEnabled = true;
            this.SocketPanelcheckedListBox1.Location = new System.Drawing.Point(169, 101 + 20);
            this.SocketPanelcheckedListBox1.Name = "SocketPanelcheckedListBox1";
            this.SocketPanelcheckedListBox1.Size = new System.Drawing.Size(100, 36);
            this.SocketPanelcheckedListBox1.TabIndex = 4;
            this.SocketPanelcheckedListBox1.SelectedIndexChanged += new System.EventHandler(this.SocketPanelcheckedListBox1_SelectedIndexChanged);
            this.SocketPanelcheckedListBox1.Items.Add("Client");
            this.SocketPanelcheckedListBox1.Items.Add("Server");
            this.SocketPanelcheckedListBox1.CheckOnClick = true;
            // 
            // SocketPanellabel3
            // 
            this.SocketPanellabel3.AutoSize = true;
            this.SocketPanellabel3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SocketPanellabel3.Location = new System.Drawing.Point(60, 112 + 20);
            this.SocketPanellabel3.Name = "SocketPanellabel3";
            this.SocketPanellabel3.Size = new System.Drawing.Size(103, 16);
            this.SocketPanellabel3.TabIndex = 5;
            this.SocketPanellabel3.Text = "选择运行模式";
            this.SocketPanellabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SocketPanelbutton1
            // 
            this.SocketPanelbutton1.Location = new System.Drawing.Point(306, 205);
            this.SocketPanelbutton1.Name = "SocketPanelbutton1";
            this.SocketPanelbutton1.Size = new System.Drawing.Size(75, 23);
            this.SocketPanelbutton1.TabIndex = 6;
            this.SocketPanelbutton1.Text = "确定";
            this.SocketPanelbutton1.UseVisualStyleBackColor = true;
            this.SocketPanelbutton1.Click += new System.EventHandler(this.SocketPanelbutton1_Click);
            // 
            // SocketPanelbutton2
            // 
            this.SocketPanelbutton2.Location = new System.Drawing.Point(56, 205);
            this.SocketPanelbutton2.Name = "SocketPanelbutton2";
            this.SocketPanelbutton2.Size = new System.Drawing.Size(75, 23);
            this.SocketPanelbutton2.TabIndex = 6;
            this.SocketPanelbutton2.Text = "返回";
            this.SocketPanelbutton2.UseVisualStyleBackColor = true;
            this.SocketPanelbutton2.Click += new System.EventHandler(this.SocketPanelbutton2_Click);

            // 
            // TitleHome
            // 
            this.TitleHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TitleHome.AutoSize = true;
            this.TitleHome.BackColor = System.Drawing.Color.Transparent;
            this.TitleHome.Font = new System.Drawing.Font("华文新魏", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleHome.ForeColor = System.Drawing.Color.OrangeRed;
            this.TitleHome.Location = new System.Drawing.Point(0, 28);
            this.TitleHome.Name = "TitleHome";
            this.TitleHome.Size = new System.Drawing.Size(300, 68);
            this.TitleHome.TabIndex = 0;
            this.TitleHome.Text = "飞机大战";
            // 
            // TitleAi
            // 
            this.TitleAi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TitleAi.AutoSize = true;
            this.TitleAi.BackColor = System.Drawing.Color.Transparent;
            this.TitleAi.Font = new System.Drawing.Font("华文新魏", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleAi.ForeColor = System.Drawing.Color.OrangeRed;
            this.TitleAi.Location = new System.Drawing.Point(8, 30);
            this.TitleAi.Name = "TitleAi";
            this.TitleAi.Size = new System.Drawing.Size(300, 68);
            this.TitleAi.TabIndex = 0;
            this.TitleAi.Text = "难度选择";
            // 
            // TitleSocketSub
            // 
            this.TitleSocketSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TitleSocketSub.AutoSize = true;
            this.TitleSocketSub.BackColor = System.Drawing.Color.Transparent;
            this.TitleSocketSub.Font = new System.Drawing.Font("华文新魏", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleSocketSub.ForeColor = System.Drawing.Color.OrangeRed;
            this.TitleSocketSub.Location = new System.Drawing.Point(8, 30);
            this.TitleSocketSub.Name = "TitleAi";
            this.TitleSocketSub.Size = new System.Drawing.Size(300, 68);
            this.TitleSocketSub.TabIndex = 0;
            this.TitleSocketSub.Text = "配置网络";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("华文中宋", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(90, 130);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "玩 家 对 决";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("华文中宋", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(90, 210);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "人 机 对 决";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Font = new System.Drawing.Font("华文中宋", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(90, 130);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 60);
            this.button3.TabIndex = 1;
            this.button3.Text = "简 单";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Font = new System.Drawing.Font("华文中宋", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(90, 210);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 60);
            this.button4.TabIndex = 2;
            this.button4.Text = "中 等";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Font = new System.Drawing.Font("华文中宋", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(90, 290);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 60);
            this.button5.TabIndex = 1;
            this.button5.Text = "困 难";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Font = new System.Drawing.Font("华文中宋", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Location = new System.Drawing.Point(90, 370);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button2";
            this.button6.Size = new System.Drawing.Size(200, 60);
            this.button6.TabIndex = 2;
            this.button6.Text = "返 回";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Font = new System.Drawing.Font("华文中宋", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7    .ForeColor = System.Drawing.SystemColors.ControlText;
            this.button7.Location = new System.Drawing.Point(530, 300);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(130, 60);
            this.button7.TabIndex = 2;
            this.button7.Text = "重新开始";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.Font = new System.Drawing.Font("华文中宋", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button8.Location = new System.Drawing.Point(530, 380);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(130, 60);
            this.button8.TabIndex = 1;
            this.button8.Text = "返 回";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.Font = new System.Drawing.Font("华文中宋", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button9.Location = new System.Drawing.Point(530, 460);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(130, 60);
            this.button9.TabIndex = 2;
            this.button9.Text = "退 出";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Font = new System.Drawing.Font("华文中宋", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CloseButton.Location = new System.Drawing.Point(90, 290);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(200, 60);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "退 出";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.leftCountLabel);
            this.panel1.Controls.Add(this.rightCountLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 600);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            //this.panel2.Controls.Add(this.label2);
            //this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 540);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // panel3
            // 
            //this.panel3.Controls.Add(this.label3);
            //this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(668, 60);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 540);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Transparent;
            this.TopPanel.Controls.Add(this.TitleHome);
            this.TopPanel.Controls.Add(this.button1);
            this.TopPanel.Controls.Add(this.CloseButton);
            this.TopPanel.Controls.Add(this.button2);
            this.TopPanel.Location = new System.Drawing.Point(180, 62);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(600, 471);
            this.TopPanel.TabIndex = 7;
            // 
            // AilPanel
            // 
            this.AiPanel.BackColor = System.Drawing.Color.Transparent;
            this.AiPanel.Controls.Add(this.TitleAi);
            this.AiPanel.Controls.Add(this.button3);
            this.AiPanel.Controls.Add(this.button4);
            this.AiPanel.Controls.Add(this.button5);
            this.AiPanel.Controls.Add(this.button6);
            this.AiPanel.Location = new System.Drawing.Point(180, 35);
            this.AiPanel.Name = "AiPanel";
            this.AiPanel.Size = new System.Drawing.Size(600, 600);
            this.AiPanel.TabIndex = 6;
            this.AiPanel.Visible = false;
            // 
            // SocketPanel
            // 
            this.SocketPanel.Location = new System.Drawing.Point(167, 152);
            this.SocketPanel.Name = "SockPanel";
            this.SocketPanel.Size = new System.Drawing.Size(416, 252);
            this.SocketPanel.Visible = false;
            this.SocketPanel.Controls.Add(this.SocketPanelbutton1);
            this.SocketPanel.Controls.Add(this.SocketPanelbutton2);
            this.SocketPanel.Controls.Add(this.SocketPanellabel3);
            this.SocketPanel.Controls.Add(this.SocketPanelcheckedListBox1);
            this.SocketPanel.Controls.Add(this.SocketPaneltextBox2);
            this.SocketPanel.Controls.Add(this.SocketPanellabel2);
            this.SocketPanel.Controls.Add(this.SocketPaneltextBox1);
            this.SocketPanel.Controls.Add(this.SocketPanellabel1);
            //
            // SocketSubPanel
            // 
            this.SocketSubPanel.BackColor = System.Drawing.Color.Transparent;
            this.SocketSubPanel.Controls.Add(this.TitleSocketSub);
            this.SocketSubPanel.Location = new System.Drawing.Point(190, 35);
            this.SocketSubPanel.Name = "SocketSubPanel";
            this.SocketSubPanel.Size = new System.Drawing.Size(600, 600);
            this.SocketSubPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 535);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1200, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // label2
            // 
            //this.label2.AutoSize = true;
            //this.label2.BackColor = System.Drawing.Color.Bisque;
            this.label2.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(170, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "我方棋盘";
            // 
            // label3
            // 
            //this.label3.AutoSize = true;
            //this.label3.BackColor = System.Drawing.Color.Bisque;
            this.label3.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(840, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "敌方棋盘";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(528, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 200);
            this.label4.TabIndex = 5;
            this.label4.Text = "请选择以下操作";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(400, 0);
            this.label5.Name = "label4";
            this.label5.Size = new System.Drawing.Size(400, 50);
            this.label5.TabIndex = 5;
            this.label5.Text = "人机对决（简单）";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label4_Click);
            //  
            // Form1
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.background));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ClientSize = new System.Drawing.Size(StandardSize.HomeWidth, StandardSize.HomeHeight);
            this.MaximizeBox = false;
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.AiPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SocketPanel);
            this.Controls.Add(this.SocketSubPanel);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.LocationChanged += new System.EventHandler(this.Form1_LocationChanged);
            this.Text = "Bomb Planes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AiPanel.ResumeLayout(false);
            this.AiPanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.SocketPanel.ResumeLayout(false);
            this.SocketPanel.PerformLayout();
            this.SocketSubPanel.ResumeLayout(false);
            this.SocketSubPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
   
            
        }

        #endregion
        private System.Windows.Forms.Label TitleHome;
        private System.Windows.Forms.Label TitleAi;
        private System.Windows.Forms.Label TitleSocketSub;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button CloseButton;
        private Panel AiPanel;
        private Panel TopPanel;
        private Panel SocketPanel;
        private Panel SocketSubPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        // for SocketPanel
        private System.Windows.Forms.Label SocketPanellabel1;
        private System.Windows.Forms.TextBox SocketPaneltextBox1;
        private System.Windows.Forms.Label SocketPanellabel2;
        private System.Windows.Forms.TextBox SocketPaneltextBox2;
        private System.Windows.Forms.CheckedListBox SocketPanelcheckedListBox1;
        private System.Windows.Forms.Label SocketPanellabel3;
        private System.Windows.Forms.Button SocketPanelbutton1;
        private System.Windows.Forms.Button SocketPanelbutton2;
        // for count down
        private System.Windows.Forms.Label leftCountLabel;
        private System.Windows.Forms.Label rightCountLabel;
    }
}

