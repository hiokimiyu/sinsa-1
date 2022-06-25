using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower2 : MonoBehaviour
{
    public ItemPic _i;
    private MeshRenderer _g;
    bool isf;
    private AudioSource _a;
    [SerializeField] private AudioClip _audio;

    // Start is called before the first frame update
    void Start()
    {
        _g = GetComponent<MeshRenderer>();
        _g.enabled = false;
        isf = false;
        _a = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_i.isKey2 == true && isf == false)
        {
            //Debug.Log("deru");
            _g.enabled = true;
            isf = true;
            _a.PlayOneShot(_audio);
        }
    }
}
