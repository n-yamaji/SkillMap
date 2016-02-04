using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillMap.Models
{
    public class SkillSet
    {
        private Dictionary<Skill, SkillLevel> map = new Dictionary<Skill, SkillLevel>();
        public SkillSet()
        {

        }

        public void Add(Skill skill, SkillLevel level) { this.map.Add(skill, level); }
        public void Remove(Skill skill) { this.map.Remove(skill); }
        public bool Contains(Skill skill) { return this.map.ContainsKey(skill); }

        public void UpLevel(Skill skill)
        {
            var level = this.map[skill];
            this.map[skill] = level.Up();
        }

        public void DownLevel(Skill skill)
        {
            var level = this.map[skill];
            this.map[skill] = level.Down();
        }
    }
}
