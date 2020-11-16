//Librerias
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class core_mariachi : MonoBehaviour
{
    //Se da una velocidad al personaje, pero esta es modificable
    public float speed = 2f;

    //Elegir jugador, a perseguir, rango, etc  visto en clase
    [SerializeField] Transform player;
    [SerializeField] float jrango;
    [SerializeField] float velmov;
    Rigidbody2D rigBD2D;

    // Start is called before the first frame update
    void Start()
    {
        rigBD2D = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        //Esto sirve ppara que el objeto no desaparezca aunque no este en camara, pero cuando este en camara visible o antes se moverá.
        //if (GetComponent<Renderer>().isVisible)
            //transform.Translate(-speed * Time.deltaTime, 0f, 0f);
        float jdistancia = Vector2.Distance(transform.position, player.position);
        if (jdistancia < jrango)
        {
            perseguir();
        }
        else
        {
            desistir();

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

        if (transform.position.x < player.position.x)
        {
          


            rigBD2D.velocity = new Vector2(velmov, 0);



            characterScale.x = 0.5f;

        }
        else if (transform.position.x > player.position.x)
        {
            //Cuando se acerca empieza a hacer la anim 


          

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

