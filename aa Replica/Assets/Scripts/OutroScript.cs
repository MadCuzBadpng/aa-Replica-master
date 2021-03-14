using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class OutroScript : MonoBehaviour
{
    
    void Start()
    {
        
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    }
}
