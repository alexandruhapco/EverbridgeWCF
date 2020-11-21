using System.Collections.Generic;
using System.ServiceModel;

namespace EverbridgeWCF {
    [ServiceContract]
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
    }
}
