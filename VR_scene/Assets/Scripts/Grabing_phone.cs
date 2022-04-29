using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabing_phone : MonoBehaviour
{
    private bool picked_phone = false;
    private float time = 0.0f;
    public float interpolationPeriod = 5f;
    public AudioSource phoneringing;
    public GameObject phone;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (picked_phone == false)
        {
            time += Time.deltaTime;
           
            if (time >= interpolationPeriod)
            {             
                phone.GetComponent<Animator>().Play("Idle_phone");
                phoneringing.Play();
                time = 0.0f;
            }
        }
    }
    public void Stopaudioandanimation()
    {
        picked_phone = true;
        phone.GetComponent<Animator>().enabled = false;
    }
}
