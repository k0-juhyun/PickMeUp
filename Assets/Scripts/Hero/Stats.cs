using UnityEngine;
using System;
using System.Collections.Generic;

[System.Serializable]
public class BaseStats
{
    [Header("��")]
    public int strength; // ��
    [Header("ü��")]
    public int health; // ü��
    [Header("����")]
    public int intellect; // ����
    [Header("��ø")]
    public int agility; // ��ø

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
    [Header("���� ����")]
    public int physicalDefense; // ��������
    [Header("���� ����")]
    public int magicalDefense; // ��������


    public DefenseStats(int physicalDefense, int magicalDefense)
    {
        this.physicalDefense = physicalDefense;
        this.magicalDefense = magicalDefense;
    }
}

[System.Serializable]
public class SpeedStats
{
    [Header("�̵��ӵ�")]
    public int moveSpeed; // �̵��ӵ�
    [Header("���ݼӵ�")]
    public int attackSpeed; // ���� �ӵ�

    public SpeedStats(int moveSpeed, int attackSpeed)
    {
        this.moveSpeed = moveSpeed;
        this.attackSpeed = attackSpeed;
    }
}


[System.Serializable]
public class SpecialStats
{
    [Header("�����")] public int potential; // �����
    [Header("����º��ʽ�")] public double potentialBonus; // ����º��ʽ�

    [Header("�»����")] public int oriRank; // �»����
    [Header("������")] public int curRank; // ������
    [Header("��޺��ʽ�")] public double rankBonus; // ��޺��ʽ�

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
        // 1.1�� rank ������ ����ϰ� �ݿø�
        double baseBonus = 1.1;
        double rankBonus = Math.Pow(baseBonus, rank);
        return Math.Round(rankBonus, 2); // �Ҽ��� 2�ڸ����� �ݿø�
    }
}

