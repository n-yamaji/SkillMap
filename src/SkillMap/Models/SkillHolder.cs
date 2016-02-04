using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillMap.Models
{
    public class SkillHolder
    {
        private int id;
        private string name;
        private SkillSet skillSet = new SkillSet();

        public SkillHolder(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public string GetName() { return this.name; }
        public void AddSkill(Skill skill, SkillLevel level) { this.skillSet.Add(skill, level); }
        public void RemoveSkill(Skill skill) { this.skillSet.Remove(skill); }
        public bool ContainsSkill(Skill skill) { return this.skillSet.Contains(skill); }
        public void UpSkillLevel(Skill skill) { this.skillSet.Remove(skill); }
        public void DownSkillLevel(Skill skill) { this.skillSet.Remove(skill); }
    }
}
