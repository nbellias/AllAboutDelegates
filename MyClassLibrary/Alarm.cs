using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Alarm
    {
        // Delegate for the alarm event
        public event EventHandler OnAlarmRaised = delegate { };
        // Called to raise an alarm
        // Does not provide any event arguments
        public event EventHandler<AlarmEventArgs> OnLocationAlarmRaised = delegate { };

        public void RaiseAlarm()
        {
            // Raises the alarm
            // The event handler receivers a reference to the alarm that is 
            // raising this event
            OnAlarmRaised(this, EventArgs.Empty);
        }

        public void RaiseLocationAlarm(string location)
        {
            // Raises the alarm
            // The event handler receivers a reference to the alarm that is 
            // raising this event
            OnLocationAlarmRaised(this, new AlarmEventArgs(location));
        }
    }
}
