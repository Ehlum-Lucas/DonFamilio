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
        nb = Random.Range(0, 2);
        if (nb == 1)
            car.transform.position = new Vector2(7.2f, -2.5f);
        else
            car.transform.position = new Vector2(7.2f, -1.4f);
    }

    void order()
    {
        if (car.transform.position.y == -2.5f)
            rend.sortingOrder = 2;
        else
            rend.sortingOrder = 0;
    }

    void Start()
    {
        init_car();
    }

    void Update()
    {
        if (car.transform.position.x > -7.30f)
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
