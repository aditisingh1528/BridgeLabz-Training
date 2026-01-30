using System.Collections.Generic;
using StreamBuzz.Model;

namespace StreamBuzz.Service
{
    // Contains all business logic
    public class EngagementService
    {
        // Register creator
        public void RegisterCreator(CreatorStats record)
        {
            CreatorStats.EngagementBoard.Add(record);
        }

        // Count weeks where likes >= threshold
        public Dictionary<string, int> GetTopPostCounts(
            List<CreatorStats> records, double likeThreshold)
        {
            Dictionary<string, int> result =
                new Dictionary<string, int>();

            foreach (var creator in records)
            {
                int count = 0;

                foreach (var likes in creator.WeeklyLikes)
                {
                    if (likes >= likeThreshold)
                        count++;
                }

                if (count > 0)
                    result.Add(creator.CreatorName, count);
            }

            return result;
        }

        // Calculate average likes
        public double CalculateAverageLikes()
        {
            double total = 0;
            int count = 0;

            foreach (var creator in CreatorStats.EngagementBoard)
            {
                foreach (var likes in creator.WeeklyLikes)
                {
                    total += likes;
                    count++;
                }
            }

            return count == 0 ? 0 : total / count;
        }
    }
}