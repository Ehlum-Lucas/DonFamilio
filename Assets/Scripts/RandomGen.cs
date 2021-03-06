using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RandomGen : MonoBehaviour
{
    public Sprite[] sprite;
    public GameObject car;
    private ScoreManager score;
    private int nb = 0;
    public float speed = 0.1f;
    public SpriteRenderer rend;

    private Sprite Get_Random_Sprite()
    {
        return sprite[Random.Range(0, 10)];
    }

    void init_car()
    {
        car.gameObject.GetComponent<SpriteRenderer>().sprite = Get_Random_Sprite();
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
        if (car.transform.position.y == -2.7f)
            rend.sortingOrder = 7;
        else if (car.transform.position.y == -1.6f)
            rend.sortingOrder = 4;
        else
            rend.sortingOrder = 1;
    }

    void Start()
    {
        init_car();
        score = FindObjectOfType<ScoreManager>();
    }

    void Update()
    {
        if (car.transform.position.x > -10)
            if (speed < 0.5f)
                car.transform.position = car.transform.position + new Vector3(-speed, 0, 0);
            else
                car.transform.position = car.transform.position + new Vector3(-0.5f, 0, 0);
        else
            init_car();
        order();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("player")) {
            Debug.Log ("AHAHAHA trop nul le type");
            SceneManager.LoadScene("EndScene");
        }
        init_car();
    }
}
