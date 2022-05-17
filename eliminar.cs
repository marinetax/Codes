using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eliminar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Cuando colisione con bala o bala2, las hara destruir, para que no se quede en la escena y se llene de clones.
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bala")
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "bala2")
        {
            Destroy(collision.gameObject);
        }


    }
}
