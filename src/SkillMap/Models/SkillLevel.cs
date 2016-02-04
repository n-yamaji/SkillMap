using System;

namespace SkillMap.Models
{
    public class SkillLevel
    {
        public enum Step
        {
            nothing = 0,
            beginner = 1,
            elementary = 2,
            intermediate = 3,
            advanced = 4,
            professional = 5
        }

        private Step level = Step.nothing;

        public SkillLevel(Step level) { this.level = level; }
        public SkillLevel() : this(Step.nothing) {  }

        public SkillLevel Up()
        {
            switch (this.level)
            {
                case Step.nothing:
                    return new SkillLevel(Step.beginner);
                case Step.beginner:
                    return new SkillLevel(Step.elementary);
                case Step.elementary:
                    return new SkillLevel(Step.intermediate);
                case Step.intermediate:
                    return new SkillLevel(Step.advanced);
                case Step.advanced:
                    return new SkillLevel(Step.professional);
                case Step.professional:
                    throw new Exception("これ以上のレベルは指定できません。");
                default:
                    throw new Exception("レベルが設定できません。");
            }
        }

        public SkillLevel Down()
        {
            switch (this.level)
            {
                case Step.nothing:
                case Step.beginner:
                    throw new Exception("これ以下のレベルは指定できません。");
                case Step.elementary:
                    return new SkillLevel(Step.beginner);
                case Step.intermediate:
                    return new SkillLevel(Step.elementary);
                case Step.advanced:
                    return new SkillLevel(Step.intermediate);
                case Step.professional:
                    return new SkillLevel(Step.advanced);
                default:
                    throw new Exception("レベルが設定できません。");
            }
        }
    }
}
