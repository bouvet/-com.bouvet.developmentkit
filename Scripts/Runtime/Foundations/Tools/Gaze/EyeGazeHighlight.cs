﻿using Bouvet.DevelopmentKit.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bouvet.DevelopmentKit.Tools.Gaze
{
    public class EyeGazeHighlight : MonoBehaviour
    {
        public GameObject objectToToggle;
        protected InputManager inputManager;
        // Start is called before the first frame update
        protected void Start()
        {
            inputManager = InputManager.Instance;
            objectToToggle.SetActive(false);
            inputManager.OnGazeEnter += InputManager_OnGazeEnter;
        }

        protected void InputManager_OnGazeEnter(InputSource obj)
        {
            objectToToggle.SetActive(gameObject.Equals(obj.collidedObject));
        }
    }
}
