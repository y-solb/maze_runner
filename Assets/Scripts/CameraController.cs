using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraController : MonoBehaviour
{

    public GameObject Player;

    private Vector3 offset;
    void Start()
    {
        offset = transform.position - Player.transform.position;
    }


    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Player.transform.position + offset;
    }

    public GameObject obj;

    public void PopupButton()
    {
        obj.SetActive(true);
    }

    public void CloseButton()
    {
        obj.SetActive(false);
    }

    public void ExitButton()
    {
        Application.Quit();
       // SceneManager.LoadScene("SampleScene");
    }

    public void NewButton()
    {
        SceneManager.LoadScene("main");
    }


}
