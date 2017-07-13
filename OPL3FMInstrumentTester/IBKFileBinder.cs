using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPL3FMInstrumentTester
{
    class IBKFileBinder
    {
        private IBKHeader ibkHeader;

        public IBKFileBinder(IBKHeader header)
        {
            this.ibkHeader = header;
        }

        public IList InstrumentNames
        {
            get {
                var bindableNames = from name in ibkHeader.InstrumentNames select new { Names = name };
                return bindableNames.ToList();
            }
        }
    }
}
