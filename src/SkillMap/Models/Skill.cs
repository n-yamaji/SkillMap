using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillMap.Models
{
    public class Skill
    {
        private string name;
        private string detail;

        public Skill(string name,string detail)
        {
            this.name = name;
            this.detail = detail;
        }
    }
}
