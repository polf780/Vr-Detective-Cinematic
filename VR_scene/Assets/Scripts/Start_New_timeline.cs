using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class Start_New_timeline : MonoBehaviour
{
    public PlayableDirector playableDirector2;
    public GameObject Robotidle;
    public GameObject cube;
    // Start is called before the first frame update
    public bool Started_timeline = false;
    // Start is called before the first frame update
    void Start()
    {
        Started_timeline = false;
    }
    void Update()
    {
        if(cube.activeInHierarchy == true)
        {
            Robotidle.GetComponent<Animator>().Play("Take 001");
            // if we want to play nothing Robotidle.GetComponent<Animator>().Play("New State");
        }
    }

    public void Play()
    {
        if (Started_timeline == false)
        {
            playableDirector2.Play();
            Started_timeline = true;
        }
    }
}
