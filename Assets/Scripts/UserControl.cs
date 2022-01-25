using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserControl : MonoBehaviour
{
    public Camera GameCamera;

    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            HandleSelection();
        }
    }

    private void HandleSelection() {
        var ray = GameCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit)) {
            //the collider could be children of the unit, so we make sure to check in the parent
            var shape = hit.collider.GetComponentInParent<Shape>();
            shape.Displaytext();
        }
    }
}
