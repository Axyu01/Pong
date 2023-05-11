using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTrigger : MonoBehaviour
{
    [SerializeField]
    Text scoreText;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        if (ball==null)
            return;
        score++;
        ball.transform.position = Vector3.zero;
        ball.rb.velocity = ((UnityEngine.Random.value-0.5f)*6f * Vector2.up+(Vector2.left*this.transform.position.x).normalized).normalized *ball.velocity;
        scoreText.text = score.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
