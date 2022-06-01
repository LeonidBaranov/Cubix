using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Moving : MonoBehaviour
{
    public float speed;
    public float normalSpeed;
    public Rigidbody rb;
    [SerializeField] Vector3 point;

    public void Start()
    {
        speed = 0f;
        rb = GetComponent<Rigidbody>();
       
    }

     public void FixedUpdate()
    {
         rb.velocity = new Vector3(speed , 0, speed);
    } 

    public void OnLeftButtonDown()
    {
        if (speed >= 0f )
        {
            speed = - normalSpeed;
        }

    }

    public void OnRightButtonDown()
    {
        if (speed <= 0f )
        {
            speed = normalSpeed;
        }

    }

    public void OnButonUp()
    {
        speed = 0f;
    }

    public void ResetButtonOnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Player") && other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
