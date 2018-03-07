namespace Template.Core.User.Entities
{
    public class User //DOMAIN MODEL
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }

        public static User Create(string name, int age)
        {
            return Create(0, name, age);
        }
        public static User Create(int id, string name, int age)
        {
            return new User
            {
                Id = id,
                Name = name,
                Age = age
            };
        }
    }
}
