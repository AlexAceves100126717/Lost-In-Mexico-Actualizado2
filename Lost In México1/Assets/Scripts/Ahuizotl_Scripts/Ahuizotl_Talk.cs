using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ahuizotl_Talk : MonoBehaviour
{
    //Para la foto a elegir
    public GameObject foto;

    // Start is called before the first frame update
    void Start()
    {
        //Foto desactivada para que no salga hasta que le digamos
        foto.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Cuando colisiona en trigger
    private void OnCollisionEnter2D(Collision2D collision)
    {

        //Si se choca con el tag se dira el texto ya aparecera la pieza
        if (collision.collider.tag == "Player")
        {
            //Lo que dira

            Debug.Log("Ahuizotl: Si quieres recuperar a los niños perdidos tendrás que superar la siguiente prueba");

            Debug.Log("Si fracasas me quedaré con tu alma");

            Debug.Log("Cuando estes listo toca mi pelaje");

            //Foto activa

            foto.SetActive(true);

        }

    }
}
