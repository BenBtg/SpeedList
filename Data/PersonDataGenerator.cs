using SpeedList.Models;
using System;

namespace SpeedList.Data
{
    public static class MemberDataGenerator
    {
        public static List<Member> GenerateList(int count)
        {
            var Members = new List<Member>();
            for (int i = 0; i < count; i++)
            {
                Members.Add(new Member(
                    GetRandomName(),
                    GetRandomEmail(),
                    GetRandomPhoneNumber(),
                    GetRandomThumbnailUrl()
                ));
            }

            return Members;
        }

        private static string GetRandomName()
        {
            // Generate a random name
            string[] names = { "John Doe", "Jane Smith", "Robert Johnson", "Emily Davis", "Michael Brown", "David Wilson",
                               "Sarah Anderson", "Thomas Martinez", "Olivia Taylor", "William Jackson", "Sophia Clark",
                               "James Rodriguez", "Ava Garcia", "Benjamin Hernandez", "Mia Moore", "Daniel Lee",
                               "Charlotte White", "Logan Perez", "Harper Thompson", "Liam Hall" };

            int index = new Random().Next(0, names.Length);
            return names[index];
        }

        private static string GetRandomEmail()
        {
            // Generate a random email
            string[] domains = { "example.com", "test.com", "sample.com", "domain.com" };

            int index = new Random().Next(0, domains.Length);
            string domain = domains[index];

            return $"{Guid.NewGuid().ToString().Substring(0, 8)}@{domain}";
        }

        private static string GetRandomPhoneNumber()
        {
            // Generate a random phone number
            string phoneNumber = string.Format("{0:000}-{1:000}-{2:0000}", new Random().Next(0, 999), new Random().Next(0, 999), new Random().Next(0, 9999));
            return phoneNumber;
        }

        private static string GetRandomThumbnailUrl()
        {
            // Fetch a random thumbnail URL from Lorem Picsum
            int imageId = new Random().Next(1, 500);  // Generate a random image ID
            return $"https://picsum.photos/50/50?image={imageId}";
        }
    }
}
