using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundCamera : MonoBehaviour
{
        /// <summary>
        /// Movement of the layer is scaled by this value.
        /// </summary>
        public Vector3 movementScale = Vector3.one;

        Transform _camera;

        void Awake()
        {
            _camera = Camera.main.transform;
        }

        void LateUpdate()
        {
            transform.position = Vector3.Scale(_camera.position, movementScale);
        }

    }
