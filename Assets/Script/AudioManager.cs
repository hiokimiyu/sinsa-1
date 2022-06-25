using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    bool isEnemy;
    private AudioSource _a;
    [SerializeField] private List<AudioClip> _audio;
    bool isE = false;
    bool isEn;


    // Start is called before the first frame update
    void Start()
    {
        _a = GetComponent<AudioSource>();
        isEnemy = false;
        isEn = false;
        //_f = GetComponent<AudioSource>();
        _a.volume = 0.5f;
        _a.Play();
        isE = false;
        
        
    }


    void Last()
    {
        _a.PlayOneShot(_audio[3], 1.4f);
    }

   

        // Update is called once per frame
        void Update()
    {
        GameObject _e = GameObject.FindGameObjectWithTag("Enemy");
        if (GameObject.FindGameObjectWithTag("Item3") == null && isEnemy == false)
        {
            _a.Stop();
            _a.volume = 1f;
            _a.PlayOneShot(_audio[1]);
            Invoke("Last", 0.5f);
            isEnemy = true;
        }
        else if (_e != null && isEnemy == false && isEn == false && isE == true)
        {
            _a.Stop();
            _a.volume = 1f;
            _a.PlayOneShot(_audio[0]);
            isEn = true;
            isE = false;
        }
        else if (_e == null && isEnemy == false && isE == false)
        {
            _a.Stop();
            isEn = false;
            _a.volume = 0.5f;
            _a.Play();
            isE = true;
        }
    }
}