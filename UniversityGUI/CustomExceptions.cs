using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityGUI
{
    class ReturningException: Exception
    {
        public ReturningException(string message): base(message)
        {

        }

        public ReturningException(string message, Exception inner): base(message, inner)
        {

        }
    }

    class WrongIDException: Exception
    {
        public int WrongID;
        public WrongIDException(string message, int wrongID): base(message)
        {
            WrongID = wrongID;
        }

        public WrongIDException(string message, int wrongID, Exception inner): base(message, inner)
        {
            WrongID = wrongID;
        }
    }
}
