using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabing_phone : MonoBehaviour
{
    public bool Started_timeline = false;
    // Start is called before the first frame update
    void Start()
    {
        Started_timeline = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartTimeLine()
    {
        if (Started_timeline == false)
        {
            //This space is for the code to start the first timeline
            Debug.Log("Starting timeline ");
            Started_timeline = true;
        }
      
    }
}
