using UnityEngine;

public class controllingCarAI : MonoBehaviour
{
    //This is an example script. To show you how to control the AI using script(At Runtime)
    private int index;
    public CarAI carAI;
    
    void variables()
    {
        //1- Patrol = true 
        carAI.Patrol = true;
        // Patrol = false
        carAI.Patrol = false;

        //2- Set the maximum steering angle
        carAI.MaxSteeringAngle = 45;

        //3- Set the maximum RPM(Speed)
        carAI.MaxRPM = 150;


        //5- Show Gizmos
        carAI.ShowGizmos = true;
        //or hide Gizmos
        carAI.ShowGizmos = false;

        //6- Allow thr car to move
        carAI.move = true;
        //or apply brakes
        carAI.move = false;
    }

    void Methods()
    {

    }
}
