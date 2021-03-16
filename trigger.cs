using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public GameObject triggerObj;
    // Start is called before the first frame update
    public void Start()
    {
        triggerObj = GameObject.Find("triggerObj");
    }
    public void triggering()
    {
        triggerObj.SendMessage("getbuttomdown");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
