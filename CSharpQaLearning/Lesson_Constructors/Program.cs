using System;

namespace Lesson_Constructors
{
	class UserAccount
	{
		private string username;
		private string role;
		private bool isActive;
		public UserAccount(string username, string role)
		{
			this.username = username; 
			this.role = role; 
			isActive = true;
		}
        public void PrintInfo() { Console.WriteLine($"User: {username} | Role: {role} | Active: {isActive}"); }
    }
	class Program
	{
		static void Main(string[] args)
		{
            // UserAccount emptyUser = new UserAccount();
            UserAccount user1 = new UserAccount("kacchan", "Admin");
            UserAccount user2 = new UserAccount("ko1ch1", "User");
			user1.PrintInfo();
			user2.PrintInfo();
        }
	}
}
