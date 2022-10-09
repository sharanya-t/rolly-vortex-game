using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float movespeed = 100f;
    float movement = 0f;
    
    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
        
    }
    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -movespeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        Audiomanager.Instance.gameObject.GetComponent<AudioSource>().Stop();
        SceneManager.LoadScene("Credits");


    }
}   

