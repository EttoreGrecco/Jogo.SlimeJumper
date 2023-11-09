using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndlessScroll : MonoBehaviour
{

    public float scroll = -1;
    public Vector3 gameVelocity;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = gameVelocity * scroll;
    }

    void OnTriggerExit(Collider gameArea)
    {
        if(gameObject.CompareTag("Cloud"))
    {
            // nuvem
            transform.position += Vector3.right * (gameArea.bounds.size.x + GetComponent<BoxCollider>().size.x);
        }
    else if (gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject); 
            // Destrói o obstáculo
        }
    }


    void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
