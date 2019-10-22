namespace DesignPatterns.CreationalPattern.Prototype
{
    public class Monster
    {
        public int Id { get; set; }

        public int Level { get; set; }

        public MonsterType MonsterType { get; set; }


        public Monster(int id, int level, string monsterType)
        {
            Id = id;
            Level = level;
            MonsterType = new MonsterType(monsterType);
        }

        public Monster ShallowCopy() => (Monster) MemberwiseClone();

        public Monster DeepCopy()
        {
            var deepCopy = (Monster) MemberwiseClone();
            deepCopy.MonsterType = new MonsterType(MonsterType.TypeName);
            return deepCopy;
        }

        public override string ToString() => 
            $"I'm monster with Id: {Id}. My level: {Level}. My type: {MonsterType.TypeName}.";
    }
}
