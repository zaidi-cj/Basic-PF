using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Questions : MonoBehaviour
{
    //variable questions 1 to 14
    int age = 25;
    double price = 9.99D;
    string name = "zaid bin saeed";
    bool isRaining = true;
    char grade = 'A';
    int num1 = 5;
    int num2 = 9;
    int sum;
    double temperature = 43D;
    string input = "my name is zaid";
    bool hasPassed = true;
    int x = 6; int y = 15;
    int add;
    int sub;
    int mul;
    int div;
    int mod;
    string myString = "I live in Lahore Pkaistan";
    string newString = "I " + "Live " + "in";
    bool myBool = true;
    int varA = 29;
    float varB = 4.67982F;
    // if sattement questions 1 to 10
    int numA = -5;
    int numB = 783;
    char charA = 'E';
    int myAge = 23;
    int numC = 34; 
    int numD = 56;
    int numE = 79;
    int year = 2004;
    int examscore = 63;
    int tempCelsius = 29;
    float tempFarenheit;
    int month = 2;
    // loops questions 
    int p = 7; int q = 0;
    int table;
    int numF = 5;
    int fictorial = 1;
    int numG = 1;
    int numH = 17;
    string stringA = "game train";
    string reversedA = "";
    int sumodd = 0;
    int numK = 34543;
    int numrev = 0;
    int numL = 9;
    // function questions
    int addition(int a , int b)
    {
        int sumf = a + b;
        return sumf;
    }
    int subtraction(int c, int d)
    {
        int subf = c - d;
        return subf;
    }
    int product(int e, int f)
    {
        int prof = e * f;
        return prof;
    }
    int division(int g, int h)
    {
        int divf = g / h;
        return divf;
    }
    string Greeting(string name)
    {
        string greeting = "Hello, " + name + "!";
        return greeting;
    }
    bool IsEven(int number)
    {
        return number % 2 == 0;
    }
    int GetMax(int j, int k)
    {
        if (j > k)
        {
            return j;
        }
        else
        {
            return k;
        }
    }
    int GetMin(int m, int n)
    {
        if (m < n)
        {
            return m;
        }
        else
        {
            return n;
        }
    }
    void Start()
    {
        //variables questions 1 to 14
        Debug.Log(age);
        Debug.Log(price);
        Debug.Log(name);
        Debug.Log(isRaining);
        Debug.Log(grade);
        sum = num1 + num2;
        Debug.Log("result = " + sum);
        if (temperature > 40)
        {
            Debug.Log("its too hot!!");
        }
        Debug.Log("string length is" + input.Length);
        if (hasPassed == false)
        {
            Debug.Log("you need to study harder");
        }
        add = x + y;
        sub = x - y;
        mul = x * y;
        div = x / y;
        mod = x % y;

        Debug.Log("addition: " + add);
        Debug.Log("subtraction: " + sub);
        Debug.Log("multiplication: " + mul);
        Debug.Log("division: " + div);
        Debug.Log("modulus: " + mod);
        Debug.Log("incerement on x: " + ++x);
        Debug.Log("decerement on y: " + --y);
        Debug.Log(newString);
        Debug.Log(myBool && myBool);
        Debug.Log(myBool || !myBool);
        Debug.Log(!(myBool && !myBool));
        Debug.Log((myBool || !myBool) && myBool);
        Debug.Log((float)varA + varB);
        Debug.Log(varA * (int)varB);

        //if statements questions 1 to 10
        if(numA >= 0)
        {
            Debug.Log("positive number");
        }
        else
        {
            Debug.Log("negative number");
        }
        if(numB % 2 == 0)
        {
            Debug.Log("even number");
        }
        else
        {
            Debug.Log("odd number");
        }
        if (charA == 'a'|| charA == 'e' || charA == 'i' || charA == 'o' || charA == 'u' || charA == 'A' || charA == 'E' || charA == 'I' || charA == 'O' || charA == 'U' )
        {
            Debug.Log("vowel character");
        }
        else
        {
            Debug.Log("consonant");
        }
        if (myAge >= 18)
        {
            Debug.Log("eligible to vote");
        }
        else
        {
            Debug.Log("not eligible to vote");
        }
        if (numC>numD)
        {
            Debug.Log("larger number is" + numC);
        }
        else
        {
            Debug.Log("larger number is" + numD);
        }
        if ((numC > numD)&& (numC > numE))
        {
            Debug.Log("larger number is" + numC);
        }
        else if ((numD > numC)&&(numD > numE))
        {
            Debug.Log("larger number is" + numD);
        }
        else
        {
            Debug.Log("larger number is" + numE);
        }
        if (examscore>=90 && examscore<=100)
        {
            Debug.Log("Grade A");
        }
        else if (examscore >= 80 && examscore <= 89)
        {
            Debug.Log("Grade B");
        }
        else if (examscore >= 70 && examscore <= 79)
        {
            Debug.Log("Grade C");
        }
        else if (examscore >= 60 && examscore <= 69)
        {
            Debug.Log("Grade D");
        }
        else if (examscore >= 0 && examscore <= 59)
        {
            Debug.Log("Grade F");
        }
        else
        {
            Debug.Log("invalid score entered");
        }
        tempFarenheit = (tempCelsius * 9 / 5) + 32;
        Debug.Log("temp in farenheit is " + tempFarenheit);
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Debug.Log(year + " is a leap year");
        }
        else
        {
            Debug.Log(year + " is not a leap year");
        }
        if ((month == 2) && ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))) //feb in leap year
        {
            Debug.Log("month: " + month + " has 29 days");
        }
        else if (month == 2)
        {
            Debug.Log("month: " + month + " has 28 days");
        }
        else if (month == 4 || month == 6 || month == 9 || month == 11)
        {
            Debug.Log("month: " + month + " has 30 days");
        }
        else
        {
            Debug.Log("month: " + month + " has 31 days");
        }
        // loop questions
        for (int i = 1; i < 100; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }
        }
        while (q <= 10) 
        {
            table = p * q;
            Debug.Log(p + "*" + q + "=" + table);
            q++;
        }
        do
        {
            fictorial *= numG;
            numG++;
        }
        while (numG <= numF);
        Debug.Log("fictorial of: " + numF + " is " + fictorial);
        if (numH <= 1)
        {
            Debug.Log(numH + " is not a prime number");
        }
        for (int p = 2; p <= numH / 2; p++)
        {
            if(numH % p == 0)
            {
                Debug.Log(numH + " is not a prime number");
            }
            else
            {
                Debug.Log(numH + " is a prime number");
            }
        }
        Debug.Log("orignal string is: " + stringA);
        for (int numJ = stringA.Length - 1; numJ >= 0; numJ--)
        {
            reversedA += stringA[numJ];
        }
        Debug.Log("reversed string is: " + reversedA);

        for (int j = 1; j <= 100; j += 2)
        {
            sumodd += j;
        }
        Debug.Log("Sum of odd numbers between 1 and 100 is: " + sumodd);


        int numOrig = numK;
        while (numOrig > 0)
        {
            int digit = numOrig % 10;
            numrev = numrev * 10 + digit;
            numOrig /= 10;
        }
        if (numK == numrev )
        {
            Debug.Log( numK + " is a palindrome");
        }
        else
        {
            Debug.Log( numK + " is not a palindrome");
        }
        for (int z = 0; z <= 40; z++)
        {
            if (z % 2 == 0)
            {
                Debug.Log(z);
            }
        }
        for (int l = 1; l <= numL; l++)
        {
            if (numL % l == 0)
            {
                Debug.Log(l);
            }
        }
        // function question
        int numM = 7;
        int numN = 8;
        int resultF = addition(numM, numN);
        Debug.Log("sum of two integer using function is" + resultF);

        int resultS = subtraction(numM, numN);
        Debug.Log("subtraction of two integer using function is" + resultS);

        int resultP = product(numM, numN);
        Debug.Log("product of two integer using function is" + resultP);

        int resultD = division(numM, numN);
        Debug.Log("division of two integer using function is" + resultD);

        string playerName = "Carl johnson";
        string greetingMessage = Greeting(playerName);
        Debug.Log(greetingMessage);

        int numToCheck = 10;
        bool isEven = IsEven(numToCheck);

        if (isEven)
        {
            Debug.Log(numToCheck + "is even");
        }
        else
        {
            Debug.Log(numToCheck + "is odd");
        }
        int numQ = 15;
        int numR = 7;

        int maxNumber = GetMax(numQ, numR);
        Debug.Log("The larger number between " + numQ +" and " +numR+ " is " + maxNumber);

        int minNumber = GetMin(numQ, numR);
        Debug.Log("The smaller number between " + numQ + " and " + numR + " is " + minNumber);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
