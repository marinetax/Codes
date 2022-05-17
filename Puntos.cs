using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntos : MonoBehaviour
{
    public static int punto = 0;
    // Start is called before the first frame update
    void Start()
    {
        punto = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = punto.ToString();
    }
}
