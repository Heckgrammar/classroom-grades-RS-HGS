// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
using System;
public class HelloWorld
{
    struct Student
    {
        public string name;
        public int studentID;
        public string formGroup;
        public Student(string nameGiven, int studentIDGiven, string formGroupGiven)
    {
        name = nameGiven;
        studentID = studentIDGiven;
        formGroup = formGroupGiven;
    }
    }
 
    public static void Main(string[] args)
    {
        const int maxStudents = 5;
        Student[] arr = new Student[maxStudents];
        int studentCount = 0;
        string[] subjects = {"Maths","English","Biology","Chemistry","Physics"};
        int maxSubjects = subjects.Length;
        int[,] grades = new int[maxStudents, maxSubjects];
        int choice = -1;
        while (choice != 0)
        {
            Console.WriteLine("Enter 1 To Add A student, 2 To Enter Grades For A Student, 3 To View All Student Grades And 0 To Quit.");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1) {
                if (studentCount < maxStudents)
                {
                    Console.WriteLine("Enter the Student's name");
                    string student_name = Console.ReadLine();
                    Console.WriteLine("Enter the Student's ID");
                    int student_studentID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Student's form group");
                    string student_formGroup = Console.ReadLine();
                    arr[studentCount] = new Student(student_name, student_studentID, student_formGroup);
                    studentCount++;
                }
                else
                {
                    Console.WriteLine("There are already the maximum number of students");
                }
            }
            if (choice == 2) {
                bool grades_studentFound = false;
                Console.WriteLine("Enter a student ID");
                int grades_studentID = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < studentCount; i++)
                {
                    if (arr[i].studentID == grades_studentID)
                    {
                        grades_studentFound = true;
                        for (int j = 0; j < maxSubjects; j++)
                        {
                            Console.WriteLine($"Enter the grade for {subjects[j]}");

                            int grades_subjectGrade = Convert.ToInt32(Console.ReadLine());
                            while (grades_subjectGrade > 100 || grades_subjectGrade < 0)
                {
                    Console.WriteLine("The grade must be valid (between 0 and 100)");
                    grades_subjectGrade = Convert.ToInt32(Console.ReadLine());
                }
                grades[i,j] = grades_subjectGrade;
                        }
                    }
                }
            }
            if (choice == 3) {
                for (int i = 0; i < studentCount; i++ )
                {
                    for (int j = 0; j < maxSubjects; j++ )
                {
                    Console.WriteLine($"The {subjects[j]} grade for {arr[i].name} is {grades[i,j]}");
                }
                }
            }
            if (choice == 0) {}
            else if (choice > 3 || choice < 0) {Console.WriteLine("Enter a valid number.");}
        }
    }
}
