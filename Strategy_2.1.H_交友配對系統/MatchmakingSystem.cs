using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Strategy_2._1.H_交友配對系統
{
    internal class MatchmakingSystem
    {
        // private IMatchMakingStrategy _strategy;
        private List<Individual> _individuals;
        public MatchmakingSystem(List<Individual> individuals, IMatchMakingStrategy strategy)
        {
            MatchingStrategy = strategy;
            _individuals = individuals;
        }
        // public List<Individual> Individuals { get; set; }
        public void Match()
        {
            foreach (var individual in _individuals)
            {
                // var friends = _strategy.SortMatchMaking(_individuals, individual);
                // 過濾掉自己
                var individuals = _individuals.Where(x => x.Id != individual.Id).ToList();
                var friends = MatchingStrategy.SortMatchMaking(individuals, individual);
                var friend = friends.First();
                individual.Match(friend);
            }
        }
        public IMatchMakingStrategy MatchingStrategy { get; set; }

    }
}
