namespace Unit_12._1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User u1 = new User();
            u1.Name = "Ilya";
            u1.Login = "I123";
            u1.IsPremium = true;
            User u2 = new User();
            u2.Name = "Nikola";
            u2.Login = "wfwfq";
            u2.IsPremium = false;
            User[] users = new User[] {u1, u2};
            Greeting(users);
        }

        class User
        {
            public string Login { get; set; }
            public string Name { get; set; }
            public bool IsPremium { get; set; }
        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }

        static void Greeting(User[] users)
        {
            foreach (User user in users)
            {
                Console.WriteLine($"Hello {user.Name}! Your login is {user.Login}");
                if (user.IsPremium) {  }
                else { ShowAds(); }
            } 
        }
    }
}