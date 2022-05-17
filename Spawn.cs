using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemy;

    public float cont;
    public float lim = 2;

    public Vector3 dir = Vector3.right;

    public int min = 2;
    public int max = 10;

    private void Start()
    {
        lim = Random.Range(min, max);
    }
    void Update()
    {
        //Spawn de los enemigos.
        cont = cont + Time.deltaTime;

        if(cont > lim)
        {
            GameObject nuevoEnemy = (GameObject) Instantiate(enemy, this.transform.position, this.transform.rotation);
            nuevoEnemy.GetComponent<MoviIA>().dir = dir;

            cont = 0;
            lim = Random.Range(min, max);

        }
    }
}
