using System;

namespace task1;

public class Teacher : Person
{
    private int _numCourse;
    private List<string> _courses = new List<string>();
    public Teacher(string name, string address, int numCourses, List<string> courses) : base(name, address)
    {
        _numCourse = numCourses;
        _courses = courses;
    }
    public void AddCourse(string course)
    {
        if(_numCourse >= 5)
        {
            System.Console.WriteLine("Teacher teaches no more than 5 courses");
        }
        _courses.Add(course);
        _numCourse++;
    }
    public void RemoveCourse(string course)
    {
        for (int i = 0; i < _numCourse; i++)
        {
            if(_courses[i] == course)
            {
                _numCourse--;
            }
        }
    }
    public void PrintGrades()
    {
        for (int i = 0; i < _numCourse; i++)
        {
            System.Console.WriteLine(_courses[i]);
        }
    }
}
