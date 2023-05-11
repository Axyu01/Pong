using System.Collections;
using System.Collections.Generic;
//using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    public float velocity = 2f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2((Random.value - 0.5f) * 2f, (Random.value - 0.5f) * 2f) * velocity;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity=rb.velocity.normalized*velocity;
        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(0);
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }
}
