using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slice : MonoBehaviour
{
    public static Slice sliceAttack;

    public bool calledOn;
    private BoxCollider2D damageArea;
    public bool hitOnce = false;
    private float damage;



    private void Awake()
    {
        if (sliceAttack == null)
        {
            sliceAttack = this;
        }

    }
    private void GetArea()
    {
        damageArea = gameObject.GetComponent<BoxCollider2D>();
    }

    public void Deactivate()
    {
        damageArea.enabled = false;
        hitOnce = false;
    }


    public void Active(float currentDam)
    {
        GetArea();
        calledOn = true;
        damageArea.enabled = true;
        damage = currentDam;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy") && hitOnce == false)
        {
            hitOnce = true;
            other.GetComponent<EnemyHit>().TakeDamage(damage);
        }
    }



}
