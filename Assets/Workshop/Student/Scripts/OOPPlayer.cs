using UnityEngine;
using UnityEngine.InputSystem;

public class OOPPlayer : Character
{

    private InputAction moveAction;

    public void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
            PrintInfo();
    }

     public void Update()
        {
            Vector2 direction = moveAction.ReadValue<Vector2>();
            
            // if we call Move() here, it will be called every frame, 
            // which is not what we want. We want to call Move() only when the moveAction is triggered.
            // Move(direction); 
            
            if (moveAction.triggered)
            {
                Move(direction);
            }
        }

}
