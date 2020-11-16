using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Libreria para cambio de escena
using UnityEngine.SceneManagement;

public class Mariachi_Nxt_Lvl : MonoBehaviour
{
    //Elegir el sig lvl
    public string nextLevel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    //Colision pero de trigger

    private void OnTriggerEnter2D(Collider2D collider)
    {
        //Si toca al tag player
        if (collider.tag == "Player")
        {
            //Carga el sig lvl
            SceneManager.LoadScene(nextLevel);
        }
    }
}
