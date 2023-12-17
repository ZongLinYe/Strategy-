namespace Strategy_2._1.H_交友配對系統
{
    internal class Program
    {
        private static readonly List<string> _habits = new List<string> { "打電動", "打籃球", "打羽球", "打麻將", "打撞球", "慢跑", "跳舞", "唱歌", "看電影", "看書", "寫程式", "寫部落格", "玩手機", "玩桌遊", "玩遊戲", "玩電腦", "睡覺", "吃飯", "喝水", "上廁所", "洗澡", "洗衣服" };
        private static readonly Random _random = new Random();
        private static readonly int _numberOfIndividuals = 30;



        static void Main(string[] args)
        {
            List<Individual> individuals = new List<Individual>();

            string[] genders = { "Male", "Female" };

            for (int i = 0; i < _numberOfIndividuals; i++)
            {
                individuals.Add(new Individual(
                    i + 1,
                    // random Gender
                    (Gender)_random.Next(1, 3),
                    // random Age > 18
                    _random.Next(18, 100),
                    "intro",
                    // random Habit
                    RandomHabits(),
                    new Coord(_random.NextDouble() * 2000, _random.NextDouble() * 2000)
                    ));
            }
            var app = new MatchmakingSystem(individuals, new DistanceBaseStrategy());
            var individual = individuals.First();
            app.Match();
            Console.WriteLine($"距離: {individual.Coord.Distance(individual.Matched.Coord)}");

            app.MatchingStrategy = new HabitBasedStrategy();
            app.Match();
            individual = individuals.First();
            Console.WriteLine($"共同興趣有哪些 : {string.Join(",", individual.Habits.Intersect(individual.Matched.Habits))}");
            Console.ReadLine();
        }

        private static List<string> RandomHabits()
        {
            HashSet<string> habits = new HashSet<string>();
            List<string> tempHabits = new List<string>(_habits);
            int numberOfHabits = _random.Next(1, tempHabits.Count + 1);
            for (int i = 0; i < numberOfHabits; i++)
            {
                int index = _random.Next(0, tempHabits.Count);
                habits.Add(tempHabits[index]);
                tempHabits.RemoveAt(index);
            }
            return habits.ToList();
        }
    }
}
