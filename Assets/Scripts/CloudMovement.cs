using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    public float maximumRight;
    public float maximumLeft;

    public float moveSpeed;

    public float downSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Boundary"))
        {
            Debug.Log("Collission");
            // Adjust the position (assuming you want to move the object up by downSpeed value)
            transform.position = new Vector3(transform.position.x, transform.position.y - downSpeed, transform.position.z);

            // Reverse the movement speed
            moveSpeed *= -1;
        }

    }





}
