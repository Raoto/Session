﻿using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SessionForms
{
	public partial class AddRow : Form
	{
		public bool ShouldAdd;
		public AddRow()
		{
			InitializeComponent();
			ShouldAdd = false;
			Course.Leave += CheckCourse;
			Group.Leave += CheckGroup;
			LastName.Leave += CheckLastName;
			Document.Leave += CheckDocument;
			Lesson.Leave += CheckLesson;
			Mark.Leave += CheckMark;
		}

		public void Clear()
		{
			Course.Text = "";
			Group.Text = "";
			LastName.Text = "";
			Document.Text = "";
			Lesson.Text = "";
			Mark.Text = "";
		}

		protected override void OnShown(EventArgs e)
		{
			ShouldAdd = false;
			base.OnShown(e);
		}

		private void Add_Click(object sender, EventArgs e)
		{
			ShouldAdd = true;
			Close();
		}

		private void CheckCourse(object sender, EventArgs e)
		{
			if (Regex.IsMatch(Course.Text, "^[0-9]+$"))
				return;
			MessageBox.Show("WrongInput");
			Course.Text = "";
		}
		
		private void CheckGroup(object sender, EventArgs e)
		{
			if (Regex.IsMatch(Group.Text, "^[0-9]+/[0-9]+$"))
				return;
			MessageBox.Show("WrongInput");
			Group.Text = "";
		}
		
		private void CheckLastName(object sender, EventArgs e)
		{
			if (Regex.IsMatch(LastName.Text, "^[a-zA-Z]+$"))
				return;
			MessageBox.Show("WrongInput");
			LastName.Text = "";
		}
		
		private void CheckDocument(object sender, EventArgs e)
		{
			if (Regex.IsMatch(Document.Text, "^[0-9]+$"))
				return;
			MessageBox.Show("WrongInput");
			Document.Text = "";
		}
		
		private void CheckLesson(object sender, EventArgs e)
		{
			if (Regex.IsMatch(Lesson.Text, "^[a-zA-Z ]+$"))
				return;
			MessageBox.Show("WrongInput");
			Lesson.Text = "";
		}
		
		private void CheckMark(object sender, EventArgs e)
		{
			if (Regex.IsMatch(Mark.Text, "^[2-5]$"))
				return;
			MessageBox.Show("WrongInput");
			Mark.Text = "";
		}
	}
}