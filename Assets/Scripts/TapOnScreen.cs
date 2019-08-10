using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapOnScreen : MonoBehaviour
{
    void Update()
    {
        if ( Input.GetMouseButtonDown(0) ) {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit )){

                Tappable tappable = hit.collider.GetComponent<Tappable>();
                if ( tappable != null) {
                    tappable.OnTapped();
                }
            }
        }
    }
}
