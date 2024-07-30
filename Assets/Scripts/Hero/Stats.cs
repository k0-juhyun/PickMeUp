using UnityEngine;
using System;
using System.Collections.Generic;

[System.Serializable]
public class BaseStats
{
    [Header("힘")]
    public int strength; // 힘
    [Header("체력")]
    public int health; // 체력
    [Header("지능")]
    public int intellect; // 지능
    [Header("민첩")]
    public int agility; // 민첩

    public BaseStats(int strength, int health, int intellect, int agility)
    {
        this.strength = strength;
        this.health = health;
        this.intellect = intellect;
        this.agility = agility;
    }
}

[System.Serializable]
public class DefenseStats
{
    [Header("물리 방어력")]
    public int physicalDefense; // 물리방어력
    [Header("마법 방어력")]
    public int magicalDefense; // 마법방어력


    public DefenseStats(int physicalDefense, int magicalDefense)
    {
        this.physicalDefense = physicalDefense;
        this.magicalDefense = magicalDefense;
    }
}

[System.Serializable]
public class SpeedStats
{
    [Header("이동속도")]
    public int moveSpeed; // 이동속도
    [Header("공격속도")]
    public int attackSpeed; // 공격 속도

    public SpeedStats(int moveSpeed, int attackSpeed)
    {
        this.moveSpeed = moveSpeed;
        this.attackSpeed = attackSpeed;
    }
}


[System.Serializable]
public class SpecialStats
{
    [Header("잠재력")] public int potential; // 잠재력
    [Header("잠재력보너스")] public double potentialBonus; // 잠재력보너스

    [Header("태생등급")] public int oriRank; // 태생등급
    [Header("현재등급")] public int curRank; // 현재등급
    [Header("등급보너스")] public double rankBonus; // 등급보너스

    public SpecialStats(int potential, int oriRank, int curRank)
    {
        this.potential = potential;
        this.potentialBonus = potential * 0.7;
        this.oriRank = oriRank;
        this.curRank = curRank;
        this.rankBonus = CalculateRankBonus(curRank);
    }

    public void UpdatePotentialBonus()
    {
        this.potentialBonus = potential * 0.7;
    }

    public void UpdateRankBonus()
    {
        this.rankBonus = CalculateRankBonus(curRank);
    }

    private double CalculateRankBonus(int rank)
    {
        // 1.1의 rank 제곱을 계산하고 반올림
        double baseBonus = 1.1;
        double rankBonus = Math.Pow(baseBonus, rank);
        return Math.Round(rankBonus, 2); // 소수점 2자리까지 반올림
    }
}

