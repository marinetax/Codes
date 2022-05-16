using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class CorrutinaScene: MonoBehaviour
{
    
    void Start()
    {

        DontDestroyOnLoad(this.gameObject);

        //Start corrutina
        StartCoroutine("cambio");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Corrutina calling
    IEnumerator cambio()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Menu2");

        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Menu3");
    }
}
