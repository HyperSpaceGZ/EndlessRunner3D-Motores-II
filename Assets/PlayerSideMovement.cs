using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSideMovement : MonoBehaviour
{
    private int desiredline = 1;
    public float roaddistance = 2.5f;
    public float lurpamount = 20;
    public float jumpforce = 4;

    bool isjumping;

    public Rigidbody rb;

    
    void Start()
    {

    }

    
    void Update()
    {
        //Movement Input
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("right");
            desiredline++;
            if (desiredline == 3)
            {
                desiredline = 2;
            }
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("left");
            desiredline--;
            if (desiredline == -1)
            {
                desiredline = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && isjumping == false)
        {
            Jump();
            isjumping = true;
            Debug.Log("IsJumping = true");
        }


        //Position (between 0, 1, 2) "checker"
        Vector3 roadposition = transform.position.z * transform.forward + transform.position.y * transform.up;

        if (desiredline == 0)
        {
            roadposition += Vector3.left * roaddistance;
        }
        else if (desiredline == 2)
        {
            roadposition += Vector3.right * roaddistance;
        }

        transform.position = Vector3.Lerp(transform.position, roadposition, lurpamount * Time.deltaTime);
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isjumping = false;
            Debug.Log("IsJumping = False");
        }

        if (collision.gameObject.tag == "Obstacle")
        {
            Death();
        }

    }
    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpforce);
    }

    public void Death()
    {
        SceneManager.LoadScene("Death");
    }

}
