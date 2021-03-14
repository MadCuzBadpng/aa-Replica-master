using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class IntroScript : MonoBehaviour
{
    public static int StartLife;
    public Dropdown timer;
    public Dropdown lifes;
    public Slider pinspeed;
    public bool check = false;
    private int droplife;
    private float droptime;
    public Text lifeText;
    public Text timeText;
    public static bool Mark = false;

    void Start()
    {
        
    }
    public void Awake()
    {
        pinspeed = GameObject.FindWithTag("Pin").GetComponent<Slider>();

    }
    public void Play()
    {
        if (check == false)
        {
            StartLife = droplife;
        }
        else
        {
            StartLife = droplife;
        }
        SceneManager.LoadScene(1);
    }

    public void OnEnable()
    {
        pinspeed.onValueChanged.AddListener(delegate { sliderCallBackPin(pinspeed); });
    }

    public void sliderCallBackPin(Slider pinspeed)
    {
        Pin.speed = pinspeed.value;
    }
    

    public void LifeDrop()
    {
        switch (lifes.value)
        {
            default:
                droplife = 3;
                check = true;
                break;
            case 1:
                droplife = 1;
                check = true;
                break;
            case 2:
                droplife = 2;
                check = true;
                break;
            case 3:
                droplife = 3;
                check = true;
                break;
        }
    }

    public void TimeDrop()
    {
        switch (timer.value)
        {
            default:
                droptime = 15f;
                
                break;
            case 1:
                droptime = 15f;
                
                break;
            case 2:
                droptime = 30f;
                
                break;
            case 3:
                droptime = 60f;
                
                break;

        }
    }

    void Update()
    {
        lifeText.text = ("LIVES: " + droplife.ToString());
        timeText.text = ("TIME: " + droptime.ToString());
        if (LifeScript.CurrentLife == 0)
        {
            LifeScript.CurrentLife = droplife;
           // Score.CurrentScore = 0;
        }

        if (TimerScript.startTime == 0)
        {
            TimerScript.startTime = droptime;
        }


        if (Mark == true)
        {
            LifeScript.CurrentLife = droplife;
            TimerScript.startTime = droptime;
            //Score.CurrentScore = 0;
            Mark = false;
        }
        
        
    }
}
