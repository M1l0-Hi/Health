using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class HealthBar : MonoBehaviour
{
    public static HealthBar healthBar;


    public float maxium;
    public float current;
    public Image mask;

    public SkillListSO skillList;

    public TextMeshProUGUI hpText;
    private string start = "HP: ";


    private void Awake()
    {
        if (healthBar == null)
        {
            healthBar = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        GetCurrentFill();
    }

    public void GetCurrentFill()
    {
        float fillAmount = (float)current / (float)maxium;
        mask.fillAmount = fillAmount;
        hpText.text = "";
        hpText.text += start + current.ToString() + " / " + maxium.ToString();
    }

    public void getHP(float currentHP)
    {
        current = currentHP;
    }

    public void MaxHealthChange()
    {
        maxium = maxium + skillList.HealthPoints;
        PlayerHealth.playerHealth.UpdateHealth(maxium);
    }
}
