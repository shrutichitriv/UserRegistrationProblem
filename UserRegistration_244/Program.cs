namespace UserRegistration_244
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome to User Registration Program");

            //UR1
            //Console.WriteLine("Welcome to Regular Expression");
            //Console.WriteLine("Enter your first name");
            //string FirstName = Console.ReadLine(); // Creating user input for first name
            //FirstNameCapi.FirstNameValidation(FirstName);//Calling method to validate firstname

            //UR2
            //Console.WriteLine("Enter your Last name");
            //string LName = Console.ReadLine(); //  input for last name
            //LastNameCapi.LastNameValidation(LName);

            //UR3
            //Console.WriteLine("\n\nEnter your email name : ");
            //string email = Console.ReadLine();
            //bool checkEmail = ValidEmail.EmailValidation(email); //Calling method to check email 

            //UR4
            //Console.Write("Enter The Mobile Number:");
            //String mob = Console.ReadLine();

            //if (MobileNumber.validate(mob))
            //{
            //    Console.WriteLine("Valid Data");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Data");
            //}

            //UR5
            //Console.Write("Enter The Password:");
            //String pass = Console.ReadLine();

            //if (Pass8Chara.validate(pass))
            //{
            //    Console.WriteLine("Valid");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}

            //UR6
            //Console.Write("enter the password:");
            //string pass = Console.ReadLine();

            //if (PasswordUpperCase.validate(pass))
            //{
            //    Console.WriteLine("valid");
            //}
            //else
            //{
            //    Console.WriteLine("invalid");
            //}


            //UR7
            //Console.Write("Enter The Password:");
            //String pass = Console.ReadLine();

            //if (Password1Numeric.validate(pass))
            //{
            //    Console.WriteLine("Valid");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}


            //UR8
            //Console.Write("Enter The Password:");
            //String pass = Console.ReadLine();

            //if (Pass1SpecialCharacter.validate(pass))
            //{
            //    Console.WriteLine("Valid");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}

            //UR9
            EmailSampleSeparately regex = new EmailSampleSeparately();
            Console.WriteLine("User registration Problem statement");
            Console.WriteLine("*First letter should be capital.");
            Console.WriteLine("*length should be Minimum three characters.");
            Console.WriteLine("Enter First name :");
            string fname = Console.ReadLine();
            regex.CheckName(fname);
            Console.WriteLine("Enter Last name :");
            string lname = Console.ReadLine();
            regex.CheckName(lname);
            Console.WriteLine("Enter Email id :");
            string email = Console.ReadLine();
            regex.CheckEmail(email);
            Console.WriteLine("Enter Mobile no. :");
            string mobile = Console.ReadLine();
            regex.CheckMobileNo(mobile);
            Console.WriteLine("Enter Password :");
            string password = Console.ReadLine();
            regex.CheckPassword(password);



















        }
    }
}

