using EverbridgeWCF.Data;
using System;
using System.Collections.Generic;

namespace EverbridgeWCF {
    public class DoorService : IDoorService {
        private IDoorDAO doorDAO;

        public DoorService(IDoorDAO doorDAO) {
            this.doorDAO = doorDAO ?? throw new ArgumentNullException(nameof(doorDAO));            
        }
        
        //Then I would like a list of all the doors at the facility.
        public List<Door> getAllDoors() {            
            return doorDAO.getAll();
        }

        //Then I would expect each door to have a customisable label to provide user friendly reference to an individual door
        public bool updateDoorLabel(long id, string label) {
            var door = doorDAO.getDoor(id);
            door.label = label;
            doorDAO.update(door);
            return true;
        }

        //And I would like to know whether door is Open or Closed
        //And I would like to know whether door is Locked or Unlocked
        public Door getDoor(long id) {
            return doorDAO.getDoor(id);
        }

        //Then I would like to be able to Add a new door
        public bool addNewDoor(string label) {
            try {
                doorDAO.insert(new Door() { label = label});
                return true;
            } catch (Exception) {
                throw;
            }
        }

        //And be able to remove an already existing door
        public bool removeDoor(long id) {
            try {
                doorDAO.delete(id);
                return true;
            } catch (Exception) {
                throw;
            }
        }

        //Then I would expect to be able to Open a Closed Door
        public bool openDoor(long id) {
            var door = doorDAO.getDoor(id);
            if (door.isOpen == true) return true;
            try {
                door.isOpen = true;
            } catch (ArgumentException) {
                return false;
            }
            doorDAO.update(door);
            return true;
        }

        //And be able to Close an Open door
        public bool closeDoor(long id) {
            var door = doorDAO.getDoor(id);
            if (door.isOpen == false) return true;
            door.isOpen = false;
            doorDAO.update(door);
            return true;
        }

        //And be able to Lock a Closed Door
        public bool lockDoor(long id) {
            var door = doorDAO.getDoor(id);
            if (door.isLocked == true) return true;
            try {
                door.isLocked = true;
            } catch (ArgumentException) {
                return false;
            }
            doorDAO.update(door);
            return true;
        }

        //And be able to Unlock a Locked Door
        public bool unlockDoor(long id) {
            var door = doorDAO.getDoor(id);
            if (door.isLocked == false) return true;
            try {
                door.isLocked = true;
            } catch (ArgumentException) {
                return false;
            }
            doorDAO.update(door);
            return true;
        }
    }
}
