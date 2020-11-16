using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Señora_tuto3 : MonoBehaviour
{
    //Reconcocera al personaje en trigger
    public GameObject player;

    //Para la foto a elegir
    public GameObject foto;


    // Start is called before the first frame update
    void Start()
    {
        //busca al jugador que se puso con el tag 
        player = GameObject.FindGameObjectWithTag("Player");
        //Desaparece la pieza
        foto.SetActive(false);




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

            Debug.Log("Trata de interactuar con nosotros para conocer mas acerca de las leyendas de México..");

            Debug.Log("Cuando estes listo toca la llorona para empezar");


            //Memorama_0.gameObject.GetComponent<Renderer>().enabled;
            //Se pondra la pieza visible

            foto.SetActive(true);



        }

    }
}
