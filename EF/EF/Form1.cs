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

			// get me the only ( single ) course offering where ID is 1
			var courseOffering = ef.CourseOfferings
				.Where( c => c.Id == 1 ).Single();

			// create new registration object to add to CourseOffering.Registrations and Student.Registration
			var registration1 = new Registration
			{
				Id = 0,
				StudentId = 1,
				CourseOfferingId = 1,
				RegistrationDate = DateTime.Today
			};

			// get the single student whose ID is 1
			var student = ef.Students.Where( s => s.Id == registration1.StudentId ).Single();
			student.Registrations.Add( registration1 );
			courseOffering.Registrations.Add( registration1 );

			var registration2 = new Registration
			{
				Id = 1,
				StudentId = 2,
				CourseOfferingId = 1,
				RegistrationDate = DateTime.Today.AddDays( 2 )
			};
			// get the single student whose ID is 2
			student = ef.Students.Where( s => s.Id == registration2.StudentId ).Single();
			student.Registrations.Add( registration2 );

			
			courseOffering.Registrations.Add( registration2 );

			ef.SaveChanges();
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

			var registrationThisMonth = ef.Registrations
				// find all registrations where the month registered is 3 ( March )
				.Where( r => r.RegistrationDate.Month == 3 );

			courseLabel.Text = "";
			offeringsLabel.Text = "";
			multiLineTextBox.Text = "";

			foreach ( var registration in registrationThisMonth )
			{
				multiLineTextBox.Text += $"{registration.Student.Name} - {registration.CourseOffering.Course.Description}{Environment.NewLine}";
			}

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
