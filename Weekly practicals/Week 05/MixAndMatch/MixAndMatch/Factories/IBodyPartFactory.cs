using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch
{
    //Interface for creating monster body parts
    public interface IBodyPartFactory
    {
        BodyPart createBodyPart(String characterString);
    }
}
