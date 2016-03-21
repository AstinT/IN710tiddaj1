using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerBuilder
{
    public class MultimediaComputerFactory : IComputerFactory
    {
        //Interface methods
        //Creates new cpu and returns it
        public Cpu buildCpu()
        {
            return new MultimediaCpu();
        }

        //Creates new ram and returns it
        public Ram buildRam()
        {
            return new MultimediaRam();
        }

        //Creates new gpu and returns it
        public Gpu buildGpu()
        {
            return new MultimediaGpu();
        }
    }
}
