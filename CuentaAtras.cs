using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CuentaAtras: MonoBehaviour
{

    public float vel;
    public float rot;
    public float Tiempo;
    public Text textoTiempo;
    public GameObject textoGasolina;


    public GameObject BalaPrin;
    public GameObject SpawnBala;
    public float cadencia;
    public float TiempoEspera;

    void Start()
    {

        //Nada mas inicar el juego desactivaremos el texto que saldra por pantalla para mas tarde activarlo cuando toque.
        textoGasolina.SetActive(false);

        //Si al empezar el juego el tiempo es 0, directamente nos saldra el texto y no nos podremos mover
        if (Tiempo <= 0)
        {         
            textoGasolina.SetActive(true);
            Debug.Log("Te has quedado sin gasolina");
        }
    }

    void Update()
    {

        //CUENTA ATRAS
        if (Tiempo > 0)
        {           

            Tiempo = Tiempo - 1;
            Debug.Log("TIEMPO : " + Tiempo); 


            //Podremos ver dentro del juego el tiempo como va dismunyendo.
            textoTiempo.text = "Tiempo : " + Tiempo;


            //MOVIMIENTO TANQUE
            //Desplazamiento en eje z.
            if (Input.GetKey(KeyCode.W))
            {

                //Aumentar eje z

                this.transform.Translate(0, 0, vel * Time.deltaTime);

            }

            //Desplazamiento en eje z atras

            if (Input.GetKey(KeyCode.S))
            {

                //Aumentar eje z atras

                this.transform.Translate(0, 0, -vel * Time.deltaTime);

            }

            //Desplazamiento en y

            if (Input.GetKey(KeyCode.A))
            {

                //Aumentar eje y izquierda

                this.transform.Rotate(0, -rot * Time.deltaTime, 0);

            }

            //Desplazamiento en y

            if (Input.GetKey(KeyCode.D))
            {

                //Aumentar eje y derecha 

                this.transform.Rotate(0, rot * Time.deltaTime, 0);

            }
            
            //DISPARO CON CADENCIA
            if (Input.GetKeyDown(KeyCode.Space))
            {

                //Si la cadencia es menor o igual a 0 se podra disparar
                if (cadencia <= 0)
                {
                    //TiempoEspera = el tiempo que queremos que tarde en disparar                    
                    cadencia = TiempoEspera;

                   
                    Instantiate(BalaPrin, SpawnBala.transform.position, this.transform.rotation);
                    //Instantiate(BalaPrin, SpawnBala.transform.position, SpawnBala.transform.rotation);
                    //Debug.Log(Time.time);

                }


            }

            //El cronometro que cuenta des de el numero de TiempoEspera hasta 0, que se reiniciara cada vez que cliquemos el espacio.
            cadencia -= Time.deltaTime;

            //CUENTA ATRAS
            if (Tiempo <= 0)
            {

                //Si el tiempo es 0 o menor activaremos el texto que en el voidStart hemos desactivado para que salga por pantalla.
                textoGasolina.SetActive(true);
                Debug.Log("Te has quedado sin gasolina");

            }


        }
      
    }
 }
    

