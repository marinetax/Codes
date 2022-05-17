using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VidaPlayer : MonoBehaviour
{

    public int vida;
    public int vidamax = 50;
    public Text vidat;

    public Text llave;
    public int numllav;
    public GameObject resObj;
    public AudioSource muerte;

    public int contador;
    // Start is called before the first frame update
    void Start()
    {
        vida = vidamax;
        vidat.text = "Vida = " + vida;

        numllav = 0;
        llave.text = "Llave = " + numllav;

        contador = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Perdera vida al chocar con los enemigos
        if (collision.gameObject.tag == "Enemy")
        {
            vida -= 1;
            vidat.text = "Vida =" + vida;
            Destroy(collision.gameObject);
            muerte.Play();
            if(vida <= 0)
            {
                SceneManager.LoadScene("GameOver");
            }
        }

        if (collision.gameObject.tag == "Llave")
        {
            numllav += 1;
            llave.text = "Llave =" + numllav;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Llave2")
        {
            numllav += 1;
            llave.text = "Llave =" + numllav;
            Destroy(collision.gameObject);
        }

        //se podran coger las puertas cada vez que tengamos 1 llave o mas (2)
        if (numllav >= 1)
        {
            if (collision.gameObject.tag == "Puerta")
            {
                Destroy(collision.gameObject);
                numllav -= 1;
                llave.text = "Llave =" + numllav;
            }
            if (collision.gameObject.tag == "Puerta2")
            {
                Destroy(collision.gameObject);
                numllav -= 1;
                llave.text = "Llave =" + numllav;
            }
        }

        //Si el player cae 3 veces al vacío perdera diretamente
        if (collision.gameObject.tag == "Respawn")
        {
            this.transform.position = resObj.transform.position;
            vida -= 1;
            vidat.text = "Vida =" + vida;
            contador++;
            if(contador >= 3)
            {
                SceneManager.LoadScene("GameOver");
            }
            if (vida <= 0)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}
