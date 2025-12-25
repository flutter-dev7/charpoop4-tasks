using task1;

System.Console.WriteLine("Student:");
Student student = new Student("Ismoil", "Dushanbe", 3, ["Dart", "Futter", "C#"], [85, 80, 92]);
student.AddCourseGrade(".Net", 90);
double average = student.GetAverageGrade();
System.Console.WriteLine(average);
student.PrintGrades();
System.Console.WriteLine("Teacher:");
Teacher teacher = new Teacher("Ali", "Dushanbe", 2, ["C#", ".Net"]);
teacher.AddCourse("SQL");
teacher.AddCourse("C++");
teacher.RemoveCourse("SQL");
teacher.PrintGrades();