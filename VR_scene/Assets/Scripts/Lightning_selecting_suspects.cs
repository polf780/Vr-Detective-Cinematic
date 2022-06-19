using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning_selecting_suspects : MonoBehaviour
{
    public GameObject Murloc_Light;
    public GameObject Faun_Light;
    public GameObject Armor_Light;
    public GameObject Detective_Light;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void Enable_light_Murloc()
    {
        Murloc_Light.SetActive(true);
    }
    public void Close_light_Murloc()
    {
        Murloc_Light.SetActive(false);
    }

    public void Faun_light_Enable()
    {
        Faun_Light.SetActive(true);
    }
    public void Faun_light_Close()
    {
        Faun_Light.SetActive(false);
    }

    public void Armor_light_Enable()
    {
        Armor_Light.SetActive(true);
    }
    public void Armor_light_Close()
    {
        Armor_Light.SetActive(false);
    }

    public void Detective_Light_Enable()
    {
        Detective_Light.SetActive(true);
    }
    public void Detective_Light_Close()
    {
        Detective_Light.SetActive(false);
    }
}
