using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beWeapon : MonoBehaviour
{
    public Camera camera;
    public Vector3 mousePos;
    public int whatWeaponAmI;
    public GameObject player;
   
    void Start()
    {
        player = GameObject.Find("player");
        transform.position = new Vector2(player.transform.position.x, player.transform.position.y);
        mousePos = camera.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotation = mousePos - transform.position;   
        whatWeaponAmI = player.GetComponent<weaponScript>().whatWeapon;

        if (whatWeaponAmI == 1) {}


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
