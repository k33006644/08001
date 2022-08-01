using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour {

	public AudioClip[] aClips;
	public AudioSource myAudioSource;
    string btname;
    private int ran;
    Random rnd = new Random();
    // Use this for initialization
    void Start () {

        
		myAudioSource = GetComponent<AudioSource>(); 
		
	}
	
	// Update is called once per frame
	void Update () {

        ran = Random.Range(1, 3);
        Debug.Log(ran);
        if (Input.touchCount > 0 && Input.touches[0].phase ==TouchPhase.Began)
		{
			Ray ray = Camera.main.ScreenPointToRay (Input.GetTouch (0).position);
            RaycastHit Hit;
            
            if (Physics.Raycast(ray, out Hit))

            { 
                    btname=Hit.transform.name;
				switch(btname)
				{
				case "myButton1":
                        Debug.Log(ran);
					myAudioSource.clip=aClips[ran];
					myAudioSource.Play();
					break;
				case "myButton2":
					myAudioSource.clip=aClips[ran];
					myAudioSource.Play();
					break;
				case "myButton3":
					myAudioSource.clip=aClips[ran];
					myAudioSource.Play();
					break;
		
	}
			}
				}
				}
				}

