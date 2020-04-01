using System;

namespace Homework05
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1

            //* Print individual characters of the string in reverse order. 
            //*Example: we love c# *Expected Output : #c evol ew

            //string reverse = "we love c#";
            //string str = "";
            //int i, l;
            //l = reverse.Length - 1;
            //for (i = l; i >= 0; i--)
            //{
            //    str = str + reverse[i];
            //}
            //Console.WriteLine(" Reverse output is : {0}", str);
            #endregion

            #region Task2
            //*Count the total number of words in a string entered by the user. 
            //*Example: user enters "I love C#" 
            //*Expected output: "I love c#" contains 3 words.

            //string str;
            //int i, wrd, l;
            //str = "I love C#";
            //l = 0;
            //wrd = 1;

            //while (l <= str.Length - 1)
            //{
            //    if (str[l] == ' ' || str[l] == ' ' || str[l] == ' ')
            //    {
            //        wrd++;
            //    }
            //    l++;
            //}
            //Console.Write("I love c# contains: {0}", wrd + " words.");
            #endregion

            #region Task3 

            //*Find maximum occurring character in a string
            //* Example: "We want this situation with covid-19 to ends!" 
            //* Expected Output: The highest frequency of character 't' appears number of times : 6

            //string str = "we want this situation with covid-19 to ends!!!!";
            //char[] toChar = str.ToCharArray();
            //int[] times = new int[toChar.Length];

            //for (int i = 0; i < toChar.Length; i++)
            //{
            //    int time = 0;
            //    for (int j = i; j < toChar.Length; j++)
            //    {
            //        if (toChar[i] == toChar[j] && !Char.IsWhiteSpace(toChar[i]))
            //            time++;
            //    }
            //    times[i] = time;
            //}
            //int max = 0;
            //int maxTimes = 0;
            //for (int i = 0; i < times.Length; i++)
            //{
            //    if (times[i] > maxTimes)
            //    {
            //        max = Array.IndexOf(times, times[i]);
            //        maxTimes = times[i];
            //    }

            //}

            //Console.WriteLine($"{toChar[max]} times: {maxTimes} ");
            #endregion

            #region Task4 
            // *"The whole group of G1 loves C#, 
            // - we are sure that with their education and passion they will be successfull programers soon!"
            //  * Print the whole text after "," in the console. 

            //string task4 = "The whole group of G1 loves C#, we are sure that with their education and passion they will be successfull programers soon!";

            //string without = task4.Substring(31);

            //Console.WriteLine(without);

            //  *Bonus - Try to do that without counting the characters till "," by yourself :)




            #endregion

            #region Task5
            //* Display the Day properties(year, month, day, hour, minute, second) from the today's date. *Expected Output : 
            //* year = 2020
            //* month = 3
            //* day = 26
            //* hour = 23
            //* minute = 12
            //* second = 22

            //var today = DateTime.Now;
            //int year = today.Year;
            //int month = today.Month;
            //int day = today.Day;
            //int hour = today.Hour;
            //int min = today.Minute;
            //int sec = today.Second;
            //string thime = "year, month, day, hour, min, sec";   

            //Console.WriteLine($" Year = {year} \n Month = {month} \n Day = {day} \n Hour = {hour} \n Minute ={min}\n Second = {sec} ");

            #endregion

            #region Task6
            //* Find the leap years between 2008 and 2020. 
            //* Expected output: 
            //* 2008 is a leap year. 
            //* 2012 is a leap year. 
            //* 2016 is a leap year. 
            //* 2020 is a leap year.
            //* Hint - make some researches of DateTime methods, you will find interesting ones that might help you;)

            //for (int year = 2008; year <= 2020; year++)
            //{
            //    if (DateTime.IsLeapYear(year))
            //    {
            //        Console.WriteLine("{0} is a leap year.", year);
            //    }
            //}
            #endregion

            Console.ReadLine();
        }
    }
}
