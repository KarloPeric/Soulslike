using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KP
{
    public class PlayerManager : MonoBehaviour
    {
        InputHandler inputHandler;
        CameraHandler cameraHandler;
        PlayerLocomotion playerLocomotion;
        Animator anim;

        [Header("Player Flags")]
        public bool isInteracting;
        public bool isSprinting;
        public bool isWalking;
        public bool canDoCombo;

        private void Start()
        {
            inputHandler = GetComponent<InputHandler>();
            cameraHandler = CameraHandler.singleton;
            playerLocomotion = GetComponent<PlayerLocomotion>();
            anim = GetComponentInChildren<Animator>();
        }

        private void Update()
        {
            float delta = Time.deltaTime;

            isInteracting = anim.GetBool("isInteracting");
            canDoCombo = anim.GetBool("canDoCombo");

            inputHandler.TickInput(delta);
            playerLocomotion.HandleMovement(delta);
            playerLocomotion.HandleRollingAndSprinting(delta);
        }

        private void FixedUpdate()
        {
            float delta = Time.fixedDeltaTime;

            if (cameraHandler != null)
            {
                cameraHandler.FollowTarget(delta);
                cameraHandler.HandleCameraRotation(delta, inputHandler.mouseX, inputHandler.mouseY);
            }
        }

        private void LateUpdate()
        {
            isSprinting = inputHandler.b_Input;
            isWalking = inputHandler.walkInput;

            inputHandler.rollFlag = false;
            inputHandler.sprintFlag = false;
            inputHandler.walkFlag = false;
            inputHandler.rb_Input = false;
            inputHandler.rt_Input = false;
            inputHandler.d_Pad_Up = false;
            inputHandler.d_Pad_Down = false;
            inputHandler.d_Pad_Left = false;
            inputHandler.d_Pad_Right = false;
        }
    }
}
