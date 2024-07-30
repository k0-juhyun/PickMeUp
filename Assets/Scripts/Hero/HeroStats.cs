using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic; // List<>�� ����ϱ� ���� ���ӽ����̽� �߰�

public class HeroStats
{
    public string heroName;
    public int curLevel;

    [Tooltip("��, ��ø, ü��, ������ �⺻ ����")]
    public BaseStats baseStats;

    [Tooltip("�̵��ӵ�, ���ݼӵ�")]
    public SpeedStats speedStats;

    [Tooltip("��������, ��������")]
    public DefenseStats defenseStats;

    [Tooltip("Ư�� ����")]
    public SpecialStats specialStats;

    [Tooltip("����ġ")]
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
