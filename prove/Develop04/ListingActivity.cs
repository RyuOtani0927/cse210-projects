// Listing Activity

// The activity should begin with the standard starting message and prompt for the duration that is used by all activities.

// The description of this activity should be something like: 
// "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."

// After the starting message, select a random prompt to show the user.

// After displaying the prompt, the program should give them a countdown of several seconds to begin thinking about the prompt. 
// Then, it should prompt them to keep listing items.

// The user lists as many items as they can until they they reach the duration specified by the user at the beginning.

// The activity them displays back the number of items that were entered.

// The activity should conclude with the standard finishing message for all activities.


public class ListingActivity : Activity
{
    
    private List<string> listingPrompts = new();
    private List<int> usedListingPrompts = new();

    public ListingActivity()
    {
        _activityName = "Listing";
        _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        listingPrompts.Add("Who are people that you appreciate?");
        listingPrompts.Add("What are personal strengths of yours?");
        listingPrompts.Add("Who are people that you have helped this week?");
        listingPrompts.Add("When have you felt the Holy Ghost this month?");
        listingPrompts.Add("When have you felt the Holy Ghost this month?");
    }

    public void StartListing()
    {
        DisplayStart();

        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(_activityTime);

        Random rnd = new();
        int randomIndex;

        do
        {
            randomIndex = rnd.Next(listingPrompts.Count);
        } while (usedListingPrompts.Contains(randomIndex) & (usedListingPrompts.Count != listingPrompts.Count));

        usedListingPrompts.Add(randomIndex);
        string listingPrompt = listingPrompts[randomIndex];

        Console.WriteLine("List as many responses as you can to the following prompt: ");

        Console.WriteLine($" --- {listingPrompt} --- ");

        Console.WriteLine();

        Console.Write("You may begin in: ");
        Countdown(5);

        Console.WriteLine();

        int responseCounter = 0;

        while (currentTime < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();

            responseCounter = responseCounter + 1;

            currentTime = DateTime.Now;
        }

        Console.WriteLine($"You listed {responseCounter} items!");

        Console.WriteLine();

        DisplayEnd();
    }

}