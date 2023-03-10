
using SEDC.Homework4.Excercise3.Classes;

Console.WriteLine("Excercise 3");


Student student1 = new Student("Dimitar", "SEDC", "G5");
Student student2 = new Student("Frank", "Oxford", "G2");
Student student3 = new Student("Steve", "Berkley", "H5");
Student student4 = new Student("Jimi", "Stanford", "3R");
Student student5 = new Student("Gary", "Brainster", "A2");


Student[] studentsArray = new Student[] {student1, student2, student3, student4,student5};

void SearchForStudent (string studentName, Student[] arrayOfStudents)
{
    int studentsFound = 0;
    foreach (Student student in arrayOfStudents)
    {
        if(student.Name.ToLower() == studentName.ToLower())
        {
            Console.WriteLine($"Found student {student.Name} attending academy {student.Academy}, group {student.Group}");
            studentsFound ++;
        }

        
    }
    if (studentsFound == 0)
    {
        Console.WriteLine("There is no Student with that name!");
    }
}


Console.WriteLine("Please enter a stundet name:");

string inputStudentName = Console.ReadLine();

SearchForStudent(inputStudentName, studentsArray);