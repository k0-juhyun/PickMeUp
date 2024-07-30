using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic; // List<>를 사용하기 위한 네임스페이스 추가

public class HeroStats
{
    public string heroName;
    public int curLevel;

    [Tooltip("힘, 민첩, 체력, 지능의 기본 스텟")]
    public BaseStats baseStats;

    [Tooltip("이동속도, 공격속도")]
    public SpeedStats speedStats;

    [Tooltip("물리방어력, 마법방어력")]
    public DefenseStats defenseStats;

    [Tooltip("특수 스탯")]
    public SpecialStats specialStats;

    [Tooltip("경험치")]
    public Experience experience;

    public Job job;
    public List<Skill> skillList;

    public UnityEvent onLevelUp;

    public int availableStatPoints;
    private bool isUsingSkill = false;

    public HeroStats(string heroName, int curLevel, BaseStats baseStats,
        DefenseStats defenseStats, SpeedStats speedStats, SpecialStats specialStats, Job job)
    {
        this.heroName = heroName;
        this.curLevel = curLevel;
        this.baseStats = baseStats;
        this.speedStats = speedStats;
        this.defenseStats = defenseStats;
        this.specialStats = specialStats;
        this.experience = new Experience(curLevel);
        this.availableStatPoints = 0;
        this.onLevelUp = new UnityEvent();
    }

    public void DisplayStats()
    {
        Debug.Log($"Hero: {heroName}, Level: {curLevel}, Strength: {baseStats.strength}, Health: {baseStats.health}, Intellect: {baseStats.intellect}, Agility: {baseStats.agility}");
        Debug.Log($"Move Speed: {speedStats.moveSpeed}, Attack Speed: {speedStats.attackSpeed}");
        Debug.Log($"Physical Defense: {defenseStats.physicalDefense}, Magical Defense: {defenseStats.magicalDefense}");
        Debug.Log($"Potential: {specialStats.potential}, Potential Bonus: {specialStats.potentialBonus}, Ori Rank: {specialStats.oriRank}, Cur Rank: {specialStats.curRank}, Rank Bonus: {specialStats.rankBonus}");
        Debug.Log($"Exp: {experience.currentExp}/{experience.expToNextLevel}, Available Stat Points: {availableStatPoints}");
    }
}
