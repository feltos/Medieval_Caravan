using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownsManager : MonoBehaviour
{
    Vector3 baseScale;
    Vector3 highlightScale;

    [SerializeField]
    Canvas townInterface;
    [SerializeField]
    GameObject map;
    GameObject player;

	void Start ()
    {
        baseScale = transform.localScale;
        highlightScale = transform.localScale + new Vector3(0.1f, 0.1f, 0.1f);
        player = GameObject.Find("Player");
	}

    private void OnMouseOver()
    {
        transform.localScale = highlightScale;
    }

    private void OnMouseExit()
    {
        transform.localScale = baseScale;
    }

    private void OnMouseDown()
    {
        if(player.transform.parent == gameObject.transform)
        {
            townInterface.gameObject.SetActive(true);
            map.SetActive(false);
        }  
    }
}
