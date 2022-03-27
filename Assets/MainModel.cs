using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainModel : MonoBehaviour
{
    // main controller
    private static MainController mainController;

    public delegate void Callback();

    public void SwitchScene(int id, int from)
    {
        GameObject obj = mainController.LoadScene(from);

        // find the GameObject location-from-<from>
        string locationNode = string.Format("location-from-{0}", from);
        Vector3 location = obj.transform.Find(locationNode).position;

        mainController.playerObj.transform.position = location;
    }

    public void CreateDialog(string message, Callback callback)
    {
        // TODO: set text to the retrieved message & mainController.SetDialogueText
        UnityEngine.UI.Text text = mainController.dialogueObj.GetComponent<UnityEngine.UI.Text>();
        text.text = message;

        // TODO: show it? (how? and how long? / how do we close it?)

        // TODO: callback after dialogue is finished (e.g. connect to some source / some onclicked())
        // callback();
    }

    void Start()
    {
        mainController = GameObject.Find("MainController").GetComponent<MainController>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
