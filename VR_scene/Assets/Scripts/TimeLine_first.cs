using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimeLine_first : MonoBehaviour
{
    public PlayableDirector playableDirector;

    public bool Started_timeline = false;
    // Start is called before the first frame update
    void Start()
    {
        Started_timeline = false;
    }

    public void Play()
    {
        if (Started_timeline == false)
        {
            playableDirector.Play();
            Started_timeline = true;
        }
    }
}
