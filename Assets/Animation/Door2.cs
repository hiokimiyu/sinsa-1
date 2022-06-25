using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2 : MonoBehaviour
{
    [SerializeField] private AudioClip _audio;
    private Animator _anime2;
    bool isdoor;
    private AudioSource _a;
    public ItemPic _key;

    // Start is called before the first frame update
    void Start()
    {
        _anime2 = gameObject.GetComponent<Animator>();
        isdoor = false;
        _a = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //GameObject _item2 = GameObject.FindGameObjectWithTag("Item2");
        if (_key.isKey4 == true && isdoor == false)
        {
            _anime2.SetBool("door2", true);
            isdoor = true;
            _a.PlayOneShot(_audio);
        }
    }
}
