/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using coffee.tool.Model;

namespace coffee.tool.Data;

public class coffdataprovider
{
    public IEnumerable<CofeeShop> Data { get; set; }

    public IEnumerable<CofeeShop> LoadShops()
    {
        return new CofeeShop[]
        {
            new CofeeShop("adin",1),
            new CofeeShop("dwa4",4),
            new CofeeShop("direct",44),
            new CofeeShop("semi",7)
        };
    }


}
