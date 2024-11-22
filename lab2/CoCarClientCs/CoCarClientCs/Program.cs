using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace CsClient
{
    [ComVisible(true)]
    [ComDefaultInterface(typeof(ICreateCar))]
    [ComSourceInterfaces(typeof(IStats))]
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("FA698658-53C6-4D7B-BBB8-26C758F4A07C")]
    public class Car : ICreateCar
    {
        private string petName;
        private int maxSpeed;

        public void SetPetName(string petName)
        {
            this.petName = petName;
        }

        public void SetMaxSpeed(int maxSpeed)
        {
            this.maxSpeed = maxSpeed;
        }
    }

    //{E00F98DE-30D6-410C-9CA0-4A328072FDE2}
    //DEFINE_GUID(IID_ICreateCar,
    //0xe00f98de, 0x30d6, 0x410c, 0x9c, 0xa0, 0x4a, 0x32, 0x80, 0x72, 0xfd, 0xe2);
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("E00F98DE-30D6-410C-9CA0-4A328072FDE2")]
    public interface ICreateCar
    {
        void SetPetName(string petName);
        void SetMaxSpeed(int maxSp);
    }

    // {6D6C6F04-490D-42E0-9DD4-4FC458C43908}
    //DEFINE_GUID(IID_IStats,
    //0x6d6c6f04, 0x490d, 0x42e0, 0x9d, 0xd4, 0x4f, 0xc4, 0x58, 0xc4, 0x39, 0x8);
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("6D6C6F04-490D-42E0-9DD4-4FC458C43908")]
    public interface IStats
    {
        void DisplayStats();
        void GetPetName(ref string petName);
    }

    // {DE89F71B-FB17-4AB3-98D0-8146E0676ADF}
    //DEFINE_GUID(IID_IEngine,
    //0xde89f71b, 0xfb17, 0x4ab3, 0x98, 0xd0, 0x81, 0x46, 0xe0, 0x67, 0x6a, 0xdf);
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("DE89F71B-FB17-4AB3-98D0-8146E0676ADF")]
    public interface IEngine
    {
        void SpeedUp();
        void GetMaxSpeed(ref int curSpeed);
        void GetCurSpeed(ref int maxSpeed);
    }


    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            ICreateCar iCrCar = (ICreateCar)myCar;
            Console.WriteLine("Напишите имя: ");
            iCrCar.SetPetName(Console.ReadLine());
            iCrCar.SetMaxSpeed(200);


            Type comType = Type.GetTypeFromCLSID(new Guid("FA698658-53C6-4D7B-BBB8-26C758F4A07C"));
            dynamic comObject = Activator.CreateInstance(comType);
            object comInterface = comObject as object;

        }
    }
}