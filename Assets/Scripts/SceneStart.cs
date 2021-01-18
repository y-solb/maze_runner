using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStart : MonoBehaviour {
    public GameObject obj;

    void Awake()
    {

    }


	public void StartButton () {
        Invoke("startgame", .3f);
	}
    public void HelpButton()
    {
        obj.SetActive(true);
    }

    public void CloseButton()
    {
        obj.SetActive(false);
    }
    void startgame()
    {

        SceneManager.LoadScene("main");
    }
	
}
