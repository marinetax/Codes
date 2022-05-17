using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public GameObject bala;
    public GameObject puntodiparo;

    public Vector3 dirdisp = Vector3.right;

    public float vel = 14;

    public Animator disparar;
    public Animator mover;
    public AudioSource sonido;

   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            dirdisp = Vector3.left;
            mover.SetTrigger("movi");
        }
        if (Input.GetKey(KeyCode.D))
        {
            dirdisp = Vector3.right;
            mover.SetTrigger("movi");
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            sonido.Play();
            disparar.SetTrigger("shoot");
            GameObject newBala = (GameObject)Instantiate(bala, puntodiparo.transform.position, this.transform.rotation);
            newBala.GetComponent<Rigidbody>().velocity = dirdisp * vel;
            Destroy(newBala, 2);
        }
    }
}
