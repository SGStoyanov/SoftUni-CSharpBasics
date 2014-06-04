/* Problem 13.	Average Load Time Calculator
We have a report that holds dates, web site URLs and load times (in seconds) in the same format like in the examples below. 
Your task is to calculate the average load time for each URL. Print the URLs in the same order as they first appear in the input 
report. Print the output in the format given below. Use double floating-point precision. */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

class AvgLoadTimeCalc
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        //string[] inputStrings =
        //{
        //    "2014-Mar-02 11:33 http://softuni.bg 8.37725",
        //    "2014-Mar-02 11:34 http://www.google.com 1.335",
        //    "2014-Mar-03 21:03 http://softuni.bg 7.25",
        //    "2014-Mar-03 22:00 http://www.google.com 2.44",
        //    "2014-Mar-03 22:01 http://www.google.com 2.45",
        //    "2014-Mar-03 22:01 http://www.google.com 2.77"
        //};

        string[] inputStrings =
        {
            "2014-Apr-01 02:01 http://softuni.bg 8.37725",
            "2014-Apr-01 02:05 http://www.nakov.com 11.622",
            "2014-Apr-01 02:06 http://softuni.bg 4.33",
            "2014-Apr-01 02:11 http://www.google.com 1.94",
            "2014-Apr-01 02:11 http://www.google.com 2.011",
            "2014-Apr-01 02:12 http://www.google.com 4.882",
            "2014-Apr-01 02:34 http://softuni.bg 4.885",
            "2014-Apr-01 02:36 http://www.nakov.com 10.74",
            "2014-Apr-01 02:36 http://www.nakov.com 11.75",
            "2014-Apr-01 02:38 http://softuni.bg 3.886",
            "2014-Apr-01 02:44 http://www.google.com 1.04",
            "2014-Apr-01 02:48 http://www.google.com 1.4555",
            "2014-Apr-01 02:55 http://www.google.com 1.977"
        };

        var sites = new List<Site>();

        foreach (var str in inputStrings)
        {
            string[] inputData = str.Split(' ');

            if (!sites.Exists(s => s.url == inputData[2]))
            {
                sites.Add(new Site(inputData[2]));
            }

            var site = sites.Find(s => s.url == inputData[2]);
            site.GetDateTime(inputData[0] + " " + inputData[1]);
            site.SumLoadTime(double.Parse(inputData[3]));
        }

        foreach (var item in sites)
        {
            item.PrintInfo();
        }

    }
}

class Site
{
    public List<DateTime> date = new List<DateTime>();
    public string url = "";
    private double totalLoadTime = 0;
    private int count = 0;

    public Site(string url)
    {
        this.url = url;
    }

    public double AverageLoadTime
    {
        get { return this.totalLoadTime / count; }
    }//end AverageLoadTime

    public void PrintInfo()
    {
        Console.WriteLine("{0} -> {1}", this.url, this.AverageLoadTime);
    }//end PrintInfo

    public void GetDateTime(string dateAsString)
    {
        this.date.Add(DateTime.Parse(dateAsString));
    }// end GetDateTime

    public void SumLoadTime(double loadTime)
    {
        this.totalLoadTime += loadTime;
        this.count++;
    }//end SumLoadTime
}