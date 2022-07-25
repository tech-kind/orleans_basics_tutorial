using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrleansBasics
{
    public interface IHello : Orleans.IGrainWithIntegerKey
    {
        ValueTask<string> SayHello(string greeting);
    }
}
