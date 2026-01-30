using System;
using StreamBuzz.Model;
using StreamBuzz.Service;

namespace StreamBuzz.Menu
{
    // Handles menu and user interaction
    public class StreamBuzzMenu
    {
        private readonly EngagementService service =
            new EngagementService();

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("1. Register Creator");
                Console.WriteLine("2. Show Top Posts");
                Console.WriteLine("3. Calculate Average Likes");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        RegisterCreatorMenu();
                        break;

                    case 2:
                        ShowTopPostsMenu();
                        break;

                    case 3:
                        double avg =
                            service.CalculateAverageLikes();
                        Console.WriteLine(
                            $"Overall average weekly likes: {avg}");
                        break;

                    case 4:
                        Console.WriteLine(
                            "Logging off — Keep Creating with StreamBuzz!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        private void RegisterCreatorMenu()
        {
            CreatorStats creator = new CreatorStats();
            creator.WeeklyLikes = new double[4];

            Console.Write("Enter Creator Name: ");
            creator.CreatorName = Console.ReadLine();

            Console.WriteLine("Enter weekly likes (Week 1 to 4):");
            for (int i = 0; i < 4; i++)
            {
                creator.WeeklyLikes[i] =
                    double.Parse(Console.ReadLine());
            }

            service.RegisterCreator(creator);
            Console.WriteLine("Creator registered successfully");
        }

        private void ShowTopPostsMenu()
        {
            Console.Write("Enter like threshold: ");
            double threshold = double.Parse(Console.ReadLine());

            var result =
                service.GetTopPostCounts(
                    CreatorStats.EngagementBoard, threshold);

            if (result.Count == 0)
            {
                Console.WriteLine(
                    "No top-performing posts this week");
            }
            else
            {
                foreach (var item in result)
                {
                    Console.WriteLine(
                        $"{item.Key} - {item.Value}");
                }
            }
        }
    }
}