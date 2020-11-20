using System.Collections.Generic;

namespace EverbridgeWCF.Data {
    static class DBContext {

        public static List<Door> doorsList = getAllDoorsFromSomeDB();

        private static List<Door> getAllDoorsFromSomeDB() {
            return new List<Door>() {
                new Door(1, "first door",  isOpen:true, isLocked:false),
                new Door(2, "second door",  isOpen:true, isLocked:false),
                new Door(3, "third door", isOpen:true, isLocked:false),
                new Door(4, "fourth door",  isOpen:true, isLocked:false)                
            };
        }

    }
}
