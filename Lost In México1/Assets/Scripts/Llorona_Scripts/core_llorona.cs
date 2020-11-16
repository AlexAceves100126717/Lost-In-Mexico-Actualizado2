//Librerias
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class core_llorona : MonoBehaviour
{
    //Se da una velocidad al personaje, pero esta es modificable

    //Elegir jugador, a perseguir, rango, etc  visto en clase
    [SerializeField] Transform player;
    [SerializeField] float jrango;
    [SerializeField] float velmov;
    Rigidbody2D rigBD2D;

    private Animator anima;
    // Start is called before the first frame update
    void Start()
    {
        anima = GetComponent<Animator>();

        rigBD2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float jdistancia = Vector2.Distance(transform.position, player.position);
        if (jdistancia < jrango)
        {
            perseguir();
            anima.SetBool("Llorona", true);
            anima.SetBool("Llorona_iddle", false);
        }
        else
        {
            desistir();
            anima.SetBool("Llorona", false);
            anima.SetBool("Llorona_iddle", true);
        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            //Esto sirve ppara que el objeto no desaparezca aunque no este en camara, pero cuando este en camara visible o antes se moverá.
            
        }
    }

    void perseguir()
    {
        Vector3 characterScale = transform.localScale;

        if (transform.position.x > player.position.x)
        {
            anima.SetBool("Llorona", true);
            anima.SetBool("Llorona_iddle", false);


            rigBD2D.velocity = new Vector2(velmov, 0);



            characterScale.x = 0.5f;

        }
        else if (transform.position.x < player.position.x)
        {
            //Cuando se acerca empieza a hacer la anim 


            anima.SetBool("Llorona", false);
            anima.SetBool("Llorona_iddle", true);

            rigBD2D.velocity = new Vector2(-velmov, 0);
            characterScale.x = -0.5f;

        }
        transform.localScale = characterScale;
    }

    void desistir()
    {
        rigBD2D.velocity = new Vector2(0, 0);
    }
}
