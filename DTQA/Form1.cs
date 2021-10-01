using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DTQA
{
	
	public partial class Form1 : Form
	{
		private int questionNumber;
		private List<Question> questionLibrary= new List<Question>();
		private int[] questions = new int[10];
		private int[] answers = new int[10];
		private string school="";
		private string grade="";
		private int classnum=1;
		private string username="";
		public Form1()
		{
			InitializeComponent();
			string xmlquestion = Properties.Resources.questions;
			XmlDocument xml = new XmlDocument();
			xml.LoadXml(xmlquestion);
			XmlNode root = xml.SelectSingleNode("Library");
			foreach(var cn in root.ChildNodes)
            {
				XmlElement ce = (XmlElement)cn;
				string txt = ce.GetAttribute("text");
				string exp = ce.GetAttribute("explanation");
				int ans = int.Parse(ce.GetAttribute("answer"));
				string a = ce.GetAttribute("A");
				string b = ce.GetAttribute("B");
				string c = ce.GetAttribute("C");
				string d = ce.GetAttribute("D");
				questionLibrary.Add(new Question(txt,ans,a,b,c,d,exp));
            }
			WelcomePanel.Location = new Point(46, 46);
			QAPanel.Location = new Point(46, 46);
			FinalPanel.Location = new Point(46, 46);
			InfPanel.Location = new Point(46, 46);
		}
		private void Start_Click(object sender, EventArgs e)
		{
			WelcomePanel.Hide();
			FinalPanel.Hide();
			InfPanel.Show();
			QAPanel.Hide();
		}

		private void Exit_Click(object sender, EventArgs e)
		{
			this.Close();
			Application.Exit();
		}
		private void ChangeQuestion(int number)
		{
			if (number > 10 | number < 1) return;
			((ToolStripButton)QuestionList.Items[questionNumber]).Checked = false;
			this.questionNumber = number-1;
			Question current = this.questionLibrary[questions[questionNumber]];
			QuestionText.Text = current.question;
			AnswerA.Text = current.options[0];
			AnswerB.Text = current.options[1];
			AnswerC.Text = current.options[2];
			AnswerD.Text = current.options[3];
			((ToolStripButton)QuestionList.Items[questionNumber]).Checked = true;
			switch (answers[questionNumber])
			{
				case -1:
					AnswerA.Checked = false;
					AnswerB.Checked = false;
					AnswerC.Checked = false;
					AnswerD.Checked = false;
					break;
				case 0:
					AnswerA.Checked = true;
					break;
				case 1:
					AnswerB.Checked = true;
					break;
				case 2:
					AnswerC.Checked = true;
					break;
				case 3:
					AnswerD.Checked = true;
					break;
			}
		}

		private void Question2_Click(object sender, EventArgs e)
		{
			ChangeQuestion(2);
		}

		private void Question1_Click(object sender, EventArgs e)
		{
			ChangeQuestion(1);
		}

		private void Question3_Click(object sender, EventArgs e)
		{
			ChangeQuestion(3);
		}

		private void Question4_Click(object sender, EventArgs e)
		{
			ChangeQuestion(4);
		}

		private void Question5_Click(object sender, EventArgs e)
		{
			ChangeQuestion(5);
		}

		private void Question6_Click(object sender, EventArgs e)
		{
			ChangeQuestion(6);
		}

		private void Question7_Click(object sender, EventArgs e)
		{
			ChangeQuestion(7);
		}

		private void Question8_Click(object sender, EventArgs e)
		{
			ChangeQuestion(8);
		}

		private void Question9_Click(object sender, EventArgs e)
		{
			ChangeQuestion(9);
		}

		private void Question10_Click(object sender, EventArgs e)
		{
			ChangeQuestion(10);
		}

		private void Previous_Click(object sender, EventArgs e)
		{
			ChangeQuestion(questionNumber);
		}

		private void Next_Click(object sender, EventArgs e)
		{
			ChangeQuestion(questionNumber + 2);
		}
		private void StartChanllenge()
		{
			Random r = new Random();
			for (int i = 0; i < 10; i++)
			{
				answers[i] = -1;
				questions[i] = -1;
			}
			for (int i = 0; i < 10; i++)
			{
				int j;
				do
				{
					j = r.Next(questionLibrary.Count);
				} while (questions.Contains(j));
				questions[i] = j;
			}
			WelcomePanel.Hide();
			FinalPanel.Hide();
			InfPanel.Hide();
			QAPanel.Show();
			ChangeQuestion(1);
		}
		private void JudgeChallenge()
		{
			int score=0;
			string s = "";
			for(int i = 0; i < 10; i++)
			{
				if (answers[i] == questionLibrary[questions[i]].answer)
					score += 10;
                else
                {
                    string wrong;
                    if (answers[i] == -1)
						wrong = "你没选";
					else
						wrong = "你选了\""+ questionLibrary[questions[i]].options[answers[i]]+"\"";
					s += $"错了第{i+1}题,题目为\"{questionLibrary[questions[i]].question}\",答案为\"{questionLibrary[questions[i]].options[questionLibrary[questions[i]].answer]}\",{wrong}.\r\n";
                }
			}
			Summary.Text=s.Insert(0,$"{school}校区{grade}{classnum}班的{username}同学,你的得分是{score}分.\r\n");
			WelcomePanel.Hide();
			FinalPanel.Show();
			QAPanel.Hide();
		}

		private void Again_Click(object sender, EventArgs e)
		{
			StartChanllenge();
		}

		private void AnswerA_Click(object sender, EventArgs e)
		{
			answers[questionNumber] = 0;
		}

		private void AnswerB_Click(object sender, EventArgs e)
		{
			answers[questionNumber] = 1;
		}

		private void AnswerC_Click(object sender, EventArgs e)
		{
			answers[questionNumber] = 2;
		}

		private void AnswerD_Click(object sender, EventArgs e)
		{
			answers[questionNumber] = 3;
		}

		private void Submit_Click(object sender, EventArgs e)
		{
			JudgeChallenge();
		}

        private void School_SelectedIndexChanged(object sender, EventArgs e)
        {		
			Grade.Items.Clear();
			Grade.Text = "";
            switch (school=School.SelectedItem.ToString())
            {
				case "枋湖":				
					Grade.Items.Add("高一");
					Grade.Items.Add("高二");
					Grade.Items.Add("高三");
					Class.Maximum = 20;
					break;
				case "镇海":
					Grade.Items.Add("初一");
					Grade.Items.Add("初二");
					Grade.Items.Add("初三");
					Class.Maximum = 20;
					break;
				case "翔安":
					Grade.Items.Add("高一");
					Grade.Items.Add("初一");
					Class.Maximum = 8;
					break;
			}
        }

        private void Grade_SelectedIndexChanged(object sender, EventArgs e)
        {
			grade = Grade.SelectedItem.ToString();
        }

        private void Class_ValueChanged(object sender, EventArgs e)
        {
			classnum = (int)Class.Value;
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {
			username = UserName.Text;
        }

        private void SaveInformation_Click(object sender, EventArgs e)
        {
			if (grade == "" | school == "" | username == "")
			{
				MessageBox.Show("信息不完整，请完善后再继续哦！");
				return;
			}
			else
				StartChanllenge();
        }
    }
    public class Question
	{
		public string question;
		public int answer;
		public string explanation;
		public string[] options = new string[4];
		public Question(string ques, int ans, string a,string b,string c,string d,string reason = "")
		{
			answer = ans;
			question = ques;
			options[0] = a;
			options[1] = b;
			options[2] = c;
			options[3] = d;
			explanation = reason;
		}
	}
}
