﻿using UnityEngine;
using System.Collections;

namespace WhaleForge.ForgeTools
{
    //It is common to create a class to contain all of your
    //extension methods. This class must be static.
    public static class ExtensionMethods
    {
        //Even though they are used like normal methods, extension
        //methods must be declared static. Notice that the first
        //parameter has the 'this' keyword followed by a Transform
        //variable. This variable denotes which class the extension
        //method becomes a part of.
        public static void ResetTransformation(this Transform trans, Space space)
        {
            switch (space)
            {
                case Space.World:
                    trans.position = Vector3.zero;
                    trans.rotation = Quaternion.identity;
                    trans.localScale = new Vector3(1, 1, 1);
                    break;
                case Space.Self:
                    trans.localPosition = Vector3.zero;
                    trans.localRotation = Quaternion.identity;
                    trans.localScale = new Vector3(1, 1, 1);
                    break;
                default:
                    break;
            }
        }
    }
}