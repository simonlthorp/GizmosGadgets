using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class UIButtom : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    //Canvas canvas;
    //public RectTransform rectTransform;

    //public float max_x;
    //public float max_y;
    //public float min_x;
    //public float min_y;

    //private void Awake()
    //{
    //    canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
    //    rectTransform = transform as RectTransform;
    //    Vector2 pos;
    //    if (RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, transform.position, canvas.worldCamera, out pos))
    //    {
    //        Debug.Log(pos);
    //    }
    //    RectTransform rt = GetComponent<RectTransform>();
    //    max_x = rt.anchorMax.x + pos.x;
    //    max_y = rt.anchorMax.y + pos.y;
    //    min_x = rt.anchorMin.x + pos.x;
    //    min_y = rt.anchorMin.y + pos.y;
    //}

    public Material mat;

    public int id;

    public bool select = false;

    public void OnSelected()
    {
        transform.localScale = new Vector3(1.2f, 1.2f, 1);
        mat.SetColor("_Color", new Color(1, 1, 1, 1));
        select = true;
    }

    public void DisSelected()
    {
        transform.localScale = Vector3.one;
        mat.SetColor("_Color", new Color(1, 1, 1, 0));
        select = false;
    }

    /// <summary>
    /// 在这个方法里写按钮按下时的回调
    /// </summary>
    public void OnButtomDown()
    {
        Debug.Log(2333);
        if (id == 0)
        {
            //options
            SceneManager.LoadScene(2);
        }
        else if (id == 1)
        {
            //play
            SceneManager.LoadScene(1);
        }
        else if (id == 2)
        {
            Application.Quit();
            //quit
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        OnSelected();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        DisSelected();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        OnButtomDown();
    }


}
