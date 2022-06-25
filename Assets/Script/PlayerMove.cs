using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove: MonoBehaviour
{
    [Header("Playerのスピード")]
    public float _speed = 3f;
    [Header("カメラスピード")]
    public float _s = 3f;
    [SerializeField] private Vector3 velocity;
    public Rigidbody _rb;
    [Header("アイテム")] public GameObject _i;
    public Text _t;
    [SerializeField] private int _n = 15;

    //private Transform P_t;
    //private Transform C_t;
    //[Header("カメラ")]
    //public GameObject _c;
    //[Header("アイテム")]
    //public GameObject _item;

    // Start is called before the first frame update
    void Start()
    {
        //P_t = GetComponent<Transform>();
        //C_t = GetComponent<Transform>();
        _t.GetComponent<UnityEngine.UI.Text>().text = $"のこり{_n}";
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        float xRot = Input.GetAxis("Mouse X") * _s;
        transform.Rotate(0, xRot, 0);

        //float yRot = Input.GetAxis("Mouse Y") * _s;
        /*float inputH = Input.GetAxis("Mouse X");
        float inputV = Input.GetAxis("Mouse Y");

        // 軸入力に応じて回転角度を計算
        float angleH = inputH * 45.0f;
        float angleV = inputV * -30.0f;

        // 上下方向（X軸）と水平方向（Y軸）の回転角度を指定して回転を作成して適用
        transform.localRotation = Quaternion.Euler(angleV, angleH, 0.0f);*/

        velocity = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            velocity = transform.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            velocity = -transform.right;
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocity = -transform.forward;
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocity = transform.right;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_n > 0)
            {
                _n--;
                _rb = Instantiate(_i, transform.position, transform.rotation).GetComponent<Rigidbody>();
                _t.text = $"のこり{_n}";
            }
            else if (_n == 0)
            {
                _t.text = $"のこり{_n}";
            }
            
        }
        

        //速度ベクトルの長さを一秒で＿h進むように
        velocity = velocity.normalized * _speed * Time.deltaTime;

        //いずれかの方向に移動して時
        if (velocity.magnitude > 0)
        {
            transform.position += velocity;
        }
    }
}
