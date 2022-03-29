using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISayable
{
    void playSaySound();
}

public class MainModel : MonoBehaviour
{
    public static MainModel theModel { get; private set; } = null;

    // main controller
    private static MainController mainController;

    public delegate void Callback();

    private UnityEngine.InputSystem.InputActionAsset defaultPlayerAction = null;

    public void SetEmptyScene()
    {
        GameObject locationObj = GameObject.Find("location-empty");
        Vector3 location = locationObj.transform.position;
        Quaternion rotation = locationObj.transform.rotation;

        mainController.playerObj.transform.Find("PlayerController").position = location;
        mainController.playerObj.transform.Find("PlayerController").rotation = rotation;
    }
    public void SwitchScene(int id, int from)
    {
        GameObject obj = mainController.LoadScene(id);

        // find the GameObject location-from-<from>
        string locationNode = string.Format("location-from-{0}", from);

        // Debug.Log("switch: " + obj);
        // Debug.Log("switch: " + obj + " " + obj.transform.Find(locationNode));
        Vector3 location = obj.transform.Find(locationNode).position;
        Quaternion rotation = obj.transform.Find(locationNode).rotation;

        // TODO: set rotation
        Debug.Log("Switching player to: location=" + location + ", rotation=" + rotation);
        mainController.playerObj.transform.Find("PlayerController").position = location;
        mainController.playerObj.transform.Find("PlayerController").rotation = rotation;

        mainController.GetSceneBGM(from).Stop();
        mainController.GetSceneBGM(id).Play();
    }

    //private Callback _theCallback;
    //private float _waitTime;
    
    //private void SetPlayerLock(bool enabled)
    //{
    //    //mainController.playerObj.SetActive(enabled);

    //    //mainController.playerObj.GetComponent<BNG.VREmulator>().EmulatorEnabled = enabled;

    //    mainController.playerObj.GetComponent<BNG.VREmulator>().EmulatorActionSet = (enabled ? defaultPlayerAction : null);
    //}
    
    public string splitLineWithWidth(string messageRaw, int width)
    {
        string res = "";
        foreach (string message in messageRaw.Split('\n'))
        {
            for (int i = 0; i < message.Length; i += width)
            {
                int remLen = Math.Min(width, message.Length - i);
                res += message.Substring(i, remLen) + '\n';
            }
        }

        return res;
    }

    public void CreateDialogue(string message_, Callback callback)
    {
        CreateDialogue(message_, callback, null, false);
    }

    public void CreateDialogue(string message_, Callback callback, ISayable target)
    {
        CreateDialogue(message_, callback, target, false);
    }

    public void CreateDialogueOverlay(string message_, Callback callback)
    {
        CreateDialogue(message_, callback, null, true);
    }

    public void CreateDialogue(string message_, Callback callback, ISayable target, bool isOverlay)
    {
        string message = splitLineWithWidth(message_, 15);
        int lineCnt = message.Split('\n').Length;

        // TODO: set text to the retrieved message & mainController.SetDialogueText
        UnityEngine.UI.Text text = mainController.dialogueObj.transform.Find("Text").GetComponent<UnityEngine.UI.Text>();
        text.text = message;

        RectTransform rectTransform = mainController.dialogueObj.transform.Find("Panel").GetComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta[0], /*lineCnt * 60*/ lineCnt*50 + 50);

        // TODO: show it? (how? and how long? / how do we close it?)
        mainController.dialogueObj.SetActive(true);
        // Debug.Log(mainController.dialogueObj);
        // Debug.Assert(mainController.dialogueObj.activeSelf);
        
        Debug.Log("created dialog: " + message);

        // TODO: callback after dialogue is finished (e.g. connect to some source / some onclicked())
        // callbackInSecond(() => {
        //     Debug.Log("is calling callback");
        //     callback();
        // }, 2.0f);

        mainController.SetPlayerMovable(isOverlay);

        if (target != null)
        {
            target.playSaySound();
        }

        //_startCoroutine(callback, 2.0f);
        //StartCoroutine(callbackInSecond(callback, 2.0f));
        StartCoroutine(callBackAfterIndexClick(() => {
            mainController.SetPlayerMovable(true);
            mainController.dialogueObj.SetActive(false);

            // mainController.dialogueObj.GetComponent<AudioSource>().Play();
            GameObject.Find("UISound").GetComponent<AudioSource>().Play();

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

        // Debug.Log("Hello?");

        yield return new WaitForFixedUpdate();
        callback();
    }

    public void CallbackInSecond(Callback callback, float waitTime)
    {
        StartCoroutine(callbackInSecond(callback, waitTime));
    }

    private IEnumerator callbackInSecond(Callback callback, float waitTime) {
        // Debug.Log("is calling callback");
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


