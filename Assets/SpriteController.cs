using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SpriteController : MonoBehaviour, IDragHandler, IEndDragHandler, IPointerClickHandler
{
    public float firstHight;
    public float dropHight;
    private Vector3 inputPosition;
    private Vector3 pos;

    public bool isControlled;
    public bool isDraged;

    // Start is called before the first frame update
    void Start()
    {   
        isControlled = true;
        isDraged = false;
        pos = transform.position;
        pos.y = firstHight;
        transform.position = pos;
        gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
    }

    // Update is called once per frame
    void Update()
    {   
        if(transform.position.y < -20)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Failed", LoadSceneMode.Single);
        }
    }

    public void OnDrag(PointerEventData data)
    {
        if(isControlled)
        {
            isDraged = true;
            transform.position = pos;
            inputPosition = Input.mousePosition;
            pos.x = Camera.main.ScreenToWorldPoint(inputPosition).x;
            transform.position = pos;
        }
    }
    public void OnEndDrag(PointerEventData data)
    {
        if(isControlled)
        {
            pos = transform.position;
            pos.y = dropHight;
            transform.position = pos;
            gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            isControlled = false;
        }
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if(isControlled && !isDraged)
        {
            Transform myTransform = this.transform;

            Vector3 worldAngle = myTransform.eulerAngles;
            worldAngle.z += 60.0f;
            myTransform.eulerAngles = worldAngle;
        }
    }

    
}
