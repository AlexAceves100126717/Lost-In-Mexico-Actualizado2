using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Señora_Tuto : MonoBehaviour
{
    //Reconcocera al personaje en trigger
    public GameObject player;

    //Para la foto a elegir
    public GameObject foto;

    //Para la foto a elegir
    public GameObject foto2;
    // Start is called before the first frame update
    void Start()
    {
        //busca al jugador que se puso con el tag 
        player = GameObject.FindGameObjectWithTag("Player");
        //Desaparece la pieza
        foto.SetActive(true);
        foto2.SetActive(false);

        Debug.Log("Hola Bienvenido!");

        Debug.Log("Camina hacia mí con las flechas");

    }

    // Update is called once per frame
    void Update()
    {
     
    }
    //Para l acolision de trigger
    private void OnTriggerEnter2D(Collider2D collider)
    {

        //Si se choca con el tag se dira el texto ya aparecera la pieza
        if (collider.tag == "Player")
        {

            Debug.Log("Tambien te puedes mover con w a s d");
            


            //Memorama_0.gameObject.GetComponent<Renderer>().enabled;
            //Se pondra la pieza visible

            foto.SetActive(true);
            foto2.SetActive(true);


        }

    }
}
