using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Tema1
{
    class Equation
    {
        private int memory = 0;
        private string expression;

        public int GetMemory()
        {
            return this.memory;
        }

        public string GetExpression()
        {
            return this.expression;
        }

        public Equation()
        {

        }

        public bool IncrementMemory(string input)
        {
            if (input.Length > 0 && !input.Equals("ERROR"))
            {
                this.memory += Int32.Parse(input);
                return true;
            }

            return false;
        }

        public void ResetMemory()
        {
            this.memory = 0;
        }

        public string GetMemoryToString()
        {
            if (this.memory == 0)
            {
                return "   (MR= 0 )";
            }

            return "   (MR= " + this.memory.ToString() + " )";
        }

        public void CalculateExpression(string inputExpression)
        {
            expression = Utils.PolishFormCalculate(inputExpression);
        }
    }
}
