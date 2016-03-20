using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerBuilder
{
    public class GameComputerFactory : IComputerFactory
    {
        public Cpu buildCpu()
        {
            return new GamingCpu();            
        }

        public Ram buildRam()
        {
            return new GamingRam(); 
        }

        public Gpu buildGpu()
        {
            return new GamingGpu();
        }
    }
}
