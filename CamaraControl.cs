using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraControl : MonoBehaviour
{
    // Start is called before the first frame update
    Transform player;

    void Start()
    {
        //Al empezar la camara buscara al componente que su TAG sea "Player" en este caso se lo hemos asignado al tanque
        player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        //La camara sera estatica pero en todo momento mirara a Player
        transform.LookAt(player);
    }
}
