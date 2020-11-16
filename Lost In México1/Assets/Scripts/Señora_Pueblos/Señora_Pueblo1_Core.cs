using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Señora_Pueblo1_Core : MonoBehaviour
{
    //Poner jugador
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //Buscar jugador
        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    //Colision pero de trigger
    private void OnTriggerEnter2D(Collider2D collider)
    {
        //Si se colisiona con el tag
        if (collider.tag == "Player")
        {
     //Lo que dira
            Debug.Log("Hola");
            Debug.Log("Me Ayudas?");

            Debug.Log("La Llorona robo a mi hija y no lo encuentro");
            Debug.Log("Es de noche asi que no encontrarás más gentes pero agarra todas las pistas y no dejes que la llorona se escape");

        }

    }
}
