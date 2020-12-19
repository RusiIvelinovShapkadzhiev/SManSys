namespace Domain
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Parent Parent { get; set; }
        public Teacher Teacher { get; set; }
    }
}