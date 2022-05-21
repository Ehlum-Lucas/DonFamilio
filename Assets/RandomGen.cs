using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomGen : MonoBehaviour
{
    public GameObject car;
    private int nb = 0;
    public float speed = 0.1f;
    public SpriteRenderer rend;

    void init_car()
    {
        nb = Random.Range(0, 3);
        if (nb == 0)
            car.transform.position = new Vector2(11, -2.7f);
        else if (nb == 1)
            car.transform.position = new Vector2(11, -1.6f);
        else
            car.transform.position = new Vector2(11, -0.5f);
    }

    void order()
    {
        if (car.transform.position.y == -1.6f || car.transform.position.y == -0.5f)
            rend.sortingOrder = 2;
        else
            rend.sortingOrder = 2;
    }

    void Start()
    {
        init_car();
    }

    void Update()
    {
        if (car.transform.position.x > -10)
            car.transform.position = car.transform.position + new Vector3(-speed, 0, 0);
        else
            init_car();
        order();
    }

    void OnTriggerEnter2D()
    {
        Debug.Log ("AHAHAHA trop nul le type");
        init_car();
    }

}
