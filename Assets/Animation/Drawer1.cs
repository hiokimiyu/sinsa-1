using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer1 : MonoBehaviour
{
    private Animator _drawer;
    [SerializeField]private AudioSource _a;
    [SerializeField] private AudioClip _ac;
    [SerializeField] private Camera _c;

    bool isDrawer1 = false;
    bool isDrawer2 = false;
    bool isDrawer3 = false;
    bool isDrawer4 = false;
    bool isDrawer5 = false;
    bool isDrawer6 = false;
    bool isDrawer7 = false;
    bool isDrawer8 = false;
    bool isDrawer9 = false;

    //GameObject _name;

    // Start is called before the first frame update
    void Start()
    {
        //_drawer = GetComponent<Animator>();
        //_name = GameObject.Find("Drawer1");
        _a = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_c)
        {
            RaycastHit hit;
            if (Physics.Raycast(_c.ViewportPointToRay(new Vector2(0.5f, 0.5f)), out hit, 7.0f))
            {
                if (hit.collider.CompareTag("Drawer"))
                {
                    _drawer = hit.collider.GetComponent<Animator>();
                    if (Input.GetKeyDown(KeyCode.E) && isDrawer1)
                    {
                        _drawer.SetBool("Drawer1", false);
                        isDrawer1 = false;
                        _a.PlayOneShot(_ac);
                    }
                    else if (Input.GetKeyDown(KeyCode.E) && isDrawer1 == false)
                    {
                        _drawer.SetBool("Drawer1", true);
                        isDrawer1 = true;
                        _a.PlayOneShot(_ac);
                    }
                }


                //2
                if (hit.collider.CompareTag("Drawer2"))
                {
                    _drawer = hit.collider.GetComponent<Animator>();
                    if (Input.GetKeyDown(KeyCode.E) && isDrawer2)
                    {
                        _drawer.SetBool("Drawer1", isDrawer2 = false);
                        isDrawer2 = false;
                        _a.PlayOneShot(_ac);
                    }
                    else if (Input.GetKeyDown(KeyCode.E) && isDrawer2 == false)
                    {
                        _drawer.SetBool("Drawer1", isDrawer2 = true);
                        isDrawer2 = true;
                        _a.PlayOneShot(_ac);
                    }
                }
                if (hit.collider.CompareTag("Drawer3"))
                {
                    _drawer = hit.collider.GetComponent<Animator>();
                    if (Input.GetKeyDown(KeyCode.E) && isDrawer3)
                    {
                        _drawer.SetBool("Drawer1", isDrawer3 = false);
                        isDrawer3 = false;
                        _a.PlayOneShot(_ac);
                    }
                    else if (Input.GetKeyDown(KeyCode.E) && isDrawer3 == false)
                    {
                        _drawer.SetBool("Drawer1", isDrawer3 = true);
                        isDrawer3 = true;
                        _a.PlayOneShot(_ac);
                    }
                }
                if (hit.collider.CompareTag("Drawer4"))
                {
                    _drawer = hit.collider.GetComponent<Animator>();
                    if (Input.GetKeyDown(KeyCode.E) && isDrawer4)
                    {
                        _drawer.SetBool("Drawer1", isDrawer4 = false);
                        isDrawer4 = false;
                        _a.PlayOneShot(_ac);
                    }
                    else if (Input.GetKeyDown(KeyCode.E) && isDrawer4 == false)
                    {
                        _drawer.SetBool("Drawer1", isDrawer4 = true);
                        isDrawer4 = true;
                        _a.PlayOneShot(_ac);
                    }
                }
                if (hit.collider.CompareTag("Drawer5"))
                {
                    _drawer = hit.collider.GetComponent<Animator>();
                    if (Input.GetKeyDown(KeyCode.E) && isDrawer5)
                    {
                        _drawer.SetBool("Drawer1", isDrawer5 = false);
                        isDrawer5 = false;
                        _a.PlayOneShot(_ac);
                    }
                    else if (Input.GetKeyDown(KeyCode.E) && isDrawer5 == false)
                    {
                        _drawer.SetBool("Drawer1", isDrawer5 = true);
                        isDrawer5 = true;
                        _a.PlayOneShot(_ac);
                    }
                }
                if (hit.collider.CompareTag("Drawer6"))
                {
                    _drawer = hit.collider.GetComponent<Animator>();
                    if (Input.GetKeyDown(KeyCode.E) && isDrawer6)
                    {
                        _drawer.SetBool("Drawer1", isDrawer6 = false);
                        isDrawer6 = false;
                        _a.PlayOneShot(_ac);
                    }
                    else if (Input.GetKeyDown(KeyCode.E) && isDrawer6 == false)
                    {
                        _drawer.SetBool("Drawer1", isDrawer6 = true);
                        isDrawer6 = true;
                        _a.PlayOneShot(_ac);
                    }
                }
                if (hit.collider.CompareTag("Drawer7"))
                {
                    _drawer = hit.collider.GetComponent<Animator>();
                    if (Input.GetKeyDown(KeyCode.E) && isDrawer7)
                    {
                        _drawer.SetBool("Drawer1", isDrawer7 = false);
                        isDrawer7 = false;
                        _a.PlayOneShot(_ac);
                    }
                    else if (Input.GetKeyDown(KeyCode.E) && isDrawer7 == false)
                    {
                        _drawer.SetBool("Drawer1", isDrawer7 = true);
                        isDrawer7 = true;
                        _a.PlayOneShot(_ac);
                    }
                }
                if (hit.collider.CompareTag("Drawer8"))
                {
                    _drawer = hit.collider.GetComponent<Animator>();
                    if (Input.GetKeyDown(KeyCode.E) && isDrawer8)
                    {
                        _drawer.SetBool("Drawer1", isDrawer8 = false);
                        isDrawer8 = false;
                        _a.PlayOneShot(_ac);
                    }
                    else if (Input.GetKeyDown(KeyCode.E) && isDrawer8 == false)
                    {
                        _drawer.SetBool("Drawer1", isDrawer8 = true);
                        isDrawer8 = true;
                        _a.PlayOneShot(_ac);
                    }
                }
                if (hit.collider.CompareTag("Drawer9"))
                {
                    _drawer = hit.collider.GetComponent<Animator>();
                    if (Input.GetKeyDown(KeyCode.E) && isDrawer9)
                    {
                        _drawer.SetBool("Drawer1", isDrawer9 = false);
                        isDrawer9 = false;
                        _a.PlayOneShot(_ac);
                    }
                    else if (Input.GetKeyDown(KeyCode.E) && isDrawer9 == false)
                    {
                        _drawer.SetBool("Drawer1", isDrawer9 = true);
                        isDrawer9 = true;
                        _a.PlayOneShot(_ac);
                    }
                }
            }
        }
    }
}
