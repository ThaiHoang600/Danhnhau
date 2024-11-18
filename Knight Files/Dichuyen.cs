
using UnityEngine;

public class Dichuyen : MonoBehaviour
{
    public float tocdo;

    private Rigidbody2D rb;
    private Animator anim;
    private float traiphai ;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        transform.localScale = new Vector3(1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
       // traiphai = Input.GetAxisRaw("Horizontal");
       
       if(Input.GetKey(KeyCode.A))
        {
            traiphai = -1;
            transform.localScale = new Vector3(-1, 1, 1);
        }
       else if(Input.GetKey(KeyCode.D))
        {
            traiphai = 1;
            transform.localScale = new Vector3(1, 1, 1);
        }
        rb.velocity += new Vector2(traiphai * tocdo * Time.deltaTime, 0);
    }   
}

