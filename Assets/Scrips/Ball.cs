using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //esta es la velocidad de la bola
    public float speed;

    private Rigidbody2D rb;
    //Para almacenar la direccion a la cual estamos llendo
    private Vector2 direction;
    private Vector2 initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        //Accede a la lista de componentes del objeto al cual este asignado y te devuelve el componente el que esta en "<>"
        rb = GetComponent<Rigidbody2D>();
        // Es lo mismo rb = gameObject.GetComponent<Rigidbody2D>();


        direction.x = Random.Range(-1, 2);

        do
        {

        //El random de enteros no incluye el ultimo numro es decir va del min al max odsea q el 2 no cuenta
        direction.x = Random.Range(-1, 2);

        } while(direction.x == 0);

        direction.y = Random.Range(-1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetPosition()
    {
        transform.position = initialPosition;
    }


    private void FixedUpdate()
    {
        rb.velocity = direction * speed;
    }


    //Para que revote la bola
    //El parametro de collision es el objeto con quien me he chocado
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Cada vez que ocurra una colision CON LA PALA, reboto
        //en el if vamos a preguntar que si es el jugador
        if (collision.gameObject.GetComponent<PalaMovement>())
        {
            direction.x *= -1;  // es lo mismo que direction.x = direction.x * -1;  es como una inversion 
            direction.y = Random.Range(-1, 2);
            initialPosition = transform.position;
        }
        else  //Cada vez que ocurra una colision con cualquier otra cosa, reboto
        {
            //solo hya techo o suelo
            direction.y *= -1;
        }
       
    }

}
