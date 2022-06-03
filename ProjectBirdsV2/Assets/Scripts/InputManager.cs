using UnityEngine;
using UnityEngine.InputSystem;

[DefaultExecutionOrder(-1)]
public class InputManager : MonoBehaviour
{
    #region Events
    public delegate void StartTouch(Vector2 position, float time);
    public event StartTouch OnStartTouch;
    public delegate void EndTouch(Vector2 position, float time);
    public event EndTouch OnEndTouch;
    #endregion

    private PlayerControls playerControls;
    private Camera mainCamera;

    private void Awake()
    {
        if (playerControls == null)
        {
            playerControls = new PlayerControls();
        }

        mainCamera = Camera.main;
    }

    void Start()
    {
        playerControls.Menu.SwipePrimaryContact.started += ctx => StartTouchPrimary(ctx);
        playerControls.Menu.SwipePrimaryContact.canceled += ctx => EndTouchPrimary(ctx);
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    public Vector3 ScreenToWorld(Camera camera, Vector3 position)
    {
        position.z = camera.nearClipPlane;
        return camera.ScreenToWorldPoint(position);
    }

    private void StartTouchPrimary(InputAction.CallbackContext context)
    {
        if (OnStartTouch != null) OnStartTouch(ScreenToWorld(mainCamera, playerControls.Menu.SwipePrimaryPosition.ReadValue<Vector2>()), (float)context.startTime);
    }

    private void EndTouchPrimary(InputAction.CallbackContext context)
    {
        if (OnEndTouch != null) OnEndTouch(ScreenToWorld(mainCamera, playerControls.Menu.SwipePrimaryPosition.ReadValue<Vector2>()), (float)context.time);
    }

    public Vector2 PrimaryPosition()
    {
        return ScreenToWorld(mainCamera, playerControls.Menu.SwipePrimaryPosition.ReadValue<Vector2>());
    }
}
