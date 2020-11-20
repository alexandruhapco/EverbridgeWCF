using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EverbridgeWCF.Data {
    class DoorDAO : IDoorDAO{

        private readonly DoorContext db;

        public DoorDAO(DoorContext db) {
            this.db = db;
        }

        public List<Door> getAll() {
            return db.doors.ToList();
        }

        public void insert(Door door) {
            db.doors.Add(door);
            db.SaveChanges();
        }

        public void delete(long id) {
            db.doors.RemoveRange(db.doors.Where(x => x.id == id));
            db.SaveChanges();
        }

        public void update(Door door) {
            var result = db.doors.SingleOrDefault(x => x.id == door.id);
            if (result != null) {
                result.isLocked = door.isLocked;
                result.isOpen = door.isOpen;
                result.label = door.label;
            }
            db.SaveChanges();
        }

        public Door getDoor(long id) {
            return db.doors.SingleOrDefault(x => x.id == id);
        }
    }
}
