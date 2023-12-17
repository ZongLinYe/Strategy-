using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_2._1.H_交友配對系統
{
    internal class HabitBasedStrategy : IMatchMakingStrategy
    {
        public List<Individual> SortMatchMaking(List<Individual> individuals, Individual individual)
        {
            // 依照兩個人的習慣排序
            var friends = individuals.OrderByDescending(x => x.Habits.Count(y => individual.Habits.Contains(y))).ThenBy(x => x.Id).ToList();
            return friends;
        }
    }
}
