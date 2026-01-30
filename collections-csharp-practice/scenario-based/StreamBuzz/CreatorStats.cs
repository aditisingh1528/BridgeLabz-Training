using System.Collections.Generic;

namespace StreamBuzz.Model
{
    // Holds creator engagement data
    public class CreatorStats
    {
        public string CreatorName { get; set; }

        // Likes for 4 weeks
        public double[] WeeklyLikes { get; set; }

        // Stores all creators
        public static List<CreatorStats> EngagementBoard =
            new List<CreatorStats>();
    }
}