using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrabbleMaker
{
    class InvalidSettingsException : Exception
    {

        public InvalidSettingsException()
        {
        }

        public InvalidSettingsException(string message) : base(message)
        {
        }

    }
}
