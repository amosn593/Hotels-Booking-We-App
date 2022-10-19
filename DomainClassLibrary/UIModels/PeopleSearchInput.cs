using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClassLibrary.UIModels
{
    public class PeopleSearchInput
    {
        public int Adult { get; set; } = 1;

        public int Children { get; set; } = 0;

        public int Room { get; set; } = 1;
    }
}
