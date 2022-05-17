using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoviIA : MonoBehaviour
{
    public float vel = 4;
    public AudioSource muerte;
    public Vector3 dir = Vector3.right;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(dir * vel * Time.deltaTime, Space.World);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            //Se detsruiran los enemigos si chocan entre ellos
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            
        }
        if(collision.gameObject.tag == "Bala")
        {
            //Sonido de muerte enemigo
            muerte.Play();

            Destroy(collision.gameObject, 0.07f);
            
            
           
        }
        




    }
}
