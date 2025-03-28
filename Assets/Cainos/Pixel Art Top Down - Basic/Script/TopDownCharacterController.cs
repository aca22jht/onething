﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    public class TopDownCharacterController : MonoBehaviour
    {
        public float speed;

        private Animator animator;

        public bool levelComplete;

        public PuzzleController PuzzleController;

        private void Start()
        {
            Debug.Log("test");
            animator = GetComponent<Animator>();
            levelComplete = false;
            PuzzleController.activePuzzle = false;
        }


        private void Update()
        {
            if (PuzzleController.activePuzzle == false)
            {
                Vector2 dir = Vector2.zero;
                if (Input.GetKey(KeyCode.A))
                {
                    dir.x = -1;
                    animator.SetInteger("Direction", 3);
                }
                else if (Input.GetKey(KeyCode.D))
                {
                    dir.x = 1;
                    animator.SetInteger("Direction", 2);
                }

                if (Input.GetKey(KeyCode.W))
                {
                    dir.y = 1;
                    animator.SetInteger("Direction", 1);
                }
                else if (Input.GetKey(KeyCode.S))
                {
                    dir.y = -1;
                    animator.SetInteger("Direction", 0);
                }

                dir.Normalize();
                animator.SetBool("IsMoving", dir.magnitude > 0);

                GetComponent<Rigidbody2D>().linearVelocity = speed * dir;
            }
            

            //Debug.Log(PuzzleController.activePuzzle);
        }
    }
}
