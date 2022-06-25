using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField]public DeleteObject _item1;
    [SerializeField] public DeleteObject _item2;
    
    //public DeleteObject target;
    private AudioSource _a;
    [Header("��")]
    [SerializeField]private AudioClip _audio;

    // Start is called before the first frame update
    void Start()
    {
        _a = GetComponent<AudioSource>();
    }

    void OnEnable()
    {
        _item1.OnDestroyed.AddListener(() =>
        {
            //Debug.Log("�Ԃ���܂���");
            // �����ɏ�����ǉ�
            _a.PlayOneShot(_audio);
        });
        _item2.OnDestroyed.AddListener(() =>
        {
            _a.PlayOneShot(_audio);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
