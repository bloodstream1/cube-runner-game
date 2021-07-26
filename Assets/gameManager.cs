using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    public void completeLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void CompleteLevel()
    {
        Debug.Log("you won!!");
    }

    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            Debug.Log("GAME OVER!!");
            gameHasEnded = true;
            Invoke("restart",restartDelay);
        }
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
