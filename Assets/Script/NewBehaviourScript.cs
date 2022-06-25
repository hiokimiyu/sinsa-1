using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [Header("ÉJÉÅÉâ")]
    public Transform C_t;
    [Header("ä¥ìx")]
    public float _sp = 3f;
    //float mini_x, max_x;

    // Start is called before the first frame update
    void Start()
    {
        //P_t = GetComponent<Transform>();
        C_t = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float x_ca = Input.GetAxis("Mouse X");
        float y_ca = Input.GetAxis("Mouse Y");
        C_t.transform.localRotation = Quaternion.Euler(-y_ca, x_ca, 0);

    }
    /*public Quaternion QlampRotation (Quaternion q)
    {
        q.x /= q.w;
        q.y /= q.w;
        q.z /= q.w;
        q.w = 1f;

        float angle_x = Mathf.Atan(q.x) * Mathf.Rad2Deg * 2f;
        angle_x = Mathf.Clamp(angle_x, mini_x, max_x);
        q.x = Mathf.Tan(angle_x * Mathf.Deg2Rad * 0.5f);

        return q;
    }*/
}
