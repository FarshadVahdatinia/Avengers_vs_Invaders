namespace Core
{
    public class Hero : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get { return string.IsNullOrEmpty(Name)? "" : Name.Contains("@") ? Name : Name + "@Avengers.com"; } }
    }
}
