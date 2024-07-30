using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HeroAI : MonoBehaviour
{
    public HeroStats heroStats;

    private void Start()
    {
        // Job ��ü ����
        Job warriorJob = new Warrior();

        // HeroStats ��ü �ʱ�ȭ
        heroStats = new HeroStats("HeroName", 1, new BaseStats(10, 20, 15, 12),
            new DefenseStats(5, 7), new SpeedStats(10, 8), new SpecialStats(3, 1, 1), warriorJob);

        // ������ �̺�Ʈ ���
        heroStats.onLevelUp.AddListener(OnHeroLevelUp);

        // �ʱ� ���� ���
        heroStats.DisplayStats();
    }

    private void Update()
    {
        // �׽�Ʈ�� ���� Ű �Է��� ����Ͽ� ������ ����
        if (Input.GetKeyDown(KeyCode.K))
        {
            heroStats.specialStats.curRank = 2;
            heroStats.specialStats.UpdateRankBonus();
            heroStats.DisplayStats();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            heroStats.specialStats.potential = 5;
            heroStats.specialStats.UpdatePotentialBonus();
            heroStats.DisplayStats();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            heroStats.DisplayStats();
        }
    }

    private void OnHeroLevelUp()
    {
        Debug.Log($"{heroStats.heroName} has leveled up to {heroStats.curLevel}!");
        heroStats.DisplayStats();
    }
}
