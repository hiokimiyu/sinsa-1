using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D1 : MonoBehaviour
{
    private Animator _drawer;
    [SerializeField] private Camera _c;
    bool isD1 = false;
    private AudioSource _au;
    [SerializeField] private AudioClip _audio;

    //GameObject _name;

    // Start is called before the first frame update
    void Start()
    {
        _au = GetComponent<AudioSource>();
    }

    void Audio1()
    {
        _au.PlayOneShot(_audio);
    }
    // Update is called once per frame
    void Update()
    {
        if (_c)
        {
            RaycastHit hit;
            if (Physics.Raycast(_c.ViewportPointToRay(new Vector2(0.5f, 0.5f)), out hit, 7.0f))
            {
                if (hit.collider.CompareTag("D1"))
                {
                    _drawer = hit.collider.GetComponent<Animator>();
                    if (Input.GetKeyDown(KeyCode.E) && isD1)
                    {
                        _drawer.SetBool("D1", false);
                        isD1 = false;
                        Invoke("Audio1", 0.7f);
                    }
                    else if (Input.GetKeyDown(KeyCode.E) && isD1 == false)
                    {
                        _drawer.SetBool("D1", true);
                        isD1 = true;
                        Invoke("Audio1", 0.7f);
                    }
                }
            }
        }
    }
}
