using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 10;
    private PlayerController playerControllerScript;
    private float downBound=-50;
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver==false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (transform.position.y<downBound&&gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
        
    }
}
