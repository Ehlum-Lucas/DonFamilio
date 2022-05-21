using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bkg_parallax : MonoBehaviour
{
    [Range(-10f, 10f)]
    public float speed = 10f;
    private float length, startpos, offset;
    public GameObject cam;
    public float parallaxEffect;

    void Start()
    {
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x * 2;
    }

    void FixedUpdate()
    {
        float temp = (cam.transform.position.x * (1 - parallaxEffect));
        float dist = (cam.transform.position.x * parallaxEffect);
        transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);
        if (temp > startpos + length) startpos += length;
        else if (temp < startpos - length) startpos -= length;

        startpos -= (Time.deltaTime * speed) / 2f;
    }
}
