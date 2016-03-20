using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerBuilder
{
    public class BusinessComputerFactory : IComputerFactory
    {
        public Cpu buildCpu()
        {
            return new BusinessCpu();
        }

        public Ram buildRam()
        {
            return new BusinessRam();
        }

        public Gpu buildGpu()
        {
            return new BusinessGpu();
        }
    }
}
