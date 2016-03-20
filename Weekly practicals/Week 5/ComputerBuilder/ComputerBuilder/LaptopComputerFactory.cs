using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerBuilder
{
    public class LaptopComputerFactory : IComputerFactory
    {
        //Interface methods
        //Creates new cpu and returns it
        public Cpu buildCpu()
        {
            return new LaptopCpu();
        }

        //Creates new ram and returns it
        public Ram buildRam()
        {
            return new LaptopRam();
        }

        //Creates new gpu and returns it
        public Gpu buildGpu()
        {
            return new LaptopGpu();
        }
    }
}
