using System;

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
            Validation(name, age);

            return new User
            {
                Id = id,
                Name = name,
                Age = age
            };
        }

        private static void Validation(string name, int age)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException($"{nameof(name)} - {name}");
            }

            if (age <= 0)
            {
                throw new ArgumentNullException($"{nameof(age)} - {age}");
            }
        }
    }
}
