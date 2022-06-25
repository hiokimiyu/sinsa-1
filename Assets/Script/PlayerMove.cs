using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove: MonoBehaviour
{
    [Header("Player�̃X�s�[�h")]
    public float _speed = 3f;
    [Header("�J�����X�s�[�h")]
    public float _s = 3f;
    [SerializeField] private Vector3 velocity;
    public Rigidbody _rb;
    [Header("�A�C�e��")] public GameObject _i;
    public Text _t;
    [SerializeField] private int _n = 15;

    //private Transform P_t;
    //private Transform C_t;
    //[Header("�J����")]
    //public GameObject _c;
    //[Header("�A�C�e��")]
    //public GameObject _item;

    // Start is called before the first frame update
    void Start()
    {
        //P_t = GetComponent<Transform>();
        //C_t = GetComponent<Transform>();
        _t.GetComponent<UnityEngine.UI.Text>().text = $"�̂���{_n}";
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

        // �����͂ɉ����ĉ�]�p�x���v�Z
        float angleH = inputH * 45.0f;
        float angleV = inputV * -30.0f;

        // �㉺�����iX���j�Ɛ��������iY���j�̉�]�p�x���w�肵�ĉ�]���쐬���ēK�p
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
                _t.text = $"�̂���{_n}";
            }
            else if (_n == 0)
            {
                _t.text = $"�̂���{_n}";
            }
            
        }
        

        //���x�x�N�g���̒�������b�ŁQh�i�ނ悤��
        velocity = velocity.normalized * _speed * Time.deltaTime;

        //�����ꂩ�̕����Ɉړ����Ď�
        if (velocity.magnitude > 0)
        {
            transform.position += velocity;
        }
    }
}
