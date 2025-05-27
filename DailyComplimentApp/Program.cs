using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyComplimentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //بِسْمِ ٱللَّٰهِ ٱلرَّحْمَٰنِ ٱلرَّحِيمِ
            string firstName, middleName, lastName;
            DateTime currentTime = DateTime.Now;

            List<string> compliments = new List<string>
            {
                "Please never forget, you have a beautiful smile, one that can brighten up even the darkest of days.",
                "Never forget, you are loved, cared for, cherished and appreciated. You are a genuine blessing, always have been and always will be.",
                "The world is a better place because YOU ARE in it, please never forget that.",
                "I'm proud of you, genuinely, I'm so freaking proud of you! And trust me, I'm not the only one who's proud of you and rooting for you.",
                "You're hardwork, trust me, it's noticed. And the things you've done in secret, all the tears you've shed, make you one of the strongest people I know. Never underestimate how stong you are, okay?",
                "No matter what comes your way, I, and many others, will always ALWAYS believe in you!"
            };

            while (true)
            {
                Console.Write("Please Enter Your First Name: ");
                firstName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(firstName))
                {
                    Console.WriteLine("First name cannot be empty. Please try again.\n");
                    continue;
                }

                Console.Write("Please Enter Your Middle Name: ");
                middleName = Console.ReadLine();

                Console.Write("Please Enter Your Last Name: ");
                lastName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(lastName))
                {
                    Console.WriteLine("Last name cannot be empty. Please try again.\n");
                    continue;
                }

                break;
            }

            Console.Clear();

            Random random = new Random();
            int id = random.Next(0, compliments.Count);

            string complimentOfTheDay = compliments[id];

            string welcomeMessage;

            if (string.IsNullOrWhiteSpace(middleName))
            {
                welcomeMessage = $"WELCOME {firstName} {lastName}";
            }
            else
            {
                welcomeMessage = $"WELCOME {firstName} {middleName} {lastName}";
            }

            Console.WriteLine($"---------------------------------------------- {welcomeMessage} ----------------------------------------------");
            Console.WriteLine($"----------------------------------------- TODAY IS {currentTime} -----------------------------------------");
            Console.WriteLine($"------------------------------------------- TODAY'S DAILY REMINDER IS: -------------------------------------------");
            Console.WriteLine($"{complimentOfTheDay}");

            Console.ReadLine();
        }
    }
}
