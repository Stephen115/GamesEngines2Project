using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitching : MonoBehaviour
{
    public int camNumber;
    public Camera liftoffCam;
    public Camera dracoPanCam;
    public Camera incomingMarauderCam;
    public Camera TunnelCam;
    public Camera cockpitCam;
    public Camera followCam;
    public Camera cam7;
    public Camera FlyTo;
    public Camera cam9;
    public Camera cam10;
    public Camera cam11;
    public Camera shootingFlyby;
    public Camera DracoExplosions;
    public Camera BarrelRollCam;
    public Camera FlyUpCam;
    public Camera ShootingForwardCam;
    public Camera ChaseCam;


    // Start is called before the first frame update
    void Start()
    {
        camNumber = 0;
        liftoffCam.enabled = true;
        dracoPanCam.enabled = false;
        incomingMarauderCam.enabled = false;
        TunnelCam.enabled = false;
        cockpitCam.enabled = false;
        followCam.enabled = false;
        cam7.enabled = false;
        FlyTo.enabled = false;
        cam9.enabled = false;
        cam10.enabled = false;
        cam11.enabled = false;
        shootingFlyby.enabled = false;
        DracoExplosions.enabled = false;
        BarrelRollCam.enabled = false;
        FlyUpCam.enabled = false;
        ShootingForwardCam.enabled = false;
        ChaseCam.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (camNumber == 0) {

            liftoffCam.enabled = true;
            dracoPanCam.enabled = false;
            incomingMarauderCam.enabled = false;
            TunnelCam.enabled = false;
            cockpitCam.enabled = false;
            followCam.enabled = false;
            cam7.enabled = false;
            FlyTo.enabled = false;
            cam9.enabled = false;
            cam10.enabled = false;
            cam11.enabled = false;
            shootingFlyby.enabled = false;
            DracoExplosions.enabled = false;
            BarrelRollCam.enabled = false;
            FlyUpCam.enabled = false;
            ShootingForwardCam.enabled = false;
            ChaseCam.enabled = false;
        } else if (camNumber == 1)
        {

            liftoffCam.enabled = false;
            dracoPanCam.enabled = true;
            incomingMarauderCam.enabled = false;
            TunnelCam.enabled = false;
            cockpitCam.enabled = false;
            followCam.enabled = false;
            cam7.enabled = false;
            FlyTo.enabled = false;
            cam9.enabled = false;
            cam10.enabled = false;
            cam11.enabled = false;
            shootingFlyby.enabled = false;
            DracoExplosions.enabled = false;
            BarrelRollCam.enabled = false;
            FlyUpCam.enabled = false;
            ShootingForwardCam.enabled = false;
            ChaseCam.enabled = false;
        }
        else if (camNumber == 2)
        {

            liftoffCam.enabled = false;
            dracoPanCam.enabled = false;
            incomingMarauderCam.enabled = true;
            TunnelCam.enabled = false;
            cockpitCam.enabled = false;
            followCam.enabled = false;
            cam7.enabled = false;
            FlyTo.enabled = false;
            cam9.enabled = false;
            cam10.enabled = false;
            cam11.enabled = false;
            shootingFlyby.enabled = false;
            DracoExplosions.enabled = false;
            BarrelRollCam.enabled = false;
            FlyUpCam.enabled = false;
            ShootingForwardCam.enabled = false;
            ChaseCam.enabled = false;
        }
        else if (camNumber == 3)
        {
            liftoffCam.enabled = false;
            dracoPanCam.enabled = false;
            incomingMarauderCam.enabled = false;
            TunnelCam.enabled = true;
            cockpitCam.enabled = false;
            followCam.enabled = false;
            cam7.enabled = false;
            FlyTo.enabled = false;
            cam9.enabled = false;
            cam10.enabled = false;
            cam11.enabled = false;
            shootingFlyby.enabled = false;
            DracoExplosions.enabled = false;
            BarrelRollCam.enabled = false;
            FlyUpCam.enabled = false;
            ShootingForwardCam.enabled = false;
            ChaseCam.enabled = false;
        }
        else if (camNumber == 4)
        {

            liftoffCam.enabled = false;
            dracoPanCam.enabled = false;
            incomingMarauderCam.enabled = false;
            TunnelCam.enabled = false;
            cockpitCam.enabled = true;
            followCam.enabled = false;
            cam7.enabled = false;
            FlyTo.enabled = false;
            cam9.enabled = false;
            cam10.enabled = false;
            cam11.enabled = false;
            shootingFlyby.enabled = false;
            DracoExplosions.enabled = false;
            BarrelRollCam.enabled = false;
            FlyUpCam.enabled = false;
            ShootingForwardCam.enabled = false;
            ChaseCam.enabled = false;
        }
        else if (camNumber == 5)
        {

            liftoffCam.enabled = false;
            dracoPanCam.enabled = false;
            incomingMarauderCam.enabled = false;
            TunnelCam.enabled = false;
            cockpitCam.enabled = false;
            followCam.enabled = true;
            cam7.enabled = false;
            FlyTo.enabled = false;
            cam9.enabled = false;
            cam10.enabled = false;
            cam11.enabled = false;
            shootingFlyby.enabled = false;
            DracoExplosions.enabled = false;
            BarrelRollCam.enabled = false;
            FlyUpCam.enabled = false;
            ShootingForwardCam.enabled = false;
            ChaseCam.enabled = false;
        }
        else if (camNumber == 6)
        {

            liftoffCam.enabled = false;
            dracoPanCam.enabled = false;
            incomingMarauderCam.enabled = false;
            TunnelCam.enabled = false;
            cockpitCam.enabled = false;
            followCam.enabled = false;
            cam7.enabled = true;
            FlyTo.enabled = false;
            cam9.enabled = false;
            cam10.enabled = false;
            cam11.enabled = false;
            shootingFlyby.enabled = false;
            DracoExplosions.enabled = false;
            BarrelRollCam.enabled = false;
            FlyUpCam.enabled = false;
            ShootingForwardCam.enabled = false;
            ChaseCam.enabled = false;
        }
        else if (camNumber == 7)
        {

            liftoffCam.enabled = false;
            dracoPanCam.enabled = false;
            incomingMarauderCam.enabled = false;
            TunnelCam.enabled = false;
            cockpitCam.enabled = false;
            followCam.enabled = false;
            cam7.enabled = false;
            FlyTo.enabled = true;
            cam9.enabled = false;
            cam10.enabled = false;
            cam11.enabled = false;
            shootingFlyby.enabled = false;
            DracoExplosions.enabled = false;
            BarrelRollCam.enabled = false;
            FlyUpCam.enabled = false;
            ShootingForwardCam.enabled = false;
            ChaseCam.enabled = false;
        }
        else if (camNumber == 8)
        {

            liftoffCam.enabled = false;
            dracoPanCam.enabled = false;
            incomingMarauderCam.enabled = false;
            TunnelCam.enabled = false;
            cockpitCam.enabled = false;
            followCam.enabled = false;
            cam7.enabled = false;
            FlyTo.enabled = false;
            cam9.enabled = true;
            cam10.enabled = false;
            cam11.enabled = false;
            shootingFlyby.enabled = false;
            DracoExplosions.enabled = false;
            BarrelRollCam.enabled = false;
            FlyUpCam.enabled = false;
            ShootingForwardCam.enabled = false;
            ChaseCam.enabled = false;
        }
        else if (camNumber == 9)
        {

            liftoffCam.enabled = false;
            dracoPanCam.enabled = false;
            incomingMarauderCam.enabled = false;
            TunnelCam.enabled = false;
            cockpitCam.enabled = false;
            followCam.enabled = false;
            cam7.enabled = false;
            FlyTo.enabled = false;
            cam9.enabled = false;
            cam10.enabled = true;
            cam11.enabled = false;
            shootingFlyby.enabled = false;
            DracoExplosions.enabled = false;
            BarrelRollCam.enabled = false;
            FlyUpCam.enabled = false;
            ShootingForwardCam.enabled = false;
            ChaseCam.enabled = false;
        }
        else if (camNumber == 10)
        {

            liftoffCam.enabled = false;
            dracoPanCam.enabled = false;
            incomingMarauderCam.enabled = false;
            TunnelCam.enabled = false;
            cockpitCam.enabled = false;
            followCam.enabled = false;
            cam7.enabled = false;
            FlyTo.enabled = false;
            cam9.enabled = false;
            cam10.enabled = false;
            cam11.enabled = true;
            shootingFlyby.enabled = false;
            DracoExplosions.enabled = false;
            BarrelRollCam.enabled = false;
            FlyUpCam.enabled = false;
            ShootingForwardCam.enabled = false;
            ChaseCam.enabled = false;
        }
        else if (camNumber == 11)
        {

            liftoffCam.enabled = false;
            dracoPanCam.enabled = false;
            incomingMarauderCam.enabled = false;
            TunnelCam.enabled = false;
            cockpitCam.enabled = false;
            followCam.enabled = false;
            cam7.enabled = false;
            FlyTo.enabled = false;
            cam9.enabled = false;
            cam10.enabled = false;
            cam11.enabled = false;
            shootingFlyby.enabled = true;
            DracoExplosions.enabled = false;
            BarrelRollCam.enabled = false;
            FlyUpCam.enabled = false;
            ShootingForwardCam.enabled = false;
            ChaseCam.enabled = false;
        }
        else if (camNumber == 12)
        {

            liftoffCam.enabled = false;
            dracoPanCam.enabled = false;
            incomingMarauderCam.enabled = false;
            TunnelCam.enabled = false;
            cockpitCam.enabled = false;
            followCam.enabled = false;
            cam7.enabled = false;
            FlyTo.enabled = false;
            cam9.enabled = false;
            cam10.enabled = false;
            cam11.enabled = false;
            shootingFlyby.enabled = false;
            DracoExplosions.enabled = true;
            BarrelRollCam.enabled = false;
            FlyUpCam.enabled = false;
            ShootingForwardCam.enabled = false;
            ChaseCam.enabled = false;
        }
        else if (camNumber == 13)
        {

            liftoffCam.enabled = false;
            dracoPanCam.enabled = false;
            incomingMarauderCam.enabled = false;
            TunnelCam.enabled = false;
            cockpitCam.enabled = false;
            followCam.enabled = false;
            cam7.enabled = false;
            FlyTo.enabled = false;
            cam9.enabled = false;
            cam10.enabled = false;
            cam11.enabled = false;
            shootingFlyby.enabled = false;
            DracoExplosions.enabled = false;
            BarrelRollCam.enabled = true;
            FlyUpCam.enabled = false;
            ShootingForwardCam.enabled = false;
            ChaseCam.enabled = false;
        }
        else if (camNumber == 14)
        {

            liftoffCam.enabled = false;
            dracoPanCam.enabled = false;
            incomingMarauderCam.enabled = false;
            TunnelCam.enabled = false;
            cockpitCam.enabled = false;
            followCam.enabled = false;
            cam7.enabled = false;
            FlyTo.enabled = false;
            cam9.enabled = false;
            cam10.enabled = false;
            cam11.enabled = false;
            shootingFlyby.enabled = false;
            DracoExplosions.enabled = false;
            BarrelRollCam.enabled = false;
            FlyUpCam.enabled = true;
            ShootingForwardCam.enabled = false;
            ChaseCam.enabled = false;
        }
        else if (camNumber == 15)
        {

            liftoffCam.enabled = false;
            dracoPanCam.enabled = false;
            incomingMarauderCam.enabled = false;
            TunnelCam.enabled = false;
            cockpitCam.enabled = false;
            followCam.enabled = false;
            cam7.enabled = false;
            FlyTo.enabled = false;
            cam9.enabled = false;
            cam10.enabled = false;
            cam11.enabled = false;
            shootingFlyby.enabled = false;
            DracoExplosions.enabled = false;
            BarrelRollCam.enabled = false;
            FlyUpCam.enabled = false;
            ShootingForwardCam.enabled = true;
            ChaseCam.enabled = false;
        }
        else if (camNumber == 16)
        {

            liftoffCam.enabled = false;
            dracoPanCam.enabled = false;
            incomingMarauderCam.enabled = false;
            TunnelCam.enabled = false;
            cockpitCam.enabled = false;
            followCam.enabled = false;
            cam7.enabled = false;
            FlyTo.enabled = false;
            cam9.enabled = false;
            cam10.enabled = false;
            cam11.enabled = false;
            shootingFlyby.enabled = false;
            DracoExplosions.enabled = false;
            BarrelRollCam.enabled = false;
            FlyUpCam.enabled = false;
            ShootingForwardCam.enabled = false;
            ChaseCam.enabled = true;
        }
    }
}
