using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Señora_Pueblo_Ah : MonoBehaviour
{
 


    // Start is called before the first frame update
    void Start()
    {
    
       

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
            //Lo que dira
            Debug.Log("Señora: Espera! No lo sigas");

            Debug.Log("Deja te cuento un poco del Ahuizotl");

            Debug.Log("Es una leyenda que dicen que esta a merced de los dioses y secuestra para sus dioses y estos puedan comerlos..");

            Debug.Log("No se sabe cual es su presa ya que solo se escucha un llanto de bebe en los lagos pero nunca te acerques.");

            Debug.Log("Ahora ya sabiendo esto queda a tu juicio seguirlo o no..");

        }

    }
}
