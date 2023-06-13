namespace SpeedList.Models
{
    public class Member
    {
        public string Name { get; }
        public string Email { get; }
        public string Phone { get; }
        public string ThumbnailUrl { get; }

        public Member(string name, string email, string phone, string thumbnailUrl)
        {
            Name = name;
            Email = email;
            Phone = phone;
            ThumbnailUrl = thumbnailUrl;
        }
    }
}
