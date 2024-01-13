using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class CohortManager {
        public List<string> _coHorts;

        public bool SearchManeger(List<string> coHorts, string name) {
            if (coHorts.Contains(name)) {
                return true;
            }
            return false;
        } 
    }
}
