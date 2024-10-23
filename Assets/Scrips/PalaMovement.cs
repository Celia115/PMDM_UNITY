using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Los dos puntitios es la herencia
// MonoBehavior es el componente de Unity
public class PalaMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private float x, y;


    // Start es para inciar variables
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        //Para meterle velocidad ponemos
        // Vector2 es un onjeto
        // el eje x y el eje y son vectores
        // speed significa escalar
        rb.velocity = new Vector2(x, y) * speed;
    }
}
