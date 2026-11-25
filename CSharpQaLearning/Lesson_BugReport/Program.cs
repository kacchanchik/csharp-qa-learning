using System;

namespace BugReportApp
{
    public enum BugSeverity { Low, Medium, High, Critical }
    class BugReport
    {
        public int Id;
        public string Title;
        public BugSeverity Severity;
        public bool IsFixed;
    }
    class Program
    {
        static void PrintBugInfo(BugReport bug)
        {
            if (bug == null)
            {
                Console.WriteLine("Bug report not found");
                return;
            }
            Console.WriteLine($"[#{bug.Id}] {bug.Title}\t|\tSeverity: {bug.Severity}\t|\tFixed: {bug.IsFixed}");
        }
        static void Main(string[] args)
        {
            BugReport bug1 = new BugReport
            {
                Id = 101,
                Title = "Login button is broken",
                Severity = BugSeverity.Critical,
                IsFixed = false
            };
            PrintBugInfo(bug1);

            BugReport bug2 = new BugReport
            {
                Id = 102,
                Title = "Typo in footer text",
                Severity = BugSeverity.Medium,
                IsFixed = true
            };
            PrintBugInfo(bug2);

            PrintBugInfo(null);
        }
    }
}
