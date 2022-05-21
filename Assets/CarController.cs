using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public GameObject player;
    public float speed = 1;
    public bool move = false;
    public int pos;

    void Update()
    {
        if (pos == 3)
            player.transform.position = new Vector2(0.01f, -2.7f);
        if (pos == 2)
            player.transform.position = new Vector2(0.01f, -1.6f);
        if (pos == 1)
            player.transform.position = new Vector2(0.01f, -0.5f);
        if (Input.GetButtonDown("Vertical") && Input.GetAxisRaw("Vertical") < 0 && player.transform.position.y == -0.5f) {
            for (float f = -0.5f; f > -1.6f; f -= 0.1f) {
                player.transform.position = new Vector2(0.01f, f);
            }
            pos = 2;
        }
        else if (Input.GetButtonDown("Vertical") && Input.GetAxisRaw("Vertical") < 0 && player.transform.position.y == -1.6f) {
            for (float f = -1.6f; f > -2.7f; f -= 0.1f) {
                player.transform.position = new Vector2(0.01f, f);
            }
            pos = 3;
        }
        else if (Input.GetButtonDown("Vertical") && Input.GetAxisRaw("Vertical") > 0 && player.transform.position.y == -1.6f) {
            for (float f = -1.6f; f < -0.5f; f += 0.1f) {
                player.transform.position = new Vector2(0.01f, f);
            }
            pos = 1;
        }
        else if (Input.GetButtonDown("Vertical") && Input.GetAxisRaw("Vertical") > 0 && player.transform.position.y == -2.7f) {
            for (float f = -2.7f; f < -1.6f; f += .1f) {
                player.transform.position = new Vector2(0.01f, f);
            }
            pos = 2;
        }
    }
}
// < 0 = flech du bas hihi