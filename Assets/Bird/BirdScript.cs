using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public LogicManager logic;
    public bool BirdAlive = true;
    public float upperLimit = 8f; 
    public float lowerLimit = -8f; 
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) && BirdAlive == true){
            rb.velocity = Vector2.up * 9;
        }
        if (transform.position.y > upperLimit || transform.position.y < lowerLimit)
        {
            logic.gameOver();
            BirdAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        logic.gameOver();
        BirdAlive = false;
    }
}
