using System.Collections.Generic;
using System.Linq;

namespace EverbridgeWCF.Data {
    class DoorDAO : IDoorDAO{

        public List<Door> getAll() {
            return DBContext.doorsList;
        }

        public void insert(Door door) {
            DBContext.doorsList.Add(door);
        }

        public void delete(long id) {
            DBContext.doorsList.RemoveAll(x => x.id == id);
        }

        public void update(Door door) {
            //with EF this should work

            //var result = DBContext.doorsList.SingleOrDefault(x => x.id == door.id);
            //if (result != null) {
            //    result.isLocked = door.isLocked;
            //    result.isOpen = door.isOpen;
            //    result.label = door.label;
            //}

            foreach (Door d in DBContext.doorsList) {
                if (d.id == door.id) {
                    d.isLocked = door.isLocked;
                    d.isOpen = door.isOpen;
                    d.label = door.label;
                    break;
                }
            }
        }

        public Door getDoor(long id) {
            return DBContext.doorsList.SingleOrDefault(x => x.id == id);
        }
    }
}
