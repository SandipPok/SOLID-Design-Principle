namespace SingleResponsibilityDemo.Methods.Education_System
{
    internal class GPACalculator
    {
        public double CalculateGPA(Student student)
        {
            return student._coursesAndGrades.Values.Average();
        }
    }
}
