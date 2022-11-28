using MyClassLibrary;

namespace AboutEvents
{
    internal class Program
    {
        // Method that must run when the alarm is raised 
        static void AlarmListener1(object sender, EventArgs e)
        {
            // Only the sender is valid as this event doesn't have arguments
            Console.WriteLine("Alarm listener 1 called");
        }

        // Method that must run when the alarm is raised 
        static void AlarmListener2(object sender, EventArgs e)
        {
            // Only the sender is valid as this event doesn't have arguments
            Console.WriteLine("Alarm listener 2 called");
        }

        static void LocationAlarmListener1(object source, AlarmEventArgs args)
        {
            Console.WriteLine("Alarm location listener 1 called");
            Console.WriteLine("Alarm in {0}", args.Location);
        }

        static void LocationAlarmListener2(object source, AlarmEventArgs args)
        {
            Console.WriteLine("Alarm location listener 2 called");
            Console.WriteLine("Alarm in {0}", args.Location);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("About events...");

            var video = new Video()
            {
                Title = "Star Wars Andor"
            };
            var videoEncoder = new VideoEncoder(); //Publisher
            var mailService = new MailService(); //Subscriber
            var smsService = new SMSService(); //Subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += smsService.OnVideoEncoded;
            videoEncoder.Encode(video);

            // Create an alarm
            Alarm alarm = new Alarm();
            // Connect the two listener methods
            alarm.OnAlarmRaised += AlarmListener1;
            alarm.OnAlarmRaised += AlarmListener2;
            alarm.RaiseAlarm();
            Console.WriteLine("Alarm raised");

            // Unsubscribing from a delegate
            alarm.OnAlarmRaised -= AlarmListener1;
            alarm.RaiseAlarm();
            Console.WriteLine("Alarm raised");

            alarm.OnLocationAlarmRaised += LocationAlarmListener1;
            alarm.OnLocationAlarmRaised += LocationAlarmListener2;
            alarm.RaiseLocationAlarm("Sleeping room");
            Console.WriteLine("Location alarm raised");

            alarm.OnLocationAlarmRaised -= LocationAlarmListener1;
            alarm.RaiseLocationAlarm("Bathroom");
            Console.WriteLine("Location Alarm raised");
        }
    }
}