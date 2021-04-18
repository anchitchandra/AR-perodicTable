using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class touch : MonoBehaviour
{
    public GameObject text;
    string btnname;
    
    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Return))
        //{
          //  text.SetActive(true);
       // }
        //if (Input.GetKeyUp(KeyCode.Return))
        //{
          //  text.SetActive(false);
        //}
        if(Input.touchCount> 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                btnname = Hit.transform.name;
                if(btnname == gameObject.name)
                {
                    text.gameObject.SetActive(true);
                }
            }
        }       
    }

}
