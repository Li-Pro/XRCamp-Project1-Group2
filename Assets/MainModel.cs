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

        Debug.Log("switch: " + obj);
        Debug.Log("switch: " + obj + " " + obj.transform.Find(locationNode));
        Vector3 location = obj.transform.Find(locationNode).position;

        // TODO: set rotation
        mainController.playerObj.transform.position = location;
    }

    private Callback _theCallback;
    private float _waitTime;

    public void CreateDialogue(string message, Callback callback)
    {
        // TODO: set text to the retrieved message & mainController.SetDialogueText
        UnityEngine.UI.Text text = mainController.dialogueObj.transform.Find("Text").GetComponent<UnityEngine.UI.Text>();
        text.text = message;

        // TODO: show it? (how? and how long? / how do we close it?)
        mainController.dialogueObj.SetActive(true);
        Debug.Log(mainController.dialogueObj);
        Debug.Assert(mainController.dialogueObj.activeSelf);
        
        Debug.Log("created dialog");

        // TODO: callback after dialogue is finished (e.g. connect to some source / some onclicked())
        // callbackInSecond(() => {
        //     Debug.Log("is calling callback");
        //     callback();
        // }, 2.0f);

        _startCoroutine(callback, 2.0f);
    }

    private void _startCoroutine(Callback callback, float seconds) {
        _theCallback = callback;
        _waitTime = seconds;
        StartCoroutine("callbackInSecond");
    }

    private IEnumerator callbackInSecond() {
        Debug.Log("is calling callback");
        // yield return new WaitForSeconds(seconds);
        // callback();

        yield return new WaitForSeconds(_waitTime);
        _theCallback();
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
