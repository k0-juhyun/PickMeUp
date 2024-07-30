using System.Collections.Generic;

public class Job
{
    public string jobName;
    public List<Skill> skills;

    public Job(string jobName, List<Skill> skills)
    {
        this.jobName = jobName;
        this.skills = skills;
    }
}

public class Warrior : Job
{
    public Warrior() : base("Warrior", new List<Skill>
    {
        new ActiveSkill("Slash", 50, 10, "A powerful sword attack.", 10),
        new PassiveSkill("Warrior's Spirit", 0, 0, "Increases attack power.")
    })
    {
    }
}

public class Mage : Job
{
    public Mage() : base("Mage", new List<Skill>
    {
        new ActiveSkill("Fireball", 70, 20, "Throws a fireball at the enemy.", 20),
        new PassiveSkill("Mana Shield", 0, 0, "Increases defense using mana.")
    })
    {
    }
}
