using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KP
{
    [CreateAssetMenu(menuName = "Items/Weapon Item")]
    public class WeaponItem : Item
    {
        public GameObject modelPrefab;
        public bool isUnarmed;

        [Header("Idle Animations")]
        public string rightHand_Idle;
        public string leftHand_Idle;


        [Header("One Handed Attacks Animations")]
        public string OH_LightAttack1;
        public string OH_LightAttack2;
        public string OH_HeavyAttack1;
        public string OH_HeavyAttack2;

    }
}
