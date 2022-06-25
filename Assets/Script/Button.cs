using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private Camera _c;
    [SerializeField] private GameObject _r;
    [SerializeField] private GameObject _b;
    [SerializeField] private GameObject _g;
    [SerializeField] private MeshRenderer _key;
    [SerializeField] private BoxCollider _bc;
    [SerializeField] private AudioClip _audio;
    [SerializeField] private AudioClip _ab;
    private AudioSource _a;
    bool isb1;
    bool isb2;
    bool isb3;
    bool isKey;

    // Start is called before the first frame update
    void Start()
    {
        //_key = GetComponent<MeshRenderer>();
        isb1 = false;
        isb2 = false;
        isb3 = false;
        isKey = false;
        _key.enabled = false;
        _bc.enabled = false;
        _a = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_c)
        {
            RaycastHit hit;//RAYが当たったオブジェクトの情報が格納さる
            if (Physics.Raycast(_c.ViewportPointToRay(new Vector2(0.5f, 0.5f)), out hit, 5.0f))
            {
                if (hit.collider.CompareTag("Button") && Input.GetKeyDown(KeyCode.E))
                {
                    _a.PlayOneShot(_ab);
                    if (hit.collider.gameObject == _r && isb1 == false)
                    {
                        isb1 = true;
                        Debug.Log("aka");
                    }
                    /*else if (hit.collider.gameObject == _r && isb1 == true)
                    {
                        Debug.Log("*");
                        isb1 = false;
                        isb2 = false;
                        isb3 = false;
                    }*/
                    if (hit.collider.gameObject == _g && isb1 == true && isb2 == false)
                    {
                        isb2 = true;
                        Debug.Log("g");
                    }
                    else if (hit.collider.gameObject == _g && isb1 == true && isb2 == true) 
                    {
                        Debug.Log("*");
                        isb1 = false;
                        isb2 = false;
                        isb3 = false;
                    }
                    if (hit.collider.gameObject == _g && isb1 == false)
                    {
                        Debug.Log("*");
                        isb1 = false;
                        isb2 = false;
                        isb3 = false;
                    }
                    if (hit.collider.gameObject == _b && isb1 == true && isb2 == true)
                    {
                        isb3 = true;
                        Debug.Log("b");
                    }
                    if (hit.collider.gameObject == _b && isb1 == true && isb2 == false)
                    {
                        Debug.Log("*");
                        isb1 = false;
                        isb2 = false;
                        isb3 = false;
                    }


                }
            }
        }
        if(isb1 == true && isb2 == true && isb3 == true && isKey == false)
        {
            _key.enabled = true;
            _bc.enabled = true;
            isKey = true;
            _a.PlayOneShot(_audio,1.5f);
        }
    }
}
