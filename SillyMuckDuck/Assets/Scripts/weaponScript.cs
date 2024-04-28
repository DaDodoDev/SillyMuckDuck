using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponScript : MonoBehaviour
{
    public int whatWeapon;
    public float timeBTWAttacks;
    public float timeBTWAttacksNow;
    public float timeBTWSecondsAttacks;
    public float timeBTWSecondsAttacksNow;


    public GameObject sword;
    public void ChangeWeapon()
    {if(whatWeapon == 1) { timeBTWAttacks = 1f;  timeBTWSecondsAttacks = 2f; }
        
    }



    void Start()
    {
        timeBTWAttacksNow = timeBTWAttacks;
        timeBTWSecondsAttacksNow = timeBTWSecondsAttacks;
    }
    // Update is called once per frame
    void Update()
    {
        timeBTWAttacksNow -= Time.deltaTime;
        timeBTWSecondsAttacksNow -= Time.deltaTime;

        if (Input.GetMouseButtonDown(0) && timeBTWAttacksNow < 0) { firstAttack(); }
    }

    void firstAttack()
    {if(whatWeapon == 1) { Instantiate(sword,transform.position, transform.rotation); }
        Debug.Log("and");
    }

    
}
