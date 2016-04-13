using System;

    class AgeAfterTenyears
    {
        static void Main()
        {
            DateTime today = DateTime.Now;
            Console.WriteLine("Enter your age DD/MM/YYYY: ");
            string birthDay = Console.ReadLine();
            DateTime myBirthDay = DateTime.Parse(birthDay);
            int ageNow = today.Year - myBirthDay.Year;

            if (today.Month < myBirthDay.Month || today.Day < myBirthDay.Day)
            {
                ageNow -= 1;
            }

            Console.WriteLine("Your age now: " +ageNow);
            Console.WriteLine("Your age after 10  years: " + (ageNow + 10));
          
        }
    }
