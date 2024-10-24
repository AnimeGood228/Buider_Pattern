using Buider_Pattern.Сomponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buider_Pattern
{
    public class Computer
    {
        public CPU Cpu { get; private set; }
        public Motherboard Motherboard { get; private set; }
        public RAM Ram { get; private set; }
        public Storage Storage { get; private set; }
        public GPU Gpu { get; private set; }

        public Computer(CPU cpu, Motherboard motherboard, RAM ram, Storage storage, GPU gpu)
        {
            Cpu = cpu;
            Motherboard = motherboard;
            Ram = ram;
            Storage = storage;
            Gpu = gpu;
        }

        public override string ToString()
        {
            return $"Computer Configuration:\n" +
                   $"CPU: {Cpu.Model} ({Cpu.Cores} cores)\n" +
                   $"Motherboard: {Motherboard.Model} ({Motherboard.FormFactor})\n" +
                   $"RAM: {Ram.Model} ({Ram.SizeGB} GB)\n" +
                   $"Storage: {Storage.Type} ({Storage.SizeGB} GB)\n" +
                   $"GPU: {Gpu.Model} ({Gpu.VRAM} GB)";
        }
    }
}
