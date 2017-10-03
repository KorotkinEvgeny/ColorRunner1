using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Basic.Scripts.WeaponsScripts
{
    abstract class MagicalWeapon : MonoBehaviour, IWeapon
    {
        public Rigidbody bulletPrefab;
        public float damage;
        public float speed;

        public void Shoot()
        {
            if (!bulletPrefab.isKinematic)
            {
                bulletPrefab.isKinematic = true;
            }
            //TOD: add some logic for shooting with rigidbody withoout using the Gravity
            //bulletPrefab = Instantiate(bulletPrefab, gunEnd.position, gunEnd.rotation);
            //bulletPrefab.AddForce(gunEnd.forward * forcePower);

            PlayAnimation();
        }

        protected abstract void PlayAnimation();
    }
}