using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public GameObject player;
    public float speed = 1;
    public bool move = false;

    void Update()
    {
        //if (Input.GetButtonDown("Vertical") && Input.GetAxisRaw("Vertical") > 0)
        //    move = true;
        if (Input.GetButtonDown("Vertical") && Input.GetAxisRaw("Vertical") > 0)
            player.transform.position = new Vector2(-6.8f, -1.4f);
        else if (Input.GetButtonDown("Vertical") && Input.GetAxisRaw("Vertical") < 0)
            player.transform.position = new Vector2(-6.8f, -2.6f);
        //while (move == true)
        //    player.transform.position = player.transform.position + new Vector3(0.1f, 0, 0);
    }
}