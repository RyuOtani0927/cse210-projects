using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activityList = new();

        Activity activity1 = new RunningActivity("03 Nov 2022",30,3);
        activityList.Add(activity1);

        Activity activity2 = new CyclingActivity("04 Nov 2022",30,9.6);
        activityList.Add(activity2);

        Activity activity3 = new SwimmingActivity("05 Nov 2022",30,30);
        activityList.Add(activity3);

        foreach (Activity activity in activityList)
        {
            Console.WriteLine();
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }



    }
}