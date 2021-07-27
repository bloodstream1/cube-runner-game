using UnityEngine;

public class endTrigger : MonoBehaviour
{
    public gameManager gemManager;

    void OnTriggerEnter()
    {
        gemManager.completeLevel();
    }
}
