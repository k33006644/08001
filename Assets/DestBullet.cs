using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestBullet : MonoBehaviour
{
    // Start is called before the first frame update
    public int k;
    void Start()
    {
        StartCoroutine(waitandDest(k));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator waitandDest(int p)
    {
        yield return new WaitForSeconds(p);

        Destroy(this.gameObject);
    }
}
