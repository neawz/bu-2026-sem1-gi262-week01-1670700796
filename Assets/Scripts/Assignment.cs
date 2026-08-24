using NUnit.Framework.Interfaces;
using UnityEngine;

public class Assignment : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        As01_CheckNumberSign();
        As02_GetDayName();
        As03_ValidatePassword();
        As04_GetGrade();
        As05_IsLeapYear();
        As06_Calculate();
        As07_GetSeason();
        As08_PurchasingSystemExample();
        As09_RockPaperScissorsExample();
        As10_CalculateWeaponDamage();
        As11_DeterminePlayerRank();
    }

    public int as01Number;
    public void As01_CheckNumberSign()
    {
        // TODO: Implement logic to determine sign
        // Example: Debug.Log("Positive");

        if (as01Number > 0)
        {
            Debug.Log("Positive");
        }
        else if (as01Number < 0)
        {
            Debug.Log("Negative");
        }
        else
        {
            Debug.Log("Zero");
        }
    }

    public int as02Day;
    public void As02_GetDayName()
    {
        // TODO: Implement logic to return day name
        // Example: Debug.Log("Monday");

        switch (as02Day)
        {
            case 1: Debug.Log("Monday"); break;
            case 2: Debug.Log("Tuesday"); break;
            case 3: Debug.Log("Wednesday"); break;
            case 4: Debug.Log("Thursday"); break;
            case 5: Debug.Log("Friday"); break;
            case 6: Debug.Log("Saturday"); break;
            case 7: Debug.Log("Sunday"); break;
            default: Debug.Log("Invalid day"); break;
        }
    }

    public string as03InputPassword;
    public string as03CorrectPassword;
    public void As03_ValidatePassword()
    {
        // TODO: Implement password validation logic
        // Example: Debug.Log("True");

        if (as03InputPassword == as03CorrectPassword)
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("False");
        }
    }

    public int as04Score;
    public void As04_GetGrade()
    {
        // TODO: Implement logic to return grade
        // Example: Debug.Log("A");

        if (as04Score < 0 || as04Score > 100)
        {
            Debug.Log("Invalid score");
            return;
        }

        if (as04Score >= 80)
        {
            Debug.Log("A");
        }
        else if (as04Score >= 70)
        {
            Debug.Log("B");
        }
        else if (as04Score >= 60)
        {
            Debug.Log("C");
        }
        else if (as04Score >= 50)
        {
            Debug.Log("D");
        }
        else
        {
            Debug.Log("F");
        }
    }

    public int as05Year;
    public void As05_IsLeapYear()
    {
        // TODO: Implement leap year check logic
        // Example: Debug.Log("True");

        if (as05Year < 0)
        {
            Debug.Log("Invalid year");
            return;
        }

        if (as05Year % 400 == 0)
        {
            Debug.Log("True");
        }
        else if (as04Score % 100 == 0)
        {
            Debug.Log("False");
        }
        else if (as04Score % 4 == 0)
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("False");
        }
    }

    public double as06Num1;
    public char as06Op;
    public double as06Num2;
    public void As06_Calculate()
    {
        // TODO: Implement calculator logic
        // Example: Debug.Log("Result: 42");

        double result;
        switch (as06Op)
        {
            case '+': result = as06Num1 + as06Num2; break;
            case '-': result = as06Num1 - as06Num2; break;
            case '*': result = as06Num1 * as06Num2; break;
            case '/':
                if (as06Num2 == 0)
                {
                    Debug.Log("Undefined");
                    return;
                }
                else
                {
                    result = as06Num1 / as06Num2;
                    break;
                }
            default: Debug.Log("Invalid operator. Please use + - / *"); return;
        }
        Debug.Log(result);
    }

    public int as07Month;
    public void As07_GetSeason()
    {
        // TODO: Implement logic to return season
        // Example: Debug.Log("Summer");

        if (as07Month <= 0 || as07Month >= 12)
        {
            Debug.Log("Invalid month number.");
            return;
        }

        if (as07Month == 1 || as07Month == 2 || as07Month == 12)
        {
            Debug.Log("It's Winter.");
        }
        else if (as07Month >= 3 && as07Month <= 5)
        {
            Debug.Log("It's Spring.");
        }
        else if (as07Month >= 6 && as07Month <= 8)
        {
            Debug.Log("It's Summer.");
        }
        else if (as07Month >= 9 && as07Month <= 11)
        {
            Debug.Log("It's Fall.");
        }
        else
        {
            Debug.Log("As07: Error");
        }
    }

    public int as08Quantity;
    public int as08Price;
    public int as08Payment;
    public void As08_PurchasingSystemExample()
    {
        if (as08Quantity <= 0)
        {
            Debug.Log("Out of Stock.");
            return;
        }

        if (as08Payment >= as08Price)
        {
            Debug.Log("You got your Order.");
            if (as08Payment > as08Price)
            {
                Debug.Log($"As08: change {as08Payment - as08Price} baht");
            }
        }
        else
        {
            Debug.Log("Not Enough Money.");
        }
    }

    public int as09UserChoice;
    public int as09ComputerChoice;
    public void As09_RockPaperScissorsExample()
    {
        if (as09UserChoice < 0 || as09UserChoice > 2)
        {
            Debug.Log("Please input a valid number. (0=Rock, 1=Paper, 2=Scissor)");
            return;
        }

        if (as09UserChoice == as09ComputerChoice)
        {
            Debug.Log("Draw");
        }
        else if ((as09UserChoice == 0 && as09ComputerChoice == 2) ||
                 (as09UserChoice == 1 && as09ComputerChoice == 0) ||
                 (as09UserChoice == 2 && as09ComputerChoice == 1))
        {
            Debug.Log("You Win!");
        }
        else
        {
            Debug.Log("You Lose!");
        }
    }

    public string as10WeaponType;
    public int as10BaseDamage;
    public void As10_CalculateWeaponDamage()
    {
        // TODO: Add your implementation here
        // Example: Debug.Log("result as string");

        double dmgMultiplier = 1.0;
        switch (as10WeaponType.ToLower())
        {
            case "sword":
                dmgMultiplier = 1.3;
                break;
            case "axe":
                dmgMultiplier = 1.4;
                break;
            case "bow":
                dmgMultiplier = 1.2;
                break;
            case "staff":
                dmgMultiplier = 1.5;
                break;
            case "dagger":
                dmgMultiplier = 1.1;
                break;
            default:
                dmgMultiplier = 1.0;
                break;
        }

        float finalDmg = (float)(as10BaseDamage * dmgMultiplier);
        Debug.Log(finalDmg);
    }

    public int as11Score;
    public int as11CompletionTime;
    public void As11_DeterminePlayerRank()
    {
        // TODO: Add your implementation here
        // Example: Debug.Log("result as string");

        if (as11Score < 0 || as11CompletionTime < 0)
        {
            Debug.Log("Invalid score or time");
            return;
        }

        string rank;
        int baseCoins;
        if (as11Score >= 8000)
        {
            rank = "Gold";
            baseCoins = 100;
        }
        else if (as11Score >= 6000)
        {
            rank = "Silver";
            baseCoins = 75;
        }
        else if (as11Score >= 4000)
        {
            rank = "Bronze";
            baseCoins = 50;
        }
        else
        {
            rank = "Participation";
            baseCoins = 25;
        }

        int bonusCoins;
        if (as11CompletionTime <= 30)
        {
            bonusCoins = 25;
        }
        else if (as11CompletionTime <= 60)
        {
            bonusCoins = 10;
        }
        else
        {
            bonusCoins = 0;
        }

        int totalCoins = baseCoins + bonusCoins;
        Debug.Log($"{rank} Rank - {totalCoins} coin earned");
    }
}
