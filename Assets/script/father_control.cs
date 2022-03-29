using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class father_control : MonoBehaviour, ISayable
{
    // Start is called before the first frame update
    
    public void playSaySound()
    {
        // AudioSource source = this.transform.Find("SaySound").GetComponent<AudioSource>();
        AudioSource source = this.transform.parent.Find("SaySound").GetComponent<AudioSource>();
        source.Stop();
        
        source.Play();
        source.time = 5.0f;
    }

}
