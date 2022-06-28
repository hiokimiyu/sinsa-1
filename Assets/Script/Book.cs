using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Book : MonoBehaviour
{
    [SerializeField] private Camera _c;
    [SerializeField] private GameObject _se;
    [SerializeField] private GameObject _br;
    [SerializeField] private GameObject _bg;
    [SerializeField] private GameObject _bb;

    [SerializeField] GameObject _book;
    [SerializeField] GameObject _bookr;
    [SerializeField] GameObject _bookg;
    [SerializeField] GameObject _bookb;
    [Header("open")]
    [SerializeField]private AudioClip _a1;
    [Header("close")]
    [SerializeField]private AudioClip _a2;
    [SerializeField] private Text _t1;

    private bool isSe = false;
    bool isR;
    bool isG;
    bool isB;
    private GameObject _b;
    private AudioSource _a;
    
    // Start is called before the first frame update
    void Start()
    {
        isSe = false;
        _a= GetComponent<AudioSource>();
        isR = false;
        isG = false;
        isB = false;
        _t1.enabled = false;
    }
    void Panel()
    {
        _se.SetActive(true);
        isSe = true;
        Time.timeScale = 0;
        
    }
    void PanelR()
    {
        _br.SetActive(true);
        isR = true;
        Time.timeScale = 0;
        
    }
    void PanelG()
    {
        _bg.SetActive(true);
        isG = true;
        Time.timeScale = 0;
        
    }
    void PanelB()
    {
        _bb.SetActive(true);
        isB = true;
        Time.timeScale = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_c)
        {
            RaycastHit hit;//RAY�����������I�u�W�F�N�g�̏�񂪊i�[����
            if (Physics.Raycast(_c.ViewportPointToRay(new Vector2(0.5f, 0.5f)), out hit, 5.0f))
            {
                if (hit.collider.CompareTag("Book") || hit.collider.CompareTag("BookR") || hit.collider.CompareTag("BookG") || hit.collider.CompareTag("BookB"))
                {
                    _t1.enabled = true;
                    _t1.text = $"�J���uE�v";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        //Debug.Log("Book");
                        //�J����
                        if (isSe == false && hit.collider.CompareTag("Book"))
                        {
                            _a.PlayOneShot(_a1);
                            //Invoke("Panel", 0.8f);
                            _se.SetActive(true);
                            isSe = true;
                            Time.timeScale = 0;
                            _t1.enabled = false;

                        }

                        if (isR == false && hit.collider.CompareTag("BookR"))
                        {
                            _a.PlayOneShot(_a1);
                            //Invoke("PanelR", 0.8f);
                            _br.SetActive(true);
                            isR = true;
                            Time.timeScale = 0;
                            _t1.enabled = false;
                        }


                        if (isG == false && hit.collider.CompareTag("BookG"))
                        {
                            _a.PlayOneShot(_a1);
                            //Invoke("PanelG", 0.8f); 
                            _bg.SetActive(true);
                            isG = true;
                            Time.timeScale = 0;
                            _t1.enabled = false;
                        }


                        if (isB == false && hit.collider.CompareTag("BookB"))
                        {
                            _a.PlayOneShot(_a1);
                            //Invoke("PanelB", 0.8f);
                            _bb.SetActive(true);
                            isB = true;
                            Time.timeScale = 0;
                            _t1.enabled = false;
                        }
                    }
                }
                else
                {
                    _t1.enabled = false;
                }
            }
            if(Input.GetKeyDown(KeyCode.Tab))
            {
                //����
                if (isSe == true)
                {
                    _se.SetActive(false);
                    isSe = false;
                    _a.PlayOneShot(_a2);
                    Time.timeScale = 1;
                    Cursor.visible = false;
                    Cursor.lockState = CursorLockMode.Locked;
                }
                if (isR == true)
                {
                    _br.SetActive(false);
                    isR = false;
                    _a.PlayOneShot(_a2);
                    Time.timeScale = 1;
                    Cursor.visible = false;
                    Cursor.lockState = CursorLockMode.Locked;
                }
                if (isG == true)
                { 
                    _bg.SetActive(false);
                    isG = false;
                    _a.PlayOneShot(_a2);
                    Time.timeScale = 1;
                    Cursor.visible = false;
                    Cursor.lockState = CursorLockMode.Locked;
                }
                if (isB == true)
                {
                    _bb.SetActive(false);
                    isB = false;
                    _a.PlayOneShot(_a2);
                    Time.timeScale = 1;
                    Cursor.visible = false;
                    Cursor.lockState = CursorLockMode.Locked;
                }

            }
        }
    }
}

