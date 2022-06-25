using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DeleteObject : MonoBehaviour
{

    //private AudioSource _a;
    //[SerializeField]private AudioClip _audio;

    void Start()
    {
        //_a = GetComponent<AudioSource>();
        
    }


    public UnityEvent OnDestroyed = new UnityEvent();
    private void OnDestroy()
    {
        //Debug.Log("Destroyed");
        OnDestroyed.Invoke();
        
    }

    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
