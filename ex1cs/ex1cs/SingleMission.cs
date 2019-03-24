using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        private object p;
        private string v;

        public SingleMission(object p, string v)
        {
            this.p = p;
            this.v = v;
        }

        string IMission.Name => throw new NotImplementedException();

        string IMission.Type => throw new NotImplementedException();

        event EventHandler<double> IMission.OnCalculate
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        internal double Calculate(double val)
        {
            throw new NotImplementedException();
        }

        double IMission.Calculate(double value)
        {
            throw new NotImplementedException();
        }
    }
}
