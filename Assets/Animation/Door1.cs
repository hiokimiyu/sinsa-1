using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1 : MonoBehaviour
{
    private Animator _anime;
    bool isDoor1;
    [SerializeField]private AudioClip _d;
    private AudioSource _a;
    public ItemPic _key;

    // Start is called before the first frame update
    void Start()
    {
        _a = GetComponent<AudioSource>();
        _anime = GetComponent<Animator>();
        isDoor1 = false;
    }

    void Door()
    {
        _a.PlayOneShot(_d);
    }


    // Update is called once per frame
    void Update()
    {
        //GameObject _item1 = GameObject.FindGameObjectWithTag("Item1");
        if (_key.isKey1 == true && isDoor1 == false)
        {
            _anime.SetBool("door1", true);
            Invoke("Door", 0.5f);
            isDoor1 = true;
        }
    }
}
