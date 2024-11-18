using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinaorong : MonoBehaviour
{
    public float tocdo;

    private Rigidbody2D rbd;
    private Animator ani;
    private float hgtraiphai;

    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        transform.localScale = new Vector3(1, 1, 1);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            hgtraiphai = -1;
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            hgtraiphai = 1;
            transform.localScale = new Vector3(1, 1, 1);
        }
        rbd.velocity += new Vector2(hgtraiphai * tocdo * Time.deltaTime, 0);
    }
}
