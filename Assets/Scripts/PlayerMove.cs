using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float playerSpeed = 8f;
    
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game.");
        Debug.Log("Move the player with WASD");
        Debug.Log("Avoid the obstacles");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * playerSpeed;
        transform.Translate(xValue, 0f, zValue);
    }
}
