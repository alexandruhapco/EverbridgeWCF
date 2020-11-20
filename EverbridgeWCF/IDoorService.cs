using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EverbridgeWCF {
    [ServiceContract]
    public interface IDoorService {

        [OperationContract]
        bool addNewDoor(Door door);
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
        void updateDoorLabel(long id, string label);       
    }
}
