using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnicornShoot : MonoBehaviour
{
    public GameObject shootingpoopPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(shootingpoopPrefab, transform.position, Quaternion.identity);
        }
    }

    // Use OnTriggerEnter2D for 2D colliders

}