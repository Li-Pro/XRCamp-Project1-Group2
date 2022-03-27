using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mother_control : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject UiObject;
    public Material mat;
    void Start()
    {
        // UiObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void mother_controller(Collider other, bool check){

            if (check)
            {
                Debug.Log("to teddy" + other);
                //check the message
                //mom change the material

                //Instantiate(teddy, mom.transform.position, mom.transform.rotation);//生成一個teddy的複製品在指定的位置上
                //Destroy(mom);
                this.GetComponent<Renderer>().material = mat;
            }
            else
            {
                Debug.Log("talk to mom");
                //good
                //text bubble
                UiObject.SetActive(true);
            }

    }
}
