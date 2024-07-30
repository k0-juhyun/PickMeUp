using UnityEngine;

[System.Serializable]
public class Skill
{
    [Header("��ų��")]
    public string skillName;
    [Header("������")]
    public int power;
    [Header("��Ÿ��")]
    public int coolTime;
    [Header("����")]
    public string description;

    public Skill(string skillName, int power, int coolTime, string description)
    {
        this.skillName = skillName;
        this.power = power;
        this.coolTime = coolTime;
        this.description = description;
    }

    public virtual void ActivateSkill()
    {
        Debug.Log($"{skillName} Ȱ��ȭ!");
    }
}

public class ActiveSkill : Skill
{
    [Header("�Ҹ�")]
    public int cost;

    public ActiveSkill(string skillName, int power, int coolTime, string description, int cost)
        : base(skillName, power, coolTime, description)
    {
        this.cost = cost;
    }

    public override void ActivateSkill()
    {
        base.ActivateSkill();
        Debug.Log($"{cost} �� ����Ͽ� {skillName} Ȱ��ȭ");
    }
}

public class PassiveSkill : Skill
{
    public PassiveSkill(string skillName, int power, int coolTime, string description)
        : base(skillName, power, coolTime, description)
    {
    }
}
