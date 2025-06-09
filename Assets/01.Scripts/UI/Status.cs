using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour
{
    public void OpenStatus()
    {
        this.gameObject.SetActive(true);
    }

    public void CloseStatus()
    {
        this.gameObject.SetActive(false);
    }
}
