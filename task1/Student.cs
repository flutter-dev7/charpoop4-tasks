using System;

namespace task1;

public class Student : Person
{
    private int _numCourses;
    private List<string> _courses = new List<string>();
    private List<int> _grades = new List<int>();
    public Student(string name, string address, int numCourses, List<string> courses, List<int> grades) : base(name, address)
    {
        _numCourses = numCourses;
        _courses = courses;
        _grades = grades;
    }
    public void AddCourseGrade(string course, int grade)
    {
        if(_numCourses >= 30)
        {
            System.Console.WriteLine("Student takes no more than 30 courses");
        }
        _courses.Add(course);
        _grades.Add(grade);
        _numCourses++;
    }

    public void PrintGrades()
    {
        for (int i = 0; i < _numCourses; i++)
        {
            System.Console.WriteLine($"{_courses[i]}: {_grades[i]}");
        }
    }

    public double GetAverageGrade()
    {
        return _grades.Average();
    }
}
