using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float destroyXPos = -20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < destroyXPos)
        {
            Destroy(gameObject);
        }
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }
}
