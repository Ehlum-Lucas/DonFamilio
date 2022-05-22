using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Family : MonoBehaviour
{
    public GameObject family;
    private ScoreManager score;
    private RandomGen enemy;
    private int nb = 0;
    public float speed = 0.07f;
    public float acceleration = 0;
    public float PtsPerSecond = 5;
    public SpriteRenderer rend;

    void init_family()
    {
        nb = Random.Range(0, 3);
        if (nb == 0)
            family.transform.position = new Vector2(11, -3.4f);
        else if (nb == 1)
            family.transform.position = new Vector2(11, -2.5f);
        else
            family.transform.position = new Vector2(11, -1.5f);
    }

    void order()
    {
        if (family.transform.position.y == -3.4f)
            rend.sortingOrder = 3;
        else
            rend.sortingOrder = 0;
    }

    void Start()
    {
        init_family();
        score = FindObjectOfType<ScoreManager>();
        enemy = FindObjectOfType<RandomGen>();
    }

    void Update()
    {
        if (acceleration < 200) {
            acceleration += PtsPerSecond * Time.deltaTime;
        }
        else {
            acceleration = 0;
            speed *= 1.4f;
        }
        if (family.transform.position.x > -11)
            family.transform.position = family.transform.position + new Vector3(-speed, 0, 0);
        else
            init_family();
        order();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Enemy")) {
            // Debug.Log("Ouïe");
        }
        if (collider.CompareTag("player")) {
            // Debug.Log ("Let's gooooo");
            score.Score += 50;
            score.Speed += 50;
            acceleration += 50;
        }
        init_family();
    }

}
