using UnityEngine;

[System.Serializable]
public class Skill
{
    [Header("스킬명")]
    public string skillName;
    [Header("데미지")]
    public int power;
    [Header("쿨타임")]
    public int coolTime;
    [Header("설명")]
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
        Debug.Log($"{skillName} 활성화!");
    }
}

public class ActiveSkill : Skill
{
    [Header("소모값")]
    public int cost;

    public ActiveSkill(string skillName, int power, int coolTime, string description, int cost)
        : base(skillName, power, coolTime, description)
    {
        this.cost = cost;
    }

    public override void ActivateSkill()
    {
        base.ActivateSkill();
        Debug.Log($"{cost} 를 사용하여 {skillName} 활성화");
    }
}

public class PassiveSkill : Skill
{
    public PassiveSkill(string skillName, int power, int coolTime, string description)
        : base(skillName, power, coolTime, description)
    {
    }
}
