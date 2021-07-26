using UnityEngine;

public class plyerMument : MonoBehaviour
{
    public float force1;
    public float force2;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rb.AddForce(force2 * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-force2 * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<gameManager>().EndGame();
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,force1 * Time.deltaTime);
    }

}
