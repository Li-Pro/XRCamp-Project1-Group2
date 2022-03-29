using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainModel : MonoBehaviour
{
    public static MainModel theModel { get; private set; } = null;

    // main controller
    private static MainController mainController;

    public delegate void Callback();

    private UnityEngine.InputSystem.InputActionAsset defaultPlayerAction = null;

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

    //private Callback _theCallback;
    //private float _waitTime;
    
    //private void SetPlayerLock(bool enabled)
    //{
    //    //mainController.playerObj.SetActive(enabled);

    //    //mainController.playerObj.GetComponent<BNG.VREmulator>().EmulatorEnabled = enabled;

    //    mainController.playerObj.GetComponent<BNG.VREmulator>().EmulatorActionSet = (enabled ? defaultPlayerAction : null);
    //}
    
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

        mainController.SetPlayerLock(false);

        //_startCoroutine(callback, 2.0f);
        //StartCoroutine(callbackInSecond(callback, 2.0f));
        StartCoroutine(callBackAfterIndexClick(() => {
            mainController.SetPlayerLock(true);
            callback();
        }));
    }

    //private void _startCoroutine(Callback callback, float seconds) {
    //    //_theCallback = callback;
    //    //_waitTime = seconds;
    //    //StartCoroutine("callbackInSecond");

    //    StartCoroutine(callbackInSecond(callback, seconds));
    //}

    private IEnumerator callBackAfterIndexClick(Callback callback)
    {
        // need implementation
        //return callbackInSecond(callback, 2.0f);

        yield return new WaitUntil(() => {
            return Input.GetButtonDown("Oculus_GearVR_LIndexTrigger")
                || Input.GetButtonDown("Oculus_GearVR_RIndexTrigger")
                || /* for debug */ Input.GetButtonDown("Jump");
        });

        Debug.Log("Hello?");

        yield return new WaitForFixedUpdate();
        callback();
    }

    private IEnumerator callbackInSecond(Callback callback, float waitTime) {
        Debug.Log("is calling callback");
        // yield return new WaitForSeconds(seconds);
        // callback();

        //yield return new WaitForSeconds(_waitTime);
        //_theCallback();

        yield return new WaitForSeconds(waitTime);
        callback();
    }

    void Start()
    {
        Debug.Assert(theModel == null, "There should be only one MainModel.");
        theModel = this;

        mainController = GameObject.Find("MainController").GetComponent<MainController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(string.Format("button: {0} {1} {2}", Input.GetButton("space"), Input.GetButton("Oculus_CrossPlatform_PrimaryIndexTrigger"), Input.GetButton("Oculus_CrossPlatform_SecondaryIndexTrigger")));
        //Debug.Log(string.Format("axis: {0} {1} {2}", Input.GetAxis("Jump"), Input.GetAxis("Oculus_CrossPlatform_PrimaryIndexTrigger"), Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger")));
        //Debug.Log(string.Format("Button: {0} {1} {2}", Input.GetButton("Jump"), Input.GetAxis("Oculus_CrossPlatform_PrimaryIndexTrigger"), Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger")));
    }
}


