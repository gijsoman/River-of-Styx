using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct TriangleData
{
    //The corners ot this triangle in global coordinates
    public Vector3 P1;
    public Vector3 P2;
    public Vector3 P3;

    //The center of the triangle
    public Vector3 Center;

    //The distance to the surface from the center of the triangle
    public float DistanceToSurface;

    //The normal to the triganle
    public Vector3 Normal;

    //The area of the triangle
    public float Area;

    public TriangleData(Vector3 _P1, Vector3 _P2, Vector3 _P3)
    {
        P1 = _P1;
        P2 = _P2;
        P3 = _P3;

        //Set the center of the triangle
        Center = (_P1 + _P2 + _P3) / 3f;

        //Distance to the surface from the center of the triangle
        DistanceToSurface = Mathf.Abs(WaterController.current.DistanceToWater(this.Center, Time.time));

        //normal to the triangle
        Normal = Vector3.Cross(_P2 - _P1, _P3 - _P1).normalized;

        //Area of the triangle
        float a = Vector3.Distance(_P1, _P2);
        float C = Vector3.Distance(_P3, _P1);
        Area = (a * C * Mathf.Sin(Vector3.Angle(_P2 - _P1, _P3 - P1) * Mathf.Deg2Rad)) / 2f;        
    }
}
