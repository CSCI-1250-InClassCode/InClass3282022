class MyClass
{
    static void Main()
    {
        //User Entered Date of Birth
        //string dateOfBirth = "March 29 2002";

        string[] testData = {"March 29 2002", "3 28 2002", "03 27 2002", "March 30 2002", "1 1 2002", "Nov 5 1995", "March 14 2024", "Nov 12 1955", "12 15 1898"};
        
        //Invokes the Age Method
        for (int i = 0; i < testData.Length; i++)
        {
            Console.WriteLine($"Birthdate: {testData[i]}, \t\tAge: {Age(testData[i])}");
        }
     }

    static string HelloClass()
    {
        return "Hello Class!";
    }

    static int Age(string dateOfBirth)
    {
        //todays date
        DateTime currentDate = DateTime.Now;

        char delimeter = ' ';
        //represents the string split into three different parts
        string[] partsOfDate = dateOfBirth.Split(delimeter);

        //uses the ConverMonthToNumber method to get a month as a int
        int birthMonth = ConvertMonthToNumber(partsOfDate[0]);

        //the remainder of the parts of Date convert into a int
        int birthDay = int.Parse(partsOfDate[1]);
        int birthYear = int.Parse(partsOfDate[2]);
        
        int age = currentDate.Year - birthYear;

        //current Month = 3
        //birth month = 7
        if(currentDate.Month < birthMonth)
        {
            age -= 1;
        }

        if(currentDate.Month == birthMonth)
        {
            if(currentDate.Day < birthDay)
            {
                age -= 1;
            }
        }

        return age;
  
    }

    static int ConvertMonthToNumber(string month)
    {
        if(month == "Jan" || month == "January" || month == "1" || month == "01")
        {
            return 1;
        }
        else if(month == "Feb" || month == "February" || month == "2" || month == "02")
        {
            return 2;
        }
        else if(month == "Mar" || month == "March" || month == "3" || month == "03")
        {
            return 3;
        }
        else if(month == "Apr" || month == "April" || month == "4" || month == "04")
        {
            return 4;
        }
        else if(month == "May" || month == "5" || month == "05")
        {
            return 5;
        }
        else if(month == "Jun" || month == "June" || month == "6" || month == "06")
        {
            return 6;
        }
        else if(month == "Jul" || month == "July" || month == "7" || month == "07")
        {
            return 7;
        }
        else if(month == "Aug" || month == "August" || month == "8" || month == "08")
        {
            return 8;
        }
        else if(month == "Sep" || month == "September" || month == "9" || month == "09")
        {
            return 9;
        }
        else if(month == "Oct" || month == "October" || month == "10")
        {
            return 10;
        }
        else if(month == "Nov" || month == "November" || month == "11")
        {
            return 11;
        }
        else
        {
            return 12;
        }
    }

int x = 6;
int y = 3;
int z = 12;
            //  6  3  12
int w = Method1(x, y, z);

Console.WriteLine($"w = {w}");

            //         6      3      12   
static int Method1(int y, int z, int x)
{
    return (x * z) / y;
}
}