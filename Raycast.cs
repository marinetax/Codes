using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Raycast : MonoBehaviour
{
    public GameObject BalaPrin;
    public GameObject SpawnBala;
    public GameObject efectoOri;
    public GameObject textoFinal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Cuando aprete el mouse saldran las balas y si toca a Enemy lo destruira
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit resultRayo;
            Instantiate(BalaPrin, SpawnBala.transform.position, this.transform.rotation);

            if (Physics.Raycast(this.transform.position, this.transform.forward, out resultRayo, 1000))
            {


                Instantiate(efectoOri, resultRayo.point, this.transform.rotation);


                if (resultRayo.transform.tag == "Enemy")
                {
                    Destroy(resultRayo.collider.gameObject);

                }
            }


        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "final")
        {
            textoFinal.SetActive(true);
        }
        else
        {
            textoFinal.SetActive(false);
        }
    }
}

