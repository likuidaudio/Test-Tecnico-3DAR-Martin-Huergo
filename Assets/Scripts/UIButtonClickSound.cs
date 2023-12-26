using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtonClickSound : MonoBehaviour
{
    public void OnClick()
    {
        AkSoundEngine.PostEvent("Play_Click", gameObject);
    }

    public void OnMouseEnter()
    {
        AkSoundEngine.PostEvent("Play_Hover", gameObject);
    }

    public void StopMusic()
    {
        AkSoundEngine.StopAll();

    }
}
