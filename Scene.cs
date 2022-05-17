using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void jugar()
    {
        SceneManager.LoadScene("Juego");
    }

    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
