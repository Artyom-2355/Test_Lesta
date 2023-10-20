using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeStart;
    public float endTime;
    public Text textTimer;
    // Start is called before the first frame update
    void Start()
    {
        textTimer.text = timeStart.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        timeStart += Time.deltaTime;
        textTimer.text = timeStart.ToString("F2");
        
    }
}
