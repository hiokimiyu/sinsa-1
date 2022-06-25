using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    private Animator _anime;
    bool isDoor1;
    [SerializeField] private AudioClip _d;
    private AudioSource _a;
    public ItemPic _key;

    // Start is called before the first frame update
    void Start()
    {
        _anime = gameObject.GetComponent<Animator>();
        isDoor1 = false;
        _a = GetComponent<AudioSource>();
    }

    void Door()
    {
        _a.PlayOneShot(_d);
    }


    // Update is called once per frame
    void Update()
    {
        //GameObject _item = GameObject.FindGameObjectWithTag("item");
        if (_key.isKey2 == true && isDoor1 == false)
        {
            _anime.SetBool("dooropen", true);
            Invoke("Door", 0.5f);
            isDoor1 = true;
        }
    }
}
