using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMusic : MonoBehaviour
{
    public AK.Wwise.Event levelMusic;
    void Start()
    {
        levelMusic.Stop(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
