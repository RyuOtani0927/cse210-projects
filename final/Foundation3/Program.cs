using System;

class Program
{
    static void Main(string[] args)
    {

        List<Event> eventList = new();


        Event event1 = new LectureEvent("The Wonders of Quantum Computing","Join us for an engaging exploration of the quantum realm!","Thursday, January 18, 2024","6:30 PM - 8:30 PM","Dr. Emily Carter",150);
        event1.SetAddress("Innovation Hub Auditorium, 450 Tech Lane","Palo Alto","Cansas","United States");
        eventList.Add(event1);

        Event event2 = new ReceptionEvent("Glow in the Dark Art Night","Join us for a vibrant evening of creativity under blacklights!","Saturday, February 17, 2024","6:00 PM - 9:30 PM","The Art Loft, 2415 Maple Avenue","Springfield","Illinois","United States","glowartnight@theartloft.com");
        eventList.Add(event2);

        Address address3 = new Address("Green Valley Park, 123 Meadow Lane","Willowbrook","Cansas","United States");
        Event event3 = new OutdoorEvent("Starlit Stories and S'mores Night","Gather under the open skies for an enchanting evening of storytelling around a crackling fire.","Saturday, March 16, 2024","7:00 PM - 10:00 PM",address3,"Snow");
        eventList.Add(event3);

        foreach (Event eachEvent in eventList)
        {
            eachEvent.DisplayMarketingMessage();
        }
    
    }
}