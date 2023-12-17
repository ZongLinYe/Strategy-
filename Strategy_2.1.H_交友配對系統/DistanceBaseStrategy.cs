using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_2._1.H_交友配對系統
{
    internal class DistanceBaseStrategy : IMatchMakingStrategy
    {
        public List<Individual> SortMatchMaking(List<Individual> individuals, Individual individual)
        {
            // throw new NotImplementedException();Intersect 
            // 依照兩個人的距離排序
            // var friends = individuals.OrderBy(x => x.Distance(individual)).ToList();
            var friends = individuals.OrderBy(x => x.Coord.Distance(individual.Coord)).ThenBy(x => x.Id).ToList();
            return friends;
        }
    }
}
