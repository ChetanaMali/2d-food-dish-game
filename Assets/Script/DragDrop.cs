using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragDrop : MonoBehaviour , IDragHandler
{
    int vegcount;
    
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Pot")
        {
            GameManager.Instance.scorincrease();
            Destroy(gameObject);
         }
        GameManager.Instance.winGame();

        //if (GameManager.Instance.vegcount == (GameManager.Instance.count - 1))
        //{
        //    UIManeger.Instance.WinGame();
        //}
        
         
         //
        
        
    }

    

}
