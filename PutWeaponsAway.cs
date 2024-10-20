using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutWeaponsAway : MonoBehaviour
{
    private Animator player;

    private void Start()
    {
        player = gameObject.GetComponent<Animator>();
    }
    private void WeaponAway()
    {
        

        player.SetBool("isStabbing", false);
        player.SetBool("isStriking", false);
    }
}
