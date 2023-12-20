using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootingpoop : MonoBehaviour
{

    public float moveSpeed;
    //public AudioSource wanishSound;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            PlaySound.Instance.wanishSound.Play();
        }
        if (other.CompareTag("Boundary"))
        {
            Destroy(gameObject);
        }
    }
}
