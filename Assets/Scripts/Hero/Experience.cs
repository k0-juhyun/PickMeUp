using UnityEngine;

[System.Serializable]
public class Experience
{
    public int currentExp;
    public int expToNextLevel;

    public Experience(int level)
    {
        this.currentExp = 0;
        this.expToNextLevel = CalculateExpToNextLevel(level);
    }

    private int CalculateExpToNextLevel(int level)
    {
        return level * 100;
    }
}