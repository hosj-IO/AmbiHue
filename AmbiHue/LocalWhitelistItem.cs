using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbiHue.Classes
{
    public class LocalWhitelistItem
    {
        public string ApplicationID { get; set; }

        public string UniqueID { get; set; }

        public DateTime LastUsed { get; set; }

        public DateTime Created { get; set; }

        public LocalWhitelistItem()
        {

        }

        public override string ToString()
        {
            return ApplicationID;
        }
    }
}
