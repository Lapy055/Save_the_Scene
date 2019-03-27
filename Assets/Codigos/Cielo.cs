using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cielo : MonoBehaviour {
    
    private Rigidbody2D rb2d;
    private float Velocidad = -0.5f;

    public void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        if (transform.position.x <= -20f)
        {
            transform.position = new Vector3(20f, 4f, 0);
        }

        rb2d.velocity = new Vector2(Velocidad, 0f);
    }
}
