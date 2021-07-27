using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public plyerMument movement;
    public gameManager gemManger;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "obsticle")
        {
            movement.enabled=false;
            FindObjectOfType<gameManager>().EndGame();
        }
    }
}
