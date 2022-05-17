using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimPlayer : MonoBehaviour
{
    public int vel = 1;
    private Rigidbody2D rb;
    public GameObject gameo;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

        rb = GetComponent<Rigidbody2D>();
        gameo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            rb.velocity = Vector2.up * vel;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Suelo")
        {
            gameo.SetActive(true);
            Time.timeScale = 0;

        }

        if (collision.gameObject.tag == "Tubo")
        {
            gameo.SetActive(true);
            Time.timeScale = 0;

        }
    }

}
