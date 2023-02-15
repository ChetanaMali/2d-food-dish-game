using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCounter : MonoBehaviour
{
    
    [SerializeField] Image timerFGImage;
    [SerializeField] float maxTime = 20f;
    float remainningTime;

    // Start is called before the first frame update
    void Start()
    {
        remainningTime = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(remainningTime > 0)
        {
            remainningTime -= Time.deltaTime;
            timerFGImage.fillAmount = remainningTime / maxTime;
        }
        else
        {
            UIManeger.Instance.loseGame();
        }
    }
}
