using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer4 : MonoBehaviour
{
    private Animator _drawer;
    [SerializeField] private Camera _c;
    bool Drawer = false;

    // Start is called before the first frame update
    void Start()
    {
        //_drawer = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_c)
        {
            RaycastHit hit;
            if (Physics.Raycast(_c.ViewportPointToRay(new Vector2(0.5f, 0.5f)), out hit, 7.0f))
            {
                if (hit.collider.CompareTag("Drawer4"))
                {
                    _drawer = hit.collider.GetComponent<Animator>();
                    if (Input.GetKeyDown(KeyCode.E) && Drawer)
                    {
                        _drawer.SetBool("Drawer1", false);
                        Drawer = false;
                    }
                    else if (Input.GetKeyDown(KeyCode.E) && Drawer == false)
                    {
                        _drawer.SetBool("Drawer1", true);
                        Drawer = true;
                    }
                }
            }
        }
    }
}
