using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;
using UnityEngine.EventSystems;


public class GingerBreadByText : MonoBehaviour ,IPointerEnterHandler,IPointerExitHandler
{
    public Button button;
    public GameObject Gingerbred;

    void Start()
    {
        button = GetComponent<Button>();
        Gingerbred.SetActive(false);
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        Gingerbred.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Gingerbred.SetActive(false);
    }
}
