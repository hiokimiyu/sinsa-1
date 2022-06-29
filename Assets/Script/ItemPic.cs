using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemPic : MonoBehaviour
{
    [SerializeField] private Camera _c;
    [SerializeField] private Image _se;
    [SerializeField] private GameObject _item1;
    [SerializeField] private AudioClip _audio;
    [SerializeField] private AudioClip _aKey;
    private AudioSource _a;
    [SerializeField] Button _button;
    bool isF1;
    bool isF2;
    bool isF3;
    bool isF4;
    bool isC;
    public bool isKey1;
    public bool isKey2;
    public bool isKey3;
    public bool isKey4;
    [SerializeField] private Text _t1;
    [SerializeField] private GameObject _en;
    [SerializeField]private Text _t2;
    [SerializeField] private Text _t3;
    [SerializeField] private Text _t4;
    int _iC = 2;
    int _iC1 = 3;

    // Start is called before the first frame update
    void Start()
    {
        isF1 = false;
        isF2 = false;
        isF3 = false;
        isF4 = false;
        isKey1 = false;
        isKey2 = false;
        isKey3 = false;
        isKey4 = false;

        _a = GetComponent<AudioSource>();
        _t1.GetComponent<UnityEngine.UI.Text>().enabled = false;
        _en.SetActive(false);
        _t2.text = $"あと{_iC}つ";
        _t3.enabled = false;
        _t4.enabled = false;
        isC = false;
        //isK = false;

    }


    void Text1()
    {
        _t1.enabled = false;
    }
    void Text3()
    {
        _t1.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject _item1 = GameObject.FindGameObjectWithTag("Item1");
        if (_item1 == null && isF1 == false)
        {
            isF1 = true;
        }
        GameObject _item2 = GameObject.FindGameObjectWithTag("item");
        if(_item2 == null && isF2 == false)
        {
            isF2 = true;
        }
        GameObject _item3 = GameObject.FindGameObjectWithTag("Item3");
        if (_item3 == null && isF3 == false)
        {
            isF3 = true;
            _en.gameObject.SetActive(true);
            _t1.enabled = true;
            _t1.text = $"最初の所に戻れ";
            Invoke("Text3", 1f);
        }
        //GameObject _key = GameObject.FindGameObjectWithTag("Key");
        if (_button.Key == true && isF4 == false)
        {
            isF4 = true;
        }
        if (_c)
        {
            RaycastHit hit;//RAYが当たったオブジェクトの情報が格納さる

            //RAYが当たっていれば
            if (Physics.Raycast(_c.ViewportPointToRay(new Vector2(0.5f, 0.5f)), out hit, 10.0f))
            {
                if(hit.collider.CompareTag("Vase1") || hit.collider.CompareTag("Vase2") || hit.collider.CompareTag("Vase3") || hit.collider.CompareTag("Vase4"))
                {
                    _t4.enabled = true;
                    _t4.text = $"調べる";
                }
                if(hit.collider.CompareTag("Vase1") && isF1 == true)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        isKey1 = true;
                    }
                }
                else if(hit.collider.CompareTag("Vase1") && isF1 == false && Input.GetKeyDown(KeyCode.E))
                {
                    _t1.enabled = true;
                    _t1.GetComponent<UnityEngine.UI.Text>().text = $"花が足りない";
                    Invoke("Text1", 2f);
                }
                if(hit.collider.CompareTag("Vase2") && isF2 == true)
                {
                    if(Input.GetKeyDown(KeyCode.E))
                    {
                        isKey2 = true;
                    }
                }
                else if (hit.collider.CompareTag("Vase2") && isF2 == false && Input.GetKeyDown(KeyCode.E))
                {
                    _t1.enabled = true;
                    _t1.GetComponent<UnityEngine.UI.Text>().text = $"花が足りない";
                    Invoke("Text1", 2f);
                }
                if (hit.collider.CompareTag("Vase3") && isF3 == true)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        isKey3 = true;
                    }
                }
                if (hit.collider.CompareTag("Vase4") && isF4 == true)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        isKey4 = true;
                    }
                }
                else if (hit.collider.CompareTag("Vase4") && isF4 == false && Input.GetKeyDown(KeyCode.E))
                {
                    _t1.enabled = true;
                    _t1.GetComponent<UnityEngine.UI.Text>().text = $"鍵がない";
                    Invoke("Text1", 2f);
                }

                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (hit.collider.CompareTag("Item1"))
                    {
                        _iC--;
                        _t2.text = $"あと{_iC}つ";
                    }
                    if(_iC == 0)
                    {
                        _t2.enabled = false;
                    }
                    if(isKey1 == true && isC == false)
                    {
                        _t3.enabled = true;
                        _t3.text = $"あと{_iC1}つ";
                        isC = true;
                    }
                    if (hit.collider.CompareTag("item"))
                    {
                        _iC1--;
                        _t3.text = $"あと{_iC1}つ";
                    }
                    if(_iC1 == 0)
                    {
                        _t3.enabled = false;
                    }
                }
                if (hit.collider.CompareTag("item")||hit.collider.CompareTag("Item1") || hit.collider.CompareTag("Item2") || hit.collider.CompareTag("Item3"))
                {
                    if (Physics.Raycast(_c.ViewportPointToRay(new Vector2(0.5f, 0.5f)), out hit, 5.0f))
                    {
                        _t4.enabled = true;
                        _t4.text = $"調べる「E」";

                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Destroy(hit.collider.gameObject);
                            _a.PlayOneShot(_audio);
                        }
                    }   
                }
                else if (hit.collider.CompareTag("Key"))
                {
                    if (Physics.Raycast(_c.ViewportPointToRay(new Vector2(0.5f, 0.5f)), out hit, 5.0f))
                    {
                        _t4.enabled = true;
                        _t4.text = $"調べる「E」";

                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Destroy(hit.collider.gameObject);
                            _a.PlayOneShot(_aKey);
                        }
                    }
                }
                else
                {
                    _t4.enabled = false;
                }
            }
       /* Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 10.0f))
        {
            Debug.Log(hit.collider.gameObject.transform.position);
        }*/


        }
    }
}
