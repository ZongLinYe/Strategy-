using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_2._1.H_交友配對系統
{
    internal class Reversed : IMatchMakingStrategy
    {
        public List<Individual> SortMatchMaking(List<Individual> individuals, Individual individual)
        {
            // 將傳進來的 individuals 反向排序，不要依靠任何參數
            var friends = individuals.Reverse<Individual>().ToList();
            return friends;
        }
    }
}
