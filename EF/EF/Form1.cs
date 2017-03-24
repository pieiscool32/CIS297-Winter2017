using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF
{
	public partial class Form1 : Form
	{
		private CollegeEntities1 ef;

		public Form1()
		{
			InitializeComponent();
			ef = new CollegeEntities1();

		}

		private void newCourseButton_Click( object sender, EventArgs e )
		{
			var nextCourseId = (from Courses in ef.Courses
						  orderby Courses.Id descending
						  select Courses).First().Id + 1;

			Course newCourse = new Course
			{
				Id = nextCourseId,
				Department = courseDepartmentTextBox.Text,
				Number = courseNumberTextBox.Text,
				Description = courseDescriptionTextBox.Text
			};

			ef.Courses.Add( newCourse );

			ef.SaveChanges();

		}

		private void button1_Click( object sender, EventArgs e )
		{
			var courses = from Courses in ef.Courses
						  select Courses;


			courseLabel.Text = "";
			offeringsLabel.Text = "";

			foreach ( var course in courses )
			{
				courseLabel.Text += $"{course.Department} - {course.Number} - {course.Description}{Environment.NewLine}";
				foreach ( var offering in course.CourseOfferings )
				{
					offeringsLabel.Text += $"{course.Department} - {course.Number} - {offering.Semester} - {offering.Faculty.Name}{Environment.NewLine}";
				}
			}
		}
	}
}
