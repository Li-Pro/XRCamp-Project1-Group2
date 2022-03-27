using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainModel : MonoBehaviour
{
    private static MainController mainController;
    public delegate void Callback();

    
    public void CreateDialog(string message, Callback callback)
    {
        // TODO: set text to the retrieved message & mainController.SetDialogueText
        UnityEngine.UI.Text text = mainController.dialogueObj.GetComponent<UnityEngine.UI.Text>();
        text.text = message;

        // TODO: show it?

        // TODO: callback after dialogue finished (e.g. connect to some source / some onclicked())
        // callback();
    }

    //public void CreateDialog(string[] message)
    //{
    //    // do we need to create a list of dialogue?
    //}

    void Start()
    {
        mainController = GameObject.Find("MainController").GetComponent<MainController>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
