using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class rotateScript : MonoBehaviour
{

    public Slider rotatespeed;


    // Start is called before the first frame update
    void Awake()
    {
        rotatespeed = GameObject.FindWithTag("Rotator").GetComponent<Slider>();
    }

    public void OnEnable()
    {
       
        rotatespeed.onValueChanged.AddListener(delegate { sliderCallBackRot(rotatespeed); });
    }

    public void sliderCallBackRot(Slider rotatespeed)
    {
        Rotator.speed = rotatespeed.value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
