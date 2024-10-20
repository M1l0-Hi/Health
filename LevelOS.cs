using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class LevelOS : ScriptableObject
{
    [SerializeField]
    public int level;
    public int levelOn;
    public int skillPoints;

    public int PlayerLevel
    {
        get { return level; }
        set { level = value; }
    }


    public int MapLevel
    {
        get { return levelOn; }
        set { levelOn = value; }
    }

    public int PointsAvailable
    {
        get { return skillPoints; }
        set { skillPoints = value; }
    }
}
