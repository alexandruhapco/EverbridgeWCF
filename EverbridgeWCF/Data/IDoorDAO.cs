using System.Collections.Generic;

namespace EverbridgeWCF.Data {
    public interface IDoorDAO {
        void delete(long id);
        List<Door> getAll();
        Door getDoor(long id);
        void insert(Door door);
        void update(Door door);
    }
}