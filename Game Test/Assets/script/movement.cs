using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //kecepatan gerak object
    public float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movehorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        //buat vektor gerakan berdasarkan input
        Vector3 movement = new Vector3(movehorizontal, 0.0f, moveVertical);
        // gerakan objek
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);

    }
}
