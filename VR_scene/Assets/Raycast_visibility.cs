using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Raycast_visibility : MonoBehaviour
{
    //public GameObject raycast_right;
    //public GameObject raycast_left;
    public LineRenderer left_one;
    public XRInteractorLineVisual left_one_2;

    public LineRenderer right_one;
    public XRInteractorLineVisual right_one_2;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InvisibleRightifnotHover()
    {
        right_one.enabled = false;
        right_one_2.enabled = false;
    }
    public void InvisibleLeftifnotHover()
    {
        left_one.enabled = false;
        left_one_2.enabled = false;
    }

    public void VisibleRightifHover()
    {
        right_one.enabled = true;
        right_one_2.enabled = true;
    }
    public void VisibleLeftifHover()
    {
        left_one.enabled = true;
        left_one_2.enabled = true;
    }
}
