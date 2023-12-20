using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnicornController : MonoBehaviour
{
    public float moveSpeed = 5;
    public float hInput;
    // Horizontal input
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector2.right * hInput * moveSpeed * Time.deltaTime);
    }
    // horizontal input added to get the input witj get axis raw function
    // transform added for the movement of the player
}

