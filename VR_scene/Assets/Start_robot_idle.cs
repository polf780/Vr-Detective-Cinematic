using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_robot_idle : MonoBehaviour
{
    public GameObject Robotidle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Start_idlerobot_animation()
    {
        Robotidle.GetComponent<Animator>().Play("Take 001");
    }
}
