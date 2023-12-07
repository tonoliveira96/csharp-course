using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExercicio.Entities
{
    internal class OutsourcedEmployee : Emploee
    {

        public double additionalCharg { get; set; }

        public OutsourcedEmployee() { }

        public OutsourcedEmployee(string name, int hours, double valuePerHour,double additionalCharg)
            : base(name, hours, valuePerHour)
        {
            this.additionalCharg = additionalCharg;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * additionalCharg;
        }
    }
}
