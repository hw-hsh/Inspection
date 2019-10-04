using Cognex.InSight;

namespace Haewon.Module
{
    public class Vision_Cognex
    {
        public Cognex.InSight.Net.CvsNetworkMonitor oNetworkMonitor;
        public Cognex.InSight.NativeMode.CvsNativeModeClient oNativeModeClient;
        public Cognex.InSight.Net.CvsHostSensor oHostSensor;
        public Cognex.InSight.Controls.Filmstrip.CvsFilmstripResultsQueue oFilmstrip;
        public Cognex.InSight.Controls.Filmstrip.CvsFilmstripPlayback oFilmstripPlayback;
        public CvsInSight oInsight;
        public CvsImage oImage;

        public bool IsConnected
        {
            get
            {
                // It's possible for InSight to be nothing while the display is 
                // connecting to a new sensor, so we must handle that case as well as
                // when its State property is CvsInSightState_NotConnected
                if (oInsight != null)
                {
                    return (oInsight.State != CvsInSightState.NotConnected);
                }
                else
                    return false;
            }
        }
    }
}
