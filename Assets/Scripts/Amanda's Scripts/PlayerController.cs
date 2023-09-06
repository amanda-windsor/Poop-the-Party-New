using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controllers
{ 

public class PlayerController : MonoBehaviour
{
        Animator anim;
        // Start is called before the first frame update
        void Awake()
        {
            anim = GetComponent<Animator>();
        }

        void ResetAnimation()
        {
            anim.SetBool("isLookUp", false);
            anim.SetBool("isRun", false);
            anim.SetBool("isJump", false);
            anim.SetBool("isAttack", false);
        }
        public void Idle()
        {
            ResetAnimation();
            anim.SetTrigger("idle");
        }
        public void Attack()
        {
            ResetAnimation();
            anim.SetBool("isAttack", true);
        }
        public void TripOver()
        {
            ResetAnimation();
            anim.SetTrigger("tripOver");
        }
        public void Hurt()
        {
            ResetAnimation();
            anim.SetTrigger("hurt");
        }

        public void LookUp()
        {
            ResetAnimation();
            anim.SetBool("isLookUp", true);
        }
        public void Run()
        {
            ResetAnimation();
            anim.SetBool("isRun", true);

        }
        public void Jump()
        {
            ResetAnimation();
            anim.SetBool("isJump", true);

        }
    }
}