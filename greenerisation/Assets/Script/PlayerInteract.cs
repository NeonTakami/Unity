using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerInteract : MonoBehaviour
{
    private Camera cam;
    [SerializeField]
    private float distance = 3f;
    [SerializeField]
    private LayerMask mask;
    private PlayerUI playerUI;
    private Inputmanager inputManager;
    [SerializeField] private float PickupRange;
    [SerializeField] private Transform PickupTarget;
    private Rigidbody CurrentObject;
    [SerializeField] private LayerMask PickupMask;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<PlayerLook>().cam;
        playerUI = GetComponent<PlayerUI>();
        inputManager = GetComponent<Inputmanager>();
    }

    // Update is called once per frame
    void Update()
    {
        playerUI.UpdateText(string.Empty);
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo, distance, mask))
        {
            if (hitInfo.collider.GetComponent<Interactable>() != null)
            {

                Interactable interactable = hitInfo.collider.GetComponent<Interactable>();
                playerUI.UpdateText(interactable.promptMessage);

                if (inputManager.onFoot.Interact.triggered)
                {
                    interactable.BaseInteract();
                }
            }
        }
        if (Physics.Raycast(ray, out hitInfo, distance, PickupMask))
        {
            if (inputManager.onFoot.Interact.triggered)
            {
                if (CurrentObject)
                {
                    CurrentObject.useGravity = true;
                    CurrentObject = null;
                    return;
                }
                if (Physics.Raycast(ray, out hitInfo, distance, PickupMask))
                {
                    CurrentObject = hitInfo.rigidbody;
                    CurrentObject.useGravity = false;
                }
            }
        }
    }
    void FixedUpdate()
    {
        if (CurrentObject)
        {
            Vector3 DirectionToPoint = PickupTarget.position - CurrentObject.position;
            float DistanceToPoint = DirectionToPoint.magnitude;

            CurrentObject.velocity = DirectionToPoint * 12f * DistanceToPoint;
        }
    }
}