using System;

namespace Lesson_AccessModifiers
{
    public class TestCase
    {
        public int Id;
        public string Title;
        private int runCount;
        private string lastStatus = "Not Run";
        private void RegisterRun()
        {
            runCount++;
            Console.WriteLine("[System] Test execution registered");
        }
        public void RunTest(bool isSuccess)
        {
            RegisterRun();
            lastStatus = isSuccess ? "Passed" : "Failed";
        }
        public void PrintReport() { Console.WriteLine($"Test #{Id}: {Title} | Status: {lastStatus} | Total runs: {runCount}"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TestCase test1 = new TestCase { Id = 1, Title = "Check user login" };
            test1.RunTest(false);
            test1.RunTest(true);
            test1.PrintReport();
        }
    }
}
