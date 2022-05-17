using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class escenas : MonoBehaviour
{

    //Diferentes cambios de escenas
    public void cargar() {
        SceneManager.LoadScene("Juego");
        }

    public void volver ()
    {
        SceneManager.LoadScene("Juego");
    }

    public void menu()
    {
        SceneManager.LoadScene("Play");
    }

    public void control()
    {
        SceneManager.LoadScene("Controles");
    }
}
