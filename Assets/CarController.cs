using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public GameObject player;
    public float speed = 1;
    public bool move;

    void Update()
    {
        //if (Input.GetButtonDown("Vertical") && Input.GetAxisRaw("Vertical") > 0)
        //    player.transform.position.x += 0.1f;
        //if (Input.GetButtonDown("Vertical") && Input.GetAxisRaw("Vertical") > 0)
        //    player.transform.position = new Vector2(0.01f, -1.6f);
        //else if (Input.GetButtonDown("Vertical") && Input.GetAxisRaw("Vertical") < 0)
        //    player.transform.position = new Vector2(0.01f, -2.7f);
        
    }
}