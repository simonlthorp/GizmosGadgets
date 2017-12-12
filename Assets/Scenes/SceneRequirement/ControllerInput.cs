using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ControllerInput : MonoBehaviour{

    public UIButtom[] bs;

    int current = 0;

    public LayerMask layer;

    void Start()
    {
        HighlightButton(bs[current]);
        StartCoroutine(UpdateEnumerator());
        for(int i = 0;i< bs.Length; i++)
        {
            bs[i].id = i;
        }
    }

    IEnumerator UpdateEnumerator()
    {
        while (true)
        {
            float offset = Input.GetAxis("Horizontal");
            
            if (Mathf.Abs(offset) > 0.1f)
            {
                if(offset > 0)
                {
                    if (current < (bs.Length - 1))
                    {
                        UnHighlightButton(bs[current]);
                        current++;
                        HighlightButton(bs[current]);
                    }
                    else
                    {
                        UnHighlightButton(bs[current]);
                        current = 0;
                        HighlightButton(bs[current]);
                    }
                }
                else
                {
                    if (current > 0)
                    {
                        UnHighlightButton(bs[current]);
                        current--;
                        HighlightButton(bs[current]);
                    }
                    else
                    {
                        UnHighlightButton(bs[current]);
                        current = bs.Length - 1;
                        HighlightButton(bs[current]);
                    }
                }
                yield return new WaitForSeconds(0.3f);
            }
            else
            {
                yield return new WaitForEndOfFrame();
            }
        }

    }

    UIButtom RayToButtom()
    {
        Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(r, out hitInfo, layer))
        {
            //Debug.DrawLine(r.origin, hitInfo.point);//划出射线，只有在scene视图中才能看到
            GameObject gameObj = hitInfo.collider.gameObject;
            //Debug.Log("click object name is " + gameObj.name);
            return gameObj.GetComponentInParent<UIButtom>();
        }else
        {
            return null;
        }
    }

    Vector3 mousePos = Vector3.zero;

    private void Update()
    {
        if (mousePos != Input.mousePosition)
        {
            mousePos = Input.mousePosition;
               var b = RayToButtom();
            if (b != null)
            {
                bs[current].DisSelected();
                b.OnSelected();
                current = b.id;
            }
            else
            {
                bs[current].DisSelected();
            }
        }
        if (Input.GetButtonDown("Fire1") || Input.GetMouseButtonDown(0))
        {
            if (bs[current].select)
            {
                bs[current].OnButtomDown();
            }
        }
    }

    void OnDisable()
    {
        UnHighlightButton(bs[current]);
    }

    void HighlightButton(UIButtom butt)
    {
        butt.OnSelected();
    }

    void UnHighlightButton(UIButtom butt)
    {
        if (butt == null) return;
        butt.DisSelected();
    }
}
