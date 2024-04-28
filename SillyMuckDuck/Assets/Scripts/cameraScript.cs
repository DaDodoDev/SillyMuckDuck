using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{
    public GameObject and;
    public Vector2 andPos;

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        andPos = new Vector2(and.transform.position.x + and.GetComponent<And>().speedNow * 0.2f, and.transform.position.y);
        transform.position = Vector2.Lerp(transform.position, andPos, 0.1f);
        transform.position = new Vector3(transform.position.x, transform.position.y, -10);
    }
}
