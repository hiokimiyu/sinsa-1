using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer2 : MonoBehaviour
{
    private Animator _drawer;
    [SerializeField] private Camera _c;
    bool isDrawer = false;

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
                if (hit.collider.CompareTag("Drawer2"))
                {
                    _drawer = hit.collider.GetComponent<Animator>();
                    if (Input.GetKeyDown(KeyCode.E) && isDrawer)
                    {
                        _drawer.SetBool("Drawer1", isDrawer = false);
                        isDrawer = false;
                    }
                    else if (Input.GetKeyDown(KeyCode.E) && isDrawer == false)
                    {
                        _drawer.SetBool("Drawer1", isDrawer = true);
                        isDrawer = true;
                    }
                }
            }
        }
    }
}
