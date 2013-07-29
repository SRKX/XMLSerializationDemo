using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLSerializationDemo.Instruments
{
    /// <summary>
    /// Represents a Stock
    /// </summary>
    public class Stock:Instrument
    {
        private string _name;

        public override string Name
        {
            get { return _name; }
        }
    }
}
