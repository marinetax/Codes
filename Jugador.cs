using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jugador : MonoBehaviour
{

    public Rigidbody mirig;

    public float vel;
    public float vel2;
    public float rot;
    public bool tocosuelo = false;

    public Animator mover;

    //public AudioSource mov;
    //public float contDist = 0;
    //public float distPaso = 8f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            
            mover.SetTrigger("movi");
            //Aumentar eje y izquierda
            this.transform.localScale = new Vector3((float)-1.3797, (float)1.3797, (float)1.3797);
            this.transform.Translate(-vel2 * Time.deltaTime, 0, 0, Space.World);
            //contDist += vel2 * Time.deltaTime;
        }

        //Desplazamiento en y

        if (Input.GetKey(KeyCode.D))
        {
            
            mover.SetTrigger("movi");
            this.transform.localScale = new Vector3((float)1.3797, (float)1.3797, (float)1.3797);
            //Aumentar eje y derecha   
            this.transform.Translate(vel2 * Time.deltaTime,0 , 0, Space.World);
            //contDist += vel2 * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.E))
        {
            this.transform.localScale = new Vector3((float)1.3797, (float)1.3797, (float)1.3797);
            //Aumentar eje y derecha   
            this.transform.Translate(vel2 * 2 *Time.deltaTime, 0, 0, Space.World);
            mover.SetTrigger("movi");
        }

        if (Input.GetKey(KeyCode.Q))
        {
            this.transform.localScale = new Vector3((float)-1.3797, (float)1.3797, (float)1.3797);
            //Aumentar eje y derecha   
            this.transform.Translate(-vel2 * 1 * Time.deltaTime, 0, 0, Space.World);
            mover.SetTrigger("movi");
        }
        //if( contDist > distPaso)
        //{
        //    mov.Play();
        //    contDist = 0;
        //}
        tocosuelo = false;

        RaycastHit rayo;

        if(Physics.Raycast (this.transform.position, Vector3.down, out rayo, 1.0f))
        {
            if(rayo.transform.tag == "Suelo")
            {
                tocosuelo = true;

            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && tocosuelo == true)
        {
            mirig.velocity = Vector3.up * vel;

        }


    }

    

}
