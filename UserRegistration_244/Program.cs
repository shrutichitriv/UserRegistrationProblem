namespace UserRegistration_244
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome to User Registration Program");

            //UR1
            Console.WriteLine("Welcome to Regular Expression");
            Console.WriteLine("Enter your first name");
            string FirstName = Console.ReadLine(); // Creating user input for first name
            FirstNameCapi.FirstNameValidation(FirstName);//Calling method to validate firstname


        }
    }
}

