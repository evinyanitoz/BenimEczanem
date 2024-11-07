using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimEczanem.Entity
{
    public class ilDal
    {

        BenimEczanemContext benimEczanemContext = new BenimEczanemContext();
        public List<il> SehirListele()
        {


            return benimEczanemContext.il.ToList();

        }
    }
}
