using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAvion : MonoBehaviour
{
    public float vel;
    public float rot;

    public GameObject BalaPrin;
    public GameObject SpawnBala;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento hacia adelante sin parar
        this.transform.Translate(0, 0, vel * Time.deltaTime);

        if (Input.GetKey(KeyCode.W))
        {

            //Cabeceo hacia arriba

            this.transform.Rotate(-rot * Time.deltaTime, 0, 0);

        }

        if (Input.GetKey(KeyCode.S))
        {

            //Cabeceo hacia abajo

            this.transform.Rotate(rot * Time.deltaTime, 0, 0);

        }

        if (Input.GetKey(KeyCode.A))
        {

            //Alabeo hacia la izquierda

            this.transform.Rotate(0, 0 , rot * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.D))
        {

            //Alabeo hacia la derecha 

            this.transform.Rotate(0, 0, -rot * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.E))
        {

            //Guiñada hacia la derecha 

            this.transform.Rotate(0, rot * Time.deltaTime, 0);

        }

        if (Input.GetKey(KeyCode.Q))
        {

            //Guiñada hacia la izquierda 

            this.transform.Rotate(0, -rot * Time.deltaTime, 0);

        }

        //Disparara las balas cada vez que apretemos el boton izquierdo
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            Instantiate(BalaPrin, SpawnBala.transform.position, this.transform.rotation);

        }
    }
   
}

