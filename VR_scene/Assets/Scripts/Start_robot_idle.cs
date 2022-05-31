using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class Start_robot_idle : MonoBehaviour
{
    public PlayableDirector Director_idle_robot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Play_director_robot_idle()
    {
        Director_idle_robot.Play();

    }
}
