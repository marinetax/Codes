using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaMatar : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Destruir el enemigo en cuanto colisionen
        if( collision.gameObject.tag == "Enemy")

        {
            Destroy(collision.gameObject, 0.1f);
            
        }
        Destroy(this.gameObject);
    }
}
