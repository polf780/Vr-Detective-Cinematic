using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_scene_from_Train_toFinal_Detective : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void changemap()
    {
        SceneManager.LoadScene("Escena Detective Final");
    }
}
