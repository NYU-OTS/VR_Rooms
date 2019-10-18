using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigateRoom : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sign;

    public void ShowSign()
    {
        sign.SetActive(true);
    }

    public void HideSign()
    {
        sign.SetActive(false);
    }

    void Start()
    {
        sign.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
