using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class Start_New_timeline : MonoBehaviour
{
    public PlayableDirector playableDirector2;
    public GameObject button;
    // Start is called before the first frame update
    public bool Started_timeline = false;
    // Start is called before the first frame update
    void Start()
    {
        Started_timeline = false;
    }
    void Update()
    {
    
    }

    public void Play()
    {
        if (Started_timeline == false)
        {
            playableDirector2.Play();
            Started_timeline = true;
        }
    }
    public void create_button()
    {
        button.SetActive(true);
    }
}
