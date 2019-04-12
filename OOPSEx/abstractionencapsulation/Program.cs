using System;


namespace abstractionencapsulation
{

    public class User
    {
        public bool AddUserDetail(String name,string email)
        {
            return false;
        }

        private bool ValidateUser(String name, string email)
        {
            return true;
        }

        private int CreateDatabaseConnection()
        {
            return 1 ;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.AddUserDetail("shri", "shri@gmail.com");

            
            

            Console.ReadLine();
        }
    }
}
