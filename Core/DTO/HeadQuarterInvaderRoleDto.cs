using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO
{
    public class HeadQuarterInvaderRoleDto
    {
        public Role Role { get; set; }
        public HeadQuarter HeadQuarter { get; set; }
        public Invader Invader { get; set; }
        public Hero Hero { get; set; }
    }
}
