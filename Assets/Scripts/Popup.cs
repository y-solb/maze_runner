using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour {

    public GameObject obj;

    public void PopupButton()
    {
        obj.SetActive(true);
    }
}
