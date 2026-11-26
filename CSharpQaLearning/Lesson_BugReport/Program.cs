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
        public void PrintBugInfo() { Console.WriteLine($"[#{Id}] {Title}\t|\tSeverity: {Severity}\t|\tFixed: {IsFixed}"); }
        public void MarkAsFixed()
        {
            IsFixed = true;
            Console.WriteLine($"Bug #{Id} has been fixed");
        }
        public string GetRetestStatus()
        {
            if (IsFixed)
                return "Ready for retest";
            return "Still broken";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BugReport bug1 = new BugReport
            {
                Id = 101,
                Title = "Login button is broken",
                Severity = BugSeverity.Critical,
                IsFixed = false
            };
            bug1.PrintBugInfo();

            BugReport bug2 = new BugReport
            {
                Id = 102,
                Title = "Typo in footer text",
                Severity = BugSeverity.Medium,
                IsFixed = true
            };
            bug2.PrintBugInfo();
            bug1.MarkAsFixed();
            Console.WriteLine(bug1.GetRetestStatus());
            bug1.PrintBugInfo();
        }
    }
}