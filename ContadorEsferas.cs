using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorEsferas : MonoBehaviour
{

    private int esferas;

    public GameObject textoEsferas;



    // Start is called before the first frame update
    void Start()
    {
        esferas = 0;

        textoEsferas.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    //Cada vez que el avion colisione con "esferas" sumara 1 y las destruira
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "esfera")
        {
            esferas = esferas + 1;
            Debug.Log(esferas);       
            Destroy(other.gameObject);

            if(esferas == 4)
            {
                textoEsferas.SetActive(true);

            }
        }

  
    }
}
