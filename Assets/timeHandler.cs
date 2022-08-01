using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale=0f;
    }

    // Update is called once per frame
    public void timeconti()
    {
        Time.timeScale=1f;
    }
}
