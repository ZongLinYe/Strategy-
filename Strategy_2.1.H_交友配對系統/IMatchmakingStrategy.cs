using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_2._1.H_交友配對系統
{
    public interface IMatchMakingStrategy
    {
        List<Individual> SortMatchMaking(List<Individual> individuals, Individual individual);
    }
}
