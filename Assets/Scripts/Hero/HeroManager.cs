using UnityEngine;
using System.Collections.Generic;

public class HeroManager : MonoBehaviour
{
    public HeroStats heroStats;

    private void Start()
    {
        List<Skill> exampleSkills = new List<Skill>
        {
            new ActiveSkill("Skill1", 10, 5, "Example Active Skill", 10),
            new PassiveSkill("Skill2", 15, 0, "Example Passive Skill")
        };

        // Job 객체를 생성합니다.
        Job exampleJob = new Job("Warrior", exampleSkills);

        heroStats = new HeroStats("HeroName", 1, new BaseStats(10, 20, 15, 12),
            new DefenseStats(5, 7), new SpeedStats(10, 8), new SpecialStats(3, 1, 1), exampleJob);

        heroStats.onLevelUp.AddListener(OnHeroLevelUp);
    }

    private void OnHeroLevelUp()
    {
        Debug.Log($"{heroStats.heroName} has leveled up to {heroStats.curLevel}!");
        heroStats.DisplayStats();
    }
}
