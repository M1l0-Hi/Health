using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skills : MonoBehaviour
{
    public LevelOS level;
    public SkillListSO skillList;
    public string whichSkill;

    public void AddPoint()
    {
        if(level.skillPoints > 0)
        {
            level.skillPoints -= 1;
            if (whichSkill == "attack")
            {
                skillList.AttackSkill += 1;
            }
            else if (whichSkill == "defense")
            {
                skillList.DefenseSkill += 1;
            }
            else if (whichSkill == "health")
            {
                skillList.HealthPoints += 1;
                HealthBar.healthBar.MaxHealthChange();
            }
        }
        
        

    }
}
