using System;

namespace Lesson_Encapsulation
{
    class BrowserSession
    {
        private string url = "about:blank";
        private bool isOpen;
        private void StartBrowser()
        {
            isOpen = true;
            Console.WriteLine("[System] Browser started");
        }
        public void SetUrl(string newUrl)
        {
            if (string.IsNullOrWhiteSpace(newUrl))
                Console.WriteLine("Error: URL is empty");
            else
                url = newUrl;
        }
        public string GetUrl() { return url; }
        public void OpenPage()
        {
            if (!isOpen)
                StartBrowser();
            Console.WriteLine($"Opening {url}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BrowserSession session = new BrowserSession();
            session.SetUrl("");
            session.SetUrl("https://shop.test");
            session.OpenPage();
            session.OpenPage();
            Console.WriteLine(session.GetUrl());
        }
    }
}
