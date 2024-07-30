using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HeroAI : MonoBehaviour
{
    public HeroStats heroStats;

    private void Start()
    {
        // Job 객체 생성
        Job warriorJob = new Warrior();

        // HeroStats 객체 초기화
        heroStats = new HeroStats("HeroName", 1, new BaseStats(10, 20, 15, 12),
            new DefenseStats(5, 7), new SpeedStats(10, 8), new SpecialStats(3, 1, 1), warriorJob);

        // 레벨업 이벤트 등록
        heroStats.onLevelUp.AddListener(OnHeroLevelUp);

        // 초기 스탯 출력
        heroStats.DisplayStats();
    }

    private void Update()
    {
        // 테스트를 위해 키 입력을 사용하여 스탯을 변경
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
