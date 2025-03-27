using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;
using UnityEngine.EventSystems;


public class shakeItShakeIt : MonoBehaviour ,IPointerEnterHandler,IPointerExitHandler
{

    public Button buton;

    public bool shakeIt;
    public bool updated;
    

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        buton = GetComponent<Button>();
        animator = transform.GetChild(0).GetComponent<Animator>();
    }

    public void Update()
    {
        if (!updated)
        {
            if (shakeIt)
            {
                animator.SetBool("ShakeIt", true);
                animator.SetBool("Idle", false);
            }
            else
            {
                animator.SetBool("ShakeIt", false);
                animator.SetBool("Idle", true);
            }
            updated = true;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        updated = false;
        shakeIt = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        updated = false;
        shakeIt = false;
    }
}
