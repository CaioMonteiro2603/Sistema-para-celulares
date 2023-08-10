using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemofSmart
{
    internal class Smartphone
    {
        protected string Name;
        protected string Model;
        protected decimal Memory;

        public Smartphone(string name, string model, decimal memory)
        {
            this.Name = name;
            this.Model = model;
            this.Memory = memory;
        } 

        public void setName(string Newname)
        {
            this.Name = Newname;
        }
        public string getName() 
        {
            return this.Name; 
        }
        public void setModel(string Newmodel)
        {
            this.Model = Newmodel;
        }
        public string getModel()
        {
            return this.Model;
        }
        public void setMemory(decimal Memory)
        {
            this.Memory = Memory;
        }
        public decimal getMemory()
        {
            return this.Memory;
        }

        public void MakeCall()
        {
            Console.WriteLine("Calling!");
        }
        public void ReceiveCall()
        {
            Console.WriteLine("Receiving!");
        }

        public virtual void Apresentation()
        {
            Console.WriteLine();
        }
    }
}
