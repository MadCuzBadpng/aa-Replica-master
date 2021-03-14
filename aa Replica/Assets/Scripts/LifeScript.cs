using UnityEngine.UI;
using UnityEngine;

public class LifeScript : MonoBehaviour
{
    public static int CurrentLife = IntroScript.StartLife;
    public Text lifeText;
    
    

    void Start()
    {
        lifeText.text = ("LIVES: " + CurrentLife.ToString());
    }

}
