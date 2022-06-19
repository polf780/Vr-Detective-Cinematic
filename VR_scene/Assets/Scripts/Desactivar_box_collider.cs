using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desactivar_box_collider : MonoBehaviour
{
    public GameObject Faun;
    public GameObject Robot;
    public GameObject Murloc;
    public GameObject Armadura;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TurnOff_All_Colliders()
    {
        Faun.GetComponent<BoxCollider>().enabled = false; 
        Faun.GetComponent<BoxCollider>().enabled = false;
        Robot.GetComponent<BoxCollider>().enabled = false;
        Murloc.GetComponent<BoxCollider>().enabled = false;
        Armadura.GetComponent<BoxCollider>().enabled = false;
    }
    public void TurnOn_All_Colliders()
    {
        Faun.GetComponent<BoxCollider>().enabled = true;
        Faun.GetComponent<BoxCollider>().enabled = true;
        Robot.GetComponent<BoxCollider>().enabled = true;
        Murloc.GetComponent<BoxCollider>().enabled = true;
        Armadura.GetComponent<BoxCollider>().enabled = true;
    }
}
