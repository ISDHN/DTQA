
using System;

namespace DTQA
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.WelcomePanel = new System.Windows.Forms.Panel();
            this.Start = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.FinalPanel = new System.Windows.Forms.Panel();
            this.Summary = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.Again = new System.Windows.Forms.Button();
            this.QAPanel = new System.Windows.Forms.Panel();
            this.QuestionText = new System.Windows.Forms.Label();
            this.QuestionList = new System.Windows.Forms.ToolStrip();
            this.Question1 = new System.Windows.Forms.ToolStripButton();
            this.Question2 = new System.Windows.Forms.ToolStripButton();
            this.Question3 = new System.Windows.Forms.ToolStripButton();
            this.Question4 = new System.Windows.Forms.ToolStripButton();
            this.Question5 = new System.Windows.Forms.ToolStripButton();
            this.Question6 = new System.Windows.Forms.ToolStripButton();
            this.Question7 = new System.Windows.Forms.ToolStripButton();
            this.Question8 = new System.Windows.Forms.ToolStripButton();
            this.Question9 = new System.Windows.Forms.ToolStripButton();
            this.Question10 = new System.Windows.Forms.ToolStripButton();
            this.Submit = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Options = new System.Windows.Forms.GroupBox();
            this.AnswerD = new System.Windows.Forms.RadioButton();
            this.AnswerC = new System.Windows.Forms.RadioButton();
            this.AnswerB = new System.Windows.Forms.RadioButton();
            this.AnswerA = new System.Windows.Forms.RadioButton();
            this.Previous = new System.Windows.Forms.Button();
            this.InfPanel = new System.Windows.Forms.Panel();
            this.SaveInformation = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Class = new System.Windows.Forms.NumericUpDown();
            this.Grade = new System.Windows.Forms.ComboBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.School = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WelcomePanel.SuspendLayout();
            this.FinalPanel.SuspendLayout();
            this.QAPanel.SuspendLayout();
            this.QuestionList.SuspendLayout();
            this.Options.SuspendLayout();
            this.InfPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Class)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomePanel
            // 
            this.WelcomePanel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomePanel.Controls.Add(this.Start);
            this.WelcomePanel.Controls.Add(this.Title);
            this.WelcomePanel.Location = new System.Drawing.Point(113, 12);
            this.WelcomePanel.Name = "WelcomePanel";
            this.WelcomePanel.Size = new System.Drawing.Size(510, 310);
            this.WelcomePanel.TabIndex = 22;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(186, 204);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(149, 53);
            this.Start.TabIndex = 1;
            this.Start.Text = "开始答题";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft YaHei", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title.Location = new System.Drawing.Point(57, 24);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(427, 97);
            this.Title.TabIndex = 0;
            this.Title.Text = "你了解双十吗？";
            // 
            // FinalPanel
            // 
            this.FinalPanel.Controls.Add(this.Summary);
            this.FinalPanel.Controls.Add(this.Exit);
            this.FinalPanel.Controls.Add(this.Again);
            this.FinalPanel.Location = new System.Drawing.Point(62, 29);
            this.FinalPanel.Name = "FinalPanel";
            this.FinalPanel.Size = new System.Drawing.Size(510, 310);
            this.FinalPanel.TabIndex = 21;
            this.FinalPanel.Visible = false;
            // 
            // Summary
            // 
            this.Summary.BackColor = System.Drawing.Color.White;
            this.Summary.Cursor = System.Windows.Forms.Cursors.Default;
            this.Summary.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Summary.HideSelection = false;
            this.Summary.Location = new System.Drawing.Point(44, 22);
            this.Summary.Multiline = true;
            this.Summary.Name = "Summary";
            this.Summary.ReadOnly = true;
            this.Summary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Summary.Size = new System.Drawing.Size(419, 197);
            this.Summary.TabIndex = 3;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(342, 235);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(121, 48);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "退出";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Again
            // 
            this.Again.Location = new System.Drawing.Point(44, 235);
            this.Again.Name = "Again";
            this.Again.Size = new System.Drawing.Size(121, 48);
            this.Again.TabIndex = 1;
            this.Again.Text = "再来一次";
            this.Again.UseVisualStyleBackColor = true;
            this.Again.Click += new System.EventHandler(this.Again_Click);
            // 
            // QAPanel
            // 
            this.QAPanel.BackColor = System.Drawing.Color.Transparent;
            this.QAPanel.Controls.Add(this.QuestionText);
            this.QAPanel.Controls.Add(this.QuestionList);
            this.QAPanel.Controls.Add(this.Submit);
            this.QAPanel.Controls.Add(this.Next);
            this.QAPanel.Controls.Add(this.Options);
            this.QAPanel.Controls.Add(this.Previous);
            this.QAPanel.Location = new System.Drawing.Point(36, 88);
            this.QAPanel.Name = "QAPanel";
            this.QAPanel.Size = new System.Drawing.Size(510, 310);
            this.QAPanel.TabIndex = 23;
            this.QAPanel.Visible = false;
            // 
            // QuestionText
            // 
            this.QuestionText.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.QuestionText.Location = new System.Drawing.Point(37, 28);
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.Size = new System.Drawing.Size(437, 38);
            this.QuestionText.TabIndex = 20;
            this.QuestionText.Text = "[问题]";
            // 
            // QuestionList
            // 
            this.QuestionList.BackColor = System.Drawing.Color.White;
            this.QuestionList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.QuestionList.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.QuestionList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Question1,
            this.Question2,
            this.Question3,
            this.Question4,
            this.Question5,
            this.Question6,
            this.Question7,
            this.Question8,
            this.Question9,
            this.Question10});
            this.QuestionList.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.QuestionList.Location = new System.Drawing.Point(0, 285);
            this.QuestionList.Name = "QuestionList";
            this.QuestionList.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.QuestionList.Size = new System.Drawing.Size(510, 25);
            this.QuestionList.TabIndex = 19;
            this.QuestionList.Text = "QuestionList";
            // 
            // Question1
            // 
            this.Question1.AutoSize = false;
            this.Question1.BackColor = System.Drawing.Color.White;
            this.Question1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Question1.Image = ((System.Drawing.Image)(resources.GetObject("Question1.Image")));
            this.Question1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Question1.Name = "Question1";
            this.Question1.Size = new System.Drawing.Size(20, 20);
            this.Question1.Text = "1";
            this.Question1.ToolTipText = "第一题";
            this.Question1.Click += new System.EventHandler(this.Question1_Click);
            // 
            // Question2
            // 
            this.Question2.AutoSize = false;
            this.Question2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Question2.Image = ((System.Drawing.Image)(resources.GetObject("Question2.Image")));
            this.Question2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Question2.Margin = new System.Windows.Forms.Padding(30, 1, 0, 2);
            this.Question2.Name = "Question2";
            this.Question2.Size = new System.Drawing.Size(20, 20);
            this.Question2.Text = "2";
            this.Question2.ToolTipText = "第二题";
            this.Question2.Click += new System.EventHandler(this.Question2_Click);
            // 
            // Question3
            // 
            this.Question3.AutoSize = false;
            this.Question3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Question3.Image = ((System.Drawing.Image)(resources.GetObject("Question3.Image")));
            this.Question3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Question3.Margin = new System.Windows.Forms.Padding(30, 1, 0, 2);
            this.Question3.Name = "Question3";
            this.Question3.Size = new System.Drawing.Size(20, 20);
            this.Question3.Text = "3";
            this.Question3.ToolTipText = "第三题";
            this.Question3.Click += new System.EventHandler(this.Question3_Click);
            // 
            // Question4
            // 
            this.Question4.AutoSize = false;
            this.Question4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Question4.Image = ((System.Drawing.Image)(resources.GetObject("Question4.Image")));
            this.Question4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Question4.Margin = new System.Windows.Forms.Padding(30, 1, 0, 2);
            this.Question4.Name = "Question4";
            this.Question4.Size = new System.Drawing.Size(20, 20);
            this.Question4.Text = "4";
            this.Question4.ToolTipText = "第四题";
            this.Question4.Click += new System.EventHandler(this.Question4_Click);
            // 
            // Question5
            // 
            this.Question5.AutoSize = false;
            this.Question5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Question5.Image = ((System.Drawing.Image)(resources.GetObject("Question5.Image")));
            this.Question5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Question5.Margin = new System.Windows.Forms.Padding(30, 1, 0, 2);
            this.Question5.Name = "Question5";
            this.Question5.Size = new System.Drawing.Size(20, 20);
            this.Question5.Text = "5";
            this.Question5.ToolTipText = "第五题";
            this.Question5.Click += new System.EventHandler(this.Question5_Click);
            // 
            // Question6
            // 
            this.Question6.AutoSize = false;
            this.Question6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Question6.Image = ((System.Drawing.Image)(resources.GetObject("Question6.Image")));
            this.Question6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Question6.Margin = new System.Windows.Forms.Padding(30, 1, 0, 2);
            this.Question6.Name = "Question6";
            this.Question6.Size = new System.Drawing.Size(20, 20);
            this.Question6.Text = "6";
            this.Question6.ToolTipText = "第六题";
            this.Question6.Click += new System.EventHandler(this.Question6_Click);
            // 
            // Question7
            // 
            this.Question7.AutoSize = false;
            this.Question7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Question7.Image = ((System.Drawing.Image)(resources.GetObject("Question7.Image")));
            this.Question7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Question7.Margin = new System.Windows.Forms.Padding(30, 1, 0, 2);
            this.Question7.Name = "Question7";
            this.Question7.Size = new System.Drawing.Size(23, 22);
            this.Question7.Text = "7";
            this.Question7.ToolTipText = "第七题";
            this.Question7.Click += new System.EventHandler(this.Question7_Click);
            // 
            // Question8
            // 
            this.Question8.AutoSize = false;
            this.Question8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Question8.Image = ((System.Drawing.Image)(resources.GetObject("Question8.Image")));
            this.Question8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Question8.Margin = new System.Windows.Forms.Padding(30, 1, 0, 2);
            this.Question8.Name = "Question8";
            this.Question8.Size = new System.Drawing.Size(20, 20);
            this.Question8.Text = "8";
            this.Question8.ToolTipText = "第八题";
            this.Question8.Click += new System.EventHandler(this.Question8_Click);
            // 
            // Question9
            // 
            this.Question9.AutoSize = false;
            this.Question9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Question9.Image = ((System.Drawing.Image)(resources.GetObject("Question9.Image")));
            this.Question9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Question9.Margin = new System.Windows.Forms.Padding(30, 1, 0, 2);
            this.Question9.Name = "Question9";
            this.Question9.Size = new System.Drawing.Size(20, 20);
            this.Question9.Text = "9";
            this.Question9.ToolTipText = "第九题";
            this.Question9.Click += new System.EventHandler(this.Question9_Click);
            // 
            // Question10
            // 
            this.Question10.AutoSize = false;
            this.Question10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Question10.Image = ((System.Drawing.Image)(resources.GetObject("Question10.Image")));
            this.Question10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Question10.Margin = new System.Windows.Forms.Padding(30, 1, 0, 2);
            this.Question10.Name = "Question10";
            this.Question10.Size = new System.Drawing.Size(20, 20);
            this.Question10.Text = "10";
            this.Question10.ToolTipText = "第十题";
            this.Question10.Click += new System.EventHandler(this.Question10_Click);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(414, 219);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 18;
            this.Submit.Text = "提交";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(217, 219);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 17;
            this.Next.Text = "下一题";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Options
            // 
            this.Options.Controls.Add(this.AnswerD);
            this.Options.Controls.Add(this.AnswerC);
            this.Options.Controls.Add(this.AnswerB);
            this.Options.Controls.Add(this.AnswerA);
            this.Options.Location = new System.Drawing.Point(20, 75);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(469, 132);
            this.Options.TabIndex = 16;
            this.Options.TabStop = false;
            // 
            // AnswerD
            // 
            this.AnswerD.AutoSize = true;
            this.AnswerD.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AnswerD.Location = new System.Drawing.Point(25, 106);
            this.AnswerD.Name = "AnswerD";
            this.AnswerD.Size = new System.Drawing.Size(38, 21);
            this.AnswerD.TabIndex = 10;
            this.AnswerD.Text = "D.";
            this.AnswerD.UseVisualStyleBackColor = true;
            this.AnswerD.Click += new System.EventHandler(this.AnswerD_Click);
            // 
            // AnswerC
            // 
            this.AnswerC.AutoSize = true;
            this.AnswerC.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AnswerC.Location = new System.Drawing.Point(25, 76);
            this.AnswerC.Name = "AnswerC";
            this.AnswerC.Size = new System.Drawing.Size(37, 21);
            this.AnswerC.TabIndex = 9;
            this.AnswerC.Text = "C.";
            this.AnswerC.UseVisualStyleBackColor = true;
            this.AnswerC.Click += new System.EventHandler(this.AnswerC_Click);
            // 
            // AnswerB
            // 
            this.AnswerB.AutoSize = true;
            this.AnswerB.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AnswerB.Location = new System.Drawing.Point(25, 43);
            this.AnswerB.Name = "AnswerB";
            this.AnswerB.Size = new System.Drawing.Size(37, 21);
            this.AnswerB.TabIndex = 8;
            this.AnswerB.Text = "B.";
            this.AnswerB.UseVisualStyleBackColor = true;
            this.AnswerB.Click += new System.EventHandler(this.AnswerB_Click);
            // 
            // AnswerA
            // 
            this.AnswerA.AutoSize = true;
            this.AnswerA.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AnswerA.Location = new System.Drawing.Point(25, 10);
            this.AnswerA.Name = "AnswerA";
            this.AnswerA.Size = new System.Drawing.Size(37, 21);
            this.AnswerA.TabIndex = 7;
            this.AnswerA.Text = "A.";
            this.AnswerA.UseVisualStyleBackColor = true;
            this.AnswerA.Click += new System.EventHandler(this.AnswerA_Click);
            // 
            // Previous
            // 
            this.Previous.Location = new System.Drawing.Point(20, 219);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(75, 23);
            this.Previous.TabIndex = 15;
            this.Previous.Text = "上一题";
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // InfPanel
            // 
            this.InfPanel.Controls.Add(this.SaveInformation);
            this.InfPanel.Controls.Add(this.label6);
            this.InfPanel.Controls.Add(this.Class);
            this.InfPanel.Controls.Add(this.Grade);
            this.InfPanel.Controls.Add(this.UserName);
            this.InfPanel.Controls.Add(this.label5);
            this.InfPanel.Controls.Add(this.label4);
            this.InfPanel.Controls.Add(this.label3);
            this.InfPanel.Controls.Add(this.label2);
            this.InfPanel.Controls.Add(this.School);
            this.InfPanel.Controls.Add(this.label1);
            this.InfPanel.Location = new System.Drawing.Point(12, 91);
            this.InfPanel.Name = "InfPanel";
            this.InfPanel.Size = new System.Drawing.Size(510, 310);
            this.InfPanel.TabIndex = 21;
            this.InfPanel.Visible = false;
            // 
            // SaveInformation
            // 
            this.SaveInformation.Location = new System.Drawing.Point(407, 268);
            this.SaveInformation.Name = "SaveInformation";
            this.SaveInformation.Size = new System.Drawing.Size(75, 23);
            this.SaveInformation.TabIndex = 10;
            this.SaveInformation.Text = "确定";
            this.SaveInformation.UseVisualStyleBackColor = true;
            this.SaveInformation.Click += new System.EventHandler(this.SaveInformation_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(318, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "班";
            // 
            // Class
            // 
            this.Class.Location = new System.Drawing.Point(218, 182);
            this.Class.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Class.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(98, 21);
            this.Class.TabIndex = 8;
            this.Class.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Class.ValueChanged += new System.EventHandler(this.Class_ValueChanged);
            // 
            // Grade
            // 
            this.Grade.FormattingEnabled = true;
            this.Grade.Location = new System.Drawing.Point(218, 130);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(126, 20);
            this.Grade.TabIndex = 7;
            this.Grade.SelectedIndexChanged += new System.EventHandler(this.Grade_SelectedIndexChanged);
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(218, 235);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(126, 21);
            this.UserName.TabIndex = 6;
            this.UserName.TextChanged += new System.EventHandler(this.UserName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(91, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(91, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "年段：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(91, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "班级：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(91, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "校区：";
            // 
            // School
            // 
            this.School.FormattingEnabled = true;
            this.School.Items.AddRange(new object[] {
            "镇海",
            "枋湖",
            "翔安"});
            this.School.Location = new System.Drawing.Point(218, 78);
            this.School.Name = "School";
            this.School.Size = new System.Drawing.Size(126, 20);
            this.School.TabIndex = 1;
            this.School.SelectedIndexChanged += new System.EventHandler(this.School_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "请填写你的信息：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(599, 400);
            this.Controls.Add(this.FinalPanel);
            this.Controls.Add(this.QAPanel);
            this.Controls.Add(this.WelcomePanel);
            this.Controls.Add(this.InfPanel);
            this.Name = "Form1";
            this.Text = "双十小测试";
            this.WelcomePanel.ResumeLayout(false);
            this.FinalPanel.ResumeLayout(false);
            this.FinalPanel.PerformLayout();
            this.QAPanel.ResumeLayout(false);
            this.QAPanel.PerformLayout();
            this.QuestionList.ResumeLayout(false);
            this.QuestionList.PerformLayout();
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            this.InfPanel.ResumeLayout(false);
            this.InfPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Class)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel FinalPanel;
		private System.Windows.Forms.Panel WelcomePanel;
		private System.Windows.Forms.TextBox Summary;
		private System.Windows.Forms.Button Exit;
		private System.Windows.Forms.Button Again;
		private System.Windows.Forms.Button Start;
		private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel QAPanel;
        private System.Windows.Forms.Label QuestionText;
        private System.Windows.Forms.ToolStrip QuestionList;
        private System.Windows.Forms.ToolStripButton Question1;
        private System.Windows.Forms.ToolStripButton Question2;
        private System.Windows.Forms.ToolStripButton Question3;
        private System.Windows.Forms.ToolStripButton Question4;
        private System.Windows.Forms.ToolStripButton Question5;
        private System.Windows.Forms.ToolStripButton Question6;
        private System.Windows.Forms.ToolStripButton Question7;
        private System.Windows.Forms.ToolStripButton Question8;
        private System.Windows.Forms.ToolStripButton Question9;
        private System.Windows.Forms.ToolStripButton Question10;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.GroupBox Options;
        private System.Windows.Forms.RadioButton AnswerD;
        private System.Windows.Forms.RadioButton AnswerC;
        private System.Windows.Forms.RadioButton AnswerB;
        private System.Windows.Forms.RadioButton AnswerA;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Panel InfPanel;
        private System.Windows.Forms.Button SaveInformation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Class;
        private System.Windows.Forms.ComboBox Grade;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox School;
        private System.Windows.Forms.Label label1;
    }
}

