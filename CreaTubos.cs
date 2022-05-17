using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaTubos : MonoBehaviour
{
    public float tempmax;
    private float tempin = 0;
    public GameObject tubos;
    public float altura;

    // Start is called before the first frame update
    void Start()
    {
        GameObject nuevotubo = Instantiate(tubos);
        nuevotubo.transform.position = transform.position + new Vector3(0, 0, 0);
        Destroy(nuevotubo, 10);
    }

    // Update is called once per frame
    void Update()
    {
        if(tempin > tempmax)
        {
            GameObject nuevotubo = Instantiate(tubos);
            nuevotubo.transform.position = transform.position + new Vector3(0, Random.Range(-altura,altura), 0);
            Destroy(nuevotubo, 10);
            tempin = 0;
        }
        else
        {
            tempin += Time.deltaTime;
        }
    }
}
