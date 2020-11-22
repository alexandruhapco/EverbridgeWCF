using System.Collections.Generic;
using System.ServiceModel;

namespace EverbridgeWCF {
    [ServiceContract(Namespace = "http://localhost:50071/DoorService.svc", SessionMode = SessionMode.Required, CallbackContract = typeof(IDoorNotificationCallback))]
    public interface IDoorService {

        [OperationContract]
        bool addNewDoor(string label);
        [OperationContract]
        bool closeDoor(long id);
        [OperationContract]
        List<Door> getAllDoors();
        [OperationContract]
        Door getDoor(long id);
        [OperationContract]
        bool lockDoor(long id);
        [OperationContract]
        bool openDoor(long id);
        [OperationContract]
        bool removeDoor(long id);
        [OperationContract]
        bool unlockDoor(long id);
        [OperationContract]
        bool updateDoorLabel(long id, string label);
        [OperationContract]
        void clientRegistration();
    }

    //https://docs.microsoft.com/en-us/dotnet/framework/wcf/feature-details/how-to-create-a-duplex-contract?redirectedfrom=MSDN
    public interface IDoorNotificationCallback {
        [OperationContract(IsOneWay = true)]
        void notifyUserOnChange(string message);
    }
}
