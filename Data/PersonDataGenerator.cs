using SpeedList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedList.Data
{
    public static class MemberDataGenerator
    {
        public static List<Member> GenerateList()
        {
            var Members = new List<Member>()
            {
                new Member("John Doe", "john.doe@example.com", "123-456-7890", GetRandomThumbnailUrl()),
                new Member("Jane Smith", "jane.smith@example.com", "555-555-5555", GetRandomThumbnailUrl()),
                new Member("Robert Johnson", "robert.johnson@example.com", "999-999-9999", GetRandomThumbnailUrl()),
                new Member("Emily Davis", "emily.davis@example.com", "987-654-3210", GetRandomThumbnailUrl()),
                new Member("Michael Brown", "michael.brown@example.com", "123-123-1234", GetRandomThumbnailUrl()),
                new Member("David Wilson", "david.wilson@example.com", "456-789-0123", GetRandomThumbnailUrl()),
                new Member("Sarah Anderson", "sarah.anderson@example.com", "789-012-3456", GetRandomThumbnailUrl()),
                new Member("Thomas Martinez", "thomas.martinez@example.com", "234-567-8901", GetRandomThumbnailUrl()),
                new Member("Olivia Taylor", "olivia.taylor@example.com", "567-890-1234", GetRandomThumbnailUrl()),
                new Member("William Jackson", "william.jackson@example.com", "901-234-5678", GetRandomThumbnailUrl()),
                new Member("Sophia Clark", "sophia.clark@example.com", "345-678-9012", GetRandomThumbnailUrl()),
                new Member("James Rodriguez", "james.rodriguez@example.com", "678-901-2345", GetRandomThumbnailUrl()),
                new Member("Ava Garcia", "ava.garcia@example.com", "012-345-6789", GetRandomThumbnailUrl()),
                new Member("Benjamin Hernandez", "benjamin.hernandez@example.com", "321-654-9870", GetRandomThumbnailUrl()),
                new Member("Mia Moore", "mia.moore@example.com", "654-987-0123", GetRandomThumbnailUrl()),
                new Member("Daniel Lee", "daniel.lee@example.com", "987-012-3456", GetRandomThumbnailUrl()),
                new Member("Charlotte White", "charlotte.white@example.com", "210-543-8765", GetRandomThumbnailUrl()),
                new Member("Logan Perez", "logan.perez@example.com", "543-876-2091", GetRandomThumbnailUrl()),
                new Member("Harper Thompson", "harper.thompson@example.com", "876-209-5438", GetRandomThumbnailUrl()),
                new Member("Liam Hall", "liam.hall@example.com", "209-543-8762", GetRandomThumbnailUrl())
            };

            return Members;
        }

        private static string GetRandomThumbnailUrl()
        {
            // Fetch a random thumbnail URL from Lorem Picsum
            int imageId = new Random().Next(1, 1000);  // Generate a random image ID
            return $"https://picsum.photos/50/50?image={imageId}";
        }
    }
}
