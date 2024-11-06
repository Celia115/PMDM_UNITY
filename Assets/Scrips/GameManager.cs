using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int[] puntuacion;
    //Singletone -> es una variable accesible y unica en toda la app

    //una variable estatica es que solo existe una copia no puede a ver mas 
    public static GameManager instance;


    //Es para incializar las cosas antes 


    void Awake()
    {
     if(!instance)
        {
            //establecemos el nuevo GameManager
            //this se refiere al new GameManager en el que nos encontramos
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
     else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        //asi se inicializa un array
        puntuacion = new int[2];
    }

    public int GetIndexpuntuacion(int index)
    {
        //aqui es para que nos de la puntuacion del jugador1 y jugador2
        return puntuacion[index]; 
    }

    public void SetIndexPuntuacion(int index, int nValue)
    {
        puntuacion[index] = nValue;
    }

    public void ChangeScene(string sceneName)
    {
       SceneManager.LoadScene(sceneName);
    }

}
