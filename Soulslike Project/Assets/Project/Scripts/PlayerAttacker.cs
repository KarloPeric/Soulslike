using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KP
{
    public class PlayerAttacker : MonoBehaviour
    {
        AnimatorHandler animatorHandler;
        InputHandler inputHandler;

        public string lastAttack;

        private void Start()
        {
            animatorHandler = GetComponentInChildren<AnimatorHandler>();
            inputHandler = GetComponent<InputHandler>();
        }

        public void HandleWeaponCombo(WeaponItem weapon)
        {
            if (inputHandler.comboFlag)
            {
                animatorHandler.anim.SetBool("canDoCombo", false);

                if (lastAttack == weapon.OH_LightAttack1)
                {
                    if (inputHandler.rb_Input)
                    {
                        animatorHandler.PlayTargetAnimation(weapon.OH_LightAttack2, true);
                    }
                }
                else if (lastAttack == weapon.OH_HeavyAttack1)
                {
                    if (inputHandler.rt_Input)
                    {
                        animatorHandler.PlayTargetAnimation(weapon.OH_HeavyAttack2, true);
                    }
                }
            }
        }

        public void HandleLightAttack(WeaponItem weapon)
        {
            animatorHandler.PlayTargetAnimation(weapon.OH_LightAttack1, true);
            lastAttack = weapon.OH_LightAttack1;
        }

        public void HandleHeavyAttack(WeaponItem weapon)
        {
            animatorHandler.PlayTargetAnimation(weapon.OH_HeavyAttack1, true);
            lastAttack = weapon.OH_HeavyAttack1;
        }
    }
}
