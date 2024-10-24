using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buider_Pattern.Сomponents;

namespace Buider_Pattern
{
    public class ComputerBuilder
    {
        private CPU _cpu;
        private Motherboard _motherboard;
        private RAM _ram;
        private Storage _storage;
        private GPU _gpu;

        public ComputerBuilder SetCPU(CPU cpu)
        {
            _cpu = cpu;
            return this; 
        }

        public ComputerBuilder SetMotherboard(Motherboard motherboard)
        {
            _motherboard = motherboard;
            return this;
        }

        public ComputerBuilder SetRAM(RAM ram)
        {
            _ram = ram;
            return this;
        }

        public ComputerBuilder SetStorage(Storage storage)
        {
            _storage = storage;
            return this;
        }

        public ComputerBuilder SetGPU(GPU gpu)
        {
            _gpu = gpu;
            return this;
        }

        public Computer Build()
        {
            
            if (_cpu == null || _motherboard == null || _ram == null || _storage == null || _gpu == null)
            {
                throw new InvalidOperationException("Все компоненты компьютера должны быть заданы.");
            }

            return new Computer(_cpu, _motherboard, _ram, _storage, _gpu);
        }

    }
}
