
class NonGui {
    private static void Main(String[] args) {
            Console.WriteLine("Are you a natural born citizen. Type Yes or No");
    bool found_answer = true;
    bool isNaturalBornCitizen = false;
    do
    {
        string natural_born_citizen = Console.ReadLine();
        if (natural_born_citizen == "Yes" || natural_born_citizen == "No")
        {
            found_answer = true;
            if (natural_born_citizen == "Yes")
            {
                isNaturalBornCitizen = true;
            }
            else
            {
                isNaturalBornCitizen = false;
            }
        }
        else
        {
            Console.WriteLine("Wrong input. Please enter the corrent input either yes or no");
            found_answer = false;
        }
    } while (!found_answer);
    Console.WriteLine("Please enter your birthday: ");
    string birthday = Console.ReadLine();
    Console.WriteLine("Enter in the number of years you have resided in the United States");
    int yearResidedInUs = int.Parse(Console.ReadLine());
    Console.WriteLine("How many Prior Terms have You served");
    int priorTermsServed = int.Parse(Console.ReadLine());
    Console.WriteLine("Have You rebelled against the United States");
    found_answer = true;
    bool isRebbelious = false;
    do
    {
        string rebellious = Console.ReadLine();
        if (rebellious != "Yes" || rebellious != "No")
        {
            found_answer = true;
            if (rebellious == "Yes")
            {
                isRebbelious = true;
            }
            else
            {
                isRebbelious = false;
            }
        }
        else
        {
            Console.WriteLine("Wrong input. Please enter the corrent input either yes or no");
            found_answer = false;
        }
    } while (!found_answer);
    PresidentAnalyzer presidentAnalyzer= new PresidentAnalyzer(isNaturalBornCitizen, birthday, yearResidedInUs, priorTermsServed, isRebbelious);
    Console.WriteLine(presidentAnalyzer.Response());
}
}
