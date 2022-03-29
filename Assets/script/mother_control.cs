using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mother_control : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject UiObject;
    public Material mat;
    public bool check_mom_first = false;
  
    public void toteddy(Collider other)
    {
        Debug.Log("to teddy" + other);
        this.GetComponent<Renderer>().material = mat;
    }
    public void talkmom(Collider other)
    {
        Debug.Log("talk to mom");
        //UiObject.SetActive(true);
        //check_mom_first = true;
    }

}
