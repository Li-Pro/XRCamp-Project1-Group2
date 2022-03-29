using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mother_control : MonoBehaviour, ISayable
{
    // Start is called before the first frame update
    public GameObject UiObject;
    public Material mat;
    
    public bool check_mom_first = false;

    private Material mat_original;
    private bool isTeddy = false;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        mat_original = this.GetComponent<Renderer>().material;
    }
  
    public void playSaySound()
    {
        // AudioSource source = this.transform.Find("SaySound").GetComponent<AudioSource>();
        AudioSource source = this.transform.parent.Find("SaySound").GetComponent<AudioSource>();
        source.Stop();
        
        source.Play();
        source.time = 3.0f;
    }

    public void toteddy(Collider other)
    {
        if (isTeddy)
        {
            return;
        }

        isTeddy = true;

        Debug.Log("to teddy" + other);
        this.transform.parent.Find("TeddySound").GetComponent<AudioSource>().Play();
        
        // GameObject.Find("BGM").GetComponent<AudioSource>().pitch -= 0.2f;
        // MainController.theController.GetSceneBGM(1).pitch -= 0.2f;
        // MainController.theController.GetSceneBGM(1).pitch -= 0.1f;
        MainController.theController.GetSceneBGM(1).volume -= 0.12f;

        this.GetComponent<Renderer>().material = mat;
    }

    public void backFromTeddy()
    {
        if (!isTeddy)
        {
            return;
        }

        isTeddy = false;

        // Debug.Log("to teddy" + other);
        this.transform.parent.Find("TeddySound").GetComponent<AudioSource>().pitch += 0.2f;
        this.transform.parent.Find("TeddySound").GetComponent<AudioSource>().Play();

        this.GetComponent<Renderer>().material = mat_original;
    }

    public void talkmom(Collider other)
    {
        Debug.Log("talk to mom");
        //UiObject.SetActive(true);
        //check_mom_first = true;
    }

}
