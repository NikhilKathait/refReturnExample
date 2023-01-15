class Student
{
    //Public field
    public int grade = 2;

    //Public method
    public void PrintGrade()
    {
        System.Console.WriteLine("Grade : " + grade);
    }

    //Public method with ref return
    public ref int DoWork()
    {
        return ref grade;
    }
}

class Program
{
    static void Main()
    {
        //Creating object of student
        Student s = new Student();

        s.PrintGrade(); //Output Grade : 2

        //Call DoWork
        ref int g = ref s.DoWork();

        //Call PrintGrade
        s.PrintGrade(); //Output Grade : 2

        //Update the value of 'ref return'
        g = 5;

        //Call PrintGrade after updating the value of 'ref return'
        s.PrintGrade(); //Output Grade : 5

        System.Console.ReadKey();
    }
}