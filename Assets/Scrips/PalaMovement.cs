using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Los dos puntitios es la herencia
// MonoBehavior es el componente de Unity
public class PalaMovement : MonoBehaviour
{
    public bool palaIzquierda;
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
        if(palaIzquierda)
        {
            y = Input.GetAxisRaw("Vertical2");
        }
        else
        {
            y = Input.GetAxisRaw("Vertical1");
        }
       
        transform.Translate(new Vector2 (0, y) * speed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        //Para meterle velocidad ponemos
        // Vector2 es un onjeto
        // el eje x y el eje y son vectores
        // speed significa escalar
        rb.velocity = new Vector2(0, y) * speed;
    }
}
