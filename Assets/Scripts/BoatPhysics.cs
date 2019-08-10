using UnityEngine;

public class BoatPhysics : MonoBehaviour
{
    //Drags the object which is the part that is under water
    public GameObject UnderWaterObject;

    //Reference to the script that is finding out which part is above water
    private ModifyBoatMesh modifyBoatMesh;

    //Mesh for debugging
    private Mesh underWaterMesh;

    //Rigidbody of the boat.
    private Rigidbody boatRb;

    //Density of the water the boat is traveling in
    private float rhoWaterDensity = 1027f;

    private void Start()
    {
        boatRb = GetComponent<Rigidbody>();

        //here we will modify the mesh of the boat.
        modifyBoatMesh = new ModifyBoatMesh(gameObject);

        underWaterMesh = UnderWaterObject.GetComponent<MeshFilter>().mesh;
    }

    private void Update()
    {
        //Generate the under water mesh
        //modifyBoatMesh.GenerateUnderwaterMesh();

        //Display the under water mesh
        //modifyBoatMesh.DisplayMesh(underWaterMesh, "UnderWater Mesh", modifyBoatMesh.underWaterTriangleData);
    }

    private void FixedUpdate()
    {
        //Add forces to the part of the boat that's below the water.
        //if(modifyBoatMesh.underWaterTriangleData.Count > 0)
        //{
        //    AddUnderWaterForces();
        //}
    }

    private void AddUnderWaterForces()
    {
        //Get all the triangles
        List<TriangleData>
    }
}
