using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class All_Characters_on_Idle : MonoBehaviour
{
    public GameObject Faun;
    public GameObject Armor;
    public GameObject Robot;
    public GameObject Murloc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AllCharacters_idle()
    {
        Armor.GetComponent<Animator>().Play("Take 001");
        Faun.GetComponent<Animator>().Play("Take 001");
        Robot.GetComponent<Animator>().Play("Take 001");
        Murloc.GetComponent<Animator>().Play("Take 001");
    }
}
