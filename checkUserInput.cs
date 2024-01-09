/*
C#:
the user has to insert in the console "administrator", "manager" or "user" (the program deals with capital / no capital issues and spaces), the method I created converts in capital the first letter in the program answer
Solved by Alessandro Silvestri for Microsoft Learn - 2023 <alessandro.silvestri.work@gmail.com>
*/  

namespace CheckInput
{
    class Program
    {
        static void Main(string[] arg)
        {
            string[] userRoles = { "administrator", "manager", "user" };
            bool validAnswer = false;

            do
            {
                Console.WriteLine("Enter your role name (Administrator, Manager, or User): ");
                string userAnswer = Console.ReadLine() ?? "";
                userAnswer = userAnswer.Trim();

                if (userRoles.Contains(userAnswer.ToLower()))
                {
                    Console.WriteLine($"Your input value ({ToCapitalFirstChar(userAnswer)}) has been accepted");
                    validAnswer = true;
                }
                else
                {
                    Console.WriteLine($"The role name that you entered, \"{ToCapitalFirstChar(userAnswer)}\" is not valid.");
                }
            } while (!validAnswer);
        }

        static string ToCapitalFirstChar(string? strToConvert)
        {
            char firstLetter = strToConvert.ToUpper()[0];
            string restOfString = strToConvert[1..].ToLower();
            string strResult = firstLetter + restOfString;
            return strResult;
        }
    }
}
