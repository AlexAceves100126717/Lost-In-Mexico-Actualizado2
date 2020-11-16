using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Señora_tuto2 : MonoBehaviour
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

            Debug.Log("Tambien puedes saltar con espacio");



            //Memorama_0.gameObject.GetComponent<Renderer>().enabled;
            //Se pondra la pieza visible

            foto.SetActive(true);
            


        }

    }
}
