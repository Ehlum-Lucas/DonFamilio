using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public GameObject player;
    public float speed = 1;
    public bool move = false;
    public int pos;
    public SpriteRenderer rend;

    void Start()
    {
        player.transform.position = new Vector2(-6, -2.7f);
    }

    void order()
    {
        if (player.transform.position.y == -2.7f)
            rend.sortingOrder = 6;
        else if (player.transform.position.y == -1.6f)
            rend.sortingOrder = 3;
        else
            rend.sortingOrder = 0;
    }

    void Update()
    {
        if (pos == 3)
            player.transform.position = new Vector2(-6, -2.7f);
        if (pos == 2)
            player.transform.position = new Vector2(-6, -1.6f);
        if (pos == 1)
            player.transform.position = new Vector2(-6, -0.5f);
        if (Input.GetButtonDown("Vertical") && Input.GetAxisRaw("Vertical") < 0 && player.transform.position.y == -0.5f) {
            for (float f = -0.5f; f > -1.6f; f -= 0.1f) {
                player.transform.position = new Vector2(-6, f);
            }
            pos = 2;
        }
        else if (Input.GetButtonDown("Vertical") && Input.GetAxisRaw("Vertical") < 0 && player.transform.position.y == -1.6f) {
            for (float f = -1.6f; f > -2.7f; f -= 0.1f) {
                player.transform.position = new Vector2(-6, f);
            }
            pos = 3;
        }
        else if (Input.GetButtonDown("Vertical") && Input.GetAxisRaw("Vertical") > 0 && player.transform.position.y == -1.6f) {
            for (float f = -1.6f; f < -0.5f; f += 0.1f) {
                player.transform.position = new Vector2(-6, f);
            }
            pos = 1;
        }
        else if (Input.GetButtonDown("Vertical") && Input.GetAxisRaw("Vertical") > 0 && player.transform.position.y == -2.7f) {
            for (float f = -2.7f; f < -1.6f; f += .1f) {
                player.transform.position = new Vector2(-6, f);
            }
            pos = 2;
        }
        order();
    }
}
// < 0 = flech du bas hihi