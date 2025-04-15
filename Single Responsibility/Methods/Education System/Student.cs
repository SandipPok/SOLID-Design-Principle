namespace SingleResponsibilityDemo.Methods.Education_System
{
    internal class Student
    {
        public string Name { get; set; }
        public Dictionary<string, double> _coursesAndGrades = new Dictionary<string, double>();

        public void EnrollCourse(string courseName)
        {
            _coursesAndGrades[courseName] = 0;
        }

        public void AssignGrade(string courseName, double grade)
        {
            if (_coursesAndGrades.ContainsKey(courseName))
            {
                _coursesAndGrades[courseName] = grade;
            }
        }
    }
}
