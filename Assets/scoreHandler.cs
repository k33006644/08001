using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreHandler : MonoBehaviour
{
    // Start is called before the first frame update

    public UnityEngine.UI.Text scoreUI;
     public UnityEngine.UI.Text InfectionUI;
     public GameObject gameOver;

    public AudioClip impact,sprayed,damage;
    AudioSource audioSource;
     int score;
     int infection;
    void Start()
    {
        infection=20;
        InfectionUI.text=infection.ToString();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(infection<0)
        {
            Time.timeScale=0f;
            gameOver.SetActive(true);
        }
    }

    public void spraySound()
    {
        audioSource.PlayOneShot(sprayed);
    }
    public void scoreUpdate()
    {
        score++;
        audioSource.PlayOneShot(impact);
        scoreUI.text=score.ToString();
        
    }
    public void InfectionUpdate()
    {
        infection--;
        audioSource.PlayOneShot(damage);
        InfectionUI.text=infection.ToString();
        
    }
}
