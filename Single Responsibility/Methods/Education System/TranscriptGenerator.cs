namespace SingleResponsibilityDemo.Methods.Education_System
{
    internal class TranscriptGenerator
    {
        public GPACalculator _gpaCalculator;
        public TranscriptGenerator(GPACalculator gpaCalculator)
        {
            _gpaCalculator = gpaCalculator;
        }

        public void PrintTranscript(Student student)
        {
            Console.WriteLine($"Transcript for {student.Name}");
            foreach (var course in student._coursesAndGrades)
            {
                Console.WriteLine($"{course.Key}: {course.Value}");
            }
            Console.WriteLine($"GPA: {_gpaCalculator.CalculateGPA(student)}");
        }
    }
}
