using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerBuilder
{
    public class MultimediaComputerFactory : IComputerFactory
    {
        public Cpu buildCpu()
        {
            return new MultimediaCpu();
        }

        public Ram buildRam()
        {
            return new MultimediaRam();
        }

        public Gpu buildGpu()
        {
            return new MultimediaGpu();
        }
    }
}
