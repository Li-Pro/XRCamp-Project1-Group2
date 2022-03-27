using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol_mother : MonoBehaviour
{
    public GameObject mom;
    public GameObject teddy;
    private bool check;
    public float dist=10;
    RaycastHit hit;
    public GameObject UiObject;
    void Start()
    {
        UiObject.SetActive(false);
    }
    /*
    void Update()
    {
        Debug.DrawRay(this.transform.position,this.transform.forward*dist,Color.magenta);
        if (Physics.Raycast (Camera.main.transform.position, Camera.main.transform.forward,out hit, dist) && hit.transform.tag == "mother"){
            check = GameObject.Find("phone").GetComponent<message>().message_check;
            if (check)
            {
                Debug.Log("to teddy");
                //check the message
                //mom turn to teddy
                Instantiate(teddy, mom.transform.position, mom.transform.rotation);//生成一個teddy的複製品在指定的位置上
                Destroy(mom);
            }
            else
            {
                Debug.Log("talk to mom");
                //good
                //text bubble
                UiObject.SetActive(true);
            }
        }
        else{
            UiObject.SetActive(false);
        }
    }
    */
    void OnTriggerEnter(Collider other){
        check = GameObject.Find("phone").GetComponent<message>().message_check;
            if (check)
            {
                Debug.Log("to teddy");
                //check the message
                //mom turn to teddy
                Instantiate(teddy, mom.transform.position, mom.transform.rotation);//生成一個teddy的複製品在指定的位置上
                Destroy(mom);
            }
            else
            {
                Debug.Log("talk to mom");
                //good
                //text bubble
                UiObject.SetActive(true);
            }
    }
    void OnTriggerExit(Collider other){
        if(other.tag=="mother"){
            UiObject.SetActive(false);
        }
    }
}
