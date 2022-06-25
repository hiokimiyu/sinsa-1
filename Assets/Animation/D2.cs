using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D2 : MonoBehaviour
{
    private Animator _a;
    [SerializeField]
    private Camera _c;
    private bool isD = false;
    private AudioSource _au;
    [SerializeField]private AudioClip _audio;

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
                if (hit.collider.CompareTag("D2"))
                {
                    _a = hit.collider.GetComponent<Animator>();
                    if (Input.GetKeyDown(KeyCode.E) && isD)
                    {
                        _a.SetBool("D2", false);
                        isD = false;
                        Invoke("Audio1", 0.7f);
                    }
                    else if (Input.GetKeyDown(KeyCode.E) && isD == false)
                    {
                        _a.SetBool("D2", true);
                        isD = true;
                        Invoke("Audio1", 0.7f);
                    }
                }
            }
        }
    }
}
