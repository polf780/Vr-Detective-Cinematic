using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Changescenefrommenu : MonoBehaviour
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

    public void changemap()
    {
        if (Started_timeline == false)
        {
            SceneManager.LoadScene("Escena Detective");
            Started_timeline = true;
        }
        
    }

    public void exitgame()
    {
        Debug.Log("Quited game");
        Application.Quit();
    }
}
