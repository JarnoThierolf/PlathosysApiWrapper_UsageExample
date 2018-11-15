using System;
using System.Text;

namespace PlathosysApiDllWrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            // ApiVerionNumber
            int apiVersionNumber = PlathosysApiWrapper.Plathosys.ApiVersionNumber();
            Console.WriteLine("ApiVersionNumber: {0}", Convert.ToString(apiVersionNumber, 2));

            // Open the device
            bool successful;
            // choose specific USB ID or 0 for first Device found
            int vendorID = 0;
            int productID = 0;
            // Variables to store found IDs
            int selectedVendorID;
            int selectedProductID;
            // Stringbuilder instances to store DeviceName and SerialNumber
            StringBuilder deviceName = new StringBuilder(200);
            StringBuilder serialNumber = new StringBuilder(200);

            successful = PlathosysApiWrapper.Plathosys.Opendevice(
                vendorID,
                productID,
                out selectedVendorID,
                out selectedProductID,
                deviceName,
                serialNumber);

            Console.WriteLine($"Open successful? {successful}");
            Console.WriteLine("Selected Vendor ID: {0:X}", selectedVendorID);
            Console.WriteLine("Selected Product ID: {0:X}", selectedProductID);
            Console.WriteLine($"Device name: {deviceName}");
            Console.WriteLine($"Serial number: {serialNumber}");

            // IsDeviceOpen
            bool isDeviceOpen = PlathosysApiWrapper.Plathosys.IsDeviceOpen();
            Console.WriteLine($"IsDeviceOpen? {isDeviceOpen}");

            // SetHandsetVolume (only PID 1 and 2)
            successful = PlathosysApiWrapper.Plathosys.SetHandsetVolume(128);
            Console.WriteLine($"SetHandsetVolume successful? {successful}");

            // SetHeadsetVolume (only PID 1 and 2)
            successful = PlathosysApiWrapper.Plathosys.SetHeadsetVolume(128);
            Console.WriteLine($"SetHeadsetVolume successful? {successful}");

            // SetIntSpeakerVolume (only PID 1 and 2)
            successful = PlathosysApiWrapper.Plathosys.SetIntSpeakerVolume(128);
            Console.WriteLine($"SetIntSpeakerVolume successful? {successful}");

            // SetIntSpeakerMute
            successful = PlathosysApiWrapper.Plathosys.SetIntSpeakerMute(true);
            Console.WriteLine($"SetIntSpeakerMute successful? {successful}");

            // SetHandsetMicVolume (only PID 1 and 2)
            successful = PlathosysApiWrapper.Plathosys.SetHandsetMicVolume(128);
            Console.WriteLine($"SetHandsetMicVolume successful? {successful}");

            // SetExtMicVolume (only PID 1 and 2)
            successful = PlathosysApiWrapper.Plathosys.SetExtMicVolume(128);
            Console.WriteLine($"SetExtMicVolume successful? {successful}");

            // ReadCurrentInfo (only PID 1 and 2)
            byte info1, info2, info3, info4, info5, info6, info7, info8, info9, info10;
            successful = PlathosysApiWrapper.Plathosys.ReadCurrentInfo(
                out info1, out info2, out info3, out info4, out info5,
                out info6, out info7, out info8, out info9, out info10);
            Console.WriteLine($"ReadCurrentInfo successful? {successful}");
            Console.WriteLine($"Connected / PTT Info: {Convert.ToString(info1, 2).PadLeft(8, '0')}");

            // SetSideTone
            successful = PlathosysApiWrapper.Plathosys.SetSideTone(true);
            Console.WriteLine($"SetSideTone successful? {successful}");

            // SetMicMute
            successful = PlathosysApiWrapper.Plathosys.SetMicMute(true);
            Console.WriteLine($"SetMicMute successful? {successful}");

            // SetWideBand (only PID 1 and 2)
            successful = PlathosysApiWrapper.Plathosys.SetWideBand(true);
            Console.WriteLine($"SetWideBand successful? {successful}");

            // SetEchoCanceller (not with PID 3 and 4)
            successful = PlathosysApiWrapper.Plathosys.SetEchoCanceller(true);
            Console.WriteLine($"SetEchoCanceller successful? {successful}");

            // SetExtMic (only PID 1 and 2)
            successful = PlathosysApiWrapper.Plathosys.SetExtMic(true);
            Console.WriteLine($"SetExtMic successful? {successful}");

            // SetConference (only PID 1 and 2)
            successful = PlathosysApiWrapper.Plathosys.SetConference(true);
            Console.WriteLine($"SetConference successful? {successful}");

            // SetHeadsetActive (not with PID 3 and 4)
            successful = PlathosysApiWrapper.Plathosys.SetHeadsetActive(true);
            Console.WriteLine($"SetHeadsetActive successful? {successful}");

            // SetWirelessHeadsetRinging (not with PID 3 and 4)
            successful = PlathosysApiWrapper.Plathosys.SetWirelessHeadsetRinging(true);
            Console.WriteLine($"SetWirelessHeadsetRinging successful? {successful}");

            // SetWirelessCall (not with PID 3 and 4)
            successful = PlathosysApiWrapper.Plathosys.SetWirelessCall(true);
            Console.WriteLine($"SetWirelessCall successful? {successful}");

            // SetPttPlathosys (not with PID 3 and 4)
            successful = PlathosysApiWrapper.Plathosys.SetPttFunctions(9); // 9 is binary 1001
            Console.WriteLine($"SetPttPlathosys successful? {successful}");

            // SetHeadsetEar (not with PID 3 and 4)
            successful = PlathosysApiWrapper.Plathosys.SetHeadsetEar(1);
            Console.WriteLine($"SetHeadsetEar successful? {successful}");

            // SetExtmicLed (only PID 1 and 2)
            successful = PlathosysApiWrapper.Plathosys.SetExtmicLed(true);
            Console.WriteLine($"SetExtmicLed successful? {successful}");

            // Error!
            // SetByListening (only PID 1 and 2)
            successful = PlathosysApiWrapper.Plathosys.SetByListening(true);
            Console.WriteLine($"SetByListening successful? {successful}");

            // SetCodecType (only PID 1 and 2)
            successful = PlathosysApiWrapper.Plathosys.SetCodecType(1);
            Console.WriteLine($"SetCodecType successful? {successful}");

            // SetSerialNumber (not with PID 3 and 4)
            successful = PlathosysApiWrapper.Plathosys.SetSerialNumber(12345678);
            Console.WriteLine($"SetSerialNumber successful? {successful}");

            // InitHookAndPTTState (only PID 3 and 4)
            successful = PlathosysApiWrapper.Plathosys.InitHookAndPTTState();
            Console.WriteLine($"InitHookAndPTTState successful? {successful}");

            // MuteSpkCt140 (only PID 3 and 4)
            successful = PlathosysApiWrapper.Plathosys.MuteSpkCt140(true);
            Console.WriteLine($"MuteSpkCt140 successful? {successful}");

            // MuteMicCt140 (only PID 3 and 4)
            successful = PlathosysApiWrapper.Plathosys.MuteMicCt140(true);
            Console.WriteLine($"MuteMicCt140 successful? {successful}");

            // SetHeadsetdBVolume (not with PID 3 and 4)
            successful = PlathosysApiWrapper.Plathosys.SetHeadsetdBVolume(-6);
            Console.WriteLine($"SetHeadsetdBVolume successful? {successful}");

            // SetHeadsetMicdBVolume (not with PID 3 and 4)
            successful = PlathosysApiWrapper.Plathosys.SetHeadsetMicdBVolume(6);
            Console.WriteLine($"SetHeadsetMicdBVolume successful? {successful}");

            // SetExtMicdBVolume (currently not in use)
            successful = PlathosysApiWrapper.Plathosys.SetExtMicdBVolume(3);
            Console.WriteLine($"SetExtMicdBVolume successful? {successful}");

            // SetIntSpeakerdBVolume (not with PID 3 and 4)
            successful = PlathosysApiWrapper.Plathosys.SetIntSpeakerdBVolume(3);
            Console.WriteLine($"SetIntSpeakerdBVolume successful? {successful}");

            // SetIntAlarmSpeakerdBVolume (not with PID 3 and 4)
            successful = PlathosysApiWrapper.Plathosys.SetIntAlarmSpeakerdBVolume(3);
            Console.WriteLine($"SetIntAlarmSpeakerdBVolume successful? {successful}");

            // SetIntAlarmSpeakerVolume (not with PID 3, 4, 5 and 6)
            successful = PlathosysApiWrapper.Plathosys.SetIntAlarmSpeakerVolume(3);
            Console.WriteLine($"SetIntAlarmSpeakerVolume successful? {successful}");

            // SetLyncFeature (only with PID 5 and 6)
            successful = PlathosysApiWrapper.Plathosys.SetLyncFeature(true);
            Console.WriteLine($"SetLyncFeature successful? {successful}");


            // ReadCurrentInfodB
            byte info11, info12, info13, info14, info15, info16;

            successful = PlathosysApiWrapper.Plathosys.ReadCurrentInfodB(
                out info1, out info2, out info3, out info4, out info5, out info6,
                out info7, out info8, out info9, out info10, out info11, out info12,
                out info13, out info14, out info15, out info16);

            Console.WriteLine($"ReadCurrentInfodB successful? {successful}");
            Console.WriteLine($"Connected Info: {Convert.ToString(info1, 2).PadLeft(8, '0')}");
            Console.WriteLine($"Standard headset connected? {(info1 & 2) != 0}");

            Console.WriteLine($"Info3: {info3}");
            string hardwareVersion = Convert.ToString(info3, 2).PadLeft(8, '0');
            int first = Convert.ToInt32(hardwareVersion.Substring(0, 4), 2);
            int second = Convert.ToInt32(hardwareVersion.Substring(4, 4), 2);
            Console.WriteLine($"Hardware version: {first}.{second}");

            Console.WriteLine($"Info4: {info4}");
            string softwareVersion = Convert.ToString(info4, 2).PadLeft(8, '0');
            first = Convert.ToInt32(hardwareVersion.Substring(0, 4), 2);
            second = Convert.ToInt32(hardwareVersion.Substring(4, 4), 2);
            Console.WriteLine($"Software version: {first}.{second}");

            Console.WriteLine($"Serial number high: {info7}");
            Console.WriteLine($"Serial number: {info8}");
            Console.WriteLine($"Serial number: {info9}");
            Console.WriteLine($"Serial number low: {info10}");
            Console.WriteLine($"Speaker volume on bylisten: {info14}");

            // HookAndPttInfo
            int hookAndPttInfo;
            successful = PlathosysApiWrapper.Plathosys.ReadHookAndPTT(out hookAndPttInfo);
            Console.WriteLine($"ReadHooAndPttInfo successful? {successful}");
            Console.WriteLine($"HookAndPttInfo: {Convert.ToString(hookAndPttInfo, 2).PadLeft(4, '0')}");
            Console.WriteLine($"HookOff? {(hookAndPttInfo & 1) != 0}");

            // IsDeviceOpen
            isDeviceOpen = PlathosysApiWrapper.Plathosys.IsDeviceOpen();
            Console.WriteLine($"IsDeviceOpen: {isDeviceOpen}");

            // Closedevice
            successful = PlathosysApiWrapper.Plathosys.Closedevice();
            Console.WriteLine($"DeviceClosed successful? {successful}");

            // IsDeviceOpen
            isDeviceOpen = PlathosysApiWrapper.Plathosys.IsDeviceOpen();
            Console.WriteLine($"IsDeviceOpen: {isDeviceOpen}");
        }
    }
}