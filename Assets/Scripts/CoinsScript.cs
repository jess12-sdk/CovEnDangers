using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsScript : MonoBehaviour
{
    private SpriteRenderer sr;
    private CircleCollider2D circle;
    public int Score;


    // Start is called before the first frame update
    void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
        circle = gameObject.GetComponent<CircleCollider2D>();
    }

    void OnTriggerEnter2D(Collider2D collider){
        if(collider.gameObject.tag == "Player")
        {
            sr.enabled = false;
            circle.enabled = false;

            GameController.instance.totalScore += Score;
            GameController.instance.UpdateScoreText();

            Destroy(gameObject, 0.25f);
            GetComponent<AudioSource>().Play();
        }
    }
}
