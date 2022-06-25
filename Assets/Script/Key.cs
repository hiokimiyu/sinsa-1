using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public ItemPic _i;
    private MeshRenderer _key;
    bool isf;
    private AudioSource _a;
    [SerializeField] private AudioClip _audio;

    // Start is called before the first frame update
    void Start()
    {
        _key = GetComponent<MeshRenderer>();
        isf = false;
        _a = GetComponent<AudioSource>();
        _key.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(_i.isKey4 == true && isf == false)
        {
            _key.enabled = true;
            isf = true;
            _a.PlayOneShot(_audio);
        }
    }
}
