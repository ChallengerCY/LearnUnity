﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class._Vector3.Script
{


    public class Vector3OrthoNormalize : MonoBehaviour
    {
        // The axis and amount of scaling.
        public Vector3 stretchAxis;
        public float stretchFactor = 1.0F;

        // MeshFilter component and arrays for the original and transformed vertices.
        private MeshFilter mf;
        private Vector3[] origVerts;
        private Vector3[] newVerts;

        // Our new basis vectors.
        private Vector3 basisA;
        private Vector3 basisB;
        private Vector3 basisC;

        void Start()
        {
            // Get the Mesh Filter, then make a copy of the original vertices
            // and a new array to calculate the transformed vertices.
            mf = GetComponent<MeshFilter>();
            origVerts = mf.mesh.vertices;
            newVerts = new Vector3[origVerts.Length];
        }

        void Update()
        {
            // BasisA is just the specified axis for stretching - the
            // other two are just arbitrary axes generated by OrthoNormalize.
            basisA = stretchAxis;
            Vector3.OrthoNormalize(ref basisA, ref basisB, ref basisC);

            // Copy the three new basis vectors into the rows of a matrix
            // (since it is actually a 4x4 matrix, the bottom right corner
            // should also be set to 1).
            Matrix4x4 toNewSpace = new Matrix4x4();
            toNewSpace.SetRow(0, basisA);
            toNewSpace.SetRow(1, basisB);
            toNewSpace.SetRow(2, basisC);
            toNewSpace[3, 3] = 1.0F;

            // The scale values are just the diagonal entries of the scale
            // matrix. The vertices should be stretched along the first axis
            // and squashed proportionally along the other two.
            Matrix4x4 scale = new Matrix4x4();
            scale[0, 0] = stretchFactor;
            scale[1, 1] = 1.0F / stretchFactor;
            scale[2, 2] = 1.0F / stretchFactor;
            scale[3, 3] = 1.0F;

            // The inverse of the first matrix transforms the vertices back to
            // the original XYZ coordinate space(transpose is the same as inverse
            // for an orthogonal matrix, which this is).
            Matrix4x4 fromNewSpace = toNewSpace.transpose;

            // The three matrices can now be combined into a single symmetric matrix.
            Matrix4x4 trans = toNewSpace * scale * fromNewSpace;

            // Transform each of the mesh's vertices by the symmetric matrix.
            int i = 0;
            while (i < origVerts.Length)
            {
                newVerts[i] = trans.MultiplyPoint3x4(origVerts[i]);
                i++;
            }

            // ...and finally, update the mesh with the new vertex array.
            mf.mesh.vertices = newVerts;
        }
    }
}
